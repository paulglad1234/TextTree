using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextTree
{
    public partial class TextTreeForm : Form
    {
        public TextTreeForm()
        {
            InitializeComponent();
        }

        private void a_button_Click(object sender, EventArgs e)
        {
            a_openFileDialog.ShowDialog();
            
        }

        private void b_button_Click(object sender, EventArgs e)
        {
            b_openFileDialog.ShowDialog();
            
        }

        private void c_button_Click(object sender, EventArgs e)
        {
            saveFileDialog.ShowDialog();
            Solution.A_ReadInputFromFile(a_openFileDialog.FileName, out string[] lines);
            Solution.B_ReadInputFromFile(b_openFileDialog.FileName, out Tree tree);
            Solution.Sln(lines, tree, saveFileDialog.FileName);
        }
    }
}
