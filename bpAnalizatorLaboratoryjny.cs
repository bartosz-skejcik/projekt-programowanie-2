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
            
            bpWykresFx.Visible = false;
            
            bpDgvFunkcjiFx.Visible = true;
            
            bpBtnWizualizacjaGraficzna.Enabled = true;
            
            bpBtnShowTableButton.Enabled = false;
        }

        private void bpBtnWizualizacjaGraficzna_Click(object sender, EventArgs e)
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
            
            // Wpisanie danych z tablicy bpTWF do serii danych kontrolki Chart
            helper.WpisanieDanychDoSeriiDanychKontrolkiChart(bpTWF, ref bpWykresFx);
            
            // Odslonienie kontrolki chart i ukrycie kontrolki DataGridView
            bpDgvFunkcjiFx.Visible = false;
            
            bpWykresFx.Visible = true;
            
            // enable the button
            bpBtnShowTableButton.Enabled = true;
            // disable the button
            bpBtnWizualizacjaGraficzna.Enabled = false;
        }

        private void zmianaFormatuCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnOblicz.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpDgvFunkcjiFx.Visible && bpDgvFunkcjiFx.Enabled))
            {
                 bpErrorProviderBtnShowTable.SetError(bpBtnShowTableButton, "Najpierw wygeneruj tabele wartosci funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany czcionki
            FontDialog bpFontDialog = new FontDialog();
            
            // ustawienie aktualnej czcionki
            bpFontDialog.Font = bpDgvFunkcjiFx.Font;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpFontDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane czcionki
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana czcionki w kontrolce DataGridView
                bpDgvFunkcjiFx.Font = bpFontDialog.Font;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void zmianaKoloruCzcionkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnOblicz.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpDgvFunkcjiFx.Visible && bpDgvFunkcjiFx.Enabled))
            {
                 bpErrorProviderBtnShowTable.SetError(bpBtnShowTableButton, "Najpierw wygeneruj tabele wartosci funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru czcionki
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru czcionki
            bpColorDialog.Color = bpDgvFunkcjiFx.ForeColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru czcionki
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru czcionki w kontrolce DataGridView
                bpDgvFunkcjiFx.ForeColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void zmianaKoloruSiatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnOblicz.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpDgvFunkcjiFx.Visible && bpDgvFunkcjiFx.Enabled))
            {
                 bpErrorProviderBtnShowTable.SetError(bpBtnShowTableButton, "Najpierw wygeneruj tabele wartosci funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru siatki
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru siatki
            bpColorDialog.Color = bpDgvFunkcjiFx.GridColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru siatki
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru siatki w kontrolce DataGridView
                bpDgvFunkcjiFx.GridColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void zmianaKoloruTlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnOblicz.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpDgvFunkcjiFx.Visible && bpDgvFunkcjiFx.Enabled))
            {
                 bpErrorProviderBtnShowTable.SetError(bpBtnShowTableButton, "Najpierw wygeneruj tabele wartosci funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru tla
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru tla
            bpColorDialog.Color = bpDgvFunkcjiFx.BackgroundColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru tla
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru tla w kontrolce DataGridView
                bpDgvFunkcjiFx.BackgroundColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void liniiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru linii
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru linii
            bpColorDialog.Color = bpWykresFx.Series[0].Color;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru linii
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru linii w kontrolce Chart
                bpWykresFx.Series[0].Color = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }

        private void siatkiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru siatki
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru siatki
            bpColorDialog.Color = bpWykresFx.ChartAreas[0].AxisX.MajorGrid.LineColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru siatki
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru siatki w kontrolce Chart
                bpWykresFx.ChartAreas[0].AxisX.MajorGrid.LineColor = bpColorDialog.Color;
                bpWykresFx.ChartAreas[0].AxisY.MajorGrid.LineColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }

        private void tlaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru tla
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru tla
            bpColorDialog.Color = bpWykresFx.BackColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru tla
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru tla w kontrolce Chart
                bpWykresFx.BackColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }

        private void tekstuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany koloru tekstu
            ColorDialog bpColorDialog = new ColorDialog();
            
            // ustawienie aktualnego koloru tekstu
            bpColorDialog.Color = bpWykresFx.ForeColor;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpColorDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane koloru tekstu
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana koloru tekstu w kontrolce Chart
                bpWykresFx.ForeColor = bpColorDialog.Color;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }

        private void zmianaFormatuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // utworzenie okna dialogowego zmiany czcionki
            FontDialog bpFontDialog = new FontDialog();
            
            // ustawienie aktualnej czcionki
            bpFontDialog.Font = bpWykresFx.Font;
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpFontDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane czcionki
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana czcionki w kontrolce Chart
                bpWykresFx.Font = bpFontDialog.Font;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }

        private void zapiszDGVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpDgvFunkcjiFx.Visible && bpDgvFunkcjiFx.Enabled))
            {
                 bpErrorProviderBtnShowTable.SetError(bpBtnShowTableButton, "Najpierw wygeneruj tabele wartosci funkcji");
                 return;
            }
            
            //utworzenie egzemplarza okna dialogowego umozliwiajacego wybor pliku do zapisania
            SaveFileDialog bpSaveFileDialog = new SaveFileDialog();
            bpSaveFileDialog.Title = "Zapisz dane z tabeli";
            
            //ustawienie filtru plikow
            bpSaveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            
            //wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpSaveFileDialog.ShowDialog();
            
            //sprawdzenie czy uzytkownik zaakceptowal wybor pliku
            if (bpDialogResult == DialogResult.OK)
            {
                //utworzenie egzemplarza klasy StreamWriter
                using (System.IO.StreamWriter bpStreamWriter = new System.IO.StreamWriter(bpSaveFileDialog.FileName))
                {
                    //zapisanie danych z kontrolki DataGridView do pliku
                    for (int bpI = 0; bpI < bpDgvFunkcjiFx.Rows.Count; bpI++)
                    {
                        bpStreamWriter.WriteLine(bpDgvFunkcjiFx.Rows[bpI].Cells[0].Value + "\t" + bpDgvFunkcjiFx.Rows[bpI].Cells[1].Value + "\t" + bpDgvFunkcjiFx.Rows[bpI].Cells[2].Value);
                    }
                }
            }
            
            //zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void pobierzDGVZPlikuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
            
            //utworzenie egzemplarza okna dialogowego umozliwiajacego wybor pliku do odczytu
            OpenFileDialog bpOpenFileDialog = new OpenFileDialog();
            bpOpenFileDialog.Title = "Wgraj dane z pliku";
            
            //ustawienie filtru plikow
            bpOpenFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*";
            
            //wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpOpenFileDialog.ShowDialog();
            
            //sprawdzenie czy uzytkownik zaakceptowal wybor pliku
            if (bpDialogResult == DialogResult.OK)
            {
                //utworzenie egzemplarza klasy StreamReader
                using (System.IO.StreamReader bpStreamReader = new System.IO.StreamReader(bpOpenFileDialog.FileName))
                {
                    //utworzenie listy do przechowywania danych z pliku
                    List<string> bpLines = new List<string>();
                    
                    //odczytanie danych z pliku
                    while (!bpStreamReader.EndOfStream)
                    {
                        bpLines.Add(bpStreamReader.ReadLine());
                    }
                    
                    //przepisanie danych z listy do kontrolki DataGridView
                    for (int bpI = 0; bpI < bpLines.Count; bpI++)
                    {
                        string[] bpData = bpLines[bpI].Split('\t');
                        bpDgvFunkcjiFx.Rows.Add(bpData);
                    }
                }
                
                // wyswietl dgv
                bpDgvFunkcjiFx.Visible = true;
                bpBtnShowTableButton.Enabled = false;
            }
            
            //zgaszenie kontrolki error provider
            bpErrorProviderBtnShowTable.Dispose();
        }

        private void zmianaStyluToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
            
            // sprawdzenie wykonalnosci danego polecenia
            if (!(bpWykresFx.Visible && bpWykresFx.Enabled))
            {
                 bpErrorProviderBtnWykresFx.SetError(bpBtnWizualizacjaGraficzna, "Najpierw wygeneruj wykres funkcji");
                 return;
            }
            
            // pobranie aktualnego stylu linii
            ChartDashStyle bpCurrentStyle = bpWykresFx.Series[0].BorderDashStyle;
            
            // utworzenie okna dialogowego z tytulem "Styl linii"
            LineStyleDialog bpLineStyleDialog = new LineStyleDialog("Styl linii", bpWykresFx, bpCurrentStyle);
            
            // wyswietlenie okna dialogowego
            DialogResult bpDialogResult = bpLineStyleDialog.ShowDialog();
            
            // sprawdzenie czy uzytkownik zaakceptowal zmiane stylu linii
            if (bpDialogResult == DialogResult.OK)
            {
                // zmiana stylu linii w kontrolce Chart
                bpWykresFx.Series[0].BorderDashStyle = bpLineStyleDialog.chart.Series[0].BorderDashStyle;
            }
            
            // zgaszenie kontrolki error provider
            bpErrorProviderBtnWykresFx.Dispose();
        }
    }
}
