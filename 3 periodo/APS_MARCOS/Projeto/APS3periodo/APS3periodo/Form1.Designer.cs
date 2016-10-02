namespace APS3periodo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cBoxMetOrd = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.pBarOrd = new System.Windows.Forms.ProgressBar();
            this.lblOrdProgress = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.rb1M = new System.Windows.Forms.RadioButton();
            this.rb100k = new System.Windows.Forms.RadioButton();
            this.rb10k = new System.Windows.Forms.RadioButton();
            this.rb1000 = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblResutBusca = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBusca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblNomeLista = new System.Windows.Forms.Label();
            this.btnPreencheLista = new System.Windows.Forms.Button();
            this.bwOrdenacao = new System.ComponentModel.BackgroundWorker();
            this.OrdList = new System.Windows.Forms.ListBox();
            this.btnListar = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cBoxMetOrd
            // 
            this.cBoxMetOrd.FormattingEnabled = true;
            this.cBoxMetOrd.Items.AddRange(new object[] {
            "Bubble Sort",
            "Selection-Sort",
            "Quick-Sort"});
            this.cBoxMetOrd.Location = new System.Drawing.Point(9, 39);
            this.cBoxMetOrd.Name = "cBoxMetOrd";
            this.cBoxMetOrd.Size = new System.Drawing.Size(163, 21);
            this.cBoxMetOrd.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Método de ordenação";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnOrdenar.Location = new System.Drawing.Point(9, 82);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 2;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // pBarOrd
            // 
            this.pBarOrd.Location = new System.Drawing.Point(9, 147);
            this.pBarOrd.Name = "pBarOrd";
            this.pBarOrd.Size = new System.Drawing.Size(280, 23);
            this.pBarOrd.TabIndex = 3;
            this.pBarOrd.Tag = "progresso";
            // 
            // lblOrdProgress
            // 
            this.lblOrdProgress.AutoSize = true;
            this.lblOrdProgress.Location = new System.Drawing.Point(9, 123);
            this.lblOrdProgress.Name = "lblOrdProgress";
            this.lblOrdProgress.Size = new System.Drawing.Size(57, 13);
            this.lblOrdProgress.TabIndex = 4;
            this.lblOrdProgress.Text = "Progresso:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 23);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(361, 235);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.rb1M);
            this.tabPage1.Controls.Add(this.rb100k);
            this.tabPage1.Controls.Add(this.rb10k);
            this.tabPage1.Controls.Add(this.rb1000);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblOrdProgress);
            this.tabPage1.Controls.Add(this.pBarOrd);
            this.tabPage1.Controls.Add(this.cBoxMetOrd);
            this.tabPage1.Controls.Add(this.btnOrdenar);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(353, 209);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ordenação";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // rb1M
            // 
            this.rb1M.AutoSize = true;
            this.rb1M.Location = new System.Drawing.Point(227, 112);
            this.rb1M.Name = "rb1M";
            this.rb1M.Size = new System.Drawing.Size(65, 17);
            this.rb1M.TabIndex = 8;
            this.rb1M.TabStop = true;
            this.rb1M.Text = "1M itens";
            this.rb1M.UseVisualStyleBackColor = true;
            this.rb1M.Visible = false;
            // 
            // rb100k
            // 
            this.rb100k.AutoSize = true;
            this.rb100k.Location = new System.Drawing.Point(227, 88);
            this.rb100k.Name = "rb100k";
            this.rb100k.Size = new System.Drawing.Size(74, 17);
            this.rb100k.TabIndex = 7;
            this.rb100k.Text = "100k itens";
            this.rb100k.UseVisualStyleBackColor = true;
            // 
            // rb10k
            // 
            this.rb10k.AutoSize = true;
            this.rb10k.Location = new System.Drawing.Point(227, 62);
            this.rb10k.Name = "rb10k";
            this.rb10k.Size = new System.Drawing.Size(68, 17);
            this.rb10k.TabIndex = 6;
            this.rb10k.Text = "10k itens";
            this.rb10k.UseVisualStyleBackColor = true;
            // 
            // rb1000
            // 
            this.rb1000.AutoSize = true;
            this.rb1000.Checked = true;
            this.rb1000.Location = new System.Drawing.Point(227, 39);
            this.rb1000.Name = "rb1000";
            this.rb1000.Size = new System.Drawing.Size(62, 17);
            this.rb1000.TabIndex = 5;
            this.rb1000.TabStop = true;
            this.rb1000.Text = "1k itens";
            this.rb1000.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblResutBusca);
            this.tabPage2.Controls.Add(this.btnBuscar);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.txtBusca);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(353, 209);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Busca";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblResutBusca
            // 
            this.lblResutBusca.AutoSize = true;
            this.lblResutBusca.Location = new System.Drawing.Point(16, 98);
            this.lblResutBusca.Name = "lblResutBusca";
            this.lblResutBusca.Size = new System.Drawing.Size(0, 13);
            this.lblResutBusca.TabIndex = 3;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(146, 39);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Digite o número do item";
            // 
            // txtBusca
            // 
            this.txtBusca.Location = new System.Drawing.Point(16, 41);
            this.txtBusca.Name = "txtBusca";
            this.txtBusca.Size = new System.Drawing.Size(115, 20);
            this.txtBusca.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 287);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Resultado";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.DarkGray;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 413);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(525, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(43, 17);
            this.toolStripStatusLabel1.Text = "Pronto";
            // 
            // lblNomeLista
            // 
            this.lblNomeLista.AutoSize = true;
            this.lblNomeLista.Location = new System.Drawing.Point(402, 23);
            this.lblNomeLista.Name = "lblNomeLista";
            this.lblNomeLista.Size = new System.Drawing.Size(29, 13);
            this.lblNomeLista.TabIndex = 9;
            this.lblNomeLista.Text = "Lista";
            // 
            // btnPreencheLista
            // 
            this.btnPreencheLista.Location = new System.Drawing.Point(405, 374);
            this.btnPreencheLista.Name = "btnPreencheLista";
            this.btnPreencheLista.Size = new System.Drawing.Size(75, 23);
            this.btnPreencheLista.TabIndex = 12;
            this.btnPreencheLista.Text = "Embaralhar";
            this.btnPreencheLista.UseVisualStyleBackColor = true;
            this.btnPreencheLista.Click += new System.EventHandler(this.btnPreencheLista_Click);
            // 
            // bwOrdenacao
            // 
            this.bwOrdenacao.WorkerReportsProgress = true;
            this.bwOrdenacao.WorkerSupportsCancellation = true;
            this.bwOrdenacao.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwOrdenacao_DoWork);
            this.bwOrdenacao.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bwOrdenacao_ProgressChanged);
            this.bwOrdenacao.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bwOrdenacao_RunWorkerCompleted);
            // 
            // OrdList
            // 
            this.OrdList.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.OrdList.FormattingEnabled = true;
            this.OrdList.Location = new System.Drawing.Point(405, 39);
            this.OrdList.MultiColumn = true;
            this.OrdList.Name = "OrdList";
            this.OrdList.Size = new System.Drawing.Size(98, 316);
            this.OrdList.TabIndex = 13;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(294, 277);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(75, 23);
            this.btnListar.TabIndex = 15;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.richTextBox1.ForeColor = System.Drawing.Color.Lime;
            this.richTextBox1.Location = new System.Drawing.Point(12, 306);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBox1.Size = new System.Drawing.Size(357, 96);
            this.richTextBox1.TabIndex = 16;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(525, 435);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.OrdList);
            this.Controls.Add(this.btnPreencheLista);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.lblNomeLista);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(541, 474);
            this.MinimumSize = new System.Drawing.Size(541, 474);
            this.Name = "Form1";
            this.Text = "APS 3º Periodo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBoxMetOrd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.ProgressBar pBarOrd;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBusca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblNomeLista;
        private System.Windows.Forms.Button btnPreencheLista;
        public System.Windows.Forms.Label lblOrdProgress;
        private System.Windows.Forms.ListBox OrdList;
        private System.Windows.Forms.Label lblResutBusca;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.RadioButton rb100k;
        private System.Windows.Forms.RadioButton rb10k;
        private System.Windows.Forms.RadioButton rb1000;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RadioButton rb1M;
        public System.ComponentModel.BackgroundWorker bwOrdenacao;
    }
}

