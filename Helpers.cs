using System;
using System.Windows.Forms;

namespace Projekt2_Paczesny_72541
{
    public class Helpers
    {
        private readonly bpAnalizatorLaboratoryjny form;
        private readonly ErrorProvider bpErrorProviderBtnOblicz;
        private readonly Button bpBtnSubmit;

        // constructor with passed form so that we can access the form elements
        public Helpers(bpAnalizatorLaboratoryjny form, ErrorProvider errorProvider, Button button)
        {
            this.form = form;
            this.bpErrorProviderBtnOblicz = errorProvider;
            this.bpBtnSubmit = button;
        }

        public bool PobranieGranicPrzedzialuOrazH(out double Xd, out double Xg, out double H)
        {
            // assign the values to 0
            Xd = 0;
            Xg = 0;
            H = 0;

            // first we want to check if the inputs have values in them and they are numbers
            if (
                string.IsNullOrWhiteSpace(form.bpTxtXd.Text) ||
                string.IsNullOrWhiteSpace(form.bpTxtXg.Text) ||
                string.IsNullOrWhiteSpace(form.bpTxtH.Text)
            )
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, "Wszystkie pola musza byc wypelnione");
                return false;
            }

            try
            {
                // get the values from the form
                Xd = Convert.ToDouble(form.bpTxtXd.Text);
                Xg = Convert.ToDouble(form.bpTxtXg.Text);
                H = Convert.ToDouble(form.bpTxtH.Text);
            }
            catch (Exception error)
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, error.Message);
                return false;
            }
            
            if (Xd >= Xg)
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, "Xd musi byc mniejsze od Xg");
                return false;
            }

            if (!(H <= 0) && !(H >= 1)) return true;
            bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, "H musi byc wieksze od 0 i mniejsze od 1");
            return false;

        }

        public bool PobranieWartosciFunkcjiKwadratowej(out double A, out double B, out double C, out double X)
        {
            // assign the values to 0
            A = 0;
            B = 0;
            C = 0;
            X = 0;

            // first we want to check if the inputs have values in them and they are numbers
            if (
                string.IsNullOrWhiteSpace(form.bpTxtA.Text) ||
                string.IsNullOrWhiteSpace(form.bpTxtB.Text) ||
                string.IsNullOrWhiteSpace(form.bpTxtC.Text) ||
                string.IsNullOrWhiteSpace(form.bpTxtX.Text)
            )
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, "Wszystkie pola musza byc wypelnione");
                return false;
            }

            try
            {
                // get the values from the form
                A = Convert.ToDouble(form.bpTxtA.Text);
                B = Convert.ToDouble(form.bpTxtB.Text);
                C = Convert.ToDouble(form.bpTxtC.Text);
                X = Convert.ToDouble(form.bpTxtX.Text);
                
                
            }
            catch (Exception error)
            {
                bpErrorProviderBtnOblicz.SetError(bpBtnSubmit, error.Message);
                return false;
            }

            return true;
        }
        
        private double ObliczenieWartosciFunkcji(double A, double B, double C, double X)
        {
            return (A * Math.Pow(X, 2)) + (B * X) + C;
        }

        public void TablicowanieWartosciFunkcji(double bpA, double bpB, double bpC, double bpXd, double bpXg,
            double bpH, out double [,] bpTWF)
        {
            bpTWF = null;

            // wyznaczenie liczby wierszy tablicy TWF (tablica wartosci funkcji)
            int bpN = (int)((bpXg - bpXd)/bpH) + 1;
            // utworzenie egzemplarza tablicy TWF
            bpTWF = new double[bpN, 3];
            
            // pomocnicze deklaracje
            double bpX; int bpI;
            for (bpX = bpXd, bpI = 0; bpI < bpTWF.GetLength(0); bpX = bpXd + bpI * bpH, bpI++)
            { // wpisanie danych do i-tego wiersza tablicy TWF
                bpTWF[bpI, 0] = bpI;
                bpTWF[bpI, 1] = bpX;
                bpTWF[bpI, 2] = ObliczenieWartosciFunkcji(bpA, bpB, bpC, bpX);
            }

        }

        public void PrzepiszDaneTablicyDoDataGridView(double[,] bpTWF, ref DataGridView bpDgvFunkcjiFx)
        {
            // wyzerowanie 
            bpDgvFunkcjiFx.Rows.Clear();
            
            //sformatowanie wycentrowania zapisow kolumnach kontrolki DataGridView
            bpDgvFunkcjiFx.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bpDgvFunkcjiFx.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            bpDgvFunkcjiFx.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            
            // przepisanie danych z tablicy do kontrolki DataGridView
            for (int bpI = 0; bpI < bpTWF.GetLength(0); bpI++) {
                // dodanie nowego (pustego) wiersza
                bpDgvFunkcjiFx.Rows.Add(bpTWF);
                // przepisanie i-tego wiersza tablicy do nowego wiersza w kontrolce DataGridView
                bpDgvFunkcjiFx.Rows[bpI].Cells[0].Value = bpTWF[bpI, 0];
                bpDgvFunkcjiFx.Rows[bpI].Cells[1].Value = bpTWF[bpI, 1];
                bpDgvFunkcjiFx.Rows[bpI].Cells[2].Value = bpTWF[bpI, 2];
            }
            
        }
    }
}