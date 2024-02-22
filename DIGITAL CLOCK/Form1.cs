using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DIGITAL_CLOCK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Set up a timer to update the clock every second
            Timer timer = new Timer();
            timer.Interval = 1000; // 1000 milliseconds = 1 second
            timer.Tick += Timer_Tick;
            timer.Start();

            // Initial update of the clock
            UpdateClock();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // Update the clock every second
            UpdateClock();
        }

        private void UpdateClock()
        {
            // Display the current time in the label
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}