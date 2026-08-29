namespace AutosApplication
{
    partial class AutoForm
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
            dataGridView1 = new DataGridView();
            Make = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Year = new DataGridViewTextBoxColumn();
            VIN = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            CurrentMileage = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Make, Model, Year, VIN, LicensePlate, CurrentMileage });
            dataGridView1.Location = new Point(12, 101);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1083, 534);
            dataGridView1.TabIndex = 0;
            // 
            // Make
            // 
            Make.DataPropertyName = "Make";
            Make.HeaderText = "Vehicle Make";
            Make.Name = "Make";
            Make.ReadOnly = true;
            // 
            // Model
            // 
            Model.DataPropertyName = "Model";
            Model.HeaderText = "Vehicle Model";
            Model.Name = "Model";
            Model.ReadOnly = true;
            // 
            // Year
            // 
            Year.DataPropertyName = "Year";
            Year.HeaderText = "Vehicle Year";
            Year.Name = "Year";
            Year.ReadOnly = true;
            // 
            // VIN
            // 
            VIN.DataPropertyName = "VIN";
            VIN.HeaderText = "Vehicle Vin";
            VIN.Name = "VIN";
            VIN.ReadOnly = true;
            // 
            // LicensePlate
            // 
            LicensePlate.DataPropertyName = "LicensePlate";
            LicensePlate.HeaderText = "Vehicle License Plate";
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            // 
            // CurrentMileage
            // 
            Make.DataPropertyName = "CurrentMileage";
            CurrentMileage.HeaderText = "Current Mileage";
            CurrentMileage.Name = "CurrentMileage";
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 659);
            Controls.Add(dataGridView1);
            Name = "AutoForm";
            Text = "Autos";
            Load += new System.EventHandler(this.AutoForm_Load);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Year;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn CurrentMileage;
    }
}
