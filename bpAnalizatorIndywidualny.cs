using System;
using System.Windows.Forms;

namespace Projekt2_Paczesny_72541
{
    public partial class bpAnalizatorIndywidualny : Form
    {
        public bpAnalizatorIndywidualny()
        {
            InitializeComponent();
        }
        
        private void bpAnalizatorIndywidualny_FormClosing(object sender, FormClosingEventArgs e)
        {
            // we want to ask the user if he really wants to close the app using a dialog

            // create a dialog
            DialogResult bpDialogMessage = MessageBox.Show("Czy na pewno chcesz zamknąć Analizator Indywidualny?", "Wyjscie z Analizatora Indywidualnego", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
        
        private void zamknijFormularzToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            // chcemy wyjsc do kokpitu
            KokpitProjektuNr2 bpMainForm = (KokpitProjektuNr2)Application.OpenForms["KokpitProjektuNr2"];
            
            Hide();
            
            bpMainForm.Show();
        }

        private void zamknijProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // chcemy zamknąć całą aplikacje, bez zadnych pytań
            Application.Exit();
            
        }

        private void bpBtnResetFormularza_Click(object sender, EventArgs e)
        {
            bpTxtX.Text = "";
            bpTxtXd.Text = "";
            bpTxtXg.Text = "";
            bpTxtH.Text = "";
            bpTxtWynik.Text = "";
            
            bpDGV.Rows.Clear();
            bpDGV.Visible = false;
            
            bpWykresFunkcji.Visible = false;
        }

        private void bpBtnOblicz_Click(object sender, EventArgs e)
        {
            try
            {
                double bpX = double.Parse(bpTxtX.Text);
                double bpResult = HelpersCalcIndywidulany.bpCalculateF(bpX);
                
                bpTxtWynik.Text = bpResult.ToString();
            } catch (Exception error)
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnOblicz, error.Message);
            }
        }

        private void bpBtnWizualizacjaTabelaryczna_Click(object sender, EventArgs e)
        {
            if (bpTxtX.Text == "" || bpTxtXd.Text == "" || bpTxtXg.Text == "" || bpTxtH.Text == "")
            {
                bpErrorProviderBtnWizualizacjaTabelaryczna.SetError(bpBtnWizualizacjaTabelaryczna, "Wszystkie pola muszą być wypełnione");
                return;
            }
            
            bpBtnWizualizacjaTabelaryczna.Enabled = false;
            bpBtnWizualizacjaGraficzna.Enabled = true;
            
            bpDGV.Visible = true;
            bpWykresFunkcji.Visible = false;

            try
            {
                double bpStart = double.Parse(bpTxtXd.Text);
                double bpEnd = double.Parse(bpTxtXg.Text);
                double bpStep = double.Parse(bpTxtH.Text);

                if (bpStep <= 0)
                {
                    bpErrorProviderBtnWizualizacjaTabelaryczna.SetError(bpBtnWizualizacjaTabelaryczna, "Krok musi być większy od 0");
                    return;
                }
                
                // Czyszczenie DataGridView
                bpDGV.Rows.Clear();
                
                // Wypełnianie DataGridView
                for (double bpX = bpStart; bpX <= bpEnd; bpX += bpStep)
                {
                    double bpResult = HelpersCalcIndywidulany.bpCalculateF(bpX);
                    bpDGV.Rows.Add(bpX, bpResult);
                }
            }
            catch (Exception error)
            {
                bpErrorProviderBtnWizualizacjaTabelaryczna.SetError(bpBtnWizualizacjaTabelaryczna, error.Message);
            }
        }

        private void bpBtnWizualizacjaGraficzna_Click(object sender, EventArgs e)
        {
            bpErrorProviderBtnWizualizacjaGraficzna.Clear();
    
            HelpersCalcIndywidulany bpHelper = new HelpersCalcIndywidulany(
                this, 
                bpErrorProviderBtnWizualizacjaGraficzna, 
                bpBtnWizualizacjaGraficzna,
                bpWykresFunkcji,
                bpDGV
            );

            double bpStart, bpEnd, bpStep;
    
            if (!bpHelper.SprawdzPoprawnoscDanych(bpTxtXd, bpTxtXg, bpTxtH, out bpStart, out bpEnd, out bpStep))
            {
                return;
            }

            try
            {
                bpDGV.Visible = false;
                bpHelper.WizualizacjaWykresu(bpStart, bpEnd, bpStep);
                bpWykresFunkcji.Visible = true;
        
                bpBtnWizualizacjaGraficzna.Enabled = false;
                bpBtnWizualizacjaTabelaryczna.Enabled = true;
            }
            catch (Exception error)
            {
                bpErrorProviderBtnWizualizacjaGraficzna.SetError(bpBtnWizualizacjaGraficzna, error.Message);
            }
        }

        // Zapisz DGV
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            bpErrorProviderBtnWizualizacjaGraficzna.Clear();
    
            HelpersCalcIndywidulany bpHelper = new HelpersCalcIndywidulany(
                this, 
                bpErrorProviderBtnWizualizacjaGraficzna, 
                bpBtnWizualizacjaGraficzna,
                bpWykresFunkcji,
                bpDGV
            );

            if (bpHelper.ZapiszTabeleDoPlikuTXT())
            {
                // Opcjonalnie: możesz dodać komunikat o sukcesie
                MessageBox.Show("Dane zostały pomyślnie zapisane do pliku.", 
                    "Sukces", 
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
            } 
        }

        // Otwórz DGV
        private void pobierzDGVZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bpErrorProviderBtnWizualizacjaGraficzna.Clear();
    
            HelpersCalcIndywidulany bpHelper = new HelpersCalcIndywidulany(
                this, 
                bpErrorProviderBtnWizualizacjaGraficzna, 
                bpBtnWizualizacjaGraficzna,
                bpWykresFunkcji,
                bpDGV
            );

            if (bpHelper.WczytajTabeleZPlikuTXT())
            {
                bpDGV.Visible = true;
                bpWykresFunkcji.Visible = false;
                bpBtnWizualizacjaGraficzna.Enabled = true;
                bpBtnWizualizacjaTabelaryczna.Enabled = false;
            }
        }

        #region DGV

        // zmiana formatu czcionki
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            // open a dialog to change the font
            FontDialog bpFontDialog = new FontDialog();
            bpFontDialog.Font = bpDGV.Font;
            
            if (bpFontDialog.ShowDialog() == DialogResult.OK)
            {
                bpDGV.Font = bpFontDialog.Font;
            }
        }

        // zmiana koloru czcionki
        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            // open a dialog to change the font color
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpDGV.ForeColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpDGV.ForeColor = bpColorDialog.Color;
            }
        }

        // zmiana koloru siatki
        private void zmianaKoloruSiatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a dialog to change the grid color
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpDGV.GridColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpDGV.GridColor = bpColorDialog.Color;
            }
        }

        // zmiana koloru tla
        private void zmianaKoloruTlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a dialog to change the background color
            ColorDialog bpColorDialog = new ColorDialog();
            
            // we want to change the color of columns and rows
            bpColorDialog.Color = bpDGV.RowsDefaultCellStyle.BackColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpDGV.RowsDefaultCellStyle.BackColor = bpColorDialog.Color;
                bpDGV.AlternatingRowsDefaultCellStyle.BackColor = bpColorDialog.Color;
            }
        }

        #endregion

        #region Wykres

        // zmiana koloru linii
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpWykresFunkcji.Series[0].Color;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.Series[0].Color = bpColorDialog.Color;
            }
        }

        // zmiana koloru siatki
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpWykresFunkcji.ChartAreas[0].AxisX.MajorGrid.LineColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.ChartAreas[0].AxisX.MajorGrid.LineColor = bpColorDialog.Color;
                bpWykresFunkcji.ChartAreas[0].AxisY.MajorGrid.LineColor = bpColorDialog.Color;
            }
        }

        // zmiana koloru tla
        private void tlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpWykresFunkcji.BackColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.BackColor = bpColorDialog.Color;
            }
        }

        // zmiana koloru teksu
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            ColorDialog bpColorDialog = new ColorDialog();
            
            bpColorDialog.Color = bpWykresFunkcji.ForeColor;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.ForeColor = bpColorDialog.Color;
            }
        }

        // zmiana formatu czcionki
        private void zmianaFormatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog bpColorDialog = new FontDialog();
            bpColorDialog.Font = bpWykresFunkcji.Titles[0].Font;
            
            if (bpColorDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.Titles[0].Font = bpColorDialog.Font;
            }
        }

        // zmiana stylu linii
        private void zmianaStyluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // open a dialog to change the line style
            LineStyleDialog bpLineStyleDialog = new LineStyleDialog(
                "Zmiana stylu linii",
                bpWykresFunkcji,
                bpWykresFunkcji.Series[0].BorderDashStyle
            );
            
            if (bpLineStyleDialog.ShowDialog() == DialogResult.OK)
            {
                bpWykresFunkcji.Series[0].BorderDashStyle = bpLineStyleDialog.LineStyle;
            }
        }

        #endregion
    }
}