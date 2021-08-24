
namespace DemoSession6_WFP
{
    partial class Form3
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
            this.textBoxContent = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonInfoDialog = new System.Windows.Forms.Button();
            this.buttonConfirmDialog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxContent
            // 
            this.textBoxContent.Location = new System.Drawing.Point(29, 39);
            this.textBoxContent.Multiline = true;
            this.textBoxContent.Name = "textBoxContent";
            this.textBoxContent.Size = new System.Drawing.Size(297, 22);
            this.textBoxContent.TabIndex = 0;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(29, 68);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(94, 23);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonInfoDialog
            // 
            this.buttonInfoDialog.Location = new System.Drawing.Point(29, 134);
            this.buttonInfoDialog.Name = "buttonInfoDialog";
            this.buttonInfoDialog.Size = new System.Drawing.Size(155, 23);
            this.buttonInfoDialog.TabIndex = 2;
            this.buttonInfoDialog.Text = "Info Dialog";
            this.buttonInfoDialog.UseVisualStyleBackColor = true;
            this.buttonInfoDialog.Click += new System.EventHandler(this.buttonInfoDialog_Click);
            // 
            // buttonConfirmDialog
            // 
            this.buttonConfirmDialog.Location = new System.Drawing.Point(283, 133);
            this.buttonConfirmDialog.Name = "buttonConfirmDialog";
            this.buttonConfirmDialog.Size = new System.Drawing.Size(193, 23);
            this.buttonConfirmDialog.TabIndex = 3;
            this.buttonConfirmDialog.Text = "Confirm Dialog";
            this.buttonConfirmDialog.UseVisualStyleBackColor = true;
            this.buttonConfirmDialog.Click += new System.EventHandler(this.buttonConfirmDialog_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonConfirmDialog);
            this.Controls.Add(this.buttonInfoDialog);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxContent);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxContent;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonInfoDialog;
        private System.Windows.Forms.Button buttonConfirmDialog;
    }
}