
namespace DemoSession7_WFP
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
            this.buttonMenu1 = new System.Windows.Forms.Button();
            this.buttonMenu2 = new System.Windows.Forms.Button();
            this.buttonMenu3 = new System.Windows.Forms.Button();
            this.buttonMenu4 = new System.Windows.Forms.Button();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonMenu1
            // 
            this.buttonMenu1.Location = new System.Drawing.Point(13, 23);
            this.buttonMenu1.Name = "buttonMenu1";
            this.buttonMenu1.Size = new System.Drawing.Size(129, 32);
            this.buttonMenu1.TabIndex = 0;
            this.buttonMenu1.Text = "Menu 1";
            this.buttonMenu1.UseVisualStyleBackColor = true;
            this.buttonMenu1.Click += new System.EventHandler(this.buttonMenu1_Click);
            // 
            // buttonMenu2
            // 
            this.buttonMenu2.Location = new System.Drawing.Point(13, 92);
            this.buttonMenu2.Name = "buttonMenu2";
            this.buttonMenu2.Size = new System.Drawing.Size(129, 32);
            this.buttonMenu2.TabIndex = 1;
            this.buttonMenu2.Text = "Menu 2";
            this.buttonMenu2.UseVisualStyleBackColor = true;
            this.buttonMenu2.Click += new System.EventHandler(this.buttonMenu2_Click);
            // 
            // buttonMenu3
            // 
            this.buttonMenu3.Location = new System.Drawing.Point(13, 165);
            this.buttonMenu3.Name = "buttonMenu3";
            this.buttonMenu3.Size = new System.Drawing.Size(129, 32);
            this.buttonMenu3.TabIndex = 2;
            this.buttonMenu3.Text = "Menu 3";
            this.buttonMenu3.UseVisualStyleBackColor = true;
            this.buttonMenu3.Click += new System.EventHandler(this.buttonMenu3_Click);
            // 
            // buttonMenu4
            // 
            this.buttonMenu4.Location = new System.Drawing.Point(13, 239);
            this.buttonMenu4.Name = "buttonMenu4";
            this.buttonMenu4.Size = new System.Drawing.Size(129, 32);
            this.buttonMenu4.TabIndex = 3;
            this.buttonMenu4.Text = "Menu 4";
            this.buttonMenu4.UseVisualStyleBackColor = true;
            this.buttonMenu4.Click += new System.EventHandler(this.buttonMenu4_Click);
            // 
            // panelMain
            // 
            this.panelMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMain.Location = new System.Drawing.Point(162, 13);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(601, 425);
            this.panelMain.TabIndex = 4;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.buttonMenu4);
            this.Controls.Add(this.buttonMenu3);
            this.Controls.Add(this.buttonMenu2);
            this.Controls.Add(this.buttonMenu1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonMenu1;
        private System.Windows.Forms.Button buttonMenu2;
        private System.Windows.Forms.Button buttonMenu3;
        private System.Windows.Forms.Button buttonMenu4;
        private System.Windows.Forms.Panel panelMain;
    }
}