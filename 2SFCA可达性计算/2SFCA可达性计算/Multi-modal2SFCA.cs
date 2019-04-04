using System;
using System.Collections;
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
    public partial class Multi_modal2SFCA : Form
    {
        public string TimeMatrixCar_Filename;
        public bool bIsloadcarTimematrix;
        public bool bIsloadPopulation;
        public bool bIsloadServiceFacality;
        public ArrayList TimeMatrix_Car;
        public bool bIsloadtransitTimematrix;
        public ArrayList TimeMatrix_Transit;
        public ArrayList PopulationList;
        public ArrayList Hospital_Capacity;
        public ArrayList Community_TimeMatrix;
        public ArrayList populationCell_List = new ArrayList();
        public ArrayList Facalityclass_List = new ArrayList();
        public double Alpha_car, Beta_car;
        public double Alpha_transit, Beta_transit;
        public double Car_minTime, Car_maxTime;
        public double Transit_minTime, Transit_maxTime;
        public Multi_modal2SFCA()
        {
            InitializeComponent();
            DecayFunc_Label.Text = " 1+exp(α+β*Ln(Tij-Tmin))^-1 ";
            bIsloadcarTimematrix = false;
            bIsloadtransitTimematrix = false;
            bIsloadPopulation = false;
            bIsloadServiceFacality = false;
            TimeMatrix_Car = new ArrayList();
            TimeMatrix_Transit = new ArrayList();
            PopulationList = new ArrayList();
            Community_TimeMatrix = new ArrayList();
            Hospital_Capacity = new ArrayList();
        }
        
        private void LnDecayFunc_menuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void Multi_modal2SFCA_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void LoadTimeMatrix_car_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                TimeMatrix_Name.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    TimeMatrix_Car.Add(double.Parse(_temp[1].ToString()) / 60.0);
                }
                sr.Close();
                fs.Close();
            }
            bIsloadcarTimematrix = true;
        }

        private void LoadTimeMatrix_Transit_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                TimeMatrix_transitName.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    TimeMatrix_Transit.Add(double.Parse(_temp[1].ToString()) / 60.0);
                }
                sr.Close();
                fs.Close();
            }
            bIsloadtransitTimematrix = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                string line;
                ArrayList list1 = new ArrayList();
                ArrayList list2 = new ArrayList();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    list1.Add(int.Parse(_temp[0]));
                    list2.Add(int.Parse(_temp[1]));
                }
                sr.Close();
                fs.Close();
                int[,] array = new int[4, 4];
                for(int i = 0;i<list1.Count;i++)
                {
                    int x = (int)list1[i];
                    int y = (int)list2[i];
                    array[x-1,y-1]++;
                }
                string str = "";
                for(int i = 0;i<4;i++)
                {
                    for(int j = 0;j<4;j++)
                    {
                        str += array[i,j].ToString() + " ";
                    }
                    str += "\n";
                }
                MessageBox.Show(str);
            }
        }

        private void Community_LoadPopulation_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Community_PopulationFile_name.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    PopulationList.Add(double.Parse(_temp[1].ToString()));
                }
                sr.Close();
                fs.Close();
            }
        }

        private void Community_LoadFacility_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Community_FacilityFile_name.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    Hospital_Capacity.Add(double.Parse(_temp[3].ToString())); // id 名字 等级 床位数
                }
                sr.Close();
                fs.Close();
            }
        }

        private void LoadCommunity_FIle_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Community_Filename.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    Community_TimeMatrix.Add(double.Parse(_temp[1].ToString()) / 60.0);
                }
                sr.Close();
                fs.Close();
            }            
        }

        private void Load_Population_Traveltime_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                Communitypage_PopulationTravel_Filename.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    TimeMatrix_Car.Add(double.Parse(_temp[1].ToString()) / 60.0);
                }
                sr.Close();
                fs.Close();
            }
        }

        private void Community_Filename_TextChanged(object sender, EventArgs e)
        {
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            //openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            //openFileDialog.RestoreDirectory = true;
            //openFileDialog.FilterIndex = 1;
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
            //    FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
            //    StreamReader sr = new StreamReader(fs, Encoding.UTF8);
            //    Communitypage_PopulationTravel_Filename.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
            //    string line;
            //    while ((line = sr.ReadLine()) != null)
            //    {
            //        string[] _temp = line.Split(',');
            //        TimeMatrix_Car.Add(double.Parse(_temp[1].ToString()) / 60.0);
            //    }
            //    sr.Close();
            //    fs.Close();
            //}
        }

        private void Communitypage_Calc_supply_demand_radio_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < TimeMatrix_Car.Count / Hospital_Capacity.Count; i++)
            {
                subDistrict temp = new subDistrict(); ;
                temp.id = i + 1;
                temp.population = (double)PopulationList[i];

                for (int j = i * Hospital_Capacity.Count; j < (i + 1) * Hospital_Capacity.Count; j++)
                {
                    temp.CartravelTimes.Add(TimeMatrix_Car[j]);
                    //temp.TransittravelTimes.Add(TimeMatrix_Transit[j]);
                }
                populationCell_List.Add(temp);
            }


            //////计算供需比
            for (int i = 0; i < Hospital_Capacity.Count; i++)
            {
                ServiceFacility temp = new ServiceFacility();
                temp.capacity = (double)Hospital_Capacity[i];
                double demands_Sum = 0;
                for (int j = 0; j < populationCell_List.Count; j++)
                {
                    subDistrict subD = (subDistrict)populationCell_List[j];
                    if ((double)subD.CartravelTimes[i] <= double.Parse(Gadecay_timeThreshold.Text))
                    {
                        //demands_Sum += subD.population * double.Parse(Prob_car_Text.Text) * Calc_decayValue((double)subD.CartravelTimes[i], Alpha_car, Beta_car,
                        //    Car_minTime, Car_maxTime);
                        demands_Sum += subD.population * calc_GadecayValue((double)subD.CartravelTimes[i], double.Parse(Gadecay_timeThreshold.Text));
                    }
                    //if ((double)subD.TransittravelTimes[i] <= Transit_maxTime)
                    //{
                    //    demands_Sum += subD.population * double.Parse(Prob_transit_Text.Text) * Calc_decayValue((double)subD.TransittravelTimes[i], Alpha_transit, Beta_transit,
                    //        Transit_minTime, Transit_maxTime);
                    //}
                }
                temp.Supply_demand_ratio = (double)temp.capacity / demands_Sum;
                Facalityclass_List.Add(temp);
            }
            MessageBox.Show("计算完成");
        }

        private void LoadPopulationFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                PopuFile_Name.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    PopulationList.Add(double.Parse(_temp[1].ToString()));
                }
                sr.Close();
                fs.Close();
            }
            bIsloadPopulation = true;
        }

        private void tabpage2_Click(object sender, EventArgs e)
        {

        }

        private void Communitypage_calc_Accessibility_Click(object sender, EventArgs e)
        {
            ArrayList Community_List = new ArrayList();
            for (int i = 0; i < Community_TimeMatrix.Count / Hospital_Capacity.Count; i++)
            {
                subDistrict temp = new subDistrict(); ;
                temp.id = i + 1;
                //temp.population = (double)PopulationList[i];

                for (int j = i * Hospital_Capacity.Count; j < (i + 1) * Hospital_Capacity.Count; j++)
                {
                    temp.CartravelTimes.Add(Community_TimeMatrix[j]);
                }
                Community_List.Add(temp);
            }
            ////test
            //for(int i = 0; i < populationCell_List.Count;i++)
            //{
            //    subDistrict subD = (subDistrict)populationCell_List[i];
            //    for (int j = 0; j < Facalityclass_List.Count; j++)
            //    {
            //        if ((double)subD.CartravelTimes[j] <= double.Parse(Gadecay_timeThreshold.Text))
            //        {
            //            ServiceFacility sf = (ServiceFacility)Facalityclass_List[j];
            //            subD.car_Accessibility += (sf.Supply_demand_ratio * calc_GadecayValue((double)subD.CartravelTimes[j], double.Parse(Gadecay_timeThreshold.Text)));
            //        }
            //    }
            //    populationCell_List[i] = subD;'
            //}
            //计算可达性
            for (int i = 0; i < Community_List.Count; i++)
            {
                subDistrict subD = (subDistrict)Community_List[i];
                for (int j = 0; j < Facalityclass_List.Count; j++)
                {
                    if ((double)subD.CartravelTimes[j] <= double.Parse(Gadecay_timeThreshold.Text))
                    {
                        ServiceFacility sf = (ServiceFacility)Facalityclass_List[j];
                        //subD.car_Accessibility += (sf.Supply_demand_ratio * Calc_decayValue((double)subD.CartravelTimes[j], Alpha_car, Beta_car, Car_minTime, Car_maxTime));
                        subD.car_Accessibility += (sf.Supply_demand_ratio * calc_GadecayValue((double)subD.CartravelTimes[j], double.Parse(Gadecay_timeThreshold.Text)));
                    }
                    //if ((double)subD.TransittravelTimes[j] <= Transit_maxTime)
                    //{
                    //    ServiceFacility sf = (ServiceFacility)ServiceFacility_List[j];
                    //    subD.transit_Accessibility += (sf.Supply_demand_ratio * Calc_decayValue((double)subD.TransittravelTimes[j], Alpha_transit, Beta_transit, Transit_minTime, Transit_maxTime));
                    //}
                }
                //subD.multiModal_Accessibility = double.Parse(Prob_car_Text.Text) * subD.car_Accessibility + double.Parse(Prob_transit_Text.Text) * subD.transit_Accessibility;
                //subD.multiModal_Accessibility = double.Parse(Prob_car_Text.Text) * subD.car_Accessibility + double.Parse(Prob_transit_Text.Text) * subD.transit_Accessibility;
                Community_List[i] = subD;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Save an csv File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                for (int i = 0; i < Community_List.Count; i++)
                {
                    subDistrict temp = (subDistrict)Community_List[i];
                    sw.WriteLine(temp.car_Accessibility.ToString()) ;
                    //sw.Write(temp.car_Accessibility.ToString() + "," + temp.transit_Accessibility + "," + temp.multiModal_Accessibility + "\n");
                }
                sw.Close();
                fs.Close();
            }
            MessageBox.Show("导出完成!");

        }

        private void LoadServiceFacility_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                ServiceFacility_Filename.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(','); 
                    Hospital_Capacity.Add(double.Parse(_temp[3].ToString())); // id 名字 等级 床位数
                }
                sr.Close();
                fs.Close();
            }
            bIsloadServiceFacality = true;
        }

        public double calc_GadecayValue(double time,double t0)
        {
            return (Math.Pow(Math.E, (-0.5) * Math.Pow(time / t0, 2.0)) - Math.Pow(Math.E, -0.5)) / (1 - Math.Pow(Math.E, -0.5));
        }
        public double Calc_decayValue(double time, double alp, double beta, double min_time ,double max_time)
        {
            //if (time > max_time)
            //    return 0;
            //else
            //    return (Math.Exp(-0.5 * Math.Pow((time / max_time),2.0)) - Math.Exp(-0.5)) / (1 - Math.Exp(-0.5));
            //return (Math.Exp(-0.5) * Math.Pow((time / max_time), 2.0) - Math.Exp(-0.5)) / (1 - Math.Exp(-0.5));
            if (time > max_time)
                return 0;
            else if (time < min_time)
                return 1;
            else
            {
                //double lnValue = alp + (beta * Math.Log(time - min_time, Math.E));
                double lnValue = alp + (beta * Math.Log(time, Math.E));
                return (1.0) / (1.0 + Math.Exp(lnValue));
            }
        }
        private void Car_ClacAccessibility_AndSave_Btn_Click(object sender, EventArgs e)
        {
            if (bIsloadcarTimematrix == false || bIsloadPopulation == false || bIsloadServiceFacality == false || bIsloadtransitTimematrix == false)
            {
                MessageBox.Show("数据输入不完整，无法计算可达性!");
                return;
            }
            if (TimeMatrix_Car.Count % Hospital_Capacity.Count != 0)
            {
                MessageBox.Show("时间矩阵数据输入有误 或 设施数据输入有误!");
                return;
            }
            Alpha_car = double.Parse(Alpha_car_Text.Text);
            Beta_car = double.Parse(Beta_car_Text.Text);
            Alpha_transit = double.Parse(Alpha_transit_text.Text);
            Beta_transit = double.Parse(Beta_transit_text.Text);
            Car_minTime = double.Parse(Tmin_car_Text.Text);
            Car_maxTime = double.Parse(Tmax_car_Text.Text);
            Transit_minTime = double.Parse(Tmin_transit_text.Text);
            Transit_maxTime = double.Parse(Tmax_transit_text.Text);

            ArrayList subDistrict_List = new ArrayList();
            ArrayList ServiceFacility_List = new ArrayList();
            for (int i = 0;i<TimeMatrix_Car.Count / Hospital_Capacity.Count; i++)
            {
                subDistrict temp = new subDistrict(); ;
                temp.id = i+1;
                temp.population = (double)PopulationList[i];
                
                for (int j = i* Hospital_Capacity.Count; j < (i+1)*Hospital_Capacity.Count; j++)
                {
                    temp.CartravelTimes.Add(TimeMatrix_Car[j]);
                    temp.TransittravelTimes.Add(TimeMatrix_Transit[j]);
                }
                subDistrict_List.Add(temp);
            }
            //////计算供需比
            for(int i = 0;i< Hospital_Capacity.Count;i++)
            {
                ServiceFacility temp = new ServiceFacility();
                temp.capacity = (double)Hospital_Capacity[i];
                double demands_Sum = 0;
                for (int j = 0;j<subDistrict_List.Count;j++)  
                {
                    subDistrict subD = (subDistrict)subDistrict_List[j];
                    if ((double)subD.CartravelTimes[i] <= Car_maxTime)
                    {
                        demands_Sum += subD.population * double.Parse(Prob_car_Text.Text) * Calc_decayValue((double)subD.CartravelTimes[i], Alpha_car, Beta_car,
                            Car_minTime,Car_maxTime);
                    }
                    if((double)subD.TransittravelTimes[i] <= Transit_maxTime)
                    {
                        demands_Sum += subD.population * double.Parse(Prob_transit_Text.Text) * Calc_decayValue((double)subD.TransittravelTimes[i], Alpha_transit, Beta_transit,
                            Transit_minTime, Transit_maxTime);
                    }
                }
                temp.Supply_demand_ratio = (double)temp.capacity / demands_Sum;
                ServiceFacility_List.Add(temp);
            }
            //计算可达性
            for(int i = 0;i<subDistrict_List.Count;i++)
            {
                subDistrict subD = (subDistrict)subDistrict_List[i];
                for(int j = 0;j<ServiceFacility_List.Count;j++)
                {
                    if((double)subD.CartravelTimes[j] <= Car_maxTime)
                    {
                        ServiceFacility sf = (ServiceFacility)ServiceFacility_List[j];
                        subD.car_Accessibility += (sf.Supply_demand_ratio * Calc_decayValue((double)subD.CartravelTimes[j],Alpha_car,Beta_car,Car_minTime,Car_maxTime));
                    }
                    if ((double)subD.TransittravelTimes[j] <= Transit_maxTime)
                    {
                        ServiceFacility sf = (ServiceFacility)ServiceFacility_List[j];
                        subD.transit_Accessibility += (sf.Supply_demand_ratio * Calc_decayValue((double)subD.TransittravelTimes[j], Alpha_transit, Beta_transit, Transit_minTime, Transit_maxTime));
                    }
                }
                subD.multiModal_Accessibility = double.Parse(Prob_car_Text.Text) * subD.car_Accessibility + double.Parse(Prob_transit_Text.Text) * subD.transit_Accessibility;
                subD.multiModal_Accessibility = double.Parse(Prob_car_Text.Text) * subD.car_Accessibility + double.Parse(Prob_transit_Text.Text) * subD.transit_Accessibility;
                subDistrict_List[i] = subD;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Save an csv File";
            if(saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                for (int i = 0; i < subDistrict_List.Count; i++)
                {
                    subDistrict temp =  (subDistrict)subDistrict_List[i];
                    sw.Write(temp.car_Accessibility.ToString() + "," + temp.transit_Accessibility + "," + temp.multiModal_Accessibility + "\n");
                }
                sw.Close();
                fs.Close();
            }
            MessageBox.Show("导出完成!");

        }
    }


    class subDistrict
    {
        public int id;
        public double population;
        public ArrayList CartravelTimes;
        public ArrayList TransittravelTimes;

        public double car_Accessibility;
        public double transit_Accessibility;
        public double multiModal_Accessibility;
        public subDistrict()
        {
            CartravelTimes = new ArrayList();
            TransittravelTimes = new ArrayList();
        }
    }
    class ServiceFacility
    {
        public double capacity;
        public double Supply_demand_ratio;
    }

}
