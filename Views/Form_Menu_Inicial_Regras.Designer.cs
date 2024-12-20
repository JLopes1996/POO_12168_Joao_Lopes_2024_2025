namespace Jardim_Zoológico.Menu_Inicio
{
    partial class Form_Menu_Inicial_Regras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu_Inicial_Regras));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.textBox_Regras_Texto = new System.Windows.Forms.TextBox();
            this.btn_Voltar_Menu_Inicial = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label_Titulo);
            this.panel1.Controls.Add(this.btn_Voltar_Menu_Inicial);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 30);
            this.panel1.TabIndex = 27;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(181, 17);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Regras do Jardim Zoológico";
            // 
            // textBox_Regras_Texto
            // 
            this.textBox_Regras_Texto.BackColor = System.Drawing.Color.MintCream;
            this.textBox_Regras_Texto.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.textBox_Regras_Texto.Location = new System.Drawing.Point(15, 52);
            this.textBox_Regras_Texto.Multiline = true;
            this.textBox_Regras_Texto.Name = "textBox_Regras_Texto";
            this.textBox_Regras_Texto.Size = new System.Drawing.Size(350, 150);
            this.textBox_Regras_Texto.TabIndex = 28;
            // 
            // btn_Voltar_Menu_Inicial
            // 
            this.btn_Voltar_Menu_Inicial.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Voltar_Menu_Inicial.BackColor = System.Drawing.Color.White;
            this.btn_Voltar_Menu_Inicial.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Voltar_Menu_Inicial.FlatAppearance.BorderSize = 0;
            this.btn_Voltar_Menu_Inicial.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Voltar_Menu_Inicial.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_Voltar_Menu_Inicial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Voltar_Menu_Inicial.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Voltar_Menu_Inicial.ForeColor = System.Drawing.Color.Black;
            this.btn_Voltar_Menu_Inicial.Location = new System.Drawing.Point(587, 0);
            this.btn_Voltar_Menu_Inicial.Name = "btn_Voltar_Menu_Inicial";
            this.btn_Voltar_Menu_Inicial.Size = new System.Drawing.Size(58, 30);
            this.btn_Voltar_Menu_Inicial.TabIndex = 29;
            this.btn_Voltar_Menu_Inicial.Text = "Voltar";
            this.btn_Voltar_Menu_Inicial.UseVisualStyleBackColor = false;
            this.btn_Voltar_Menu_Inicial.Click += new System.EventHandler(this.btn_Voltar_Menu_Inicial_Click);
            // 
            // Form_Menu_Inicial_Regras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.textBox_Regras_Texto);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form_Menu_Inicial_Regras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Informações_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.TextBox textBox_Regras_Texto;
        private System.Windows.Forms.Button btn_Voltar_Menu_Inicial;
    }
}