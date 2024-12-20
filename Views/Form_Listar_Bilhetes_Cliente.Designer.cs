namespace Jardim_Zoológico.Menu_Clientes
{
    partial class Form_Listar_Bilhetes_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Listar_Bilhetes_Cliente));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.dataGridView_Listar_Bilhetes = new System.Windows.Forms.DataGridView();
            this.btn_Ver_Bilhetes = new System.Windows.Forms.Button();
            this.btn_Comprar_Bilhete = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Bilhetes)).BeginInit();
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
            this.panel1.TabIndex = 27;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(164, 13);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - Listar Bilhetes";
            // 
            // dataGridView_Listar_Bilhetes
            // 
            this.dataGridView_Listar_Bilhetes.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView_Listar_Bilhetes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_Listar_Bilhetes.Location = new System.Drawing.Point(12, 54);
            this.dataGridView_Listar_Bilhetes.Name = "dataGridView_Listar_Bilhetes";
            this.dataGridView_Listar_Bilhetes.Size = new System.Drawing.Size(618, 314);
            this.dataGridView_Listar_Bilhetes.TabIndex = 28;
            // 
            // btn_Ver_Bilhetes
            // 
            this.btn_Ver_Bilhetes.Location = new System.Drawing.Point(510, 391);
            this.btn_Ver_Bilhetes.Name = "btn_Ver_Bilhetes";
            this.btn_Ver_Bilhetes.Size = new System.Drawing.Size(107, 23);
            this.btn_Ver_Bilhetes.TabIndex = 29;
            this.btn_Ver_Bilhetes.Text = "Listar Bilhetes";
            this.btn_Ver_Bilhetes.UseVisualStyleBackColor = true;
            this.btn_Ver_Bilhetes.Click += new System.EventHandler(this.btn_Ver_Bilhetes_Click);
            // 
            // btn_Comprar_Bilhete
            // 
            this.btn_Comprar_Bilhete.Location = new System.Drawing.Point(385, 391);
            this.btn_Comprar_Bilhete.Name = "btn_Comprar_Bilhete";
            this.btn_Comprar_Bilhete.Size = new System.Drawing.Size(107, 23);
            this.btn_Comprar_Bilhete.TabIndex = 31;
            this.btn_Comprar_Bilhete.Text = "Comprar Bilhetes";
            this.btn_Comprar_Bilhete.UseVisualStyleBackColor = true;
            this.btn_Comprar_Bilhete.Click += new System.EventHandler(this.btn_Comprar_Bilhete_Click);
            // 
            // Form_Listar_Bilhetes_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Comprar_Bilhete);
            this.Controls.Add(this.btn_Ver_Bilhetes);
            this.Controls.Add(this.dataGridView_Listar_Bilhetes);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Listar_Bilhetes_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_Listar_Bilhetes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.DataGridView dataGridView_Listar_Bilhetes;
        private System.Windows.Forms.Button btn_Ver_Bilhetes;
        private System.Windows.Forms.Button btn_Comprar_Bilhete;
    }
}