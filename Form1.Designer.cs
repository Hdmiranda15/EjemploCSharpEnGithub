namespace TresEnUno
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
            this.label1 = new System.Windows.Forms.Label();
            this.textProduNeto = new System.Windows.Forms.TextBox();
            this.ButpagarIVA = new System.Windows.Forms.Button();
            this.BotDescue = new System.Windows.Forms.Button();
            this.textSueldo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButCalcuTabla = new System.Windows.Forms.Button();
            this.textDescue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TablaPrecios = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.butLimpio = new System.Windows.Forms.Button();
            this.butSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrecios)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Precio Neto ($)";
            // 
            // textProduNeto
            // 
            this.textProduNeto.Location = new System.Drawing.Point(184, 42);
            this.textProduNeto.Name = "textProduNeto";
            this.textProduNeto.Size = new System.Drawing.Size(100, 20);
            this.textProduNeto.TabIndex = 1;
            // 
            // ButpagarIVA
            // 
            this.ButpagarIVA.Location = new System.Drawing.Point(303, 42);
            this.ButpagarIVA.Name = "ButpagarIVA";
            this.ButpagarIVA.Size = new System.Drawing.Size(139, 23);
            this.ButpagarIVA.TabIndex = 2;
            this.ButpagarIVA.Text = "pagar+ IVA";
            this.ButpagarIVA.UseVisualStyleBackColor = true;
            this.ButpagarIVA.Click += new System.EventHandler(this.ButpagarIVA_Click);
            // 
            // BotDescue
            // 
            this.BotDescue.Location = new System.Drawing.Point(303, 138);
            this.BotDescue.Name = "BotDescue";
            this.BotDescue.Size = new System.Drawing.Size(139, 23);
            this.BotDescue.TabIndex = 5;
            this.BotDescue.Text = "Total Descuento";
            this.BotDescue.UseVisualStyleBackColor = true;
            this.BotDescue.Click += new System.EventHandler(this.BotDescue_Click);
            // 
            // textSueldo
            // 
            this.textSueldo.Location = new System.Drawing.Point(184, 138);
            this.textSueldo.Name = "textSueldo";
            this.textSueldo.Size = new System.Drawing.Size(100, 20);
            this.textSueldo.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "sueldo ($)";
            // 
            // ButCalcuTabla
            // 
            this.ButCalcuTabla.Location = new System.Drawing.Point(168, 536);
            this.ButCalcuTabla.Name = "ButCalcuTabla";
            this.ButCalcuTabla.Size = new System.Drawing.Size(307, 33);
            this.ButCalcuTabla.TabIndex = 8;
            this.ButCalcuTabla.Text = "subtotales y el monto total.";
            this.ButCalcuTabla.UseVisualStyleBackColor = true;
            // 
            // textDescue
            // 
            this.textDescue.Location = new System.Drawing.Point(184, 163);
            this.textDescue.Name = "textDescue";
            this.textDescue.Size = new System.Drawing.Size(100, 20);
            this.textDescue.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "descuento (%)";
            // 
            // TablaPrecios
            // 
            this.TablaPrecios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaPrecios.Location = new System.Drawing.Point(49, 359);
            this.TablaPrecios.Name = "TablaPrecios";
            this.TablaPrecios.Size = new System.Drawing.Size(689, 161);
            this.TablaPrecios.TabIndex = 9;
            this.TablaPrecios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablaPrecios_CellContentClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(166, 333);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(39, 20);
            this.textBox1.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(53, 336);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Nombre Producto 3 ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(166, 307);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(39, 20);
            this.textBox2.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 310);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Nombre Producto 2 ";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(166, 281);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(39, 20);
            this.textBox3.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(53, 284);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Nombre Producto1 ";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(626, 284);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(513, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "cantidad Producto1";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(626, 310);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(513, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "cantidad Producto 2";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(626, 336);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(513, 339);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 13);
            this.label9.TabIndex = 16;
            this.label9.Text = "cantidad Producto 3";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(401, 284);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(54, 20);
            this.textBox7.TabIndex = 27;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 287);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Precio Producto1 ($)";
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(401, 310);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(54, 20);
            this.textBox8.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(288, 313);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(107, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Precio Producto 2 ($)";
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(401, 336);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(54, 20);
            this.textBox9.TabIndex = 23;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(288, 339);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(107, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Precio Producto 3 ($)";
            // 
            // butLimpio
            // 
            this.butLimpio.Location = new System.Drawing.Point(457, 42);
            this.butLimpio.Name = "butLimpio";
            this.butLimpio.Size = new System.Drawing.Size(159, 141);
            this.butLimpio.TabIndex = 28;
            this.butLimpio.Text = "Limpiar";
            this.butLimpio.UseVisualStyleBackColor = true;
            this.butLimpio.Click += new System.EventHandler(this.butLimpio_Click);
            // 
            // butSalir
            // 
            this.butSalir.AutoSize = true;
            this.butSalir.BackColor = System.Drawing.SystemColors.HotTrack;
            this.butSalir.ForeColor = System.Drawing.Color.Yellow;
            this.butSalir.Location = new System.Drawing.Point(792, 12);
            this.butSalir.Name = "butSalir";
            this.butSalir.Size = new System.Drawing.Size(56, 31);
            this.butSalir.TabIndex = 29;
            this.butSalir.Text = "Salir";
            this.butSalir.UseVisualStyleBackColor = false;
            this.butSalir.Click += new System.EventHandler(this.butSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 610);
            this.Controls.Add(this.butSalir);
            this.Controls.Add(this.butLimpio);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TablaPrecios);
            this.Controls.Add(this.ButCalcuTabla);
            this.Controls.Add(this.textDescue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BotDescue);
            this.Controls.Add(this.textSueldo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButpagarIVA);
            this.Controls.Add(this.textProduNeto);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.TablaPrecios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textProduNeto;
        private System.Windows.Forms.Button ButpagarIVA;
        private System.Windows.Forms.Button BotDescue;
        private System.Windows.Forms.TextBox textSueldo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButCalcuTabla;
        private System.Windows.Forms.TextBox textDescue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView TablaPrecios;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button butLimpio;
        private System.Windows.Forms.Button butSalir;
    }
}

