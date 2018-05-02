namespace GraficosPorTortuga
{
    partial class Form1
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
            this.txtResultados = new System.Windows.Forms.TextBox();
            this.btnArriba = new System.Windows.Forms.Button();
            this.btnAbajo = new System.Windows.Forms.Button();
            this.btnDerecha = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnPlumaArriba = new System.Windows.Forms.Button();
            this.btnPlumaAbjo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(239, 192);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(234, 169);
            this.txtResultados.TabIndex = 1;
            // 
            // btnArriba
            // 
            this.btnArriba.Location = new System.Drawing.Point(323, 50);
            this.btnArriba.Name = "btnArriba";
            this.btnArriba.Size = new System.Drawing.Size(75, 23);
            this.btnArriba.TabIndex = 2;
            this.btnArriba.Text = "1";
            this.btnArriba.UseVisualStyleBackColor = true;
            this.btnArriba.Click += new System.EventHandler(this.btnArriba_Click);
            // 
            // btnAbajo
            // 
            this.btnAbajo.Location = new System.Drawing.Point(323, 482);
            this.btnAbajo.Name = "btnAbajo";
            this.btnAbajo.Size = new System.Drawing.Size(75, 23);
            this.btnAbajo.TabIndex = 3;
            this.btnAbajo.Text = "3";
            this.btnAbajo.UseVisualStyleBackColor = true;
            this.btnAbajo.Click += new System.EventHandler(this.btnAbajo_Click);
            // 
            // btnDerecha
            // 
            this.btnDerecha.Location = new System.Drawing.Point(558, 257);
            this.btnDerecha.Name = "btnDerecha";
            this.btnDerecha.Size = new System.Drawing.Size(75, 23);
            this.btnDerecha.TabIndex = 4;
            this.btnDerecha.Text = "2";
            this.btnDerecha.UseVisualStyleBackColor = true;
            this.btnDerecha.Click += new System.EventHandler(this.btnDerecha_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(67, 257);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnPlumaArriba
            // 
            this.btnPlumaArriba.Location = new System.Drawing.Point(239, 146);
            this.btnPlumaArriba.Name = "btnPlumaArriba";
            this.btnPlumaArriba.Size = new System.Drawing.Size(75, 23);
            this.btnPlumaArriba.TabIndex = 6;
            this.btnPlumaArriba.Text = "Pluma arriba";
            this.btnPlumaArriba.UseVisualStyleBackColor = true;
            this.btnPlumaArriba.Click += new System.EventHandler(this.btnPlumaArriba_Click);
            // 
            // btnPlumaAbjo
            // 
            this.btnPlumaAbjo.Location = new System.Drawing.Point(398, 146);
            this.btnPlumaAbjo.Name = "btnPlumaAbjo";
            this.btnPlumaAbjo.Size = new System.Drawing.Size(75, 23);
            this.btnPlumaAbjo.TabIndex = 7;
            this.btnPlumaAbjo.Text = "Pluma Abajo";
            this.btnPlumaAbjo.UseVisualStyleBackColor = true;
            this.btnPlumaAbjo.Click += new System.EventHandler(this.btnPlumaAbjo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 618);
            this.Controls.Add(this.btnPlumaAbjo);
            this.Controls.Add(this.btnPlumaArriba);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDerecha);
            this.Controls.Add(this.btnAbajo);
            this.Controls.Add(this.btnArriba);
            this.Controls.Add(this.txtResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button btnArriba;
        private System.Windows.Forms.Button btnAbajo;
        private System.Windows.Forms.Button btnDerecha;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnPlumaArriba;
        private System.Windows.Forms.Button btnPlumaAbjo;
    }
}

