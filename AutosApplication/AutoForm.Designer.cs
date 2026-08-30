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
            AutosPageHeader = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Make, Model, Year, VIN, LicensePlate, CurrentMileage });
            dataGridView1.Location = new Point(143, 193);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(722, 197);
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
            CurrentMileage.DataPropertyName = "CurrentMileage";
            CurrentMileage.HeaderText = "Current Mileage";
            CurrentMileage.Name = "CurrentMileage";
            // 
            // AutosPageHeader
            // 
            AutosPageHeader.BackColor = SystemColors.ActiveCaption;
            AutosPageHeader.Location = new Point(-4, -2);
            AutosPageHeader.Name = "AutosPageHeader";
            AutosPageHeader.Size = new Size(1112, 104);
            AutosPageHeader.TabIndex = 1;
            // 
            // AutoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1107, 659);
            Controls.Add(AutosPageHeader);
            Controls.Add(dataGridView1);
            Name = "AutoForm";
            Text = "Autos";
            Load += AutoForm_Load;
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
        private Panel AutosPageHeader;
    }
}
