using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt2_Paczesny_72541
{
    public partial class bpAnalizatorLaboratoryjny : Form
    {
        public bpAnalizatorLaboratoryjny()
        {
            InitializeComponent();
        }

        private void bpAnalizatorLaboratoryjny_FormClosing(object sender, FormClosingEventArgs e)
        {
            // we want to ask the user if he really wants to close the app using a dialog

            // create a dialog
            DialogResult bpDialogMessage = MessageBox.Show("Czy na pewno chcesz zamknąć Analizator Laboratoryjny?", "Wyjscie z Analizatora Laboratoryjnego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (bpDialogMessage == DialogResult.Yes)
            {
                e.Cancel = false;

                // instead of looping over all the forms lets get the instance of the form by name (performance improvement)
                KokpitProjektuNr2 bpMainForm = (KokpitProjektuNr2)Application.OpenForms["KokpitProjektuNr2"];

                this.Hide();
                bpMainForm.Show();
            } else
            {
                e.Cancel = true;
            }
        }

        private void bpBtnSubmit_Click(object sender, EventArgs e)
        {
            bpErrorProviderBtnOblicz.Dispose();
            
            // first we need to get all the values from the form
            // the input name is bpTxtA, bpTxtB, bpTXTC, bpTxtX
            // we want to calculate "Wartosc rownania kwadratowego"
            // and place the reslut in bpTxtResult
            double bpA = 0;
            double bpB = 0;
            double bpC = 0;
            double bpX = 0;
            
            // first we want to check if the inputs have values in them and they are numbers
            if (string.IsNullOrWhiteSpace(bpTxtA.Text) ||
                string.IsNullOrWhiteSpace(bpTxtB.Text) ||
                string.IsNullOrWhiteSpace(bpTxtC.Text) ||
                string.IsNullOrWhiteSpace(bpTxtX.Text))
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, "Wszystkie pola musza byc wypelnione");
                return;
            }

            try
            {
                // get the values from the form
                bpA = Convert.ToDouble(bpTxtA.Text);
                bpB = Convert.ToDouble(bpTxtB.Text);
                bpC = Convert.ToDouble(bpTxtC.Text);
                bpX = Convert.ToDouble(bpTxtX.Text);
            }
            catch (Exception error)
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, error.Message);
            }
            
            // calculate the result
            double bpResult = (bpA * Math.Pow(bpX, 2)) + (bpB * bpX) + bpC;
            
            // set the result in the form
            bpTxtResult.Text = bpResult.ToString();
        }

        private void bpShowTableButton_Click(object sender, EventArgs e)
        {
            bpErrorProviderBtnShowTable.Dispose();
            
            double bpA = 0;
            double bpB = 0;
            double bpC = 0;
            double bpX = 0;
            
            Helpers helper = new Helpers(this, bpErrorProviderBtnShowTable, bpBtnShowTableButton);

            if (!helper.PobranieWartosciFunkcjiKwadratowej(out bpA, out bpB, out bpC, out bpX))
            {
                return;
            }
                
            double bpResult = (bpA * Math.Pow(bpX, 2)) + (bpB * bpX) + bpC;
            
            bpTxtResult.Text = bpResult.ToString();

            double bpXd, bpXg, bpH;
            
            if (!helper.PobranieGranicPrzedzialuOrazH(out bpXd, out bpXg, out bpH))
            {
                return;
            }
            
            double [,] bpTWF;
            
            helper.TablicowanieWartosciFunkcji(bpA, bpB, bpC,bpXd, bpXg, bpH, out bpTWF);
            
            helper.PrzepiszDaneTablicyDoDataGridView(bpTWF, ref bpDgvFunkcjiFx);
            
            bpDgvFunkcjiFx.Visible = true;
            
            bpBtnShowTableButton.Enabled = false;
        }

        private void bpDgvFunkcjiFx_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            throw new System.NotImplementedException();
        }
    }
}
