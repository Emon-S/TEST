using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace MedWinfrom
{
    public partial class ApprovalWindows : Form
    {
        public ApprovalWindows()
        {
            InitializeComponent();
            wirtetofile("what are you doing now");
            Console.WriteLine("or using this one");
            //directly invoke webserviec and send the message to another program and that program will invoke this one 
        }
        public void wirtetofile(string needwritetofile)
        {
            string filePath = "C:/Users/yanliang.song/Desktop/2323.txt";
            if (File.Exists(filePath))
                File.Delete(filePath);
            FileStream fs = new FileStream(filePath, FileMode.Create);            //获得字节数组          
            byte[] data = System.Text.Encoding.Default.GetBytes(needwritetofile);            //开始写入
            fs.Write(data, 0, data.Length);            //清空缓冲区、关闭流
            fs.Flush();
            fs.Close();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TimeLabel_Click(object sender, EventArgs e)
        {

        }

        private void ApprovalWindows_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //DataGridViewRow row = new DataGridViewRow();
            //DataGridViewTextBoxCell textboxcell = new DataGridViewTextBoxCell();
            //textboxcell.Value = "aaa";
            //row.Cells.Add(textboxcell);
            //DataGridViewComboBoxCell comboxcell = new DataGridViewComboBoxCell();
            //row.Cells.Add(comboxcell);
            //dataGridView1.Rows.Add(row);

            GetBind(dataGridView1);
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            TimeLabel.Text = System.DateTime.Now.ToString();


        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string GetMedicineInfo(string medicineInfo)
        {
            return medicineInfo;
        }
        private void GetBind(DataGridView dataGridView)
        {

            DataTable dt = new DataTable("cart");
            DataColumn dc1 = new DataColumn("prizename", Type.GetType("System.String"));
            DataColumn dc2 = new DataColumn("point", Type.GetType("System.Int16"));
            DataColumn dc3 = new DataColumn("number", Type.GetType("System.Int16"));
            DataColumn dc4 = new DataColumn("totalpoint", Type.GetType("System.Int64"));
            DataColumn dc5 = new DataColumn("prizeid", Type.GetType("System.String"));
            dt.Columns.Add(dc1);
            dt.Columns.Add(dc2);
            dt.Columns.Add(dc3);
            dt.Columns.Add(dc4);
            dt.Columns.Add(dc5);
            //以上代码完成了DataTable的构架，但是里面是没有任何数据的
            for (int i = 0; i < 10; i++)
            {
                DataRow dr = dt.NewRow();
                dr["prizename"] = "ww";
                dr["point"] = 10;
                dr["number"] = 1;
                dr["totalpoint"] = 10;
                dr["prizeid"] = "001";
                dt.Rows.Add(dr);
            }
                dataGridView.DataSource = dt; // ds是数据源

                                         

        }
    }
}
