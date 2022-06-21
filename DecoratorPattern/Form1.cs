using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DecoratorPattern
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Moveble car = new Car();
            car = new Decorator1(car);
            car = new Decorator2(car);
            MessageBox.Show(car.Name + " " + car.GetSpeed().ToString() + " км\\ч");
        }
    }
}
