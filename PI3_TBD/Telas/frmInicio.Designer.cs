﻿namespace MVC
{
    partial class frmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmInicio));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.panCadastrar = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQuestoesC = new System.Windows.Forms.Button();
            this.btnAreasC = new System.Windows.Forms.Button();
            this.btnAssuntosC = new System.Windows.Forms.Button();
            this.btnEventosC = new System.Windows.Forms.Button();
            this.btnProfessoresC = new System.Windows.Forms.Button();
            this.btnProfessoresP = new System.Windows.Forms.Button();
            this.btnEventosP = new System.Windows.Forms.Button();
            this.btnAssuntoP = new System.Windows.Forms.Button();
            this.btnAreasP = new System.Windows.Forms.Button();
            this.btnQuestoesP = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panPesquisa = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panCadastrar.SuspendLayout();
            this.panPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(770, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(77, 25);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 25);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(49, 25);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.Controls.Add(this.btnPesquisar);
            this.panel1.Controls.Add(this.btnCadastrar);
            this.panel1.Location = new System.Drawing.Point(12, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(122, 443);
            this.panel1.TabIndex = 1;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesquisar.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisar.Image")));
            this.btnPesquisar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPesquisar.Location = new System.Drawing.Point(3, 124);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(115, 115);
            this.btnPesquisar.TabIndex = 1;
            this.btnPesquisar.Text = "Pesquisar/Editar";
            this.btnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPesquisar.UseVisualStyleBackColor = false;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCadastrar.Location = new System.Drawing.Point(3, 3);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(115, 115);
            this.btnCadastrar.TabIndex = 0;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // panCadastrar
            // 
            this.panCadastrar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panCadastrar.Controls.Add(this.label1);
            this.panCadastrar.Controls.Add(this.btnQuestoesC);
            this.panCadastrar.Controls.Add(this.btnAreasC);
            this.panCadastrar.Controls.Add(this.btnAssuntosC);
            this.panCadastrar.Controls.Add(this.btnEventosC);
            this.panCadastrar.Controls.Add(this.btnProfessoresC);
            this.panCadastrar.Location = new System.Drawing.Point(221, 78);
            this.panCadastrar.Name = "panCadastrar";
            this.panCadastrar.Size = new System.Drawing.Size(419, 297);
            this.panCadastrar.TabIndex = 2;
            this.panCadastrar.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(167, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 24);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cadastrar";
            // 
            // btnQuestoesC
            // 
            this.btnQuestoesC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestoesC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuestoesC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestoesC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestoesC.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestoesC.Image")));
            this.btnQuestoesC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuestoesC.Location = new System.Drawing.Point(216, 54);
            this.btnQuestoesC.Name = "btnQuestoesC";
            this.btnQuestoesC.Size = new System.Drawing.Size(115, 115);
            this.btnQuestoesC.TabIndex = 6;
            this.btnQuestoesC.Text = "Questões";
            this.btnQuestoesC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuestoesC.UseVisualStyleBackColor = false;
            // 
            // btnAreasC
            // 
            this.btnAreasC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAreasC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAreasC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreasC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreasC.Image = ((System.Drawing.Image)(resources.GetObject("btnAreasC.Image")));
            this.btnAreasC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAreasC.Location = new System.Drawing.Point(162, 178);
            this.btnAreasC.Name = "btnAreasC";
            this.btnAreasC.Size = new System.Drawing.Size(115, 115);
            this.btnAreasC.TabIndex = 5;
            this.btnAreasC.Text = "Áreas";
            this.btnAreasC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAreasC.UseVisualStyleBackColor = false;
            this.btnAreasC.Click += new System.EventHandler(this.btnAreasC_Click);
            // 
            // btnAssuntosC
            // 
            this.btnAssuntosC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssuntosC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssuntosC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssuntosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssuntosC.Image = ((System.Drawing.Image)(resources.GetObject("btnAssuntosC.Image")));
            this.btnAssuntosC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssuntosC.Location = new System.Drawing.Point(95, 56);
            this.btnAssuntosC.Name = "btnAssuntosC";
            this.btnAssuntosC.Size = new System.Drawing.Size(115, 115);
            this.btnAssuntosC.TabIndex = 4;
            this.btnAssuntosC.Text = "Assuntos";
            this.btnAssuntosC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssuntosC.UseVisualStyleBackColor = false;
            this.btnAssuntosC.Click += new System.EventHandler(this.btnAssuntosC_Click);
            // 
            // btnEventosC
            // 
            this.btnEventosC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEventosC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEventosC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventosC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventosC.Image = ((System.Drawing.Image)(resources.GetObject("btnEventosC.Image")));
            this.btnEventosC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventosC.Location = new System.Drawing.Point(41, 178);
            this.btnEventosC.Name = "btnEventosC";
            this.btnEventosC.Size = new System.Drawing.Size(115, 115);
            this.btnEventosC.TabIndex = 3;
            this.btnEventosC.Text = "Eventos";
            this.btnEventosC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventosC.UseVisualStyleBackColor = false;
            // 
            // btnProfessoresC
            // 
            this.btnProfessoresC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfessoresC.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfessoresC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessoresC.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessoresC.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessoresC.Image")));
            this.btnProfessoresC.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfessoresC.Location = new System.Drawing.Point(283, 178);
            this.btnProfessoresC.Name = "btnProfessoresC";
            this.btnProfessoresC.Size = new System.Drawing.Size(115, 115);
            this.btnProfessoresC.TabIndex = 2;
            this.btnProfessoresC.Text = "Professores";
            this.btnProfessoresC.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfessoresC.UseVisualStyleBackColor = false;
            this.btnProfessoresC.Click += new System.EventHandler(this.btnProfessoresC_Click);
            // 
            // btnProfessoresP
            // 
            this.btnProfessoresP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnProfessoresP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnProfessoresP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProfessoresP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfessoresP.Image = ((System.Drawing.Image)(resources.GetObject("btnProfessoresP.Image")));
            this.btnProfessoresP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnProfessoresP.Location = new System.Drawing.Point(283, 167);
            this.btnProfessoresP.Name = "btnProfessoresP";
            this.btnProfessoresP.Size = new System.Drawing.Size(115, 115);
            this.btnProfessoresP.TabIndex = 2;
            this.btnProfessoresP.Text = "Professores";
            this.btnProfessoresP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnProfessoresP.UseVisualStyleBackColor = false;
            this.btnProfessoresP.Click += new System.EventHandler(this.btnProfessoresP_Click);
            // 
            // btnEventosP
            // 
            this.btnEventosP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEventosP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEventosP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEventosP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEventosP.Image = ((System.Drawing.Image)(resources.GetObject("btnEventosP.Image")));
            this.btnEventosP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEventosP.Location = new System.Drawing.Point(41, 167);
            this.btnEventosP.Name = "btnEventosP";
            this.btnEventosP.Size = new System.Drawing.Size(115, 115);
            this.btnEventosP.TabIndex = 3;
            this.btnEventosP.Text = "Eventos";
            this.btnEventosP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEventosP.UseVisualStyleBackColor = false;
            // 
            // btnAssuntoP
            // 
            this.btnAssuntoP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAssuntoP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAssuntoP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAssuntoP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAssuntoP.Image = ((System.Drawing.Image)(resources.GetObject("btnAssuntoP.Image")));
            this.btnAssuntoP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAssuntoP.Location = new System.Drawing.Point(41, 46);
            this.btnAssuntoP.Name = "btnAssuntoP";
            this.btnAssuntoP.Size = new System.Drawing.Size(115, 115);
            this.btnAssuntoP.TabIndex = 4;
            this.btnAssuntoP.Text = "Assuntos";
            this.btnAssuntoP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAssuntoP.UseVisualStyleBackColor = false;
            this.btnAssuntoP.Click += new System.EventHandler(this.btnAssuntoP_Click);
            // 
            // btnAreasP
            // 
            this.btnAreasP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAreasP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAreasP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAreasP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAreasP.Image = ((System.Drawing.Image)(resources.GetObject("btnAreasP.Image")));
            this.btnAreasP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAreasP.Location = new System.Drawing.Point(162, 93);
            this.btnAreasP.Name = "btnAreasP";
            this.btnAreasP.Size = new System.Drawing.Size(115, 115);
            this.btnAreasP.TabIndex = 5;
            this.btnAreasP.Text = "Áreas";
            this.btnAreasP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAreasP.UseVisualStyleBackColor = false;
            this.btnAreasP.Click += new System.EventHandler(this.btnAreasP_Click);
            // 
            // btnQuestoesP
            // 
            this.btnQuestoesP.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnQuestoesP.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnQuestoesP.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnQuestoesP.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuestoesP.Image = ((System.Drawing.Image)(resources.GetObject("btnQuestoesP.Image")));
            this.btnQuestoesP.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnQuestoesP.Location = new System.Drawing.Point(283, 46);
            this.btnQuestoesP.Name = "btnQuestoesP";
            this.btnQuestoesP.Size = new System.Drawing.Size(115, 115);
            this.btnQuestoesP.TabIndex = 6;
            this.btnQuestoesP.Text = "Questões";
            this.btnQuestoesP.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnQuestoesP.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Pesquisar";
            // 
            // panPesquisa
            // 
            this.panPesquisa.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panPesquisa.Controls.Add(this.label2);
            this.panPesquisa.Controls.Add(this.btnQuestoesP);
            this.panPesquisa.Controls.Add(this.btnAreasP);
            this.panPesquisa.Controls.Add(this.btnAssuntoP);
            this.panPesquisa.Controls.Add(this.btnEventosP);
            this.panPesquisa.Controls.Add(this.btnProfessoresP);
            this.panPesquisa.Location = new System.Drawing.Point(221, 78);
            this.panPesquisa.Name = "panPesquisa";
            this.panPesquisa.Size = new System.Drawing.Size(418, 285);
            this.panPesquisa.TabIndex = 7;
            this.panPesquisa.Visible = false;
            // 
            // frmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(770, 487);
            this.Controls.Add(this.panCadastrar);
            this.Controls.Add(this.panPesquisa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SenaQuiz";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panCadastrar.ResumeLayout(false);
            this.panCadastrar.PerformLayout();
            this.panPesquisa.ResumeLayout(false);
            this.panPesquisa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Panel panCadastrar;
        private System.Windows.Forms.Button btnAreasC;
        private System.Windows.Forms.Button btnAssuntosC;
        private System.Windows.Forms.Button btnEventosC;
        private System.Windows.Forms.Button btnProfessoresC;
        private System.Windows.Forms.Button btnQuestoesC;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProfessoresP;
        private System.Windows.Forms.Button btnEventosP;
        private System.Windows.Forms.Button btnAssuntoP;
        private System.Windows.Forms.Button btnAreasP;
        private System.Windows.Forms.Button btnQuestoesP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panPesquisa;
    }
}