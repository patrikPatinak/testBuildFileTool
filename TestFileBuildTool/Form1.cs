using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestFileBuildTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem.ToString() == "700-FileType") {
                label12.Text = "700";
            }
            else if (comboBox1.SelectedItem.ToString() == "U97-FileType")
            {
                label12.Text = "U97";
            }
            else if (comboBox1.SelectedItem.ToString() == "U98-FileType")
            {
                label12.Text = "U98";
            }
            else if (comboBox1.SelectedItem.ToString() == "U99-FileType")
            {
                label12.Text = "U99";
            }
        }

    }
}
