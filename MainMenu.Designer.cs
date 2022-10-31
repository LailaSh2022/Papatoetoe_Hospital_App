
namespace Papatoetoe_Hospital_App
{
    partial class MainMenu
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
            this.addNewPatient_btn = new System.Windows.Forms.Button();
            this.newAppointment_btn = new System.Windows.Forms.Button();
            this.payment_btn = new System.Windows.Forms.Button();
            this.Exit_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Papatoetoe_Hospital_App.Properties.Resources.Logo03;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(247, 44);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // addNewPatient_btn
            // 
            this.addNewPatient_btn.BackColor = System.Drawing.SystemColors.Control;
            this.addNewPatient_btn.Location = new System.Drawing.Point(142, 125);
            this.addNewPatient_btn.Name = "addNewPatient_btn";
            this.addNewPatient_btn.Size = new System.Drawing.Size(516, 43);
            this.addNewPatient_btn.TabIndex = 0;
            this.addNewPatient_btn.Text = "Add New Patient";
            this.addNewPatient_btn.UseVisualStyleBackColor = false;
            this.addNewPatient_btn.Click += new System.EventHandler(this.addNewPatient_btn_Click);
            // 
            // newAppointment_btn
            // 
            this.newAppointment_btn.BackColor = System.Drawing.SystemColors.Control;
            this.newAppointment_btn.Location = new System.Drawing.Point(142, 198);
            this.newAppointment_btn.Name = "newAppointment_btn";
            this.newAppointment_btn.Size = new System.Drawing.Size(516, 43);
            this.newAppointment_btn.TabIndex = 1;
            this.newAppointment_btn.Text = "Create New Appointment";
            this.newAppointment_btn.UseVisualStyleBackColor = false;
            this.newAppointment_btn.Click += new System.EventHandler(this.newAppointment_btn_Click);
            // 
            // payment_btn
            // 
            this.payment_btn.BackColor = System.Drawing.SystemColors.Control;
            this.payment_btn.Enabled = false;
            this.payment_btn.Location = new System.Drawing.Point(142, 272);
            this.payment_btn.Name = "payment_btn";
            this.payment_btn.Size = new System.Drawing.Size(516, 43);
            this.payment_btn.TabIndex = 2;
            this.payment_btn.Text = "Payment";
            this.payment_btn.UseVisualStyleBackColor = false;
            // 
            // Exit_btn
            // 
            this.Exit_btn.BackColor = System.Drawing.SystemColors.Control;
            this.Exit_btn.Location = new System.Drawing.Point(142, 345);
            this.Exit_btn.Name = "Exit_btn";
            this.Exit_btn.Size = new System.Drawing.Size(516, 43);
            this.Exit_btn.TabIndex = 3;
            this.Exit_btn.Text = "Exit";
            this.Exit_btn.UseVisualStyleBackColor = false;
            this.Exit_btn.Click += new System.EventHandler(this.Exit_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(305, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Main Menu";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Papatoetoe_Hospital_App.Properties.Resources.istockphoto_940993008_612x612;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Exit_btn);
            this.Controls.Add(this.payment_btn);
            this.Controls.Add(this.newAppointment_btn);
            this.Controls.Add(this.addNewPatient_btn);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button addNewPatient_btn;
        private System.Windows.Forms.Button newAppointment_btn;
        private System.Windows.Forms.Button payment_btn;
        private System.Windows.Forms.Button Exit_btn;
        private System.Windows.Forms.Label label1;
    }
}