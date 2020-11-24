using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheGameOfJeopardy
{
    public partial class SplashScreenFr : Form
    {
        //class variables
        private int counter;
        public event MakeCloseButtonVisibleDelegate MCBVEvent;

        //create delegate for event to communicate
        public delegate void MakeCloseButtonVisibleDelegate();

        public SplashScreenFr()
        {
            InitializeComponent();

            //Connect the event handler to the delegate
            MCBVEvent += MakeCloseButtonVisible;

            //start the first timer
            timer1.Start();
        }

        #region Events
        private void closeBtn_Click(object sender, EventArgs e)
        {
            //start the second timer so the form does the animation and closes
            timer2.Start();
        }

        /// <summary>
        /// This method fires with every tick and changes the opaciy of the form as it loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //adjust the opacity
            this.Opacity += 0.02d;

            if (this.Opacity >= 1.0d)
            {
                //stop the timer
                timer1.Stop();
                //start the third timer
                timer3.Start();
            }
        }

        /// <summary>
        /// This method fires with every tick of the timer and controls how long the 
        /// splash hangs out
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer3_Tick(object sender, EventArgs e)
        {
            //how fast do you want to go
            counter += 100;
            //how long do you want to wait
            if (counter > 500)
            {
                //once we've waited long enough stop the timer
                timer3.Stop();

                //start the second timer that controls the exit
                timer2.Start();
            }
        }

        /// <summary>
        /// this method fires with every tick of the second timer and control the exit
        /// animation of the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.05d;
            this.Width -= 30;
            this.Height -= 18;
            this.Left -= 15;
            this.Top -= 9;

            //when we get to a point that the form is small and too opaque
            //we should close it
            if (this.Opacity <= 0.000001d)
            {
                timer2.Stop();
                this.Close();
            }
        }
        #endregion


        #region Methods
        /// <summary>
        /// This method allows us to show the close button in case the animation 
        /// timer fails to close the form as designed. we use the Invoke flag to 
        /// check if we are calling from another thread so we have permission to 
        /// </summary>
        public void MakeCloseButtonVisible()
        {
            if (InvokeRequired)
            {
                Invoke(MCBVEvent);
            }
            else
            {
                closeBtn.Visible = true;
            }
        }

        #endregion
    }
}
