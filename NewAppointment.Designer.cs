
namespace Papatoetoe_Hospital_App
{
    partial class NewAppointment
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.PatientID_lbl = new System.Windows.Forms.Label();
            this.Patient_tbx = new System.Windows.Forms.TextBox();
            this.Search_btn = new System.Windows.Forms.Button();
            this.PName_lbl = new System.Windows.Forms.Label();
            this.PName_tbx = new System.Windows.Forms.TextBox();
            this.AppID_tbx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.NewApp_btn = new System.Windows.Forms.Button();
            this.Cancel_btn = new System.Windows.Forms.Button();
            this.AppDate_lbl = new System.Windows.Forms.Label();
            this.AppDate_pkr = new System.Windows.Forms.DateTimePicker();
            this.AppTime_pkr = new System.Windows.Forms.Label();
            this.Duration_tbx = new System.Windows.Forms.TextBox();
            this.Duration_lbl = new System.Windows.Forms.Label();
            this.Reason_rtbx = new System.Windows.Forms.RichTextBox();
            this.Reason_lbl = new System.Windows.Forms.Label();
            this.Doctor_lbl = new System.Windows.Forms.Label();
            this.Doctor_cbx = new System.Windows.Forms.ComboBox();
            this.ContTime_pkr = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Papatoetoe_Hospital_App.Properties.Resources.Logo03;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 44);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(275, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 39);
            this.label1.TabIndex = 11;
            this.label1.Text = "New Appointment";
            // 
            // Exit_btn
            // 
            this.Exit_btn.Location = new System.Drawing.Point(590, 405);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(131, 31);
            this.Exit_btn.TabIndex = 9;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = true;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // PatientID_lbl
            // 
            this.PatientID_lbl.AutoSize = true;
            this.PatientID_lbl.BackColor = System.Drawing.Color.Transparent;
            this.PatientID_lbl.Location = new System.Drawing.Point(65, 95);
            this.PatientID_lbl.Name = "PatientID_lbl";
            this.PatientID_lbl.Size = new System.Drawing.Size(69, 17);
            this.PatientID_lbl.TabIndex = 12;
            this.PatientID_lbl.Text = "Patient ID";
            // 
            // Patient_tbx
            // 
            this.Patient_tbx.Location = new System.Drawing.Point(173, 95);
            this.Patient_tbx.Name = "Patient_tbx";
            this.Patient_tbx.Size = new System.Drawing.Size(100, 22);
            this.Patient_tbx.TabIndex = 0;
            // 
            // Search_btn
            // 
            this.Search_btn.Location = new System.Drawing.Point(309, 95);
            this.Search_btn.Name = "Search_btn";
            this.Search_btn.Size = new System.Drawing.Size(67, 25);
            this.Search_btn.TabIndex = 1;
            this.Search_btn.Text = "Search";
            this.Search_btn.UseVisualStyleBackColor = true;
            this.Search_btn.Click += new System.EventHandler(this.Search_btn_Click);
            // 
            // PName_lbl
            // 
            this.PName_lbl.AutoSize = true;
            this.PName_lbl.BackColor = System.Drawing.Color.Transparent;
            this.PName_lbl.Location = new System.Drawing.Point(65, 125);
            this.PName_lbl.Name = "PName_lbl";
            this.PName_lbl.Size = new System.Drawing.Size(93, 17);
            this.PName_lbl.TabIndex = 15;
            this.PName_lbl.Text = "Patient Name";
            // 
            // PName_tbx
            // 
            this.PName_tbx.Enabled = false;
            this.PName_tbx.Location = new System.Drawing.Point(173, 125);
            this.PName_tbx.Name = "PName_tbx";
            this.PName_tbx.Size = new System.Drawing.Size(203, 22);
            this.PName_tbx.TabIndex = 14;
            // 
            // AppID_tbx
            // 
            this.AppID_tbx.Enabled = false;
            this.AppID_tbx.Location = new System.Drawing.Point(600, 95);
            this.AppID_tbx.Name = "AppID_tbx";
            this.AppID_tbx.ReadOnly = true;
            this.AppID_tbx.Size = new System.Drawing.Size(100, 22);
            this.AppID_tbx.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(490, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Appointment ID";
            // 
            // NewApp_btn
            // 
            this.NewApp_btn.Location = new System.Drawing.Point(50, 405);
            this.NewApp_btn.Name = "NewApp_btn";
            this.NewApp_btn.Size = new System.Drawing.Size(131, 31);
            this.NewApp_btn.TabIndex = 7;
            this.NewApp_btn.Text = "Create";
            this.NewApp_btn.UseVisualStyleBackColor = true;
            this.NewApp_btn.Click += new System.EventHandler(this.NewApp_btn_Click);
            // 
            // Cancel_btn
            // 
            this.Cancel_btn.Location = new System.Drawing.Point(324, 405);
            this.Cancel_btn.Name = "Cancel_btn";
            this.Cancel_btn.Size = new System.Drawing.Size(131, 31);
            this.Cancel_btn.TabIndex = 8;
            this.Cancel_btn.Text = "Cancel";
            this.Cancel_btn.UseVisualStyleBackColor = true;
            // 
            // AppDate_lbl
            // 
            this.AppDate_lbl.AutoSize = true;
            this.AppDate_lbl.BackColor = System.Drawing.Color.Transparent;
            this.AppDate_lbl.Location = new System.Drawing.Point(65, 155);
            this.AppDate_lbl.Name = "AppDate_lbl";
            this.AppDate_lbl.Size = new System.Drawing.Size(38, 17);
            this.AppDate_lbl.TabIndex = 21;
            this.AppDate_lbl.Text = "Date";
            // 
            // AppDate_pkr
            // 
            this.AppDate_pkr.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.AppDate_pkr.Location = new System.Drawing.Point(173, 155);
            this.AppDate_pkr.Name = "AppDate_pkr";
            this.AppDate_pkr.Size = new System.Drawing.Size(200, 22);
            this.AppDate_pkr.TabIndex = 2;
            // 
            // AppTime_pkr
            // 
            this.AppTime_pkr.AutoSize = true;
            this.AppTime_pkr.BackColor = System.Drawing.Color.Transparent;
            this.AppTime_pkr.Location = new System.Drawing.Point(65, 185);
            this.AppTime_pkr.Name = "AppTime_pkr";
            this.AppTime_pkr.Size = new System.Drawing.Size(39, 17);
            this.AppTime_pkr.TabIndex = 23;
            this.AppTime_pkr.Text = "Time";
            // 
            // Duration_tbx
            // 
            this.Duration_tbx.Location = new System.Drawing.Point(173, 245);
            this.Duration_tbx.Name = "Duration_tbx";
            this.Duration_tbx.Size = new System.Drawing.Size(100, 22);
            this.Duration_tbx.TabIndex = 5;
            // 
            // Duration_lbl
            // 
            this.Duration_lbl.AutoSize = true;
            this.Duration_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Duration_lbl.Location = new System.Drawing.Point(65, 245);
            this.Duration_lbl.Name = "Duration_lbl";
            this.Duration_lbl.Size = new System.Drawing.Size(62, 17);
            this.Duration_lbl.TabIndex = 25;
            this.Duration_lbl.Text = "Duration";
            // 
            // Reason_rtbx
            // 
            this.Reason_rtbx.Location = new System.Drawing.Point(173, 275);
            this.Reason_rtbx.Name = "Reason_rtbx";
            this.Reason_rtbx.Size = new System.Drawing.Size(209, 60);
            this.Reason_rtbx.TabIndex = 6;
            this.Reason_rtbx.Text = "";
            // 
            // Reason_lbl
            // 
            this.Reason_lbl.AutoSize = true;
            this.Reason_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Reason_lbl.Location = new System.Drawing.Point(65, 275);
            this.Reason_lbl.Name = "Reason_lbl";
            this.Reason_lbl.Size = new System.Drawing.Size(57, 17);
            this.Reason_lbl.TabIndex = 28;
            this.Reason_lbl.Text = "Reason";
            // 
            // Doctor_lbl
            // 
            this.Doctor_lbl.AutoSize = true;
            this.Doctor_lbl.BackColor = System.Drawing.Color.Transparent;
            this.Doctor_lbl.Location = new System.Drawing.Point(65, 215);
            this.Doctor_lbl.Name = "Doctor_lbl";
            this.Doctor_lbl.Size = new System.Drawing.Size(50, 17);
            this.Doctor_lbl.TabIndex = 29;
            this.Doctor_lbl.Text = "Doctor";
            // 
            // Doctor_cbx
            // 
            this.Doctor_cbx.FormattingEnabled = true;
            this.Doctor_cbx.Location = new System.Drawing.Point(173, 215);
            this.Doctor_cbx.Name = "Doctor_cbx";
            this.Doctor_cbx.Size = new System.Drawing.Size(200, 24);
            this.Doctor_cbx.TabIndex = 4;
            // 
            // ContTime_pkr
            // 
            this.ContTime_pkr.Location = new System.Drawing.Point(173, 185);
            this.ContTime_pkr.Name = "ContTime_pkr";
            this.ContTime_pkr.Size = new System.Drawing.Size(200, 22);
            this.ContTime_pkr.TabIndex = 30;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Papatoetoe_Hospital_App.Properties.Resources.istockphoto_940993008_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContTime_pkr);
            this.Controls.Add(this.Doctor_cbx);
            this.Controls.Add(this.Doctor_lbl);
            this.Controls.Add(this.Reason_lbl);
            this.Controls.Add(this.Reason_rtbx);
            this.Controls.Add(this.Duration_tbx);
            this.Controls.Add(this.Duration_lbl);
            this.Controls.Add(this.AppTime_pkr);
            this.Controls.Add(this.AppDate_pkr);
            this.Controls.Add(this.AppDate_lbl);
            this.Controls.Add(this.Cancel_btn);
            this.Controls.Add(this.NewApp_btn);
            this.Controls.Add(this.AppID_tbx);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PName_tbx);
            this.Controls.Add(this.PName_lbl);
            this.Controls.Add(this.Search_btn);
            this.Controls.Add(this.Patient_tbx);
            this.Controls.Add(this.PatientID_lbl);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NewAppointment";
            this.Text = "NewAppointment";
            this.Load += new System.EventHandler(this.NewAppointment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label PatientID_lbl;
        private System.Windows.Forms.TextBox Patient_tbx;
        private System.Windows.Forms.Button Search_btn;
        private System.Windows.Forms.Label PName_lbl;
        private System.Windows.Forms.TextBox PName_tbx;
        private System.Windows.Forms.TextBox AppID_tbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button NewApp_btn;
        private System.Windows.Forms.Button Cancel_btn;
        private System.Windows.Forms.Label AppDate_lbl;
        private System.Windows.Forms.DateTimePicker AppDate_pkr;
        private System.Windows.Forms.Label AppTime_pkr;
        private System.Windows.Forms.TextBox Duration_tbx;
        private System.Windows.Forms.Label Duration_lbl;
        private System.Windows.Forms.RichTextBox Reason_rtbx;
        private System.Windows.Forms.Label Reason_lbl;
        private System.Windows.Forms.Label Doctor_lbl;
        private System.Windows.Forms.ComboBox Doctor_cbx;
        private System.Windows.Forms.DateTimePicker ContTime_pkr;
    }
}