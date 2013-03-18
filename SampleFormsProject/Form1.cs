using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleFormsProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            TestClass testobject = new TestClass();
            dataGridView1.DataSource = testobject.List;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBox.Show("Goodbye");
        }
    }
}
