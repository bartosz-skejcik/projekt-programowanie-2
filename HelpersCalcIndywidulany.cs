using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt2_Paczesny_72541
{
    public class HelpersCalcIndywidulany
    {
        private readonly Form bpForm;
        private readonly ErrorProvider bpErrorProvider;
        private readonly Button bpButton;
        private readonly Chart bpChart;
        private readonly DataGridView bpDataGridView;

        public HelpersCalcIndywidulany(Form bpForm, ErrorProvider bpErrorProvider, Button bpButton, Chart bpChart, DataGridView bpDataGridView)
        {
            this.bpForm = bpForm;
            this.bpErrorProvider = bpErrorProvider;
            this.bpButton = bpButton;
            this.bpChart = bpChart;
            this.bpDataGridView = bpDataGridView;
        }

        public bool SprawdzPoprawnoscDanych(TextBox bpTxtXd, TextBox bpTxtXg, TextBox bpTxtH, out double bpStart, out double bpEnd, out double bpStep)
        {
            bpStart = 0;
            bpEnd = 0;
            bpStep = 0;

            if (string.IsNullOrWhiteSpace(bpTxtXd.Text) || 
                string.IsNullOrWhiteSpace(bpTxtXg.Text) || 
                string.IsNullOrWhiteSpace(bpTxtH.Text))
            {
                bpErrorProvider.SetError(bpButton, "Wszystkie pola muszą być wypełnione");
                return false;
            }

            try
            {
                bpStart = Convert.ToDouble(bpTxtXd.Text);
                bpEnd = Convert.ToDouble(bpTxtXg.Text);
                bpStep = Convert.ToDouble(bpTxtH.Text);
            }
            catch (Exception error)
            {
                bpErrorProvider.SetError(bpButton, error.Message);
                return false;
            }

            if (bpStep <= 0)
            {
                bpErrorProvider.SetError(bpButton, "Krok musi być większy od 0");
                return false;
            }

            return true;
        }

        public void WizualizacjaWykresu(double bpStart, double bpEnd, double bpStep)
        {
            bpChart.Series.Clear();
            bpChart.BorderlineWidth = 2;
            bpChart.BorderlineColor = Color.Blue;
            bpChart.BorderlineDashStyle = ChartDashStyle.Solid;
            
            bpChart.BackColor = Color.White;
            bpChart.ForeColor = Color.Black;
            
            bpChart.Titles.Clear();
            bpChart.Titles.Add("Wykres funkcji");
            
            bpChart.Legends.Clear();
            bpChart.Legends.Add("Legenda");
            bpChart.Legends[0].Docking = Docking.Bottom;
            
            bpChart.ChartAreas.Clear();
            bpChart.ChartAreas.Add("Obszar wykresu");
            
            bpChart.ChartAreas[0].AxisX.Title = "X";
            bpChart.ChartAreas[0].AxisY.Title = "F(x)";
            
            bpChart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:F2}";
            bpChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:F2}";

            Series bpSeria = new Series();
            bpChart.Series.Add(bpSeria);
            bpSeria.Name = "F(x)";
            bpSeria.ChartType = SeriesChartType.Line;
            bpSeria.Color = Color.Blue;

            for (double bpX = bpStart; bpX <= bpEnd; bpX += bpStep)
            {
                double result = bpCalculateF(bpX);
                bpSeria.Points.AddXY(bpX, result);
            }
        } 
        public static double bpCalculateF(double bpX)
        {
            if (bpX < -20)
            {
                return Math.Pow(Math.Sin(Math.PI * bpX) + 2 * Math.Cos(Math.PI * bpX / 2), 2);
            }
            
            if (bpX >= -20 && bpX < 0)
            {
                return (Math.Pow(10, 6) * bpX * Math.Log(Math.Abs(bpX))) / (Math.Exp(bpX) * (1 + Math.Pow(bpX, 2)));
            }
            
            return Math.Sin(Math.Pow(bpX, 4) + bpX) * Math.Cos(bpX);
        } 
        
       public bool ZapiszTabeleDoPlikuTXT()
       {
           if (!(bpDataGridView.Visible && bpDataGridView.Enabled))
           {
               bpErrorProvider.SetError(bpButton, "Najpierw wygeneruj tabelę wartości funkcji");
               return false;
           }

           SaveFileDialog bpSaveFileDialog = new SaveFileDialog
           {
               Title = "Zapisz dane z tabeli",
               Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*"
           };

           if (bpSaveFileDialog.ShowDialog() == DialogResult.OK)
           {
               try
               {
                   using (StreamWriter bpStreamWriter = new StreamWriter(bpSaveFileDialog.FileName))
                   {
                       for (int bpI = 0; bpI < bpDataGridView.Rows.Count; bpI++)
                       {
                           bpStreamWriter.WriteLine(bpDataGridView.Rows[bpI].Cells[0].Value + "\t" + bpDataGridView.Rows[bpI].Cells[1].Value);
                       }
                   }
                   return true;
               }
               catch (Exception ex)
               {
                   bpErrorProvider.SetError(bpButton, $"Błąd podczas zapisu: {ex.Message}");
                   return false;
               }
           }

           return false;
       }

       public bool WczytajTabeleZPlikuTXT()
       {
           OpenFileDialog bpOpenFileDialog = new OpenFileDialog
           {
               Title = "Wczytaj dane z pliku",
               Filter = "Pliki tekstowe (*.txt)|*.txt|Wszystkie pliki (*.*)|*.*"
           };

           if (bpOpenFileDialog.ShowDialog() == DialogResult.OK)
           {
               try
               {
                   bpDataGridView.Rows.Clear();

                   using (StreamReader bpStreamReader = new StreamReader(bpOpenFileDialog.FileName))
                   {
                       while (!bpStreamReader.EndOfStream)
                       {
                           string bpLine = bpStreamReader.ReadLine();
                           string[] bpData = bpLine.Split('\t');
                           bpDataGridView.Rows.Add(bpData);
                       }
                   }

                   bpDataGridView.Visible = true;
                   return true;
               }
               catch (Exception ex)
               {
                   bpErrorProvider.SetError(bpButton, $"Błąd podczas odczytu: {ex.Message}");
                   return false;
               }
           }

           return false;
       } 
    }
}