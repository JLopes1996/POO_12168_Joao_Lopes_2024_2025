namespace Jardim_Zoológico.Menu_Inicio
{
    partial class Calendário
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calendário));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Inicio_Login = new System.Windows.Forms.Button();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label_Calendário = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Adicionar_Evento = new System.Windows.Forms.Button();
            this.textBox1_Eventos = new System.Windows.Forms.TextBox();
            this.btn_Add_Evento = new System.Windows.Forms.Button();
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
            this.panel1.TabIndex = 25;
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
            this.label_Titulo.Size = new System.Drawing.Size(196, 17);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - Calendário";
            // 
            // label_Calendário
            // 
            this.label_Calendário.AutoSize = true;
            this.label_Calendário.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_Calendário.Location = new System.Drawing.Point(12, 82);
            this.label_Calendário.Name = "label_Calendário";
            this.label_Calendário.Size = new System.Drawing.Size(74, 17);
            this.label_Calendário.TabIndex = 26;
            this.label_Calendário.Text = "Calendário";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 127);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 27;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(424, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Eventos a serem realizados:";
            // 
            // btn_Adicionar_Evento
            // 
            this.btn_Adicionar_Evento.Location = new System.Drawing.Point(659, 385);
            this.btn_Adicionar_Evento.Name = "btn_Adicionar_Evento";
            this.btn_Adicionar_Evento.Size = new System.Drawing.Size(102, 28);
            this.btn_Adicionar_Evento.TabIndex = 30;
            this.btn_Adicionar_Evento.Text = "button1";
            this.btn_Adicionar_Evento.UseVisualStyleBackColor = true;
            // 
            // textBox1_Eventos
            // 
            this.textBox1_Eventos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1_Eventos.Location = new System.Drawing.Point(418, 104);
            this.textBox1_Eventos.Name = "textBox1_Eventos";
            this.textBox1_Eventos.ReadOnly = true;
            this.textBox1_Eventos.Size = new System.Drawing.Size(184, 20);
            this.textBox1_Eventos.TabIndex = 31;
            // 
            // btn_Add_Evento
            // 
            this.btn_Add_Evento.Location = new System.Drawing.Point(443, 329);
            this.btn_Add_Evento.Name = "btn_Add_Evento";
            this.btn_Add_Evento.Size = new System.Drawing.Size(113, 23);
            this.btn_Add_Evento.TabIndex = 32;
            this.btn_Add_Evento.Text = "Adicionar_Evento";
            this.btn_Add_Evento.UseVisualStyleBackColor = true;
            this.btn_Add_Evento.Click += new System.EventHandler(this.btn_Add_Evento_Click);
            // 
            // Calendário
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btn_Add_Evento);
            this.Controls.Add(this.textBox1_Eventos);
            this.Controls.Add(this.btn_Adicionar_Evento);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label_Calendário);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Name = "Calendário";
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
        private System.Windows.Forms.Label label_Calendário;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Adicionar_Evento;
        private System.Windows.Forms.TextBox textBox1_Eventos;
        private System.Windows.Forms.Button btn_Add_Evento;
    }
}