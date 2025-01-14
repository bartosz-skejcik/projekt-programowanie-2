namespace Projekt2_Paczesny_72541
{
    partial class KokpitProjektuNr2
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
            this.label1 = new System.Windows.Forms.Label();
            this.bpAnalizatorLaboratoryjny = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(684, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Analizator tabelaryczny i graficzny funkcji matematycznej\r\nw określonym przedzial" + "e zmian wartości zmiennej niezależnej X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bpAnalizatorLaboratoryjny
            // 
            this.bpAnalizatorLaboratoryjny.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.bpAnalizatorLaboratoryjny.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bpAnalizatorLaboratoryjny.Location = new System.Drawing.Point(164, 314);
            this.bpAnalizatorLaboratoryjny.Name = "bpAnalizatorLaboratoryjny";
            this.bpAnalizatorLaboratoryjny.Size = new System.Drawing.Size(156, 56);
            this.bpAnalizatorLaboratoryjny.TabIndex = 1;
            this.bpAnalizatorLaboratoryjny.Text = "Analizator laboratoryjny";
            this.bpAnalizatorLaboratoryjny.UseVisualStyleBackColor = false;
            this.bpAnalizatorLaboratoryjny.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(501, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 56);
            this.button2.TabIndex = 2;
            this.button2.Text = "Analizator indywidualny";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // KokpitProjektuNr2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bpAnalizatorLaboratoryjny);
            this.Controls.Add(this.label1);
            this.Name = "KokpitProjektuNr2";
            this.Text = "Kokpit Projektu Nr2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KokpitProjektuNr2_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bpAnalizatorLaboratoryjny;
        private System.Windows.Forms.Button button2;
    }
}

