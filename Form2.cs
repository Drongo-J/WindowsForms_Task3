using System;
using System.Windows.Forms;

namespace WindowsForms_Task3
{
    public partial class BestOil : Form
    {
        public decimal priceOfHotDog = 2.30M;
        public decimal priceOfHamburger = 2.50M;
        public decimal priceOfFries = 1.00M;
        public decimal priceOfCocaCola = 0.80M;

        public decimal priceOfAI92 = 1.20M; // per liter
        public decimal priceOfAI95 = 1.60M; // per liter
        public decimal priceOfAI98 = 1.90M; // per liter

        public BestOil()
        {
            InitializeComponent();
            oilsComboBox.Items.Add("AI92");
            oilsComboBox.Items.Add("AI95");
            oilsComboBox.Items.Add("AI98");

            literTxtb.KeyPress += moneyTxtb_KeyPress;
            literTxtb.TextChanged += moneyTxtb_TextChanged;
            byLiterRb.CheckedChanged += byMoneyRb_CheckedChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string oil = oilsComboBox.SelectedItem.ToString();
            if (oil == "AI92")
            {
                priceOfOilLbl.Text = priceOfAI92.ToString();
            }
            if (oil == "AI95")
            {
                priceOfOilLbl.Text = priceOfAI95.ToString();
            }
            if (oil == "AI98")
            {
                priceOfOilLbl.Text = priceOfAI98.ToString();
            }
            oilWarningLbl.Text = string.Empty;
            CalculateOil();
        }

        private void byMoneyRb_CheckedChanged(object sender, EventArgs e)
        {

            {
                oilTotalLbl.Text = 0.ToString();
            }

            if (byMoneyRb.Checked)
            {
                moneyTxtb.Enabled = true;
                literTxtb.Enabled = false;
                literTxtb.Text = String.Empty;
            }
            else
            {
                moneyTxtb.Enabled = false;
                literTxtb.Enabled = true;
                moneyTxtb.Text = String.Empty;
            }
            CalculateOil();
        }

        private void hotdogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hotdogCheckBox.Checked)
                hotdogNumericUD.Enabled = true;
            else
            {
                hotdogNumericUD.Value = 0;
                hotDogPrice.Text = String.Empty;
                hotdogNumericUD.Enabled = false;
            }
        }
        private void hotdogNumericUD_ValueChanged(object sender, EventArgs e)
        {
            hotDogPrice.Text = (hotdogNumericUD.Value * priceOfHotDog).ToString();
            CalculateFoods();
        }

        private void hamburgerCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (hamburgerCheckBox.Checked)
                hamburgerNumericUD.Enabled = true;
            else
            {
                hamburgerNumericUD.Value = 0;
                hamburgerPrice.Text = String.Empty;
                hamburgerNumericUD.Enabled = false;
            }
        }
        private void hamburgerNumericUD_ValueChanged(object sender, EventArgs e)
        {
            hamburgerPrice.Text = (hamburgerNumericUD.Value * priceOfHamburger).ToString();
            CalculateFoods();
        }

        private void friesCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (friesCheckBox.Checked)
                friesNumericUD.Enabled = true;
            else
            {
                friesNumericUD.Value = 0;
                friesPrice.Text = String.Empty;
                friesNumericUD.Enabled = false;
            }
        }
        private void friesNumericUD_ValueChanged(object sender, EventArgs e)
        {
            friesPrice.Text = (friesNumericUD.Value * priceOfFries).ToString();
            CalculateFoods();
        }

        private void cocacolaComboBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cocacolaCheckBox.Checked)
                cocacolaNumericUD.Enabled = true;
            else
            {
                cocacolaNumericUD.Value = 0;
                cocacolaPrice.Text = String.Empty;
                cocacolaNumericUD.Enabled = false;
            }
        }
        private void cocacolaNumericUD_ValueChanged(object sender, EventArgs e)
        {
            cocacolaPrice.Text = (cocacolaNumericUD.Value * priceOfCocaCola).ToString();
            CalculateFoods();
        }

        private void CalculateFoods()
        {
            decimal total = 0;
            if (hotdogCheckBox.Checked && hotDogPrice.Text != null)
            {
                total += decimal.Parse(hotDogPrice.Text);
            }
            if (hamburgerCheckBox.Checked && hamburgerPrice.Text != null)
            {
                total += decimal.Parse(hamburgerPrice.Text);
            }
            if (friesCheckBox.Checked && friesPrice.Text != null)
            {
                total += decimal.Parse(friesPrice.Text);
            }
            if (cocacolaCheckBox.Checked && cocacolaPrice.Text != null)
            {
                total += decimal.Parse(cocacolaPrice.Text);
            }

            foodTotalLbl.Text = total.ToString();
        }

        private void CalculateOil()
        {
            string oil = oilsComboBox.SelectedItem as string;
            if (oil != null)
            {
                dynamic total = 0;
                var oilPrice = 0M;

                if (oil == "AI92")
                {
                    oilPrice = priceOfAI92;
                }
                else if (oil == "AI95")
                {
                    oilPrice = priceOfAI95;
                }
                else if (oil == "AI98")
                {
                    oilPrice = priceOfAI98;
                }

                if (byMoneyRb.Checked)
                {
                    if (!string.IsNullOrEmpty(moneyTxtb.Text))
                    {
                        var result = decimal.Parse(moneyTxtb.Text);
                        oilTotalLbl.Text = result + ".00";
                    }
                }
                else if (byLiterRb.Checked)
                {
                    if (!string.IsNullOrEmpty(literTxtb.Text))
                    {
                        int liters = int.Parse(literTxtb.Text);
                        oilTotalLbl.Text = ((decimal)liters * oilPrice).ToString();
                    }
                }
            }
        }

        private void moneyTxtb_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = moneyTxtb.SelectionStart + moneyTxtb.SelectionLength;
            if (e.KeyChar == '\b' && moneyTxtb.Text != String.Empty && index != 0)
            {
                moneyTxtb.Text = moneyTxtb.Text.Remove(index - 1, 1);
                moneyTxtb.SelectionStart = index - 1;
            }
            e.Handled = !char.IsDigit(e.KeyChar);
        }

        private void moneyTxtb_TextChanged(object sender, EventArgs e)
        {
            if ((oilsComboBox.SelectedItem as string) == null) // if nothing selected
            {
                oilWarningLbl.Text = "Choose Oil";
            }
            else
            {
                oilWarningLbl.Text = string.Empty;
            }

            CalculateOil();
        }

        private void CalculateAllBtn_Click(object sender, EventArgs e)
        {
            var result = decimal.Parse(oilTotalLbl.Text) + decimal.Parse(foodTotalLbl.Text);
            allPriceLbl.Text = result.ToString();
        }
    }
}
