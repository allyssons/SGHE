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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.labelSalario = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.EntradaTB = new System.Windows.Forms.MaskedTextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.SaidaIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.EntradaIntervalo = new System.Windows.Forms.MaskedTextBox();
            this.SaidaTB = new System.Windows.Forms.MaskedTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasTrabalhadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasExtras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasNoturnas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorasCompensadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(588, 412);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 48);
            this.button2.TabIndex = 21;
            this.button2.Text = "Finalizar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(196, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Saída";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(235, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Cadastro de horas para o funcionário:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNome.Location = new System.Drawing.Point(286, 18);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(79, 18);
            this.labelNome.TabIndex = 23;
            this.labelNome.Text = "nomeLabel";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // labelSalario
            // 
            this.labelSalario.AutoSize = true;
            this.labelSalario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSalario.Location = new System.Drawing.Point(286, 55);
            this.labelSalario.Name = "labelSalario";
            this.labelSalario.Size = new System.Drawing.Size(46, 18);
            this.labelSalario.TabIndex = 25;
            this.labelSalario.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 17);
            this.label7.TabIndex = 24;
            this.label7.Text = "Valor do salário:";
            // 
            // EntradaTB
            // 
            this.EntradaTB.Location = new System.Drawing.Point(37, 32);
            this.EntradaTB.Mask = "00:00";
            this.EntradaTB.Name = "EntradaTB";
            this.EntradaTB.Size = new System.Drawing.Size(34, 20);
            this.EntradaTB.TabIndex = 26;
            this.EntradaTB.ValidatingType = typeof(System.DateTime);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.monthCalendar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.monthCalendar1.Location = new System.Drawing.Point(501, 119);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 32;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Data,
            this.HorasTrabalhadas,
            this.HorasExtras,
            this.HorasNoturnas,
            this.HorasCompensadas});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.Location = new System.Drawing.Point(28, 310);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(543, 150);
            this.dataGridView1.TabIndex = 33;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.SaidaIntervalo);
            this.panel1.Controls.Add(this.EntradaIntervalo);
            this.panel1.Controls.Add(this.SaidaTB);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.EntradaTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(28, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(445, 174);
            this.panel1.TabIndex = 36;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(302, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 48);
            this.button1.TabIndex = 46;
            this.button1.Text = "Salvar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // SaidaIntervalo
            // 
            this.SaidaIntervalo.Location = new System.Drawing.Point(199, 124);
            this.SaidaIntervalo.Mask = "00:00";
            this.SaidaIntervalo.Name = "SaidaIntervalo";
            this.SaidaIntervalo.Size = new System.Drawing.Size(34, 20);
            this.SaidaIntervalo.TabIndex = 45;
            this.SaidaIntervalo.ValidatingType = typeof(System.DateTime);
            // 
            // EntradaIntervalo
            // 
            this.EntradaIntervalo.Location = new System.Drawing.Point(37, 124);
            this.EntradaIntervalo.Mask = "00:00";
            this.EntradaIntervalo.Name = "EntradaIntervalo";
            this.EntradaIntervalo.Size = new System.Drawing.Size(34, 20);
            this.EntradaIntervalo.TabIndex = 44;
            this.EntradaIntervalo.ValidatingType = typeof(System.DateTime);
            // 
            // SaidaTB
            // 
            this.SaidaTB.Location = new System.Drawing.Point(199, 32);
            this.SaidaTB.Mask = "00:00";
            this.SaidaTB.Name = "SaidaTB";
            this.SaidaTB.Size = new System.Drawing.Size(34, 20);
            this.SaidaTB.TabIndex = 43;
            this.SaidaTB.ValidatingType = typeof(System.DateTime);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label8.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(164, 104);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 17);
            this.label8.TabIndex = 39;
            this.label8.Text = "Saída Intervalo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Font = new System.Drawing.Font("Modern No. 20", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "Entrada Intervalo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(211, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(215, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "intervalo durante a jornada de trabalho";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Preencha os campos abaixo caso houve ";
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
            // HorasCompensadas
            // 
            this.HorasCompensadas.HeaderText = "Horas Compensadas";
            this.HorasCompensadas.Name = "HorasCompensadas";
            // 
            // CadastroHoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.labelSalario);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel1);
            this.Name = "CadastroHoras";
            this.Size = new System.Drawing.Size(751, 486);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox SaidaIntervalo;
        private System.Windows.Forms.MaskedTextBox EntradaIntervalo;
        private System.Windows.Forms.MaskedTextBox SaidaTB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasTrabalhadas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasExtras;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasNoturnas;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorasCompensadas;
    }
}
