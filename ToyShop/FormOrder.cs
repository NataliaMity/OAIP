using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ToyShop
{
    public partial class FormOrder : Form
    {
        int doll = 149;
        int ball = 99;
        int teddy = 999;
        int lego = 449;

        public FormOrder()
        {
            InitializeComponent();
            txtBoxBall.Enabled = false;
            txtBoxBarbie.Enabled = false;
            txtBoxTeddy.Enabled = false;
            txtBoxLego.Enabled = false;
            radioBtnPickup.Enabled = false;
            radioBtnDelivery.Enabled = false;
            txtBoxBuilding.Enabled = false;
            txtBoxFlat.Enabled = false;
            txtBoxHouse.Enabled = false;
            txtBoxStreet.Enabled = false;
            txtBoxPhone.Enabled = false;
            comboBoxPaying.Enabled = false;
            dateTimePickerPickup.Enabled = false;
            comboBoxAddress.Enabled = false;
            btnGetOrder.Enabled = false;
        }

        private void btnExitOrder_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxDoll_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDoll.Checked == true)
            {
                txtBoxBarbie.Enabled = true;
            }
            else
            {
                txtBoxBarbie.Enabled = false;
                txtBoxBarbie.Text = "";
            }
        }

        private void checkBoxTeddy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTeddy.Checked == true)
            {
                txtBoxTeddy.Enabled = true;
            }
            else
            {
                txtBoxTeddy.Enabled = false;
                txtBoxTeddy.Text = "";
            }
        }

        private void checkBoxBall_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBall.Checked == true)
            {
                txtBoxBall.Enabled = true;
            }
            else
            {
                txtBoxBall.Enabled = false;
                txtBoxBall.Text = "";
            }
        }

        private void checkBoxLego_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLego.Checked == true)
            {
                txtBoxLego.Enabled = true;
            }
            else
            {
                txtBoxLego.Enabled = false;
                txtBoxLego.Text = "";
            }
        }

        private void btnGetOrder_Click(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxLego.Checked == true && checkBoxBall.Checked == true && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {

                    if (txtBoxBall.Text == "" || txtBoxLego.Text == "" || txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int doll_res = doll * doll_count;
                        int ball_res = ball * ball_count;
                        int teddy_res = teddy * teddy_count;
                        int lego_res = lego * lego_count;

                        lblResult.Text = "Сумма покупки: " + (doll_res + ball_res + teddy_res + lego_res).ToString() + " руб.";
                    }
                }
                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBall.Text == "" || txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int doll_res = doll * doll_count;
                        int ball_res = ball * ball_count;
                        int teddy_res = teddy * teddy_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + ball_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == false  && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {
                    if (txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int doll_res = doll * doll_count;
                        int teddy_res = teddy * teddy_count;

                        lblResult.Text = "Сумма покупки: " + (doll_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {
                    if (txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int doll_res = doll * doll_count;
                        int teddy_res = teddy * teddy_count;
                        int ball_res = ball * ball_count;

                        lblResult.Text = "Сумма покупки: " + (doll_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == false && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int doll_res = doll * doll_count;

                        lblResult.Text = "Сумма покупки: " + (doll_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == false && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == false)
                {
                    if (txtBoxTeddy.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int teddy_res = teddy * teddy_count;

                        lblResult.Text = "Сумма покупки: " + (teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == false)
                {
                    if (txtBoxBall.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int ball_res = ball * ball_count;

                        lblResult.Text = "Сумма покупки: " + ball_res.ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == false && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == false)
                {
                    if (txtBoxLego.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int lego_res = lego * lego_count;

                        lblResult.Text = "Сумма покупки: " + lego_res.ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBall.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int doll_res = doll * doll_count;
                        int ball_res = ball * ball_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + ball_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == false && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBall.Text == "" || txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int doll_res = doll * doll_count;
                        int lego_res = lego * lego_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + lego_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == false)
                {
                    if (txtBoxBall.Text == "" || txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int ball_res = ball * ball_count;
                        int teddy_res = teddy * teddy_count;
                        lblResult.Text = "Сумма покупки: " + (ball_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == false && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {
                    if (txtBoxLego.Text == "" || txtBoxTeddy.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int lego_res = lego * lego_count;
                        int teddy_res = teddy * teddy_count;
                        lblResult.Text = "Сумма покупки: " + (lego_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == true && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == false)
                {
                    if (txtBoxBall.Text == "" || txtBoxLego.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int lego_res = lego * lego_count;
                        int ball_res = ball * ball_count;
                        lblResult.Text = "Сумма покупки: " + (lego_res + ball_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == true && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBall.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int doll_res = doll * doll_count;
                        int ball_res = ball * ball_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + ball_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == true && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == false)
                {
                    if (txtBoxBall.Text == "" || txtBoxTeddy.Text == "" || txtBoxLego.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int lego_res = lego * lego_count;
                        int ball_res = ball * ball_count;
                        int teddy_res = teddy * teddy_count;
                        lblResult.Text = "Сумма покупки: " + (lego_res + ball_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == false && checkBoxTeddy.Checked == true && checkBoxDoll.Checked == true)
                {
                    if (txtBoxLego.Text == "" || txtBoxTeddy.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int teddy_count = Convert.ToInt32(txtBoxTeddy.Text);
                        int doll_res = doll * doll_count;
                        int lego_res = lego * lego_count;
                        int teddy_res = teddy * teddy_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + lego_res + teddy_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == true && checkBoxBall.Checked == true && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == true)
                {
                    if (txtBoxBall.Text == "" || txtBoxLego.Text == "" || txtBoxBarbie.Text == "")
                    { MessageBox.Show("Не все поля заполнены"); }
                    else
                    {
                        int doll_count = Convert.ToInt32(txtBoxBarbie.Text);
                        int ball_count = Convert.ToInt32(txtBoxBall.Text);
                        int lego_count = Convert.ToInt32(txtBoxLego.Text);
                        int doll_res = doll * doll_count;
                        int ball_res = ball * ball_count;
                        int lego_res = lego * lego_count;
                        lblResult.Text = "Сумма покупки: " + (doll_res + ball_res + lego_res).ToString() + " руб.";
                    }
                }

                else if (checkBoxLego.Checked == false && checkBoxBall.Checked == false && checkBoxTeddy.Checked == false && checkBoxDoll.Checked == false)
                {
                    { MessageBox.Show("Выберите товар"); }
                }
            }
            catch
            {
                { MessageBox.Show("Неверный формат"); }
            }
        }
        private void radioBtnDelivery_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnDelivery.Checked)
            {
                txtBoxStreet.Enabled = true;
                dateTimePickerPickup.Enabled = false;
                comboBoxAddress.Enabled = false;
            }
            else
            {
                txtBoxStreet.Enabled = false;
                txtBoxHouse.Enabled = false;
                txtBoxBuilding.Enabled = false;
                txtBoxFlat.Enabled = false;
                txtBoxStreet.Text = "";
                txtBoxHouse.Text = "";
                txtBoxBuilding.Text = "";
                txtBoxFlat.Text = "";
            }
        }

        private void radioBtnPickup_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPickup.Checked)
            {
                dateTimePickerPickup.Enabled = true;
                comboBoxAddress.Enabled = true;
                txtBoxStreet.Enabled = false;
                txtBoxHouse.Enabled = false;
                txtBoxBuilding.Enabled = false;
                txtBoxFlat.Enabled = false;
                txtBoxStreet.Text = "";
                txtBoxHouse.Text = "";
                txtBoxBuilding.Text = "";
                txtBoxFlat.Text = "";
            }
        }

        private void txtBoxName_TextChanged(object sender, EventArgs e)
        {
            string tmpName = txtBoxName.Text;
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(tmpName);
            if (txtBoxName.Text == " ")
            {
                MessageBox.Show("Введите имя!");
            }
            else if (matches.Count > 0)
            {
                MessageBox.Show("Введите буквенные значения!");
            }
            else if (tmpName.Length <= 0)
            {
                MessageBox.Show("Имя не может быть пустым!");
            }
            else
            {
                txtBoxPhone.Enabled = true;
            }
        }

        private void txtBoxPhone_TextChanged(object sender, EventArgs e)
        {
            string tmpPhone = txtBoxPhone.Text;
            int v = 0;
            int result;
            while (v == 0)
            {
                v = 1;
                if (!int.TryParse(txtBoxPhone.Text, out result))
                {
                    v = 0;
                    MessageBox.Show("Введите ваш номер!");
                    break;
                }
                else
                {
                    v = 1;
                    comboBoxPaying.Enabled = true;
                }
            }
        }

        private void comboBoxPaying_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxPaying.SelectedIndex < 0 )
            {
                MessageBox.Show("Введите тип оплаты!");
            }
            else
            {
                radioBtnDelivery.Enabled = true;
                radioBtnPickup.Enabled = true;
            }
        }

        private void txtBoxStreet_TextChanged(object sender, EventArgs e)
        {
            string tmpStreet = txtBoxStreet.Text;
            Regex regex = new Regex(@"\d+");
            MatchCollection matches = regex.Matches(tmpStreet);
            if (txtBoxStreet.Text == "")
            {
                MessageBox.Show("Введите улицу!");
            }
            else if (matches.Count > 0)
            {
                MessageBox.Show("Введите буквенные значения!");
            }
            else
            {
                txtBoxHouse.Enabled = true;
            }
        }

        private void txtBoxHouse_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            int result;
            while (v == 0)
            {
                v = 1;
                if (!int.TryParse(txtBoxHouse.Text, out result))
                {
                    v = 0;
                    MessageBox.Show("Введите число!!");
                    break;
                }
                else if (txtBoxHouse.Text == "")
                {
                    v = 0;
                    MessageBox.Show("Введите номер дома!");
                }
                else
                {
                    v = 1;
                    txtBoxBuilding.Enabled = true;
                }
            }
        }
        private void txtBoxBuilding_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            int result;
            while (v == 0)
            {
                v = 1;
                if (!int.TryParse(txtBoxBuilding.Text, out result))
                {
                    v = 0;
                    MessageBox.Show("Введите число, а не буквы!");
                    break;
                }
                else
                {
                    v = 1;
                    txtBoxFlat.Enabled = true;
                }
            }
        }

        private void txtBoxFlat_TextChanged(object sender, EventArgs e)
        {
            int v = 0;
            int result;
            while (v == 0)
            {
                v = 1;
                if (!int.TryParse(txtBoxFlat.Text, out result))
                {
                    v = 0;
                    MessageBox.Show("Введите число, а не буквы!");
                    break;
                }
                else
                {
                    v = 1;
                    btnGetOrder.Enabled = true;
                }
            }
        }

        private void comboBoxAddress_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxAddress.SelectedIndex < 0)
            {
                MessageBox.Show("Выберите адрес магазина!");
            }
            else
            {
                btnGetOrder.Enabled = true;
            }
        }

        private void btnOrderHelp_Click(object sender, EventArgs e)
        {
            FormHelp f1 = new FormHelp();
            f1.Show();
        }
    }
}