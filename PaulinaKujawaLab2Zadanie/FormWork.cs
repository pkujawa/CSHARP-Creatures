using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaulinaKujawaLab2Zadanie
{
    public partial class FormWork : Form 
    {
        int timespent;
        public int moneyearned;
        FormMain formMain;

        public FormWork(FormMain formMain) 
        {
            InitializeComponent();
            timerTimeOfWork.Stop();
            this.formMain = formMain;
        }
        /// <summary>
        /// Starts the timer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStart_Click(object sender, EventArgs e)
        {
            timerTimeOfWork.Start();
        }
        /// <summary>
        /// Stops the timer; money is calculated using funtion from the class
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonStop_Click(object sender, EventArgs e)
        {
            timerTimeOfWork.Stop();
            formMain.variables.EarnMoney(moneyearned);
            moneyearned = 0;
        }
        /// <summary>
        /// Every second timespent is added; 1 gold is earned every 3 seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timerTimeOfWork_Tick_1(object sender, EventArgs e)
        {
            timespent++;
            labelTimeSpentV.Text = timespent.ToString();
            moneyearned = timespent / 3;
            labelMoneyEarnedV.Text = moneyearned.ToString();
        }
    }
}
