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
    public partial class FormShop : Form
    {
        int moneyspent = 14;
        FormMain formMain;
        public FormShop(FormMain formMain)
        {
            InitializeComponent();
            this.formMain = formMain;
        }
        /// <summary>
        /// Buying food; money is substracted, food is added
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBuyFood_Click(object sender, EventArgs e)
        {
            formMain.variables.SpendMoney(moneyspent);
            labelMoneyShop.Text = formMain.variables.money.ToString();
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            labelMoneyShop.Text = formMain.variables.money.ToString();
        }
    }
}
