using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;


namespace ClickPerSecond
{
    public partial class Form1 : Form
    {

        //THIS IS A CLICKS PER SECOND COUNTER NOT REALLY A GIFT. SORRY.
        public Form1()
        {
            InitializeComponent();
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
        //saves the cps from the user
        static float cps = 0;

        //saves the clicks from the user
        static int clicks = 0;

        //saves how much time the run has lasted. starting from 1 since
        // dividing  by 0 is a problem. but starting in 1 isn't.
        static int time = 1;

        //to check if the timer has already started
        bool startedTimer = false;

        //this is the main active point of the program becauase
        //this is where the user will get it's stats off, 
        //instead of having to press a start button which is
        //pretty dumb, and inneficient when trying to check for
        //clicks per second.
        private void button2_Click(object sender, EventArgs e)
        {
            //sets to 0 if the run is over and every value isn't 0
            if (time != 0 && clicks != 0 && startedTimer != true)
            {
                time = 0;
                clicks = 0;
            }
            //sets the runtimer to start
            startedTimer = true;

            //starts the whole run timer
            runTimer.Start();

            //starts the measure for the average cps timer
            measureDeltaTimer.Start();

            //stops and starts the timer that tests for user inactivity
            clickTimer.Stop();
            clickTimerClick = 0;
            clickTimer.Start();

            //adds more clicks if the button is clicked
            ++clicks;
        }


        private void label1_Click_1(object sender, EventArgs e)
        {
        }
        int time1 = 0;
        int time2 = 1;
        int click1 = 0;
        int click2 = 0;

        private void timer2_Tick(object sender, EventArgs e)
        {
            //adds 1 tick to the time.
            time += 1;
            //calculates clicks per second
            CalculateClicksPerSecond(time, clicks);
        }
        /// <summary>
        /// This function calculates the clicks per second, sets the value to the tags,
        /// tests for user inactivity, and tests the real average delta Clicks per delta Second.
        /// </summary>
        /// <param name="time"></param>
        /// <param name="clicks"></param>
        private void CalculateClicksPerSecond(int time, int clicks)
        {
            string strCps = "";

            //sets the labels from the form to the value of the items.
            timelabel.Text = (time / 10).ToString();
            clicklabel.Text = clicks.ToString();

            //calculates cps
            cps = (float)clicks / ((float)time / 10);


            //create a char array to hold the values as a char for each number
            char[] charCps = cps.ToString().ToCharArray();

            //resizes any array that comes to the size of 3 aka(3.333333 to 3 , 3)
            Array.Resize(ref charCps, 4);

            //create the Cps string value
            foreach (char c in charCps)
            {
                strCps = strCps + c.ToString();
            }

            //sets the label to the cps value
            cpslabel.Text = strCps;

            //resets the time when it reaches 2 seconds 
            
            if (clickTimerClick >= 15)
            {
                runTimer.Stop();
                startedTimer = false;
            }
            if(time >= 15)
            {
                time = 0;
                clicks = 0;
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
        int clickTimerClick = 0;
        private void clickTimer_Tick(object sender, EventArgs e)
        {
            clickTimerClick++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        int deltaTimeTick = 0;
        float deltaCPS = 0;
        float deltaClicks = 0;
        float deltaTime = 0;
        private void measureDeltaTimer_Tick(object sender, EventArgs e)
        {
            if (deltaTimeTick <= 1)
            {
                time1 = time;
                click1 = clicks;
            }
            if (deltaTimeTick >= 11)
            {
                time2 = time;
                click2 = clicks;

                deltaTime = time2 - time1;
                deltaClicks = click2 - click1;

                deltaCPS = deltaClicks / deltaTime * 10;

                deltaCPSLabel.Text = deltaCPS.ToString();
                deltaTimeTick = 0;
            }
            deltaTimeTick++;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
