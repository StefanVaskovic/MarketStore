using MarketStore.BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketStore
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                Card[] cards = new Card[3];
                cards[0] = new BronzeCard(0, 150);
                cards[1] = new SilverCard(600, 850);
                cards[2] = new GoldCard(1500, 1300);

                var tmp = new StringBuilder();
                foreach (var item in cards)
                {
                    tmp.Append(item.ToString());
                }
                tbDetails.Text = tmp.ToString();
            }
            catch(ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
