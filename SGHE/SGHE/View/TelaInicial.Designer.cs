namespace SGHE {
    partial class SGHE {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.manipularFeriadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manipularFeriadosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.manipularFeriadosToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarCadastroHoraExtraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarNovoFuncionárioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manipularFeriadosToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 26);
            // 
            // manipularFeriadosToolStripMenuItem
            // 
            this.manipularFeriadosToolStripMenuItem.Name = "manipularFeriadosToolStripMenuItem";
            this.manipularFeriadosToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.manipularFeriadosToolStripMenuItem.Text = "Manipular Feriados";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarCadastroHoraExtraToolStripMenuItem,
            this.manipularFeriadosToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 24);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manipularFeriadosToolStripMenuItem1
            // 
            this.manipularFeriadosToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manipularFeriadosToolStripMenuItem2});
            this.manipularFeriadosToolStripMenuItem1.Name = "manipularFeriadosToolStripMenuItem1";
            this.manipularFeriadosToolStripMenuItem1.Size = new System.Drawing.Size(63, 20);
            this.manipularFeriadosToolStripMenuItem1.Text = "Feriados";
            // 
            // manipularFeriadosToolStripMenuItem2
            // 
            this.manipularFeriadosToolStripMenuItem2.Name = "manipularFeriadosToolStripMenuItem2";
            this.manipularFeriadosToolStripMenuItem2.Size = new System.Drawing.Size(175, 22);
            this.manipularFeriadosToolStripMenuItem2.Text = "Manipular Feriados";
            this.manipularFeriadosToolStripMenuItem2.Click += new System.EventHandler(this.manipularFeriadosToolStripMenuItem2_Click);
            // 
            // realizarCadastroHoraExtraToolStripMenuItem
            // 
            this.realizarCadastroHoraExtraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarNovoFuncionárioToolStripMenuItem});
            this.realizarCadastroHoraExtraToolStripMenuItem.Name = "realizarCadastroHoraExtraToolStripMenuItem";
            this.realizarCadastroHoraExtraToolStripMenuItem.Size = new System.Drawing.Size(166, 20);
            this.realizarCadastroHoraExtraToolStripMenuItem.Text = "Realizar Cadastro Hora extra";
            // 
            // cadastrarNovoFuncionárioToolStripMenuItem
            // 
            this.cadastrarNovoFuncionárioToolStripMenuItem.Name = "cadastrarNovoFuncionárioToolStripMenuItem";
            this.cadastrarNovoFuncionárioToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.cadastrarNovoFuncionárioToolStripMenuItem.Text = "Cadastrar novo funcionário";
            this.cadastrarNovoFuncionárioToolStripMenuItem.Click += new System.EventHandler(this.cadastrarNovoFuncionárioToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(663, 414);
            this.panel1.TabIndex = 13;
            this.panel1.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.panel1_ControlRemoved);
            // 
            // SGHE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(666, 440);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SGHE";
            this.Text = "SGHE";
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manipularFeriadosToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manipularFeriadosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem manipularFeriadosToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem realizarCadastroHoraExtraToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem cadastrarNovoFuncionárioToolStripMenuItem;
    }
}

