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
    public partial class D_OCapacityCount : Form
    {
        public D_OCapacityCount()
        {
            InitializeComponent();
        }
        public List<int> Population_List = new List<int>();
        public List<int> TravelTime_List = new List<int>();
        public int Count_Demand = 0;
        List<Server> ServerList = new List<Server>();
        private void LoadPopu_Data_Click(object sender, EventArgs e)
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
                    Population_List.Add(int.Parse(_temp[1]));
                }
                Count_Demand = Population_List.Count;
                sr.Close();
                fs.Close();
            }
        }

        private void LoadD_OTimeMatrix_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "csv文件|*.csv|所有文件|*.*";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.FilterIndex = 1;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileStream fs = new FileStream(openFileDialog.FileName, FileMode.Open);
                StreamReader sr = new StreamReader(fs, Encoding.UTF8);
                DO_FILENAME.Text = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                string line;
                int index = 1;
                int id = 1;
                Server temp_Server = new Server();
                while ((line = sr.ReadLine()) != null)
                {
                    string[] _temp = line.Split(',');
                    TravelTime_List.Add(int.Parse(_temp[1]));
                    temp_Server.TravelTime_Matrix.Add(int.Parse(_temp[1]));
                    if (index == Count_Demand)
                    {
                        temp_Server.id = id++;
                        ServerList.Add(temp_Server);
                        index = 1;
                        temp_Server = new Server();
                        continue;
                    }
                    index++;
                }
                sr.Close();
                fs.Close();
            }
        }

        private void Calc_ResultBtn_Click(object sender, EventArgs e)
        {
            int timeThreshold = int.Parse(Threshold_Text.Text) * 60;
            for (int i = 0;i< ServerList.Count;i++)
            {
                Server temp = ServerList[i];
                for(int j = 0;j<temp.TravelTime_Matrix.Count;j++)
                {
                    if(temp.TravelTime_Matrix[j] <= timeThreshold)
                    {
                        temp.serveCellcount++;
                        temp.servePopulation += Population_List[j];
                    }
                }
                ServerList[i] = temp;
            }
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV|*.csv";
            saveFileDialog1.Title = "Save an csv File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream fs = (System.IO.FileStream)saveFileDialog1.OpenFile();
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                for (int i = 0; i < ServerList.Count; i++)
                {
                    Server temp = ServerList[i];
                    sw.Write(temp.serveCellcount + "," + temp.servePopulation + "\n");
                }
                sw.Close();
                fs.Close();
            }
            MessageBox.Show("导出完成!");
        }
    }
    class Server
    {
        public int id;
        public List<int> TravelTime_Matrix;
        public int servePopulation;
        public int serveCellcount;
        public Server()
        {
            id = 0;
            TravelTime_Matrix = new List<int>();
            servePopulation = 0;
            serveCellcount = 0;
        }
    }
}
