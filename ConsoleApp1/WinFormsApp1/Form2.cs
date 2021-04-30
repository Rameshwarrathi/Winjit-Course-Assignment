using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using ConnectionLib;

namespace WinFormsApp1
{
    public partial class Form2 : Form
    {
       
        DataSet ds = new DataSet();
        string Con = @"Integrated Security =SSPI;initial catalog=Vehicle;Data Source=LAPTOP-5RS1NN83;";
        int indexRow;
        public Form2()
        {
            InitializeComponent();
            

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            getdata();
        }

         public void getdata()
        {
            ConnectionLib.ManageVehicle mv = new ManageVehicle();
            DataSet ds = mv.getvehicledetails();
            DataSet ds1 = mv.getvehicledetails1();

            DataGridVehicle.DataSource = ds.Tables["Vehicle"].DefaultView;
            dataGridOtherInfo.DataSource = ds1.Tables["OtherInfo"].DefaultView;
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

                else if (string.IsNullOrWhiteSpace(txtChassis.Text))
                {
                    error.SetError(this.txtChassis, "Please Enter Chassis Number");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtMake.Text))
                {
                    error.SetError(this.txtMake, "Please Enter Make");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    error.SetError(this.txtModel, "Please Enter Model Name");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtmanufacture.Text))
                {
                    error.SetError(this.txtmanufacture, "Please Enter Manufacture year");
                    return;
                }
                else
                {
                    //using normal method
                    /*SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "INSERT INTO VehicleInfo(EngineNumber,ChassisNumber,Make,Model,ManufactYear) VALUES ('" + txtEngine.Text + "','" + txtChassis.Text + "','" + txtMake.Text + "','" + txtModel.Text + "','" + txtmanufacture.Text + "')";

                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Inserted sucessfully");*/
                    
                    //using stored procedure 
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    SqlCommand c = new SqlCommand("Insert_Vehicledata", conn);
                    
                    c.CommandType = System.Data.CommandType.StoredProcedure;
                    c.Parameters.AddWithValue("@EngineNumber", txtEngine.Text);
                    c.Parameters.AddWithValue("@ChassisNumber", txtChassis.Text);
                    c.Parameters.AddWithValue("@Make", txtMake.Text);
                    c.Parameters.AddWithValue("@Model", txtModel.Text);
                    c.Parameters.AddWithValue("@ManufactYear", txtmanufacture.Text);
                    
                    c.ExecuteNonQuery();
                    MessageBox.Show("Successfully Inserted....");
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }


        private void DataGridVehicle_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex; // get the selected Row Index
            DataGridViewRow row = DataGridVehicle.Rows[indexRow];

            txtvehicleid.Text = row.Cells[0].Value.ToString();
            txtEngine.Text = row.Cells[1].Value.ToString();
            txtChassis.Text = row.Cells[2].Value.ToString();
            txtMake.Text = row.Cells[3].Value.ToString();
            txtModel.Text = row.Cells[4].Value.ToString();
            txtmanufacture.Text = row.Cells[5].Value.ToString();
        }


        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtEngine.Text))
                {
                    error.SetError(this.txtEngine, "Please Enter Engine Number");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtChassis.Text))
                {
                    error.SetError(this.txtChassis, "Please Enter Chassis Number");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtMake.Text))
                {
                    error.SetError(this.txtMake, "Please Enter Make");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtModel.Text))
                {
                    error.SetError(this.txtModel, "Please Enter Model Name");
                    return;
                }
                else if (string.IsNullOrWhiteSpace(txtmanufacture.Text))
                {
                    error.SetError(this.txtmanufacture, "Please Enter Manufacture year");
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "update VehicleInfo set  EngineNumber='" + txtEngine.Text + "',ChassisNumber='" + txtChassis.Text + "',Make='" + txtMake.Text + "',Model='" + txtMake.Text + "',ManufactYear='" + txtmanufacture.Text + "' where VehicleID='" + txtvehicleid.Text + "'";

                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Updated sucessfully of Vehicle Id" + txtvehicleid.Text);
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrWhiteSpace(txtvehicleid.Text))
                {
                    error.SetError(this.txtvehicleid, "Please Enter Vehicle Number To Delete");
                    return;
                }

                else
                {
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "delete from VehicleInfo where VehicleID='" + txtvehicleid.Text + "'";
                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Record Deleted sucessfully of Vehicle Id" + txtvehicleid.Text);
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btnsave1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtvehicleid1.Text))
                {
                    error.SetError(this.txtvehicleid1, "Please Enter Vehicle Id");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtvehinfo.Text))
                {
                    error.SetError(this.txtvehinfo, "Please Enter Vehicle Info");
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "INSERT INTO OtherInformation(VehicleId,VehicleDesc) VALUES ('" + txtvehicleid1.Text + "','" + txtvehinfo.Text + "')";

                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Inserted sucessfully");
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btnupdate1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtvehicleid1.Text))
                {
                    error.SetError(this.txtvehicleid1, "Please Enter Vehicle Id");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtvehinfo.Text))
                {
                    error.SetError(this.txtvehinfo, "Please Enter Vehicle Info");
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "Update OtherInformation (VehicleId='" + txtvehicleid1.Text + "',VehicleDesc='" + txtvehinfo.Text + "')";
                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Inserted sucessfully");
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }

        private void btndelete1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtvehicleid1.Text))
                {
                    error.SetError(this.txtvehicleid1, "Please Enter Vehicle Id");
                    return;
                }

                else if (string.IsNullOrWhiteSpace(txtvehinfo.Text))
                {
                    error.SetError(this.txtvehinfo, "Please Enter Vehicle Info");
                    return;
                }
                else
                {
                    SqlConnection conn = new SqlConnection(Con);
                    conn.Open();
                    string qur = "Delete from  OtherInformation where VehicleId='" + txtvehicleid1.Text + "'";

                    SqlCommand cmd = new SqlCommand(qur, conn);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Inserted sucessfully");
                    getdata();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.Message);
            }
        }
    }
}
