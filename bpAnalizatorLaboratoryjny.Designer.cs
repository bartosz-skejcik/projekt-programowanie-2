namespace Projekt2_Paczesny_72541
{
    partial class bpAnalizatorLaboratoryjny
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.bpEntryValues = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bpTxtX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bpTxtC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bpTxtB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bpTxtA = new System.Windows.Forms.TextBox();
            this.bpBtnSubmit = new System.Windows.Forms.Button();
            this.bpLblResult = new System.Windows.Forms.Label();
            this.bpTxtResult = new System.Windows.Forms.TextBox();
            this.bpErrorProviderBtnOblicz = new System.Windows.Forms.ErrorProvider(this.components);
            this.bpDgvFunkcjiFx = new System.Windows.Forms.DataGridView();
            this.WartoscFunkcjiFx = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumerPrzedzialu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WartoscZmiennejX = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bpBtnShowTableButton = new System.Windows.Forms.Button();
            this.bpErrorProviderBtnShowTable = new System.Windows.Forms.ErrorProvider(this.components);
            this.bpTableValues = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.bpTxtH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.bpTxtXg = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.bpTxtXd = new System.Windows.Forms.TextBox();
            this.bpBtnWizualizacjaGraficzna = new System.Windows.Forms.Button();
            this.bpWykresFx = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.zapiszDGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pobierzDGVZPlikuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolkaDGVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaFormatuCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaKoloruCzcionkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaKoloruSiatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaKoloruTlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontrolkaChartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaKoloruMiniWykresuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liniiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.siatkiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tlaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekstuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaFormatuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zmianaStyluToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bpErrorProviderBtnWykresFx = new System.Windows.Forms.ErrorProvider(this.components);
            this.bpEntryValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnOblicz)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpDgvFunkcjiFx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnShowTable)).BeginInit();
            this.bpTableValues.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpWykresFx)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnWykresFx)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(253, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(498, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator Laboratoryjny dla rownania kwadratowego";
            // 
            // bpEntryValues
            // 
            this.bpEntryValues.Controls.Add(this.label5);
            this.bpEntryValues.Controls.Add(this.bpTxtX);
            this.bpEntryValues.Controls.Add(this.label4);
            this.bpEntryValues.Controls.Add(this.bpTxtC);
            this.bpEntryValues.Controls.Add(this.label3);
            this.bpEntryValues.Controls.Add(this.bpTxtB);
            this.bpEntryValues.Controls.Add(this.label2);
            this.bpEntryValues.Controls.Add(this.bpTxtA);
            this.bpEntryValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpEntryValues.Location = new System.Drawing.Point(12, 54);
            this.bpEntryValues.Name = "bpEntryValues";
            this.bpEntryValues.Size = new System.Drawing.Size(225, 168);
            this.bpEntryValues.TabIndex = 1;
            this.bpEntryValues.TabStop = false;
            this.bpEntryValues.Text = "Wartosci wspolczynnikow i zmiennej X";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "x:";
            // 
            // bpTxtX
            // 
            this.bpTxtX.Location = new System.Drawing.Point(27, 140);
            this.bpTxtX.Name = "bpTxtX";
            this.bpTxtX.Size = new System.Drawing.Size(192, 22);
            this.bpTxtX.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(6, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "c:";
            // 
            // bpTxtC
            // 
            this.bpTxtC.Location = new System.Drawing.Point(27, 91);
            this.bpTxtC.Name = "bpTxtC";
            this.bpTxtC.Size = new System.Drawing.Size(192, 22);
            this.bpTxtC.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(6, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "b:";
            // 
            // bpTxtB
            // 
            this.bpTxtB.Location = new System.Drawing.Point(27, 65);
            this.bpTxtB.Name = "bpTxtB";
            this.bpTxtB.Size = new System.Drawing.Size(192, 22);
            this.bpTxtB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "a:";
            // 
            // bpTxtA
            // 
            this.bpTxtA.Location = new System.Drawing.Point(27, 39);
            this.bpTxtA.Name = "bpTxtA";
            this.bpTxtA.Size = new System.Drawing.Size(192, 22);
            this.bpTxtA.TabIndex = 0;
            // 
            // bpBtnSubmit
            // 
            this.bpBtnSubmit.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bpBtnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpBtnSubmit.Location = new System.Drawing.Point(780, 104);
            this.bpBtnSubmit.Name = "bpBtnSubmit";
            this.bpBtnSubmit.Size = new System.Drawing.Size(189, 29);
            this.bpBtnSubmit.TabIndex = 8;
            this.bpBtnSubmit.Text = "Oblicz";
            this.bpBtnSubmit.UseVisualStyleBackColor = false;
            this.bpBtnSubmit.Click += new System.EventHandler(this.bpBtnSubmit_Click);
            // 
            // bpLblResult
            // 
            this.bpLblResult.AutoSize = true;
            this.bpLblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpLblResult.Location = new System.Drawing.Point(780, 59);
            this.bpLblResult.Name = "bpLblResult";
            this.bpLblResult.Size = new System.Drawing.Size(115, 16);
            this.bpLblResult.TabIndex = 2;
            this.bpLblResult.Text = "Wartosc rownania";
            // 
            // bpTxtResult
            // 
            this.bpTxtResult.Location = new System.Drawing.Point(783, 78);
            this.bpTxtResult.Name = "bpTxtResult";
            this.bpTxtResult.Size = new System.Drawing.Size(186, 20);
            this.bpTxtResult.TabIndex = 3;
            // 
            // bpErrorProviderBtnOblicz
            // 
            this.bpErrorProviderBtnOblicz.ContainerControl = this;
            // 
            // bpDgvFunkcjiFx
            // 
            this.bpDgvFunkcjiFx.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bpDgvFunkcjiFx.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.WartoscFunkcjiFx, this.NumerPrzedzialu, this.WartoscZmiennejX });
            this.bpDgvFunkcjiFx.Location = new System.Drawing.Point(300, 70);
            this.bpDgvFunkcjiFx.Name = "bpDgvFunkcjiFx";
            this.bpDgvFunkcjiFx.Size = new System.Drawing.Size(432, 445);
            this.bpDgvFunkcjiFx.TabIndex = 9;
            this.bpDgvFunkcjiFx.Visible = false;
            // 
            // WartoscFunkcjiFx
            // 
            this.WartoscFunkcjiFx.HeaderText = "Wartosc funkcji F(x)";
            this.WartoscFunkcjiFx.Name = "WartoscFunkcjiFx";
            // 
            // NumerPrzedzialu
            // 
            this.NumerPrzedzialu.HeaderText = "Numer przedzialu";
            this.NumerPrzedzialu.Name = "NumerPrzedzialu";
            // 
            // WartoscZmiennejX
            // 
            this.WartoscZmiennejX.HeaderText = "Column1";
            this.WartoscZmiennejX.Name = "WartoscZmiennejX";
            // 
            // bpBtnShowTableButton
            // 
            this.bpBtnShowTableButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bpBtnShowTableButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpBtnShowTableButton.Location = new System.Drawing.Point(780, 138);
            this.bpBtnShowTableButton.Name = "bpBtnShowTableButton";
            this.bpBtnShowTableButton.Size = new System.Drawing.Size(189, 29);
            this.bpBtnShowTableButton.TabIndex = 10;
            this.bpBtnShowTableButton.Text = "Wyswietl tabele";
            this.bpBtnShowTableButton.UseVisualStyleBackColor = false;
            this.bpBtnShowTableButton.Click += new System.EventHandler(this.bpShowTableButton_Click);
            // 
            // bpErrorProviderBtnShowTable
            // 
            this.bpErrorProviderBtnShowTable.ContainerControl = this;
            // 
            // bpTableValues
            // 
            this.bpTableValues.Controls.Add(this.label7);
            this.bpTableValues.Controls.Add(this.bpTxtH);
            this.bpTableValues.Controls.Add(this.label8);
            this.bpTableValues.Controls.Add(this.bpTxtXg);
            this.bpTableValues.Controls.Add(this.label9);
            this.bpTableValues.Controls.Add(this.bpTxtXd);
            this.bpTableValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpTableValues.Location = new System.Drawing.Point(12, 247);
            this.bpTableValues.Name = "bpTableValues";
            this.bpTableValues.Size = new System.Drawing.Size(225, 112);
            this.bpTableValues.TabIndex = 11;
            this.bpTableValues.TabStop = false;
            this.bpTableValues.Text = "Tabelaryzacja Funkcji F(x)";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(18, 16);
            this.label7.TabIndex = 5;
            this.label7.Text = "h:";
            // 
            // bpTxtH
            // 
            this.bpTxtH.Location = new System.Drawing.Point(39, 76);
            this.bpTxtH.Name = "bpTxtH";
            this.bpTxtH.Size = new System.Drawing.Size(180, 22);
            this.bpTxtH.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 16);
            this.label8.TabIndex = 3;
            this.label8.Text = "Xg:";
            // 
            // bpTxtXg
            // 
            this.bpTxtXg.Location = new System.Drawing.Point(39, 50);
            this.bpTxtXg.Name = "bpTxtXg";
            this.bpTxtXg.Size = new System.Drawing.Size(180, 22);
            this.bpTxtXg.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ControlLight;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(5, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "Xd:";
            // 
            // bpTxtXd
            // 
            this.bpTxtXd.Location = new System.Drawing.Point(39, 24);
            this.bpTxtXd.Name = "bpTxtXd";
            this.bpTxtXd.Size = new System.Drawing.Size(180, 22);
            this.bpTxtXd.TabIndex = 0;
            // 
            // bpBtnWizualizacjaGraficzna
            // 
            this.bpBtnWizualizacjaGraficzna.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bpBtnWizualizacjaGraficzna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpBtnWizualizacjaGraficzna.Location = new System.Drawing.Point(780, 173);
            this.bpBtnWizualizacjaGraficzna.Name = "bpBtnWizualizacjaGraficzna";
            this.bpBtnWizualizacjaGraficzna.Size = new System.Drawing.Size(189, 32);
            this.bpBtnWizualizacjaGraficzna.TabIndex = 12;
            this.bpBtnWizualizacjaGraficzna.Text = "Wizualizacja graficzna";
            this.bpBtnWizualizacjaGraficzna.UseVisualStyleBackColor = false;
            this.bpBtnWizualizacjaGraficzna.Click += new System.EventHandler(this.bpBtnWizualizacjaGraficzna_Click);
            // 
            // bpWykresFx
            // 
            chartArea1.Name = "ChartArea1";
            this.bpWykresFx.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.bpWykresFx.Legends.Add(legend1);
            this.bpWykresFx.Location = new System.Drawing.Point(300, 70);
            this.bpWykresFx.Name = "bpWykresFx";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.bpWykresFx.Series.Add(series1);
            this.bpWykresFx.Size = new System.Drawing.Size(432, 445);
            this.bpWykresFx.TabIndex = 13;
            this.bpWykresFx.Text = "chart1";
            this.bpWykresFx.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { this.plikToolStripMenuItem1, this.plikToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(981, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem1
            // 
            this.plikToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.zapiszDGVToolStripMenuItem, this.pobierzDGVZPlikuToolStripMenuItem });
            this.plikToolStripMenuItem1.Name = "plikToolStripMenuItem1";
            this.plikToolStripMenuItem1.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem1.Text = "Plik";
            // 
            // zapiszDGVToolStripMenuItem
            // 
            this.zapiszDGVToolStripMenuItem.Name = "zapiszDGVToolStripMenuItem";
            this.zapiszDGVToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.zapiszDGVToolStripMenuItem.Text = "Zapisz DGV";
            this.zapiszDGVToolStripMenuItem.Click += new System.EventHandler(this.zapiszDGVToolStripMenuItem_Click);
            // 
            // pobierzDGVZPlikuToolStripMenuItem
            // 
            this.pobierzDGVZPlikuToolStripMenuItem.Name = "pobierzDGVZPlikuToolStripMenuItem";
            this.pobierzDGVZPlikuToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.pobierzDGVZPlikuToolStripMenuItem.Text = "Otworz plik DGV";
            this.pobierzDGVZPlikuToolStripMenuItem.Click += new System.EventHandler(this.pobierzDGVZPlikuToolStripMenuItem_Click);
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.kontrolkaDGVToolStripMenuItem, this.kontrolkaChartToolStripMenuItem });
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.plikToolStripMenuItem.Text = "Formatowanie";
            // 
            // kontrolkaDGVToolStripMenuItem
            // 
            this.kontrolkaDGVToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.zmianaFormatuCzcionkiToolStripMenuItem, this.zmianaKoloruCzcionkiToolStripMenuItem, this.zmianaKoloruSiatkiToolStripMenuItem, this.zmianaKoloruTlaToolStripMenuItem });
            this.kontrolkaDGVToolStripMenuItem.Name = "kontrolkaDGVToolStripMenuItem";
            this.kontrolkaDGVToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kontrolkaDGVToolStripMenuItem.Text = "Kontrolka DGV";
            // 
            // zmianaFormatuCzcionkiToolStripMenuItem
            // 
            this.zmianaFormatuCzcionkiToolStripMenuItem.Name = "zmianaFormatuCzcionkiToolStripMenuItem";
            this.zmianaFormatuCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.zmianaFormatuCzcionkiToolStripMenuItem.Text = "Zmiana formatu czcionki";
            this.zmianaFormatuCzcionkiToolStripMenuItem.Click += new System.EventHandler(this.zmianaFormatuCzcionkiToolStripMenuItem_Click);
            // 
            // zmianaKoloruCzcionkiToolStripMenuItem
            // 
            this.zmianaKoloruCzcionkiToolStripMenuItem.Name = "zmianaKoloruCzcionkiToolStripMenuItem";
            this.zmianaKoloruCzcionkiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.zmianaKoloruCzcionkiToolStripMenuItem.Text = "Zmiana koloru czcionki";
            this.zmianaKoloruCzcionkiToolStripMenuItem.Click += new System.EventHandler(this.zmianaKoloruCzcionkiToolStripMenuItem_Click);
            // 
            // zmianaKoloruSiatkiToolStripMenuItem
            // 
            this.zmianaKoloruSiatkiToolStripMenuItem.Name = "zmianaKoloruSiatkiToolStripMenuItem";
            this.zmianaKoloruSiatkiToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.zmianaKoloruSiatkiToolStripMenuItem.Text = "Zmiana koloru siatki";
            this.zmianaKoloruSiatkiToolStripMenuItem.Click += new System.EventHandler(this.zmianaKoloruSiatkiToolStripMenuItem_Click);
            // 
            // zmianaKoloruTlaToolStripMenuItem
            // 
            this.zmianaKoloruTlaToolStripMenuItem.Name = "zmianaKoloruTlaToolStripMenuItem";
            this.zmianaKoloruTlaToolStripMenuItem.Size = new System.Drawing.Size(206, 22);
            this.zmianaKoloruTlaToolStripMenuItem.Text = "Zmiana koloru tla";
            this.zmianaKoloruTlaToolStripMenuItem.Click += new System.EventHandler(this.zmianaKoloruTlaToolStripMenuItem_Click);
            // 
            // kontrolkaChartToolStripMenuItem
            // 
            this.kontrolkaChartToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.zmianaKoloruMiniWykresuToolStripMenuItem, this.zmianaFormatuToolStripMenuItem, this.zmianaStyluToolStripMenuItem });
            this.kontrolkaChartToolStripMenuItem.Name = "kontrolkaChartToolStripMenuItem";
            this.kontrolkaChartToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.kontrolkaChartToolStripMenuItem.Text = "Kontrolka Chart";
            // 
            // zmianaKoloruMiniWykresuToolStripMenuItem
            // 
            this.zmianaKoloruMiniWykresuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { this.liniiToolStripMenuItem, this.siatkiToolStripMenuItem, this.tlaToolStripMenuItem, this.tekstuToolStripMenuItem });
            this.zmianaKoloruMiniWykresuToolStripMenuItem.Name = "zmianaKoloruMiniWykresuToolStripMenuItem";
            this.zmianaKoloruMiniWykresuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zmianaKoloruMiniWykresuToolStripMenuItem.Text = "Zmiana koloru";
            // 
            // liniiToolStripMenuItem
            // 
            this.liniiToolStripMenuItem.Name = "liniiToolStripMenuItem";
            this.liniiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.liniiToolStripMenuItem.Text = "Linii";
            this.liniiToolStripMenuItem.Click += new System.EventHandler(this.liniiToolStripMenuItem_Click);
            // 
            // siatkiToolStripMenuItem
            // 
            this.siatkiToolStripMenuItem.Name = "siatkiToolStripMenuItem";
            this.siatkiToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.siatkiToolStripMenuItem.Text = "Siatki";
            this.siatkiToolStripMenuItem.Click += new System.EventHandler(this.siatkiToolStripMenuItem_Click);
            // 
            // tlaToolStripMenuItem
            // 
            this.tlaToolStripMenuItem.Name = "tlaToolStripMenuItem";
            this.tlaToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.tlaToolStripMenuItem.Text = "Tla";
            this.tlaToolStripMenuItem.Click += new System.EventHandler(this.tlaToolStripMenuItem_Click);
            // 
            // tekstuToolStripMenuItem
            // 
            this.tekstuToolStripMenuItem.Name = "tekstuToolStripMenuItem";
            this.tekstuToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.tekstuToolStripMenuItem.Text = "Tekstu";
            this.tekstuToolStripMenuItem.Click += new System.EventHandler(this.tekstuToolStripMenuItem_Click);
            // 
            // zmianaFormatuToolStripMenuItem
            // 
            this.zmianaFormatuToolStripMenuItem.Name = "zmianaFormatuToolStripMenuItem";
            this.zmianaFormatuToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zmianaFormatuToolStripMenuItem.Text = "Zmiana czcionki";
            this.zmianaFormatuToolStripMenuItem.Click += new System.EventHandler(this.zmianaFormatuToolStripMenuItem_Click);
            // 
            // zmianaStyluToolStripMenuItem
            // 
            this.zmianaStyluToolStripMenuItem.Name = "zmianaStyluToolStripMenuItem";
            this.zmianaStyluToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.zmianaStyluToolStripMenuItem.Text = "Zmiana stylu linii";
            this.zmianaStyluToolStripMenuItem.Click += new System.EventHandler(this.zmianaStyluToolStripMenuItem_Click);
            // 
            // bpErrorProviderBtnWykresFx
            // 
            this.bpErrorProviderBtnWykresFx.ContainerControl = this;
            // 
            // bpAnalizatorLaboratoryjny
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 541);
            this.Controls.Add(this.bpWykresFx);
            this.Controls.Add(this.bpBtnWizualizacjaGraficzna);
            this.Controls.Add(this.bpTableValues);
            this.Controls.Add(this.bpBtnShowTableButton);
            this.Controls.Add(this.bpDgvFunkcjiFx);
            this.Controls.Add(this.bpBtnSubmit);
            this.Controls.Add(this.bpTxtResult);
            this.Controls.Add(this.bpLblResult);
            this.Controls.Add(this.bpEntryValues);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "bpAnalizatorLaboratoryjny";
            this.Text = "Analizator Laboratoryjny";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.bpAnalizatorLaboratoryjny_FormClosing);
            this.bpEntryValues.ResumeLayout(false);
            this.bpEntryValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnOblicz)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpDgvFunkcjiFx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnShowTable)).EndInit();
            this.bpTableValues.ResumeLayout(false);
            this.bpTableValues.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpWykresFx)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bpErrorProviderBtnWykresFx)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.ToolStripMenuItem tekstuToolStripMenuItem;

        private System.Windows.Forms.ErrorProvider bpErrorProviderBtnWykresFx;

        private System.Windows.Forms.ToolStripMenuItem liniiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem siatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tlaToolStripMenuItem;

        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem zapiszDGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pobierzDGVZPlikuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolkaDGVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaFormatuCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaKoloruCzcionkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaKoloruSiatkiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaKoloruTlaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kontrolkaChartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaKoloruMiniWykresuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaFormatuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zmianaStyluToolStripMenuItem;

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;

        private System.Windows.Forms.Button bpBtnWizualizacjaGraficzna;
        private System.Windows.Forms.DataVisualization.Charting.Chart bpWykresFx;

        private System.Windows.Forms.GroupBox bpTableValues;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox bpTxtH;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox bpTxtXg;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox bpTxtXd;

        private System.Windows.Forms.ErrorProvider bpErrorProviderBtnShowTable;

        private System.Windows.Forms.Button bpBtnShowTableButton;

        private System.Windows.Forms.DataGridViewTextBoxColumn WartoscFunkcjiFx;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumerPrzedzialu;
        private System.Windows.Forms.DataGridViewTextBoxColumn WartoscZmiennejX;

        public System.Windows.Forms.DataGridView bpDgvFunkcjiFx;

        private System.Windows.Forms.ErrorProvider bpErrorProviderBtnOblicz;

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.GroupBox bpEntryValues;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox bpTxtB;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox bpTxtA;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox bpTxtC;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox bpTxtX;
        public System.Windows.Forms.Label bpLblResult;
        public System.Windows.Forms.TextBox bpTxtResult;
        public System.Windows.Forms.Button bpBtnSubmit;
    }
}