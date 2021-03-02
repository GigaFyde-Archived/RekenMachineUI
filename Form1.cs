using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RekenMachineUI
{
    public partial class frmHoofdscherm : Form
    {
        public frmHoofdscherm()
        {
            InitializeComponent();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            try
            {
                float getal1 = float.Parse(txbGetal1.Text);
                float getal2 = float.Parse(txbGetal2.Text);
                lblResultaat.Text = (getal1 - getal2).ToString();
            } catch(Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + error.Message);
            }
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            try
            {
                float getal1 = float.Parse(txbGetal1.Text);
                float getal2 = float.Parse(txbGetal2.Text);
                lblResultText.Text = "Resultaat: ";
                lblResultaat.Text = (getal1 + getal2).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + error.Message);
            }
        }

        private void btnDeel_Click(object sender, EventArgs e)
        {
            try
            {
                float getal1 = float.Parse(txbGetal1.Text);
                float getal2 = float.Parse(txbGetal2.Text);
                lblResultText.Text = "Resultaat: ";
                lblResultaat.Text = (getal1 / getal2).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + error.Message);
            }
        }

        private void btnKeer_Click(object sender, EventArgs e)
        {
            try
            {
                float getal1 = float.Parse(txbGetal1.Text);
                float getal2 = float.Parse(txbGetal2.Text);
                lblResultText.Text = "Resultaat: ";
                lblResultaat.Text = (getal1 * getal2).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + error.Message);
            }
        }

        private void btnBTW_Click(object sender, EventArgs e)
        {
            try
            {
                float getal1 = float.Parse(txbGetal1.Text);
                double getal2 = double.Parse(txbGetal2.Text);
                lblResultText.Text = "Het bedrag zonder btw is: ";
                lblResultaat.Text = (getal1 - (getal1 * (getal2 / 100))).ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show("Er is een fout opgetreden. De melding is: " + error.Message);
            }
        }
    }
}
