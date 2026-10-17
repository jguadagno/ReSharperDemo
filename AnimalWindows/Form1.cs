using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Animal;

namespace AnimalWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Cat> cats = new List<Cat> {createCat("Sammie", 5)};
        }

        private Cat createCat(string name, int age)
        {
            return new Cat{Name=name, Age = age};
        }
    }
}
