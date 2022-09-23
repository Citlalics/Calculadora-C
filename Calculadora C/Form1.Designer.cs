
namespace Calculadora_C
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblv1 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.lblv2 = new System.Windows.Forms.Label();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.lblresu = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.btnsumar = new System.Windows.Forms.Button();
            this.btnrestar = new System.Windows.Forms.Button();
            this.btnmulti = new System.Windows.Forms.Button();
            this.btndivi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblv1
            // 
            this.lblv1.AutoSize = true;
            this.lblv1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblv1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv1.Location = new System.Drawing.Point(157, 110);
            this.lblv1.Name = "lblv1";
            this.lblv1.Size = new System.Drawing.Size(103, 25);
            this.lblv1.TabIndex = 1;
            this.lblv1.Text = "VALOR 1";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.Location = new System.Drawing.Point(276, 104);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(131, 34);
            this.txt1.TabIndex = 4;
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblv2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblv2.Location = new System.Drawing.Point(157, 199);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(103, 25);
            this.lblv2.TabIndex = 5;
            this.lblv2.Text = "VALOR 2";
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt2.Location = new System.Drawing.Point(276, 190);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(131, 34);
            this.txt2.TabIndex = 6;
            // 
            // lblresu
            // 
            this.lblresu.AutoSize = true;
            this.lblresu.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblresu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblresu.Location = new System.Drawing.Point(110, 292);
            this.lblresu.Name = "lblresu";
            this.lblresu.Size = new System.Drawing.Size(150, 25);
            this.lblresu.TabIndex = 7;
            this.lblresu.Text = "RESULTADO:";
            // 
            // txt3
            // 
            this.txt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt3.Location = new System.Drawing.Point(276, 283);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(131, 34);
            this.txt3.TabIndex = 8;
            // 
            // btnsumar
            // 
            this.btnsumar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsumar.Location = new System.Drawing.Point(484, 100);
            this.btnsumar.Name = "btnsumar";
            this.btnsumar.Size = new System.Drawing.Size(122, 35);
            this.btnsumar.TabIndex = 9;
            this.btnsumar.Text = "Sumar";
            this.btnsumar.UseVisualStyleBackColor = true;
            this.btnsumar.Click += new System.EventHandler(this.btnsumar_Click);
            // 
            // btnrestar
            // 
            this.btnrestar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnrestar.Location = new System.Drawing.Point(484, 155);
            this.btnrestar.Name = "btnrestar";
            this.btnrestar.Size = new System.Drawing.Size(122, 35);
            this.btnrestar.TabIndex = 10;
            this.btnrestar.Text = "Restar";
            this.btnrestar.UseVisualStyleBackColor = true;
            this.btnrestar.Click += new System.EventHandler(this.btnrestar_Click);
            // 
            // btnmulti
            // 
            this.btnmulti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmulti.Location = new System.Drawing.Point(484, 214);
            this.btnmulti.Name = "btnmulti";
            this.btnmulti.Size = new System.Drawing.Size(122, 35);
            this.btnmulti.TabIndex = 11;
            this.btnmulti.Text = "Multiplicar";
            this.btnmulti.UseVisualStyleBackColor = true;
            this.btnmulti.Click += new System.EventHandler(this.btnmulti_Click);
            // 
            // btndivi
            // 
            this.btndivi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndivi.Location = new System.Drawing.Point(484, 282);
            this.btndivi.Name = "btndivi";
            this.btndivi.Size = new System.Drawing.Size(122, 35);
            this.btndivi.TabIndex = 12;
            this.btndivi.Text = "División";
            this.btndivi.UseVisualStyleBackColor = true;
            this.btndivi.Click += new System.EventHandler(this.btndivi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btndivi);
            this.Controls.Add(this.btnmulti);
            this.Controls.Add(this.btnrestar);
            this.Controls.Add(this.btnsumar);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lblresu);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.lblv1);
            this.Name = "Form1";
            this.Text = "calculadora ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblv1;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label lblresu;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.Button btnsumar;
        private System.Windows.Forms.Button btnrestar;
        private System.Windows.Forms.Button btnmulti;
        private System.Windows.Forms.Button btndivi;
    }
}

