using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElectroMagneticalAnalyse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int measuredFrequency = int.Parse(measuredFrequencyTextBox.Text);
            double lenghtOfAntenna = double.Parse(lenghtOfAntennaTextBox.Text);
            int maxDistance = int.Parse(maxDistanceTextBox.Text);

            new ExecuteService().startToAnaliysys(measuredFrequency, lenghtOfAntenna, maxDistance);
        }
    }
}
