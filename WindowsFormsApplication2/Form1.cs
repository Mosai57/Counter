using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        CounterNumber ctr = new CounterNumber(0);

        public Form1()
        {
            InitializeComponent();
            updateCounter();
        }

        public void updateCounter()
        {
            counterBox.Text = ctr.getCounter().ToString("D");
        }

        private void incOneButton_Click(object sender, EventArgs e)
        {
            ctr.modifyCounter(1);
            updateCounter();
        }
        private void incTenButton_Click(object sender, EventArgs e)
        {
            ctr.modifyCounter(10);
            updateCounter();
        }
        private void decOneButton_Click(object sender, EventArgs e)
        {
            ctr.modifyCounter(-1);
            updateCounter();
        }
        private void decTenButton_Click(object sender, EventArgs e)
        {
            ctr.modifyCounter(-10);
            updateCounter();
        }
        private void resetButton_Click(object sender, EventArgs e)
        {
            ctr.resetCounter();
            updateCounter();
        }

    }
}
