using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Projekt2_Paczesny_72541
{
    public class LineStyleDialog : Form
    {
        private ComboBox lineStyleComboBox;
        private Button okButton;
        private Button cancelButton;
        public Chart chart;
        public ChartDashStyle LineStyle { get; set; }

        public LineStyleDialog(string title, Chart chart, ChartDashStyle lineStyle)
        {
            this.Text = title;
            this.chart = chart;
            this.LineStyle = lineStyle;
            this.StartPosition = FormStartPosition.CenterParent;
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            AdjustDialogSize();

            InitializeComponents();
        }

        private void AdjustDialogSize()
        {
            int width = 300;
            int height = 150;

            if (lineStyleComboBox != null && lineStyleComboBox.Items.Count > 5)
            {
                height += 20; // Dynamically increase height if there are many items.
            }

            this.ClientSize = new System.Drawing.Size(width, height);
        }

        private void InitializeComponents()
        {
            this.lineStyleComboBox = new ComboBox();
            this.okButton = new Button();
            this.cancelButton = new Button();

            // Set up the ComboBox
            this.lineStyleComboBox.Items.AddRange(Enum.GetNames(typeof(ChartDashStyle)));
            this.lineStyleComboBox.SelectedIndex = this.lineStyleComboBox.Items.IndexOf(this.LineStyle.ToString());
            this.lineStyleComboBox.Location = new System.Drawing.Point(20, 20);
            this.lineStyleComboBox.Size = new System.Drawing.Size(260, 25);

            // Set up the OK button
            this.okButton.Text = "OK";
            this.okButton.Location = new System.Drawing.Point(120, 80);
            this.okButton.Size = new System.Drawing.Size(75, 30);
            this.okButton.Click += new EventHandler(OkButton_Click);

            // Set up the Cancel button
            this.cancelButton.Text = "Cancel";
            this.cancelButton.Location = new System.Drawing.Point(200, 80);
            this.cancelButton.Size = new System.Drawing.Size(75, 30);
            this.cancelButton.Click += new EventHandler(CancelButton_Click);

            // Add controls to the form
            this.Controls.Add(this.lineStyleComboBox);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.cancelButton);
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            ChartDashStyle selectedStyle = (ChartDashStyle)Enum.Parse(typeof(ChartDashStyle), this.lineStyleComboBox.SelectedItem.ToString());
            this.chart.Series[0].BorderDashStyle = selectedStyle;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}