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
            this.button7 = new System.Windows.Forms.Button();
            this.txtPlumaEstado = new System.Windows.Forms.TextBox();
            this.txtPos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtComandos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnEmpezar = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.txtPasos = new System.Windows.Forms.TextBox();
            this.lablPasos = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtResultados
            // 
            this.txtResultados.Location = new System.Drawing.Point(52, 193);
            this.txtResultados.Multiline = true;
            this.txtResultados.Name = "txtResultados";
            this.txtResultados.Size = new System.Drawing.Size(234, 169);
            this.txtResultados.TabIndex = 1;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(306, 12);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 7;
            this.button7.Text = "fin";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // txtPlumaEstado
            // 
            this.txtPlumaEstado.Location = new System.Drawing.Point(52, 70);
            this.txtPlumaEstado.Multiline = true;
            this.txtPlumaEstado.Name = "txtPlumaEstado";
            this.txtPlumaEstado.Size = new System.Drawing.Size(105, 26);
            this.txtPlumaEstado.TabIndex = 8;
            // 
            // txtPos
            // 
            this.txtPos.Location = new System.Drawing.Point(181, 70);
            this.txtPos.Multiline = true;
            this.txtPos.Name = "txtPos";
            this.txtPos.Size = new System.Drawing.Size(105, 26);
            this.txtPos.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Pluma";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(190, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "PosicionTortuga";
            // 
            // txtComandos
            // 
            this.txtComandos.Location = new System.Drawing.Point(333, 70);
            this.txtComandos.Multiline = true;
            this.txtComandos.Name = "txtComandos";
            this.txtComandos.Size = new System.Drawing.Size(105, 26);
            this.txtComandos.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(342, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Comando:";
            // 
            // btnEmpezar
            // 
            this.btnEmpezar.Location = new System.Drawing.Point(69, 12);
            this.btnEmpezar.Name = "btnEmpezar";
            this.btnEmpezar.Size = new System.Drawing.Size(75, 23);
            this.btnEmpezar.TabIndex = 15;
            this.btnEmpezar.Text = "Empezar";
            this.btnEmpezar.UseVisualStyleBackColor = true;
            this.btnEmpezar.Click += new System.EventHandler(this.btnEmpezar_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(181, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "Mostrar";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // txtPasos
            // 
            this.txtPasos.Location = new System.Drawing.Point(475, 70);
            this.txtPasos.Multiline = true;
            this.txtPasos.Name = "txtPasos";
            this.txtPasos.Size = new System.Drawing.Size(105, 26);
            this.txtPasos.TabIndex = 17;
            // 
            // lablPasos
            // 
            this.lablPasos.AutoSize = true;
            this.lablPasos.Location = new System.Drawing.Point(472, 54);
            this.lablPasos.Name = "lablPasos";
            this.lablPasos.Size = new System.Drawing.Size(36, 13);
            this.lablPasos.TabIndex = 18;
            this.lablPasos.Text = "Pasos";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 618);
            this.Controls.Add(this.lablPasos);
            this.Controls.Add(this.txtPasos);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnEmpezar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtComandos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPos);
            this.Controls.Add(this.txtPlumaEstado);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.txtResultados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtResultados;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox txtPlumaEstado;
        private System.Windows.Forms.TextBox txtPos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtComandos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnEmpezar;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtPasos;
        private System.Windows.Forms.Label lablPasos;
    }
}

