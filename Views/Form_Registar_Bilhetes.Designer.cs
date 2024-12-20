namespace Jardim_Zoológico.Menu_Funcionarios
{
    partial class Form_Registar_Bilhetes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Registar_Bilhetes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_Titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Registar_Bilhete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Tipo_Bilhete = new System.Windows.Forms.ComboBox();
            this.textBox_Preço_Bilhete = new System.Windows.Forms.TextBox();
            this.textBox_Descricao_Espetaculo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Local_Espetaculo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_Duracao_Espataculo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox_Nome_Espetaculo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dateTimePicker_Horario_Espetaculo = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox_Capacidade_Espetaculo = new System.Windows.Forms.ComboBox();
            this.comboBox_Animal_Espetaculo = new System.Windows.Forms.ComboBox();
            this.label_AnimalTipo = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
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
            this.panel1.TabIndex = 36;
            // 
            // label_Titulo
            // 
            this.label_Titulo.AutoSize = true;
            this.label_Titulo.ForeColor = System.Drawing.Color.White;
            this.label_Titulo.Location = new System.Drawing.Point(12, 8);
            this.label_Titulo.Name = "label_Titulo";
            this.label_Titulo.Size = new System.Drawing.Size(173, 13);
            this.label_Titulo.TabIndex = 5;
            this.label_Titulo.Text = "Jardim_Zoológico - Registar Bilhete";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(81, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Registo";
            // 
            // btn_Registar_Bilhete
            // 
            this.btn_Registar_Bilhete.BackColor = System.Drawing.Color.Transparent;
            this.btn_Registar_Bilhete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Registar_Bilhete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Registar_Bilhete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_Registar_Bilhete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Registar_Bilhete.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Registar_Bilhete.Location = new System.Drawing.Point(39, 369);
            this.btn_Registar_Bilhete.Name = "btn_Registar_Bilhete";
            this.btn_Registar_Bilhete.Size = new System.Drawing.Size(150, 30);
            this.btn_Registar_Bilhete.TabIndex = 42;
            this.btn_Registar_Bilhete.Text = "Registar";
            this.btn_Registar_Bilhete.UseVisualStyleBackColor = false;
            this.btn_Registar_Bilhete.Click += new System.EventHandler(this.btn_Registar_Bilhete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(303, 335);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "Tipo do Bilhete";
            // 
            // comboBox_Tipo_Bilhete
            // 
            this.comboBox_Tipo_Bilhete.FormattingEnabled = true;
            this.comboBox_Tipo_Bilhete.Location = new System.Drawing.Point(306, 351);
            this.comboBox_Tipo_Bilhete.Name = "comboBox_Tipo_Bilhete";
            this.comboBox_Tipo_Bilhete.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Tipo_Bilhete.TabIndex = 53;
            // 
            // textBox_Preço_Bilhete
            // 
            this.textBox_Preço_Bilhete.Location = new System.Drawing.Point(306, 302);
            this.textBox_Preço_Bilhete.Name = "textBox_Preço_Bilhete";
            this.textBox_Preço_Bilhete.Size = new System.Drawing.Size(119, 20);
            this.textBox_Preço_Bilhete.TabIndex = 54;
            // 
            // textBox_Descricao_Espetaculo
            // 
            this.textBox_Descricao_Espetaculo.Location = new System.Drawing.Point(308, 244);
            this.textBox_Descricao_Espetaculo.Name = "textBox_Descricao_Espetaculo";
            this.textBox_Descricao_Espetaculo.Size = new System.Drawing.Size(119, 20);
            this.textBox_Descricao_Espetaculo.TabIndex = 56;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(305, 228);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 13);
            this.label3.TabIndex = 55;
            this.label3.Text = "Descrição do Espetáculo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(308, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 13);
            this.label4.TabIndex = 57;
            this.label4.Text = "Capacidade do Espetáculo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(321, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 59;
            this.label5.Text = "Local do Espetáculo";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(36, 285);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 13);
            this.label6.TabIndex = 61;
            this.label6.Text = "Animal do Espetáculo";
            // 
            // textBox_Local_Espetaculo
            // 
            this.textBox_Local_Espetaculo.Location = new System.Drawing.Point(318, 113);
            this.textBox_Local_Espetaculo.Name = "textBox_Local_Espetaculo";
            this.textBox_Local_Espetaculo.Size = new System.Drawing.Size(119, 20);
            this.textBox_Local_Espetaculo.TabIndex = 64;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(36, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(119, 13);
            this.label7.TabIndex = 63;
            this.label7.Text = "Duração do Espetáculo";
            // 
            // textBox_Duracao_Espataculo
            // 
            this.textBox_Duracao_Espataculo.Location = new System.Drawing.Point(39, 239);
            this.textBox_Duracao_Espataculo.Name = "textBox_Duracao_Espataculo";
            this.textBox_Duracao_Espataculo.Size = new System.Drawing.Size(119, 20);
            this.textBox_Duracao_Espataculo.TabIndex = 66;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(36, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 65;
            this.label8.Text = "Horário do Espetáculo";
            // 
            // textBox_Nome_Espetaculo
            // 
            this.textBox_Nome_Espetaculo.Location = new System.Drawing.Point(39, 113);
            this.textBox_Nome_Espetaculo.Name = "textBox_Nome_Espetaculo";
            this.textBox_Nome_Espetaculo.Size = new System.Drawing.Size(119, 20);
            this.textBox_Nome_Espetaculo.TabIndex = 68;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(36, 96);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(106, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "Nome do Espetáculo";
            // 
            // dateTimePicker_Horario_Espetaculo
            // 
            this.dateTimePicker_Horario_Espetaculo.CustomFormat = "dd/MM/yyy HH:mm";
            this.dateTimePicker_Horario_Espetaculo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_Horario_Espetaculo.Location = new System.Drawing.Point(39, 178);
            this.dateTimePicker_Horario_Espetaculo.Name = "dateTimePicker_Horario_Espetaculo";
            this.dateTimePicker_Horario_Espetaculo.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker_Horario_Espetaculo.TabIndex = 69;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(305, 286);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 71;
            this.label10.Text = "Preço do Bilhete";
            // 
            // comboBox_Capacidade_Espetaculo
            // 
            this.comboBox_Capacidade_Espetaculo.FormattingEnabled = true;
            this.comboBox_Capacidade_Espetaculo.Location = new System.Drawing.Point(306, 181);
            this.comboBox_Capacidade_Espetaculo.Name = "comboBox_Capacidade_Espetaculo";
            this.comboBox_Capacidade_Espetaculo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Capacidade_Espetaculo.TabIndex = 72;
            // 
            // comboBox_Animal_Espetaculo
            // 
            this.comboBox_Animal_Espetaculo.FormattingEnabled = true;
            this.comboBox_Animal_Espetaculo.Location = new System.Drawing.Point(37, 302);
            this.comboBox_Animal_Espetaculo.Name = "comboBox_Animal_Espetaculo";
            this.comboBox_Animal_Espetaculo.Size = new System.Drawing.Size(121, 21);
            this.comboBox_Animal_Espetaculo.TabIndex = 73;
            this.comboBox_Animal_Espetaculo.SelectedIndexChanged += new System.EventHandler(this.comboBox_Animal_Espetaculo_SelectedIndexChanged);
            // 
            // label_AnimalTipo
            // 
            this.label_AnimalTipo.Location = new System.Drawing.Point(164, 302);
            this.label_AnimalTipo.Name = "label_AnimalTipo";
            this.label_AnimalTipo.Size = new System.Drawing.Size(119, 20);
            this.label_AnimalTipo.TabIndex = 74;
            // 
            // Form_Registar_Bilhetes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_AnimalTipo);
            this.Controls.Add(this.comboBox_Animal_Espetaculo);
            this.Controls.Add(this.comboBox_Capacidade_Espetaculo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dateTimePicker_Horario_Espetaculo);
            this.Controls.Add(this.textBox_Nome_Espetaculo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox_Duracao_Espataculo);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Local_Espetaculo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_Descricao_Espetaculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_Preço_Bilhete);
            this.Controls.Add(this.comboBox_Tipo_Bilhete);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Registar_Bilhete);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Registar_Bilhetes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_Registar_Bilhetes_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_Titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Registar_Bilhete;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Tipo_Bilhete;
        private System.Windows.Forms.TextBox textBox_Preço_Bilhete;
        private System.Windows.Forms.TextBox textBox_Descricao_Espetaculo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Local_Espetaculo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_Duracao_Espataculo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox_Nome_Espetaculo;
        private System.Windows.Forms.Label label9;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Horario_Espetaculo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox_Capacidade_Espetaculo;
        private System.Windows.Forms.ComboBox comboBox_Animal_Espetaculo;
        private System.Windows.Forms.TextBox label_AnimalTipo;
    }
}