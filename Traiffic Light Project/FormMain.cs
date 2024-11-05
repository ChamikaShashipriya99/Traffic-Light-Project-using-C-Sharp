using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traiffic_Light_Project
{
    public partial class TrafficLight : Form
    {
        int Seconds1 = 0;
        int Seconds2 = 0;
        int Seconds3 = 0;
        int Seconds4 = 0;
        public TrafficLight()
        {
            InitializeComponent();

            R1.Visible = true;
            Y1.Visible = false;
            G1.Visible = false;

            R3.Visible = true;
            Y3.Visible = false;
            G3.Visible = false;

            R4.Visible = false;
            Y4.Visible = false;
            G4.Visible = true;

            R2.Visible = false;
            Y2.Visible = false;
            G2.Visible = true;

            
            SL1.Visible = true;
            SL2.Visible = true;
            SL3.Visible = true;
            SL4.Visible = true;
            SL5.Visible = false;
            SL6.Visible = false;
            SL7.Visible = false;
            SL8.Visible = false;
            SL9.Visible = true;
            SL10.Visible = true;
            SL11.Visible = true;
            SL12.Visible = true;
            SL13.Visible = false;
            SL14.Visible = false;
            SL15.Visible = false;
            SL16.Visible = false;
            SL17.Visible = true;
            SL18.Visible = true;
            SL19.Visible = true;
            SL20.Visible = true;
            SL21.Visible = false;
            SL22.Visible = false;
            SL23.Visible = false;
            SL24.Visible = false;
            SL25.Visible = true;
            SL26.Visible = true;
            SL27.Visible = true;
            SL28.Visible = true;
            SL29.Visible = false;
            SL30.Visible = false;
            SL31.Visible = false;
            SL32.Visible = false;

            Arrow1.Visible = false;
            Arrow2.Visible = false;
            Arrow3.Visible = true;
            Arrow4.Visible = true;
            Arrow5.Visible = false;
            Arrow6.Visible = false;
            Arrow7.Visible = true;
            Arrow8.Visible = true;

            lblSeconds1.Visible = true;
            lblSeconds2.Visible = true;
            lblSeconds3.Visible = true;
            lblSeconds4.Visible = true;

        }

        private void Light1_Tick(object sender, EventArgs e)
        {
            if (R1.Visible == true)
            {
                R1.Visible = false;
                Y1.Visible = false;
                G1.Visible = true;
                Arrow1.Visible = true;
                Arrow2.Visible = true;

                Seconds1 = 5;
                CountdownTimer1.Start();
            }
            else if (G1.Visible == true)
            {
                R1.Visible = false;
                Y1.Visible = true;
                G1.Visible = false;
                Arrow1.Visible = false;
                Arrow2.Visible = false;

                Seconds1 = 5;
                CountdownTimer1.Start();
            }
            else if (Y1.Visible == true)
            {
                R1.Visible = true;
                Y1.Visible = false;
                G1.Visible = false;
                Arrow1.Visible = false;
                Arrow2.Visible = false;

                Seconds1 = 5;
                CountdownTimer1.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Light1.Enabled = true;
            Light2.Enabled = true;
            Light3.Enabled = true;
            Light4.Enabled = true;

            Seconds1 = 5;
            CountdownTimer1.Start();
            Seconds2 = 5;
            CountdownTimer2.Start();
            Seconds3 = 5;
            CountdownTimer3.Start();
            Seconds4 = 5;
            CountdownTimer4.Start();

            CarMove.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Light1.Enabled = false;
            Light2.Enabled = false;
            Light3.Enabled = false;
            Light4.Enabled = false;

            CountdownTimer1.Stop();
            CountdownTimer2.Stop();
            CountdownTimer3.Stop();
            CountdownTimer4.Stop();

            CarMove.Enabled = false;
        }

        private void Light2_Tick(object sender, EventArgs e)
        {
            if (R4.Visible == true)
            {
                R4.Visible = false;
                Y4.Visible = false;
                G4.Visible = true;
                Arrow7.Visible = true;
                Arrow8.Visible = true;

                Seconds2 = 5;
                CountdownTimer2.Start();
            }
            else if (G4.Visible == true)
            {
                R4.Visible = false;
                Y4.Visible = true;
                G4.Visible = false;
                Arrow7.Visible = false;
                Arrow8.Visible = false;

                Seconds2 = 5;
                CountdownTimer2.Start();
            }
            else if (Y4.Visible == true)
            {
                R4.Visible = true;
                Y4.Visible = false;
                G4.Visible = false;
                Arrow7.Visible = false;
                Arrow8.Visible = false;

                Seconds2 = 5;
                CountdownTimer2.Start();
            }
        }

        private void Light3_Tick(object sender, EventArgs e)
        {
            if (R2.Visible == true)
            {
                R2.Visible = false;
                Y2.Visible = false;
                G2.Visible = true;
                Arrow3.Visible = true;
                Arrow4.Visible = true;

                Seconds3 = 5;
                CountdownTimer3.Start();
            }
            else if (G2.Visible == true)
            {
                R2.Visible = false;
                Y2.Visible = true;
                G2.Visible = false;
                Arrow3.Visible = false;
                Arrow4.Visible = false;

                Seconds3 = 5;
                CountdownTimer3.Start();
            }
            else if (Y2.Visible == true)
            {
                R2.Visible = true;
                Y2.Visible = false;
                G2.Visible = false;
                Arrow3.Visible = false;
                Arrow4.Visible = false;

                Seconds3 = 5;
                CountdownTimer3.Start();
            }
        }

        private void Light4_Tick(object sender, EventArgs e)
        {
            if (R3.Visible == true)
            {
                R3.Visible = false;
                Y3.Visible = false;
                G3.Visible = true;
                Arrow5.Visible = true;
                Arrow6.Visible = true;

                Seconds4 = 5;
                CountdownTimer4.Start();
            }
            else if (G3.Visible == true)
            {
                R3.Visible = false;
                Y3.Visible = true;
                G3.Visible = false;
                Arrow5.Visible = false;
                Arrow6.Visible = false;

                Seconds4 = 5;
                CountdownTimer4.Start();
            }
            else if (Y3.Visible == true)
            {
                R3.Visible = true;
                Y3.Visible = false;
                G3.Visible = false;
                Arrow5.Visible = false;
                Arrow6.Visible = false;

                Seconds4 = 5;
                CountdownTimer4.Start();
            }
        }

        private void btnOn_Click(object sender, EventArgs e)
        {
            SL5.Visible = true;
            SL6.Visible = true;
            SL7.Visible = true;
            SL8.Visible = true;
            SL13.Visible = true;
            SL14.Visible = true;
            SL15.Visible = true;
            SL16.Visible = true;
            SL21.Visible = true;
            SL22.Visible = true;
            SL23.Visible = true;
            SL24.Visible = true;
            SL29.Visible = true;
            SL30.Visible = true;
            SL31.Visible = true;
            SL32.Visible = true;
        }

        private void btnOff_Click(object sender, EventArgs e)
        {
            SL5.Visible = false;
            SL6.Visible = false;
            SL7.Visible = false;
            SL8.Visible = false;
            SL13.Visible = false;
            SL14.Visible = false;
            SL15.Visible = false;
            SL16.Visible = false;
            SL21.Visible = false;
            SL22.Visible = false;
            SL23.Visible = false;
            SL24.Visible = false;
            SL29.Visible = false;
            SL30.Visible = false;
            SL31.Visible = false;
            SL32.Visible = false;
        }

        private void CountdownTimer1_Tick(object sender, EventArgs e)
        {
            lblSeconds1.Text = Seconds1--.ToString();
            if (Seconds1 < 0)
                CountdownTimer1.Stop();
        }

        private void CountdownTimer2_Tick(object sender, EventArgs e)
        {
            lblSeconds2.Text = Seconds2--.ToString();
            if (Seconds2 < 0)
                CountdownTimer2.Stop();
        }

        private void CountdownTimer3_Tick(object sender, EventArgs e)
        {
            lblSeconds3.Text = Seconds3--.ToString();
            if (Seconds3 < 0)
                CountdownTimer3.Stop();
        }

        private void CountdownTimer4_Tick(object sender, EventArgs e)
        {        lblSeconds4.Text = Seconds4--.ToString();
            if (Seconds4 < 0)
                CountdownTimer4.Stop();
        }

        private void CarMove_Tick(object sender, EventArgs e)
        {
            if(G1.Visible==true)
            {
                Car1.Left = Car1.Left += 50; 
            }

            if (G2.Visible == true)
            {
                Car2.Top = Car2.Top += 20;
            }

            if (G3.Visible == true)
            {
                Car3.Left = Car3.Left -= 30;
            }

            if (G4.Visible == true)
            {
                Car4.Top = Car4.Top -= 30;
            }
        }

        private void Car1_LocationChanged(object sender, EventArgs e)
        {
            if (Car1.Left >= this.Width)
            {
                Car1.Left = 0 - Car1.Width;
            }
        }

        private void Car3_LocationChanged(object sender, EventArgs e)
        {
            if (Car3.Left >= this.Width)
            {
                Car3.Left = 0 - Car3.Width;
            }
        }

        private void Car2_LocationChanged(object sender, EventArgs e)
        {
            if (Car2.Top >= this.Width)
            {
                Car2.Top = 0 - Car2.Width;
            }
        }

        private void Car4_LocationChanged(object sender, EventArgs e)
        {
            if (Car4.Top >= this.Width)
            {
                Car4.Top = 0 - Car4.Width;
            }
        }
    }
}
