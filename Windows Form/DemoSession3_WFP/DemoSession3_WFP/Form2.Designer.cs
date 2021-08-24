
namespace DemoSession3_WFP
{
    partial class Form2
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
            this.panelGender = new System.Windows.Forms.Panel();
            this.radioMale = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panelPayment = new System.Windows.Forms.Panel();
            this.radioCash = new System.Windows.Forms.RadioButton();
            this.radioPaypal = new System.Windows.Forms.RadioButton();
            this.radioCreditCard = new System.Windows.Forms.RadioButton();
            this.radioMasterCard = new System.Windows.Forms.RadioButton();
            this.buttonSave = new System.Windows.Forms.Button();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.buttonSave2 = new System.Windows.Forms.Button();
            this.panelLanguages = new System.Windows.Forms.Panel();
            this.checkBoxLanguage1 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.buttonSave3 = new System.Windows.Forms.Button();
            this.groupBoxRoles = new System.Windows.Forms.GroupBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.buttonSave4 = new System.Windows.Forms.Button();
            this.panelGender.SuspendLayout();
            this.panelPayment.SuspendLayout();
            this.panelLanguages.SuspendLayout();
            this.groupBoxRoles.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGender
            // 
            this.panelGender.Controls.Add(this.radioButton2);
            this.panelGender.Controls.Add(this.radioMale);
            this.panelGender.Location = new System.Drawing.Point(13, 13);
            this.panelGender.Name = "panelGender";
            this.panelGender.Size = new System.Drawing.Size(290, 72);
            this.panelGender.TabIndex = 0;
            // 
            // radioMale
            // 
            this.radioMale.AutoSize = true;
            this.radioMale.Location = new System.Drawing.Point(0, 21);
            this.radioMale.Name = "radioMale";
            this.radioMale.Size = new System.Drawing.Size(59, 21);
            this.radioMale.TabIndex = 0;
            this.radioMale.TabStop = true;
            this.radioMale.Text = "Male";
            this.radioMale.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(147, 21);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(75, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Female";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // panelPayment
            // 
            this.panelPayment.Controls.Add(this.radioMasterCard);
            this.panelPayment.Controls.Add(this.radioCreditCard);
            this.panelPayment.Controls.Add(this.radioPaypal);
            this.panelPayment.Controls.Add(this.radioCash);
            this.panelPayment.Location = new System.Drawing.Point(357, 13);
            this.panelPayment.Name = "panelPayment";
            this.panelPayment.Size = new System.Drawing.Size(200, 223);
            this.panelPayment.TabIndex = 1;
            // 
            // radioCash
            // 
            this.radioCash.AutoSize = true;
            this.radioCash.Checked = true;
            this.radioCash.Location = new System.Drawing.Point(4, 4);
            this.radioCash.Name = "radioCash";
            this.radioCash.Size = new System.Drawing.Size(61, 21);
            this.radioCash.TabIndex = 0;
            this.radioCash.TabStop = true;
            this.radioCash.Text = "Cash";
            this.radioCash.UseVisualStyleBackColor = true;
            // 
            // radioPaypal
            // 
            this.radioPaypal.AutoSize = true;
            this.radioPaypal.Location = new System.Drawing.Point(4, 31);
            this.radioPaypal.Name = "radioPaypal";
            this.radioPaypal.Size = new System.Drawing.Size(72, 21);
            this.radioPaypal.TabIndex = 1;
            this.radioPaypal.Text = "Paypal";
            this.radioPaypal.UseVisualStyleBackColor = true;
            // 
            // radioCreditCard
            // 
            this.radioCreditCard.AutoSize = true;
            this.radioCreditCard.Location = new System.Drawing.Point(4, 58);
            this.radioCreditCard.Name = "radioCreditCard";
            this.radioCreditCard.Size = new System.Drawing.Size(100, 21);
            this.radioCreditCard.TabIndex = 2;
            this.radioCreditCard.Text = "Credit Card";
            this.radioCreditCard.UseVisualStyleBackColor = true;
            // 
            // radioMasterCard
            // 
            this.radioMasterCard.AutoSize = true;
            this.radioMasterCard.Location = new System.Drawing.Point(3, 85);
            this.radioMasterCard.Name = "radioMasterCard";
            this.radioMasterCard.Size = new System.Drawing.Size(106, 21);
            this.radioMasterCard.TabIndex = 3;
            this.radioMasterCard.Text = "Master Card";
            this.radioMasterCard.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(13, 92);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(290, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(13, 156);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(70, 21);
            this.checkBoxStatus.TabIndex = 3;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // buttonSave2
            // 
            this.buttonSave2.Location = new System.Drawing.Point(13, 212);
            this.buttonSave2.Name = "buttonSave2";
            this.buttonSave2.Size = new System.Drawing.Size(290, 23);
            this.buttonSave2.TabIndex = 4;
            this.buttonSave2.Text = "Save";
            this.buttonSave2.UseVisualStyleBackColor = true;
            this.buttonSave2.Click += new System.EventHandler(this.buttonSave2_Click);
            // 
            // panelLanguages
            // 
            this.panelLanguages.Controls.Add(this.checkBox4);
            this.panelLanguages.Controls.Add(this.checkBox3);
            this.panelLanguages.Controls.Add(this.checkBox2);
            this.panelLanguages.Controls.Add(this.checkBox1);
            this.panelLanguages.Controls.Add(this.checkBoxLanguage1);
            this.panelLanguages.Location = new System.Drawing.Point(13, 241);
            this.panelLanguages.Name = "panelLanguages";
            this.panelLanguages.Size = new System.Drawing.Size(175, 149);
            this.panelLanguages.TabIndex = 5;
            // 
            // checkBoxLanguage1
            // 
            this.checkBoxLanguage1.AutoSize = true;
            this.checkBoxLanguage1.Location = new System.Drawing.Point(4, 4);
            this.checkBoxLanguage1.Name = "checkBoxLanguage1";
            this.checkBoxLanguage1.Size = new System.Drawing.Size(106, 21);
            this.checkBoxLanguage1.TabIndex = 0;
            this.checkBoxLanguage1.Text = "Language 1";
            this.checkBoxLanguage1.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(4, 31);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(106, 21);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Language 2";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(3, 58);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(106, 21);
            this.checkBox2.TabIndex = 2;
            this.checkBox2.Text = "Language 3";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(3, 85);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(106, 21);
            this.checkBox3.TabIndex = 3;
            this.checkBox3.Text = "Language 4";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(4, 112);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(106, 21);
            this.checkBox4.TabIndex = 4;
            this.checkBox4.Text = "Language 5";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // buttonSave3
            // 
            this.buttonSave3.Location = new System.Drawing.Point(12, 405);
            this.buttonSave3.Name = "buttonSave3";
            this.buttonSave3.Size = new System.Drawing.Size(176, 23);
            this.buttonSave3.TabIndex = 6;
            this.buttonSave3.Text = "Save";
            this.buttonSave3.UseVisualStyleBackColor = true;
            this.buttonSave3.Click += new System.EventHandler(this.buttonSave3_Click);
            // 
            // groupBoxRoles
            // 
            this.groupBoxRoles.Controls.Add(this.checkBox8);
            this.groupBoxRoles.Controls.Add(this.checkBox7);
            this.groupBoxRoles.Controls.Add(this.checkBox6);
            this.groupBoxRoles.Controls.Add(this.checkBox5);
            this.groupBoxRoles.Location = new System.Drawing.Point(316, 245);
            this.groupBoxRoles.Name = "groupBoxRoles";
            this.groupBoxRoles.Size = new System.Drawing.Size(261, 155);
            this.groupBoxRoles.TabIndex = 7;
            this.groupBoxRoles.TabStop = false;
            this.groupBoxRoles.Text = "Roles";
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(7, 22);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(71, 21);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Text = "Role 1";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(8, 49);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(71, 21);
            this.checkBox6.TabIndex = 1;
            this.checkBox6.Text = "Role 2";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(8, 76);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(71, 21);
            this.checkBox7.TabIndex = 2;
            this.checkBox7.Text = "Role 3";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(8, 103);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(71, 21);
            this.checkBox8.TabIndex = 3;
            this.checkBox8.Text = "Role 4";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // buttonSave4
            // 
            this.buttonSave4.Location = new System.Drawing.Point(316, 406);
            this.buttonSave4.Name = "buttonSave4";
            this.buttonSave4.Size = new System.Drawing.Size(261, 23);
            this.buttonSave4.TabIndex = 8;
            this.buttonSave4.Text = "Save";
            this.buttonSave4.UseVisualStyleBackColor = true;
            this.buttonSave4.Click += new System.EventHandler(this.buttonSave4_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonSave4);
            this.Controls.Add(this.groupBoxRoles);
            this.Controls.Add(this.buttonSave3);
            this.Controls.Add(this.panelLanguages);
            this.Controls.Add(this.buttonSave2);
            this.Controls.Add(this.checkBoxStatus);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panelPayment);
            this.Controls.Add(this.panelGender);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panelGender.ResumeLayout(false);
            this.panelGender.PerformLayout();
            this.panelPayment.ResumeLayout(false);
            this.panelPayment.PerformLayout();
            this.panelLanguages.ResumeLayout(false);
            this.panelLanguages.PerformLayout();
            this.groupBoxRoles.ResumeLayout(false);
            this.groupBoxRoles.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelGender;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioMale;
        private System.Windows.Forms.Panel panelPayment;
        private System.Windows.Forms.RadioButton radioMasterCard;
        private System.Windows.Forms.RadioButton radioCreditCard;
        private System.Windows.Forms.RadioButton radioPaypal;
        private System.Windows.Forms.RadioButton radioCash;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.Button buttonSave2;
        private System.Windows.Forms.Panel panelLanguages;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBoxLanguage1;
        private System.Windows.Forms.Button buttonSave3;
        private System.Windows.Forms.GroupBox groupBoxRoles;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.Button buttonSave4;
    }
}