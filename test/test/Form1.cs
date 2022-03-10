using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        private TestClass testClass;
        public Form1()
        {
            InitializeComponent();
            buttonSave.Text = "Click";
            testClass = new TestClass();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            testClass.MyProperty = textBoxText.Text;
            labelResult.Text = testClass.MyProperty;
        }
    }
}
