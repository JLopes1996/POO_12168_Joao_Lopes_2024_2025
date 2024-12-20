namespace Jardim_Zoológico.Menu_Clientes
{
    partial class Form_Menu_Cliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Menu_Cliente));
            this.btn_Listar_Bilhetes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Listar_Bilhetes
            // 
            this.btn_Listar_Bilhetes.BackColor = System.Drawing.Color.Transparent;
            this.btn_Listar_Bilhetes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Listar_Bilhetes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btn_Listar_Bilhetes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Green;
            this.btn_Listar_Bilhetes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Listar_Bilhetes.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Listar_Bilhetes.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Listar_Bilhetes.Location = new System.Drawing.Point(52, 81);
            this.btn_Listar_Bilhetes.Name = "btn_Listar_Bilhetes";
            this.btn_Listar_Bilhetes.Size = new System.Drawing.Size(150, 30);
            this.btn_Listar_Bilhetes.TabIndex = 16;
            this.btn_Listar_Bilhetes.Text = "Bilhetes";
            this.btn_Listar_Bilhetes.UseVisualStyleBackColor = false;
            this.btn_Listar_Bilhetes.Click += new System.EventHandler(this.btn_Listar_Bilhetes_Click);
            // 
            // Menu_Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.btn_Listar_Bilhetes);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Menu_Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Listar_Bilhetes;
    }
}