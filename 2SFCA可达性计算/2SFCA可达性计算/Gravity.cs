using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2SFCA可达性计算
{
    public partial class Gravity : Form
    {
        public Gravity()
        {
            InitializeComponent();
            Population_list = new List<ID_POPULATION>();
            Facility_List = new List<Pulibc_Facility>();
            grid_List = new List<Population_netWork>();
        }


        public List<ID_POPULATION> Population_list;
        public int Sum_population;
        public List<Pulibc_Facility> Facility_List;
        public int Facility_num;
        public List<Population_netWork> grid_List;
        public double beita_val;
        private void Load_gridPop_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择格网人口文件,删除人口为0的格子");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                GridPopu_FilenameTxt.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _array = line.Split(',');
                    int popu = int.Parse(_array[1]);
                    if (popu == 0)
                    {
                        continue;
                    }
                    ID_POPULATION id_popu = new ID_POPULATION();
                    int id = int.Parse(_array[0]);
                    id_popu.ID = id;
                    id_popu.Population = popu;
                    Population_list.Add(id_popu);
                }
                sr.Close();
                fs.Close();
            }
            Sum_population = 0;
            int i = 0;
            for (i = 0; i < Population_list.Count; i++)
            {
                Sum_population += Population_list[i].Population;
            }
        }

        private void Load_publicFac_btn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择公共服务设施文件！");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                PublicFac_fileName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                //int Fac_count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _array = line.Split(',');
                    Pulibc_Facility temp = new Pulibc_Facility();
                    temp.id = int.Parse(_array[0]);
                    temp.name = _array[1];
                    temp.grade = int.Parse(_array[2]);
                    temp.supply_Score = int.Parse(_array[3]);
                    Facility_List.Add(temp);
                    //Fac_count++;
                }
                sr.Close();
                fs.Close();
                Facility_num = Facility_List.Count;
            }
        }

        private void Load_ODTIME_BTN_Click(object sender, EventArgs e)
        {
            MessageBox.Show("选择交通时间文件,文件需按id排序！");
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                OD_TIME_TEXT.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);

                string line;
                Population_netWork temp = new Population_netWork();
                int id = 0;
                int count = 0;
                while ((line = sr.ReadLine()) != null)
                {
                    count++;
                    temp.grid_id = id;
                    string[] _array;
                    _array = line.Split(',');
                    int temp_id = int.Parse(_array[0]);
                    int temp_duration = 0;
                    if (_array[1] != "None")
                    {
                        temp_duration = int.Parse(_array[1]);
                    }
                    else
                    {
                        temp_duration = int.MaxValue;
                    }
                    temp.durationList_toHospital.Add(temp_duration);
                    if (count % Facility_num == 0)
                    {
                        temp.grid_id = Population_list[id].ID;
                        temp.grid_population = Population_list[id++].Population;
                        int min = int.MaxValue;
                        for (int j = 0; j < temp.durationList_toHospital.Count; j++)
                        {
                            if (temp.durationList_toHospital[j] <= min)
                            {
                                min = temp.durationList_toHospital[j];
                            }
                        }
                        temp.closet_travelTime = min;
                        grid_List.Add(temp);
                        temp = new Population_netWork();
                    }
                }
            }
        }

        private void Gravity_Load(object sender, EventArgs e)
        {
            if (Beta_Textbox.Text != "")
                beita_val = double.Parse(Beta_Textbox.Text);
            else
                beita_val = 1;
        }
        double time_threshold = double.MaxValue;
        private void Comfirm_btn_Click(object sender, EventArgs e)
        {
            beita_val = double.Parse(Beta_Textbox.Text);
            for (int i = 0; i < Facility_List.Count; i++)
            {
                int S = Facility_List[i].supply_Score;//第i个服务设施的供给量
                double X = 0;//第i个服务设施的总需求量
                for (int j = 0; j < grid_List.Count; j++)
                {
                    double time_ji = grid_List[j].durationList_toHospital[i];


                    if (time_ji < time_threshold)
                    {
                        X += Math.Pow(time_ji, -beita_val) * grid_List[j].grid_population;
                        //X += ((Math.Pow(Math.E, Math.Pow((time_ji / time_threshold), 2.0) * (-0.5)) - Math.Pow(Math.E, -0.5)) / (1 - Math.Pow(Math.E, -0.5))) * grid_List[j].grid_population;
                    }
                    else
                    {
                        continue;
                    }
                }
                Facility_List[i].Supplydemand_ratio = (double)S / X;
            }
            for (int i = 0; i < grid_List.Count; i++)
            {
                grid_List[i].accessibility_Score = 0;
                for (int j = 0; j < Facility_List.Count; j++)
                {
                    double time_ji = grid_List[i].durationList_toHospital[j];
                    if (time_ji < time_threshold)
                    {
                        grid_List[i].accessibility_Score += Math.Pow(time_ji, -beita_val) * Facility_List[j].Supplydemand_ratio;
                        //grid_List[i].accessibility_Score += ((Math.Pow(Math.E, Math.Pow((time_ji / time_threshold), 2.0) * (-0.5)) - Math.Pow(Math.E, -0.5)) / (1 - Math.Pow(Math.E, -0.5))) * Facility_List[j].Supplydemand_ratio;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "csv文件(*.csv)|*.csv";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            //sfd.DefaultFileName = "Accessibility_Score";
            MessageBox.Show("计算完成,保存结果到文件");
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string localFilePath = sfd.FileName.ToString(); //获得文件路径 
                string fileNameExt = localFilePath.Substring(localFilePath.LastIndexOf("\\") + 1); //获取文件名，不带路径
                FileStream fs = new FileStream(localFilePath, FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                for (int i = 0; i < grid_List.Count; i++)
                {
                    sw.WriteLine(grid_List[i].grid_id.ToString() + "," + grid_List[i].accessibility_Score.ToString());
                }
                sw.Close();
                fs.Close();
            }
            MessageBox.Show("结果保存完成！");
            this.Close();
        }

        private void Cancel_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
