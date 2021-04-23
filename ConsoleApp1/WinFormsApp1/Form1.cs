using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private List<Vehicle> listvehicle = new List<Vehicle>();
        //private int year = 2020;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();
        DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();
            dt.Columns.Add(new DataColumn("ID"));
            dt.Columns.Add(new DataColumn("ChassisNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("EngineNumber", typeof(string)));
            dt.Columns.Add(new DataColumn("Make", typeof(string)));
            dt.Columns.Add(new DataColumn("Model", typeof(string)));
            dt.Columns.Add(new DataColumn("Manufactyear"));
            dt1.Columns.Add(new DataColumn("id"));
            dt1.Columns.Add(new DataColumn("Custname", typeof(string)));
            ds.Tables.Add(dt);
            ds.Tables.Add(dt1);
            dt.PrimaryKey = new DataColumn[] { dt.Columns[0] };

            DataRelation dr = new DataRelation("stcourse", dt.Columns[0], dt1.Columns[0]);
            ds.Relations.Add(dr);
            DataGridVehicle.DataSource = dt;
            dataGridOtherInfo.DataSource = dt1;
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {

                if (string.IsNullOrWhiteSpace(txtEngine.Text))
                {
                    error.SetError(this.txtEngine, "Please Enter Engine Number");
                    return;
                }
                DataRow row = dt.NewRow();


                //Vehicle v1 = new Vehicle();
                //DataColumn ChassisNo = new DataColumn("ChassisNumber");
                /*v1.ChassisNumber = txtChassis.Text;
                v1.EngineNumber = txtEngine.Text;
                v1.Make = txtMake.Text;
                v1.Model = txtModel.Text;
                int.TryParse(txtmanufacture.Text, out year);
                txtmanufacture.Text = year.ToString();
                //v1.YearOfManufacture = txtmanufacture.Text;
                //listvehicle.Add(v1);
                */
                row["ID"] = txtvehicleid.Text;
                row["ChassisNumber"] = txtChassis.Text;
                row["EngineNumber"] = txtEngine.Text;
                row["Make"] = txtMake.Text;
                row["Model"] = txtModel.Text;
                row["Manufactyear"] = txtmanufacture.Text;
                dt.Rows.Add(row);
                

                //DataGridVehicle.Rows.Add();


                
            }
            catch(Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            DataRow[] dr = dt.Rows.Find(DataGridVehicle.SelectedCells[0].Value).GetChildRows("stcourse");

            foreach (DataRow d in dr)
            {
                dataGridView2.Rows.Add(d[0], d[1]);
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnsaveotherinfo_Click(object sender, EventArgs e)
        {
            DataRow row1 = dt1.NewRow();

            row1["id"] = txtvehicleid.Text;
            row1["Custname"] = txtcustnm.Text;

            dt1.Rows.Add(row1);
        }

        private void DataGridVehicle_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
