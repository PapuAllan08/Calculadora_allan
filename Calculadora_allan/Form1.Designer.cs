namespace Calculadora_allan
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
            this.txt_Resultado = new System.Windows.Forms.TextBox();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btnpunto = new System.Windows.Forms.Button();
            this.btn_historial = new System.Windows.Forms.Button();
            this.btnexponente = new System.Windows.Forms.Button();
            this.btnraiz = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnmenos = new System.Windows.Forms.Button();
            this.btndivision = new System.Windows.Forms.Button();
            this.btnmultiplicacion = new System.Windows.Forms.Button();
            this.btnmodulo = new System.Windows.Forms.Button();
            this.btnmas = new System.Windows.Forms.Button();
            this.btnigual = new System.Windows.Forms.Button();
            this.Lst_Historial = new System.Windows.Forms.ListBox();
            this.btnborrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Resultado
            // 
            this.txt_Resultado.Location = new System.Drawing.Point(29, 30);
            this.txt_Resultado.Name = "txt_Resultado";
            this.txt_Resultado.Size = new System.Drawing.Size(326, 22);
            this.txt_Resultado.TabIndex = 0;
            this.txt_Resultado.Text = "0";
            this.txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn7
            // 
            this.btn7.Location = new System.Drawing.Point(28, 79);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(95, 52);
            this.btn7.TabIndex = 1;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn8
            // 
            this.btn8.Location = new System.Drawing.Point(141, 79);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(95, 52);
            this.btn8.TabIndex = 2;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn9
            // 
            this.btn9.Location = new System.Drawing.Point(259, 79);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(95, 52);
            this.btn9.TabIndex = 3;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(28, 153);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(95, 52);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            // 
            // btn5
            // 
            this.btn5.Location = new System.Drawing.Point(141, 153);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(95, 52);
            this.btn5.TabIndex = 5;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            // 
            // btn6
            // 
            this.btn6.Location = new System.Drawing.Point(259, 153);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(95, 52);
            this.btn6.TabIndex = 6;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(28, 226);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(95, 52);
            this.btn1.TabIndex = 7;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(141, 226);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(95, 52);
            this.btn2.TabIndex = 8;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(259, 226);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(95, 52);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Location = new System.Drawing.Point(28, 294);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(179, 55);
            this.btn0.TabIndex = 10;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            // 
            // btnpunto
            // 
            this.btnpunto.Location = new System.Drawing.Point(259, 294);
            this.btnpunto.Name = "btnpunto";
            this.btnpunto.Size = new System.Drawing.Size(94, 54);
            this.btnpunto.TabIndex = 11;
            this.btnpunto.Text = ".";
            this.btnpunto.UseVisualStyleBackColor = true;
            this.btnpunto.Click += new System.EventHandler(this.btnpunto_Click);
            // 
            // btn_historial
            // 
            this.btn_historial.Location = new System.Drawing.Point(43, 355);
            this.btn_historial.Name = "btn_historial";
            this.btn_historial.Size = new System.Drawing.Size(137, 66);
            this.btn_historial.TabIndex = 12;
            this.btn_historial.Text = "Historial";
            this.btn_historial.UseVisualStyleBackColor = true;
            // 
            // btnexponente
            // 
            this.btnexponente.Location = new System.Drawing.Point(220, 355);
            this.btnexponente.Name = "btnexponente";
            this.btnexponente.Size = new System.Drawing.Size(133, 30);
            this.btnexponente.TabIndex = 13;
            this.btnexponente.Text = "Exponente ";
            this.btnexponente.UseVisualStyleBackColor = true;
            // 
            // btnraiz
            // 
            this.btnraiz.Location = new System.Drawing.Point(221, 391);
            this.btnraiz.Name = "btnraiz";
            this.btnraiz.Size = new System.Drawing.Size(133, 30);
            this.btnraiz.TabIndex = 14;
            this.btnraiz.Text = "Raiz";
            this.btnraiz.UseVisualStyleBackColor = true;
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(386, 49);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(168, 71);
            this.btnlimpiar.TabIndex = 15;
            this.btnlimpiar.Text = "C";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            // 
            // btnmenos
            // 
            this.btnmenos.Location = new System.Drawing.Point(386, 126);
            this.btnmenos.Name = "btnmenos";
            this.btnmenos.Size = new System.Drawing.Size(48, 44);
            this.btnmenos.TabIndex = 16;
            this.btnmenos.Text = "-";
            this.btnmenos.UseVisualStyleBackColor = true;
            this.btnmenos.Click += new System.EventHandler(this.btnmenos_Click);
            // 
            // btndivision
            // 
            this.btndivision.Location = new System.Drawing.Point(451, 176);
            this.btndivision.Name = "btndivision";
            this.btndivision.Size = new System.Drawing.Size(48, 44);
            this.btndivision.TabIndex = 17;
            this.btndivision.Text = "/";
            this.btndivision.UseVisualStyleBackColor = true;
            // 
            // btnmultiplicacion
            // 
            this.btnmultiplicacion.Location = new System.Drawing.Point(386, 176);
            this.btnmultiplicacion.Name = "btnmultiplicacion";
            this.btnmultiplicacion.Size = new System.Drawing.Size(48, 44);
            this.btnmultiplicacion.TabIndex = 18;
            this.btnmultiplicacion.Text = "*";
            this.btnmultiplicacion.UseVisualStyleBackColor = true;
            // 
            // btnmodulo
            // 
            this.btnmodulo.Location = new System.Drawing.Point(506, 126);
            this.btnmodulo.Name = "btnmodulo";
            this.btnmodulo.Size = new System.Drawing.Size(48, 44);
            this.btnmodulo.TabIndex = 19;
            this.btnmodulo.Text = "%";
            this.btnmodulo.UseVisualStyleBackColor = true;
            // 
            // btnmas
            // 
            this.btnmas.Location = new System.Drawing.Point(451, 126);
            this.btnmas.Name = "btnmas";
            this.btnmas.Size = new System.Drawing.Size(48, 44);
            this.btnmas.TabIndex = 20;
            this.btnmas.Text = "+";
            this.btnmas.UseVisualStyleBackColor = true;
            // 
            // btnigual
            // 
            this.btnigual.Location = new System.Drawing.Point(386, 226);
            this.btnigual.Name = "btnigual";
            this.btnigual.Size = new System.Drawing.Size(168, 71);
            this.btnigual.TabIndex = 21;
            this.btnigual.Text = "=";
            this.btnigual.UseVisualStyleBackColor = true;
            // 
            // Lst_Historial
            // 
            this.Lst_Historial.FormattingEnabled = true;
            this.Lst_Historial.ItemHeight = 16;
            this.Lst_Historial.Location = new System.Drawing.Point(584, 30);
            this.Lst_Historial.Name = "Lst_Historial";
            this.Lst_Historial.Size = new System.Drawing.Size(186, 388);
            this.Lst_Historial.TabIndex = 23;
            // 
            // btnborrar
            // 
            this.btnborrar.Location = new System.Drawing.Point(386, 314);
            this.btnborrar.Name = "btnborrar";
            this.btnborrar.Size = new System.Drawing.Size(168, 71);
            this.btnborrar.TabIndex = 24;
            this.btnborrar.Text = "Borrar";
            this.btnborrar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnborrar);
            this.Controls.Add(this.Lst_Historial);
            this.Controls.Add(this.btnigual);
            this.Controls.Add(this.btnmas);
            this.Controls.Add(this.btnmodulo);
            this.Controls.Add(this.btnmultiplicacion);
            this.Controls.Add(this.btndivision);
            this.Controls.Add(this.btnmenos);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnraiz);
            this.Controls.Add(this.btnexponente);
            this.Controls.Add(this.btn_historial);
            this.Controls.Add(this.btnpunto);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.txt_Resultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Resultado;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btnpunto;
        private System.Windows.Forms.Button btn_historial;
        private System.Windows.Forms.Button btnexponente;
        private System.Windows.Forms.Button btnraiz;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnmenos;
        private System.Windows.Forms.Button btndivision;
        private System.Windows.Forms.Button btnmultiplicacion;
        private System.Windows.Forms.Button btnmodulo;
        private System.Windows.Forms.Button btnmas;
        private System.Windows.Forms.Button btnigual;
        private System.Windows.Forms.ListBox Lst_Historial;
        private System.Windows.Forms.Button btnborrar;
    }
}

