namespace Jardim_Zoológico.Menu_Funcionarios
{
    partial class Form_Listar_Funcionários
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listar_Funcionários));
            this.dataGridView_Listar_Funcionarios = new System.Windows.Forms.DataGridView();
            this.btn_Ver_Funcionários = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Funcionarios)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView_Listar_Funcionarios
            // 
            this.dataGridView_Listar_Funcionarios.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_Listar_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar_Funcionarios.Location = new System.Drawing.Point(32, 37);
            this.dataGridView_Listar_Funcionarios.Name = "dataGridView_Listar_Funcionarios";
            this.dataGridView_Listar_Funcionarios.Size = new System.Drawing.Size(686, 376);
            this.dataGridView_Listar_Funcionarios.TabIndex = 0;
            // 
            // btn_Ver_Funcionários
            // 
            this.btn_Ver_Funcionários.Location = new System.Drawing.Point(544, 369);
            this.btn_Ver_Funcionários.Name = "btn_Ver_Funcionários";
            this.btn_Ver_Funcionários.Size = new System.Drawing.Size(107, 23);
            this.btn_Ver_Funcionários.TabIndex = 1;
            this.btn_Ver_Funcionários.Text = "Listar Funcionários";
            this.btn_Ver_Funcionários.UseVisualStyleBackColor = true;
            this.btn_Ver_Funcionários.Click += new System.EventHandler(this.btn_Ver_Funcionários_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 24;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(187, 13);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - Listar Funcionários";
            // 
            // Form_Listar_Funcionários
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_Ver_Funcionários);
            this.Controls.Add(this.dataGridView_Listar_Funcionarios);
            this.Name = "Form_Listar_Funcionários";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Listar_Funcionários";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Funcionarios)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView_Listar_Funcionarios;
        private System.Windows.Forms.Button btn_Ver_Funcionários;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Titulo;
    }
}