using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registration_Application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string Name = "";
        string Surname = "";
        string Gender = "";
        double cost = 0;

        private void TxtName_TextChanged(object sender, EventArgs e)
        {
            Name = txtName.Text;

        }

        private void TxtSurname_TextChanged(object sender, EventArgs e)
        {
            Surname = txtSurname.Text;
        }


        private void BtnRegister_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name: { Name} \n Surname: { Surname} \n Gender: { Gender}");

            lstSomething.Items.Add($"Name: {Name} \t Surname: {Surname} \t Gender: {Gender} \t Cost: {cost}");

            txtName.Text = "";
            txtSurname.Text = "";
            rdMale.Checked = false;
            rdFemale.Checked = false;
            chckBAY03A1.Checked = false;
            chckCMN03A1.Checked = false;
            chckIFS03A1.Checked = false;
            chckDSW013A.Checked = false;
        }

        private void RdMale_CheckedChanged(object sender, EventArgs e)
        {
            if(rdMale.Checked)
            {
                Gender = "Male";
            }
        }

        private void RdFemale_CheckedChanged(object sender, EventArgs e)
        {
            if(rdFemale.Checked)
            {
                Gender = "Female";
            }
        }

        private void ChckDSW013A_CheckedChanged(object sender, EventArgs e)
        {
            if(chckDSW013A.Checked)
            {
                cost += 1500;
            }
            else
            {
                cost -= 1500;
            }
            lblTheCost.Text = cost.ToString();
        }

        private void ChckIFS03A1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckIFS03A1.Checked)
            {
                cost += 1500;
            }
            else
            {
                cost -= 1500;
            }
            lblTheCost.Text = cost.ToString();
        }

        private void ChckCMN03A1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckCMN03A1.Checked)
            {
                cost += 1500;
            }
            else
            {
                cost -= 1500;
            }
            lblTheCost.Text = cost.ToString();
        }

        private void ChckBAY03A1_CheckedChanged(object sender, EventArgs e)
        {
            if (chckBAY03A1.Checked)
            {
                cost += 1500;
            }
            else
            {
                cost -= 1500;
            }
            lblTheCost.Text = cost.ToString();
        }
    }
}
