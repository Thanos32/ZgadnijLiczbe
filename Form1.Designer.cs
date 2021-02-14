
namespace ZgadnijLiczbe
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.Rekord = new System.Windows.Forms.TextBox();
            this.LiczbaProb = new System.Windows.Forms.TextBox();
            this.Srednia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ZgadnijBtn = new System.Windows.Forms.Button();
            this.LiczbaOutput = new System.Windows.Forms.TextBox();
            this.LiczbaInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DlugoscSlowa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ZgadnijBtn2 = new System.Windows.Forms.Button();
            this.SlowoOutput = new System.Windows.Forms.TextBox();
            this.SlowoInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.zresetujToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label7 = new System.Windows.Forms.Label();
            this.OstatnieSlowo = new System.Windows.Forms.TextBox();
            this.OdpowiedzBtn = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(796, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.Rekord);
            this.tabPage1.Controls.Add(this.LiczbaProb);
            this.tabPage1.Controls.Add(this.Srednia);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.ZgadnijBtn);
            this.tabPage1.Controls.Add(this.LiczbaOutput);
            this.tabPage1.Controls.Add(this.LiczbaInput);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(788, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Zgadnij liczbę";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // Rekord
            // 
            this.Rekord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Rekord.Location = new System.Drawing.Point(375, 303);
            this.Rekord.Multiline = true;
            this.Rekord.Name = "Rekord";
            this.Rekord.ReadOnly = true;
            this.Rekord.Size = new System.Drawing.Size(111, 40);
            this.Rekord.TabIndex = 9;
            this.Rekord.Text = "brak danych";
            this.Rekord.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // LiczbaProb
            // 
            this.LiczbaProb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.LiczbaProb.Location = new System.Drawing.Point(55, 303);
            this.LiczbaProb.Multiline = true;
            this.LiczbaProb.Name = "LiczbaProb";
            this.LiczbaProb.ReadOnly = true;
            this.LiczbaProb.Size = new System.Drawing.Size(114, 40);
            this.LiczbaProb.TabIndex = 8;
            this.LiczbaProb.Text = "0";
            this.LiczbaProb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Srednia
            // 
            this.Srednia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Srednia.Location = new System.Drawing.Point(542, 303);
            this.Srednia.Multiline = true;
            this.Srednia.Name = "Srednia";
            this.Srednia.ReadOnly = true;
            this.Srednia.Size = new System.Drawing.Size(111, 40);
            this.Srednia.TabIndex = 7;
            this.Srednia.Text = "brak danych";
            this.Srednia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label5.Location = new System.Drawing.Point(397, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 22);
            this.label5.TabIndex = 6;
            this.label5.Text = "Rekord:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label4.Location = new System.Drawing.Point(51, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Liczba strzałów:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.label3.Location = new System.Drawing.Point(556, 264);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 22);
            this.label3.TabIndex = 4;
            this.label3.Text = "Średnia:";
            // 
            // ZgadnijBtn
            // 
            this.ZgadnijBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZgadnijBtn.Location = new System.Drawing.Point(130, 162);
            this.ZgadnijBtn.Name = "ZgadnijBtn";
            this.ZgadnijBtn.Size = new System.Drawing.Size(161, 43);
            this.ZgadnijBtn.TabIndex = 3;
            this.ZgadnijBtn.Text = "Zgadnij";
            this.ZgadnijBtn.UseVisualStyleBackColor = true;
            this.ZgadnijBtn.Click += new System.EventHandler(this.ZgadnijBtn_Click);
            // 
            // LiczbaOutput
            // 
            this.LiczbaOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.LiczbaOutput.Location = new System.Drawing.Point(446, 58);
            this.LiczbaOutput.Multiline = true;
            this.LiczbaOutput.Name = "LiczbaOutput";
            this.LiczbaOutput.ReadOnly = true;
            this.LiczbaOutput.Size = new System.Drawing.Size(272, 133);
            this.LiczbaOutput.TabIndex = 2;
            this.LiczbaOutput.TextChanged += new System.EventHandler(this.LiczbaOutput_TextChanged);
            // 
            // LiczbaInput
            // 
            this.LiczbaInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.LiczbaInput.Location = new System.Drawing.Point(79, 96);
            this.LiczbaInput.Multiline = true;
            this.LiczbaInput.Name = "LiczbaInput";
            this.LiczbaInput.Size = new System.Drawing.Size(274, 60);
            this.LiczbaInput.TabIndex = 1;
            this.LiczbaInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LiczbaInput.TextChanged += new System.EventHandler(this.LiczbaInput_TextChanged);
            this.LiczbaInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.LiczbaInput_KeyDown);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.Location = new System.Drawing.Point(74, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(296, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "Wpisz liczbę całkowitą większą od 0 i mniejszą od 1000.";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.OdpowiedzBtn);
            this.tabPage2.Controls.Add(this.OstatnieSlowo);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.DlugoscSlowa);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ZgadnijBtn2);
            this.tabPage2.Controls.Add(this.SlowoOutput);
            this.tabPage2.Controls.Add(this.SlowoInput);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(788, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zgadnij słowo";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DlugoscSlowa
            // 
            this.DlugoscSlowa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.DlugoscSlowa.Location = new System.Drawing.Point(616, 41);
            this.DlugoscSlowa.Multiline = true;
            this.DlugoscSlowa.Name = "DlugoscSlowa";
            this.DlugoscSlowa.ReadOnly = true;
            this.DlugoscSlowa.Size = new System.Drawing.Size(65, 39);
            this.DlugoscSlowa.TabIndex = 5;
            this.DlugoscSlowa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label6.Location = new System.Drawing.Point(461, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(149, 25);
            this.label6.TabIndex = 4;
            this.label6.Text = "Długość słowa: ";
            // 
            // ZgadnijBtn2
            // 
            this.ZgadnijBtn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.ZgadnijBtn2.Location = new System.Drawing.Point(123, 196);
            this.ZgadnijBtn2.Name = "ZgadnijBtn2";
            this.ZgadnijBtn2.Size = new System.Drawing.Size(161, 53);
            this.ZgadnijBtn2.TabIndex = 3;
            this.ZgadnijBtn2.Text = "Zgadnij";
            this.ZgadnijBtn2.UseVisualStyleBackColor = true;
            this.ZgadnijBtn2.Click += new System.EventHandler(this.ZgadnijBtn2_Click);
            // 
            // SlowoOutput
            // 
            this.SlowoOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SlowoOutput.Location = new System.Drawing.Point(466, 110);
            this.SlowoOutput.Multiline = true;
            this.SlowoOutput.Name = "SlowoOutput";
            this.SlowoOutput.ReadOnly = true;
            this.SlowoOutput.Size = new System.Drawing.Size(215, 104);
            this.SlowoOutput.TabIndex = 2;
            this.SlowoOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // SlowoInput
            // 
            this.SlowoInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.SlowoInput.Location = new System.Drawing.Point(65, 110);
            this.SlowoInput.Multiline = true;
            this.SlowoInput.Name = "SlowoInput";
            this.SlowoInput.Size = new System.Drawing.Size(296, 67);
            this.SlowoInput.TabIndex = 1;
            this.SlowoInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SlowoInput.TextChanged += new System.EventHandler(this.SlowoInput_TextChanged);
            this.SlowoInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SlowoInput_KeyDown);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.Location = new System.Drawing.Point(60, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 57);
            this.label2.TabIndex = 0;
            this.label2.Text = "Wpisz losowe słowo. Prawidłowo odgadnięte litery pojawią się obok.";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zresetujToolStripMenuItem,
            this.autorToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(117, 48);
            // 
            // zresetujToolStripMenuItem
            // 
            this.zresetujToolStripMenuItem.Name = "zresetujToolStripMenuItem";
            this.zresetujToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.zresetujToolStripMenuItem.Text = "Zresetuj";
            this.zresetujToolStripMenuItem.Click += new System.EventHandler(this.zresetujToolStripMenuItem_Click);
            // 
            // autorToolStripMenuItem
            // 
            this.autorToolStripMenuItem.Name = "autorToolStripMenuItem";
            this.autorToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.autorToolStripMenuItem.Text = "Autor";
            this.autorToolStripMenuItem.Click += new System.EventHandler(this.autorToolStripMenuItem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.label7.Location = new System.Drawing.Point(134, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(165, 18);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ostatnio podane słowo:";
            // 
            // OstatnieSlowo
            // 
            this.OstatnieSlowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.OstatnieSlowo.Location = new System.Drawing.Point(84, 328);
            this.OstatnieSlowo.Multiline = true;
            this.OstatnieSlowo.Name = "OstatnieSlowo";
            this.OstatnieSlowo.ReadOnly = true;
            this.OstatnieSlowo.Size = new System.Drawing.Size(257, 55);
            this.OstatnieSlowo.TabIndex = 7;
            this.OstatnieSlowo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OdpowiedzBtn
            // 
            this.OdpowiedzBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.OdpowiedzBtn.Location = new System.Drawing.Point(524, 293);
            this.OdpowiedzBtn.Name = "OdpowiedzBtn";
            this.OdpowiedzBtn.Size = new System.Drawing.Size(144, 42);
            this.OdpowiedzBtn.TabIndex = 8;
            this.OdpowiedzBtn.Text = "Podpowiedź";
            this.OdpowiedzBtn.UseVisualStyleBackColor = true;
            this.OdpowiedzBtn.Click += new System.EventHandler(this.OdpowiedzBtn_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(387, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(378, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Klikając prawym przyciskiem i naciskając Zrestestuj możesz wybrać inne słowo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 450);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.tabControl1);
            this.MaximumSize = new System.Drawing.Size(1100, 650);
            this.MinimumSize = new System.Drawing.Size(812, 489);
            this.Name = "Form1";
            this.Text = "Witaj podróżniku";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox LiczbaOutput;
        private System.Windows.Forms.TextBox LiczbaInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox SlowoOutput;
        private System.Windows.Forms.TextBox SlowoInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ZgadnijBtn;
        private System.Windows.Forms.TextBox Rekord;
        private System.Windows.Forms.TextBox LiczbaProb;
        private System.Windows.Forms.TextBox Srednia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ZgadnijBtn2;
        private System.Windows.Forms.TextBox DlugoscSlowa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zresetujToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorToolStripMenuItem;
        private System.Windows.Forms.TextBox OstatnieSlowo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button OdpowiedzBtn;
        private System.Windows.Forms.Label label8;
    }
}

