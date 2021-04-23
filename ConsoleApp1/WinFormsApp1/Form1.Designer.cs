
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.VehID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.engineno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridOtherInfo = new System.Windows.Forms.DataGridView();
            this.DataGridVehicle = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtvehicleid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtmanufacture = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.txtChassis = new System.Windows.Forms.TextBox();
            this.txtEngine = new System.Windows.Forms.TextBox();
            this.Manufacture = new System.Windows.Forms.Label();
            this.Model = new System.Windows.Forms.Label();
            this.Make = new System.Windows.Forms.Label();
            this.Chassis = new System.Windows.Forms.Label();
            this.engine = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnsaveotherinfo = new System.Windows.Forms.Button();
            this.txtotherid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcustnm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtherInfo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehicle)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView2);
            this.panel1.Controls.Add(this.dataGridOtherInfo);
            this.panel1.Controls.Add(this.DataGridVehicle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 408);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1288, 204);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.VehID,
            this.engineno});
            this.dataGridView2.Location = new System.Drawing.Point(898, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 29;
            this.dataGridView2.Size = new System.Drawing.Size(390, 204);
            this.dataGridView2.TabIndex = 2;
            // 
            // VehID
            // 
            this.VehID.HeaderText = "Vehicle ID";
            this.VehID.MinimumWidth = 6;
            this.VehID.Name = "VehID";
            this.VehID.Width = 125;
            // 
            // engineno
            // 
            this.engineno.HeaderText = "Engine Number";
            this.engineno.MinimumWidth = 6;
            this.engineno.Name = "engineno";
            this.engineno.Width = 125;
            // 
            // dataGridOtherInfo
            // 
            this.dataGridOtherInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOtherInfo.Location = new System.Drawing.Point(568, 0);
            this.dataGridOtherInfo.Name = "dataGridOtherInfo";
            this.dataGridOtherInfo.RowHeadersWidth = 51;
            this.dataGridOtherInfo.RowTemplate.Height = 29;
            this.dataGridOtherInfo.Size = new System.Drawing.Size(324, 204);
            this.dataGridOtherInfo.TabIndex = 1;
            // 
            // DataGridVehicle
            // 
            this.DataGridVehicle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridVehicle.Location = new System.Drawing.Point(0, 0);
            this.DataGridVehicle.Name = "DataGridVehicle";
            this.DataGridVehicle.RowHeadersWidth = 51;
            this.DataGridVehicle.RowTemplate.Height = 29;
            this.DataGridVehicle.Size = new System.Drawing.Size(562, 204);
            this.DataGridVehicle.TabIndex = 0;
            this.DataGridVehicle.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridVehicle_CellClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1011, 331);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtvehicleid);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.btnclear);
            this.tabPage1.Controls.Add(this.btnsave);
            this.tabPage1.Controls.Add(this.txtmanufacture);
            this.tabPage1.Controls.Add(this.txtModel);
            this.tabPage1.Controls.Add(this.txtMake);
            this.tabPage1.Controls.Add(this.txtChassis);
            this.tabPage1.Controls.Add(this.txtEngine);
            this.tabPage1.Controls.Add(this.Manufacture);
            this.tabPage1.Controls.Add(this.Model);
            this.tabPage1.Controls.Add(this.Make);
            this.tabPage1.Controls.Add(this.Chassis);
            this.tabPage1.Controls.Add(this.engine);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1003, 298);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Vehicle Information";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtvehicleid
            // 
            this.txtvehicleid.Location = new System.Drawing.Point(185, 25);
            this.txtvehicleid.Name = "txtvehicleid";
            this.txtvehicleid.Size = new System.Drawing.Size(625, 27);
            this.txtvehicleid.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "ID";
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(815, 247);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(127, 37);
            this.btnclear.TabIndex = 21;
            this.btnclear.Text = "show";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(29, 247);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(127, 37);
            this.btnsave.TabIndex = 20;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtmanufacture
            // 
            this.txtmanufacture.Location = new System.Drawing.Point(185, 211);
            this.txtmanufacture.Name = "txtmanufacture";
            this.txtmanufacture.Size = new System.Drawing.Size(328, 27);
            this.txtmanufacture.TabIndex = 19;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(185, 169);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(625, 27);
            this.txtModel.TabIndex = 18;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(185, 133);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(625, 27);
            this.txtMake.TabIndex = 17;
            // 
            // txtChassis
            // 
            this.txtChassis.Location = new System.Drawing.Point(185, 97);
            this.txtChassis.Name = "txtChassis";
            this.txtChassis.Size = new System.Drawing.Size(625, 27);
            this.txtChassis.TabIndex = 16;
            // 
            // txtEngine
            // 
            this.txtEngine.Location = new System.Drawing.Point(185, 58);
            this.txtEngine.Name = "txtEngine";
            this.txtEngine.Size = new System.Drawing.Size(625, 27);
            this.txtEngine.TabIndex = 15;
            // 
            // Manufacture
            // 
            this.Manufacture.AutoSize = true;
            this.Manufacture.Location = new System.Drawing.Point(32, 211);
            this.Manufacture.Name = "Manufacture";
            this.Manufacture.Size = new System.Drawing.Size(124, 20);
            this.Manufacture.TabIndex = 14;
            this.Manufacture.Text = "Manufacture Year";
            // 
            // Model
            // 
            this.Model.AutoSize = true;
            this.Model.Location = new System.Drawing.Point(32, 172);
            this.Model.Name = "Model";
            this.Model.Size = new System.Drawing.Size(52, 20);
            this.Model.TabIndex = 13;
            this.Model.Text = "Model";
            // 
            // Make
            // 
            this.Make.AutoSize = true;
            this.Make.Location = new System.Drawing.Point(32, 133);
            this.Make.Name = "Make";
            this.Make.Size = new System.Drawing.Size(45, 20);
            this.Make.TabIndex = 12;
            this.Make.Text = "Make";
            // 
            // Chassis
            // 
            this.Chassis.AutoSize = true;
            this.Chassis.Location = new System.Drawing.Point(32, 100);
            this.Chassis.Name = "Chassis";
            this.Chassis.Size = new System.Drawing.Size(114, 20);
            this.Chassis.TabIndex = 11;
            this.Chassis.Text = "Chassis Number";
            // 
            // engine
            // 
            this.engine.AutoSize = true;
            this.engine.Location = new System.Drawing.Point(32, 61);
            this.engine.Name = "engine";
            this.engine.Size = new System.Drawing.Size(112, 20);
            this.engine.TabIndex = 10;
            this.engine.Text = "Engine Number";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnsaveotherinfo);
            this.tabPage2.Controls.Add(this.txtotherid);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtcustnm);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1003, 298);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Other Information";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnsaveotherinfo
            // 
            this.btnsaveotherinfo.Location = new System.Drawing.Point(706, 236);
            this.btnsaveotherinfo.Name = "btnsaveotherinfo";
            this.btnsaveotherinfo.Size = new System.Drawing.Size(127, 37);
            this.btnsaveotherinfo.TabIndex = 21;
            this.btnsaveotherinfo.Text = "Save";
            this.btnsaveotherinfo.UseVisualStyleBackColor = true;
            this.btnsaveotherinfo.Click += new System.EventHandler(this.btnsaveotherinfo_Click);
            // 
            // txtotherid
            // 
            this.txtotherid.Location = new System.Drawing.Point(179, 32);
            this.txtotherid.Name = "txtotherid";
            this.txtotherid.Size = new System.Drawing.Size(625, 27);
            this.txtotherid.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "ID";
            // 
            // txtcustnm
            // 
            this.txtcustnm.Location = new System.Drawing.Point(179, 115);
            this.txtcustnm.Name = "txtcustnm";
            this.txtcustnm.Size = new System.Drawing.Size(625, 27);
            this.txtcustnm.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "Customer Name";
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 612);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOtherInfo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridVehicle)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridVehicle;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.TextBox txtmanufacture;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.TextBox txtChassis;
        private System.Windows.Forms.TextBox txtEngine;
        private System.Windows.Forms.Label Manufacture;
        private System.Windows.Forms.Label Model;
        private System.Windows.Forms.Label Make;
        private System.Windows.Forms.Label Chassis;
        private System.Windows.Forms.Label engine;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.TextBox txtcustnm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridOtherInfo;
        private System.Windows.Forms.TextBox txtvehicleid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnsaveotherinfo;
        private System.Windows.Forms.TextBox txtotherid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn VehID;
        private System.Windows.Forms.DataGridViewTextBoxColumn engineno;
    }
}

