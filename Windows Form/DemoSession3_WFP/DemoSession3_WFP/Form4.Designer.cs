
namespace DemoSession3_WFP
{
    partial class Form4
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
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Node1");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Node2");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Category", new System.Windows.Forms.TreeNode[] {
            treeNode16,
            treeNode17});
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Node4");
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Node5");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Node3", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode20});
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Node7");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Node8");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Node9");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Node6", new System.Windows.Forms.TreeNode[] {
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Node11");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Node12");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Node13");
            System.Windows.Forms.TreeNode treeNode29 = new System.Windows.Forms.TreeNode("Node14");
            System.Windows.Forms.TreeNode treeNode30 = new System.Windows.Forms.TreeNode("Node10", new System.Windows.Forms.TreeNode[] {
            treeNode26,
            treeNode27,
            treeNode28,
            treeNode29});
            this.treeViewCategory = new System.Windows.Forms.TreeView();
            this.treeViewMenu = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // treeViewCategory
            // 
            this.treeViewCategory.Location = new System.Drawing.Point(13, 13);
            this.treeViewCategory.Name = "treeViewCategory";
            treeNode16.Name = "Node1";
            treeNode16.Text = "Node1";
            treeNode17.Name = "Node2";
            treeNode17.Text = "Node2";
            treeNode18.Name = "Node0";
            treeNode18.Text = "Category";
            treeNode19.Name = "Node4";
            treeNode19.Text = "Node4";
            treeNode20.Name = "Node5";
            treeNode20.Text = "Node5";
            treeNode21.Name = "Node3";
            treeNode21.Text = "Node3";
            treeNode22.Name = "Node7";
            treeNode22.Text = "Node7";
            treeNode23.Name = "Node8";
            treeNode23.Text = "Node8";
            treeNode24.Name = "Node9";
            treeNode24.Text = "Node9";
            treeNode25.Name = "Node6";
            treeNode25.Text = "Node6";
            treeNode26.Name = "Node11";
            treeNode26.Text = "Node11";
            treeNode27.Name = "Node12";
            treeNode27.Text = "Node12";
            treeNode28.Name = "Node13";
            treeNode28.Text = "Node13";
            treeNode29.Name = "Node14";
            treeNode29.Text = "Node14";
            treeNode30.Name = "Node10";
            treeNode30.Text = "Node10";
            this.treeViewCategory.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode18,
            treeNode21,
            treeNode25,
            treeNode30});
            this.treeViewCategory.Size = new System.Drawing.Size(222, 412);
            this.treeViewCategory.TabIndex = 0;
            // 
            // treeViewMenu
            // 
            this.treeViewMenu.Location = new System.Drawing.Point(318, 13);
            this.treeViewMenu.Name = "treeViewMenu";
            this.treeViewMenu.Size = new System.Drawing.Size(239, 412);
            this.treeViewMenu.TabIndex = 1;
            this.treeViewMenu.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewMenu_AfterSelect);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.treeViewMenu);
            this.Controls.Add(this.treeViewCategory);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeViewCategory;
        private System.Windows.Forms.TreeView treeViewMenu;
    }
}