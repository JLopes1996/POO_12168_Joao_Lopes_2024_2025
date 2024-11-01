namespace Jardim_Zoológico.Menu_Inicio
{
    partial class História
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(História));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inicio_Login = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Bilhetes = new System.Windows.Forms.Label();
            this.textBox_Bilhetes = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(18)))), ((int)(((byte)(80)))));
            this.panel1.Controls.Add(this.btn_Inicio_Login);
            this.panel1.Controls.Add(this.label_Titulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(645, 30);
            this.panel1.TabIndex = 26;
            // 
            // btn_Inicio_Login
            // 
            this.btn_Inicio_Login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Inicio_Login.BackColor = System.Drawing.Color.White;
            this.btn_Inicio_Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Inicio_Login.FlatAppearance.BorderSize = 0;
            this.btn_Inicio_Login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Yellow;
            this.btn_Inicio_Login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btn_Inicio_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Inicio_Login.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inicio_Login.ForeColor = System.Drawing.Color.Black;
            this.btn_Inicio_Login.Location = new System.Drawing.Point(587, 0);
            this.btn_Inicio_Login.Name = "btn_Inicio_Login";
            this.btn_Inicio_Login.Size = new System.Drawing.Size(58, 30);
            this.btn_Inicio_Login.TabIndex = 5;
            this.btn_Inicio_Login.Text = "Voltar";
            this.btn_Inicio_Login.UseVisualStyleBackColor = false;
            this.btn_Inicio_Login.Click += new System.EventHandler(this.btn_Inicio_Login_Click);
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(227, 17);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - História do Zoo";
            // 
            // label_Bilhetes
            // 
            this.label_Bilhetes.AutoSize = true;
            this.label_Bilhetes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Bilhetes.Location = new System.Drawing.Point(12, 82);
            this.label_Bilhetes.Name = "label_Bilhetes";
            this.label_Bilhetes.Size = new System.Drawing.Size(105, 17);
            this.label_Bilhetes.TabIndex = 27;
            this.label_Bilhetes.Text = "História do Zoo";
            // 
            // textBox_Bilhetes
            // 
            this.textBox_Bilhetes.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.textBox_Bilhetes.Location = new System.Drawing.Point(12, 121);
            this.textBox_Bilhetes.Multiline = true;
            this.textBox_Bilhetes.Name = "textBox_Bilhetes";
            this.textBox_Bilhetes.ReadOnly = true;
            this.textBox_Bilhetes.Size = new System.Drawing.Size(326, 303);
            this.textBox_Bilhetes.TabIndex = 28;
            this.textBox_Bilhetes.Text = "asdddddddddddd";
            // 
            // História
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.textBox_Bilhetes);
            this.Controls.Add(this.label_Bilhetes);
            this.Controls.Add(this.panel1);
            this.Name = "História";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_Inicio_Login;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label_Bilhetes;
        private System.Windows.Forms.TextBox textBox_Bilhetes;
    }
}