namespace Expresiones
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
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExpresion = new System.Windows.Forms.TextBox();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPosOrden = new System.Windows.Forms.Button();
            this.txtTRecorrido = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(112, 75);
            this.btnProcesar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(132, 28);
            this.btnProcesar.TabIndex = 0;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Expresion:";
            // 
            // txtExpresion
            // 
            this.txtExpresion.Location = new System.Drawing.Point(112, 34);
            this.txtExpresion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtExpresion.Name = "txtExpresion";
            this.txtExpresion.Size = new System.Drawing.Size(132, 22);
            this.txtExpresion.TabIndex = 2;
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.Location = new System.Drawing.Point(223, 134);
            this.btnPreOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(132, 28);
            this.btnPreOrden.TabIndex = 3;
            this.btnPreOrden.Text = "Pre";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnPosOrden
            // 
            this.btnPosOrden.Location = new System.Drawing.Point(223, 185);
            this.btnPosOrden.Margin = new System.Windows.Forms.Padding(4);
            this.btnPosOrden.Name = "btnPosOrden";
            this.btnPosOrden.Size = new System.Drawing.Size(132, 28);
            this.btnPosOrden.TabIndex = 4;
            this.btnPosOrden.Text = "Pos";
            this.btnPosOrden.UseVisualStyleBackColor = true;
            this.btnPosOrden.Click += new System.EventHandler(this.btnPosOrden_Click);
            // 
            // txtTRecorrido
            // 
            this.txtTRecorrido.Location = new System.Drawing.Point(13, 134);
            this.txtTRecorrido.Margin = new System.Windows.Forms.Padding(4);
            this.txtTRecorrido.Multiline = true;
            this.txtTRecorrido.Name = "txtTRecorrido";
            this.txtTRecorrido.Size = new System.Drawing.Size(186, 91);
            this.txtTRecorrido.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 248);
            this.Controls.Add(this.txtTRecorrido);
            this.Controls.Add(this.btnPosOrden);
            this.Controls.Add(this.btnPreOrden);
            this.Controls.Add(this.txtExpresion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnProcesar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExpresion;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPosOrden;
        private System.Windows.Forms.TextBox txtTRecorrido;
    }
}

