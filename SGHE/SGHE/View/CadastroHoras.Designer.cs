namespace SGHE.View {
    partial class CadastroHoras {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EntradaTB = new System.Windows.Forms.MaskedTextBox();
            this.EntradaIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabalhadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasNoturnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaidaIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.SaidaTB = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(329, 176);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 21;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Saída almoço";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(184, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cadastro de horas para o funcionário:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(222, 48);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(35, 13);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "label6";
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Location = new System.Drawing.Point(222, 81);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(35, 13);
            this.labelSalario.TabIndex = 25;
            this.labelSalario.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 81);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Valor do salário:";
            // 
            // EntradaTB
            // 
            this.EntradaTB.Location = new System.Drawing.Point(42, 176);
            this.EntradaTB.Mask = "00:00";
            this.EntradaTB.Name = "EntradaTB";
            this.EntradaTB.Size = new System.Drawing.Size(34, 20);
            this.EntradaTB.TabIndex = 26;
            this.EntradaTB.ValidatingType = typeof(System.DateTime);
            // 
            // EntradaIntervalo
            // 
            this.EntradaIntervalo.Location = new System.Drawing.Point(208, 172);
            this.EntradaIntervalo.Mask = "00:00";
            this.EntradaIntervalo.Name = "EntradaIntervalo";
            this.EntradaIntervalo.Size = new System.Drawing.Size(34, 20);
            this.EntradaIntervalo.TabIndex = 27;
            this.EntradaIntervalo.ValidatingType = typeof(System.DateTime);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(329, 146);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 31;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(426, 37);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.HorasTrabalhadas,
            this.HorasExtras,
            this.HorasNoturnas});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.Location = new System.Drawing.Point(42, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(444, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // Data
            // 
            this.Data.HeaderText = "Data";
            this.Data.Name = "Data";
            // 
            // HorasTrabalhadas
            // 
            this.HorasTrabalhadas.HeaderText = "Horas Trabalhadas";
            this.HorasTrabalhadas.Name = "HorasTrabalhadas";
            // 
            // HorasExtras
            // 
            this.HorasExtras.HeaderText = "Horas Extras";
            this.HorasExtras.Name = "HorasExtras";
            // 
            // HorasNoturnas
            // 
            this.HorasNoturnas.HeaderText = "Horas Noturnas";
            this.HorasNoturnas.Name = "HorasNoturnas";
            // 
            // SaidaIntervalo
            // 
            this.SaidaIntervalo.Location = new System.Drawing.Point(261, 172);
            this.SaidaIntervalo.Mask = "00:00";
            this.SaidaIntervalo.Name = "SaidaIntervalo";
            this.SaidaIntervalo.Size = new System.Drawing.Size(34, 20);
            this.SaidaIntervalo.TabIndex = 34;
            this.SaidaIntervalo.ValidatingType = typeof(System.DateTime);
            // 
            // SaidaTB
            // 
            this.SaidaTB.Location = new System.Drawing.Point(114, 172);
            this.SaidaTB.Mask = "00:00";
            this.SaidaTB.Name = "SaidaTB";
            this.SaidaTB.Size = new System.Drawing.Size(34, 20);
            this.SaidaTB.TabIndex = 35;
            this.SaidaTB.ValidatingType = typeof(System.DateTime);
            // 
            // CadastroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.SaidaTB);
            this.Controls.Add(this.SaidaIntervalo);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.EntradaIntervalo);
            this.Controls.Add(this.EntradaTB);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CadastroHoras";
            this.Size = new System.Drawing.Size(662, 483);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.Label labelSalario;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox EntradaTB;
        private System.Windows.Forms.MaskedTextBox EntradaIntervalo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabalhadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasNoturnas;
        private System.Windows.Forms.MaskedTextBox SaidaIntervalo;
        private System.Windows.Forms.MaskedTextBox SaidaTB;
    }
}
