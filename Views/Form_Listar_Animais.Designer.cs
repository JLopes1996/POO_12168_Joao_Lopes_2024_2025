namespace Jardim_Zoológico.Menu_Funcionarios
{
    partial class Form_Listar_Animais
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listar_Animais));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.dataGridView_Listar_Animais = new System.Windows.Forms.DataGridView();
            this.btn_Ver_Animais = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Animais)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.label_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 30);
            this.panel1.TabIndex = 25;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(163, 13);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - Listar Animais";
            // 
            // dataGridView_Listar_Animais
            // 
            this.dataGridView_Listar_Animais.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_Listar_Animais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar_Animais.Location = new System.Drawing.Point(12, 36);
            this.dataGridView_Listar_Animais.Name = "dataGridView_Listar_Animais";
            this.dataGridView_Listar_Animais.Size = new System.Drawing.Size(686, 376);
            this.dataGridView_Listar_Animais.TabIndex = 26;
            // 
            // btn_Ver_Animais
            // 
            this.btn_Ver_Animais.Location = new System.Drawing.Point(581, 371);
            this.btn_Ver_Animais.Name = "btn_Ver_Animais";
            this.btn_Ver_Animais.Size = new System.Drawing.Size(107, 23);
            this.btn_Ver_Animais.TabIndex = 27;
            this.btn_Ver_Animais.Text = "Listar Animais";
            this.btn_Ver_Animais.UseVisualStyleBackColor = true;
            this.btn_Ver_Animais.Click += new System.EventHandler(this.btn_Ver_Animais_Click);
            // 
            // Form_Listar_Animais
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Ver_Animais);
            this.Controls.Add(this.dataGridView_Listar_Animais);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Listar_Animais";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Animais)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.DataGridView dataGridView_Listar_Animais;
        private System.Windows.Forms.Button btn_Ver_Animais;
    }
}