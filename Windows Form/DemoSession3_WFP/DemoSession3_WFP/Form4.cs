using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoSession3_WFP
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void loadData()
        {
            var root = new TreeNode("Menu");
            root.Tag = 0;

            var menu1 = new TreeNode("Menu1");
            menu1.Tag = 1;
            root.Nodes.Add(menu1);

            var menu2 = new TreeNode("Menu2");
            menu2.Tag = 2;
            root.Nodes.Add(menu2);

            var menu2_1 = new TreeNode("Menu2_1");
            menu2_1.Tag = 3;
            menu2.Nodes.Add(menu2_1);

            var menu2_2 = new TreeNode("Menu2_2");
            menu2_2.Tag = 4;
            menu2.Nodes.Add(menu2_2);

            treeViewMenu.Nodes.Add(root);
        }

        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var selectedNode = treeViewMenu.SelectedNode;
            Debug.WriteLine(selectedNode.Text);
            Debug.WriteLine(selectedNode.Tag.ToString());
        }
    }
}
