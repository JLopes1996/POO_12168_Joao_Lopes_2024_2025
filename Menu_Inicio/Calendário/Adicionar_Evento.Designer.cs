using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace Jardim_Zoológico.Menu_Inicio.Calendário
{
    partial class Adicionar_EventoForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Adicionar_Evento));
            this.btn_Add_Evento = new System.Windows.Forms.Button();
            this.Texto_Evento = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_Add_Evento
            // 
            this.btn_Add_Evento.Location = new System.Drawing.Point(168, 285);
            this.btn_Add_Evento.Name = "btn_Add_Evento";
            this.btn_Add_Evento.Size = new System.Drawing.Size(75, 23);
            this.btn_Add_Evento.TabIndex = 1;
            this.btn_Add_Evento.Text = "Adicionar";
            this.btn_Add_Evento.UseVisualStyleBackColor = true;
            this.btn_Add_Evento.Click += new System.EventHandler(this.btn_Adicionar_Evento_Click);
            // 
            // Texto_Evento
            // 
            this.Texto_Evento.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Texto_Evento.Location = new System.Drawing.Point(92, 84);
            this.Texto_Evento.Multiline = true;
            this.Texto_Evento.Name = "Texto_Evento";
            this.Texto_Evento.ReadOnly = true;
            this.Texto_Evento.Size = new System.Drawing.Size(237, 181);
            this.Texto_Evento.TabIndex = 3;
            this.Texto_Evento.Text = "nmk\r\nkkk\r\nkkk\r\nkkk";
            this.Texto_Evento.TextChanged += new System.EventHandler(this.Texto_Evento_TextChanged);
            // 
            // Adicionar_Evento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Texto_Evento);
            this.Controls.Add(this.btn_Add_Evento);
            this.Name = "Adicionar_Evento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btn_Adicionar_Evento_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion
        private System.Windows.Forms.Button btn_Add_Evento;
        private System.Windows.Forms.TextBox Texto_Evento;
    }

    internal class Adicionar_Evento
    {
    }
}