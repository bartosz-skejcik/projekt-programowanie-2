using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt2_Paczesny_72541
{
    public partial class KokpitProjektuNr2 : Form
    {
        public KokpitProjektuNr2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // checking if form template has been created already "Analizator Laboratoryjny"
            foreach (Form bpForm in Application.OpenForms)
            {
                // checking if the form is the "Analizator Laboratoryjny"
                if (bpForm.Name == "bpAnalizatorLaboratoryjny")
                {
                    // hiding the general form and showing the "Analizator Laboratoryjny" form
                    this.Hide();
                    bpForm.Show();

                    return;
                }
            }

            // there was not "Analizator Laboratoryjny" form created yet
            // creating new "Analizator Laboratoryjny" form
            bpAnalizatorLaboratoryjny bpFormAnalizatorLaboratoryjny = new bpAnalizatorLaboratoryjny();

            // hiding the general form and showing the "Analizator Laboratoryjny" form
            this.Hide();
            bpFormAnalizatorLaboratoryjny.Show();
        }

        private void KokpitProjektuNr2_FormClosing(object sender, FormClosingEventArgs e)
        {
            // we want to ask the user if he really wants to close the app using a dialog

            // create a dialog
            DialogResult bpDialogMessage = MessageBox.Show("Czy na pewno chcesz zamknąć aplikację?", "Zamknięcie aplikacji", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (bpDialogMessage == DialogResult.Yes)
            {
                e.Cancel = false;

                Application.ExitThread();
            } else
            {
                e.Cancel = true;
            }
        }
    }
}
