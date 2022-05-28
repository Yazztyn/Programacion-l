namespace Principal
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
            this.lstFacturas = new System.Windows.Forms.ListBox();
            this.btnEnqueue = new System.Windows.Forms.Button();
            this.btnTope = new System.Windows.Forms.Button();
            this.btnDequeue = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.btnPestaña = new System.Windows.Forms.Button();
            this.btnFormBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstFacturas
            // 
            this.lstFacturas.BackColor = System.Drawing.SystemColors.Window;
            this.lstFacturas.FormattingEnabled = true;
            this.lstFacturas.Location = new System.Drawing.Point(12, 116);
            this.lstFacturas.Name = "lstFacturas";
            this.lstFacturas.Size = new System.Drawing.Size(285, 173);
            this.lstFacturas.TabIndex = 0;
            // 
            // btnEnqueue
            // 
            this.btnEnqueue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEnqueue.Location = new System.Drawing.Point(12, 325);
            this.btnEnqueue.Name = "btnEnqueue";
            this.btnEnqueue.Size = new System.Drawing.Size(75, 23);
            this.btnEnqueue.TabIndex = 1;
            this.btnEnqueue.Text = "Cargar";
            this.btnEnqueue.UseVisualStyleBackColor = false;
            this.btnEnqueue.Click += new System.EventHandler(this.btnEnqueue_Click);
            // 
            // btnTope
            // 
            this.btnTope.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTope.Location = new System.Drawing.Point(12, 367);
            this.btnTope.Name = "btnTope";
            this.btnTope.Size = new System.Drawing.Size(75, 23);
            this.btnTope.TabIndex = 2;
            this.btnTope.Text = "Tope";
            this.btnTope.UseVisualStyleBackColor = false;
            this.btnTope.Click += new System.EventHandler(this.btnTope_Click);
            // 
            // btnDequeue
            // 
            this.btnDequeue.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDequeue.Location = new System.Drawing.Point(222, 325);
            this.btnDequeue.Name = "btnDequeue";
            this.btnDequeue.Size = new System.Drawing.Size(75, 23);
            this.btnDequeue.TabIndex = 3;
            this.btnDequeue.Text = "Borrar";
            this.btnDequeue.UseVisualStyleBackColor = false;
            this.btnDequeue.Click += new System.EventHandler(this.btnDequeue_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExit.Location = new System.Drawing.Point(222, 367);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Ingrese el valor deseado a cargar";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(200, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(97, 20);
            this.txtCodigo.TabIndex = 6;
            // 
            // btnPestaña
            // 
            this.btnPestaña.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPestaña.Location = new System.Drawing.Point(12, 12);
            this.btnPestaña.Name = "btnPestaña";
            this.btnPestaña.Size = new System.Drawing.Size(93, 23);
            this.btnPestaña.TabIndex = 7;
            this.btnPestaña.Text = "Nueva Pestaña";
            this.btnPestaña.UseVisualStyleBackColor = false;
            this.btnPestaña.Click += new System.EventHandler(this.btnPestaña_Click);
            // 
            // btnFormBuscar
            // 
            this.btnFormBuscar.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFormBuscar.Location = new System.Drawing.Point(222, 12);
            this.btnFormBuscar.Name = "btnFormBuscar";
            this.btnFormBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnFormBuscar.TabIndex = 8;
            this.btnFormBuscar.Text = "Buscar";
            this.btnFormBuscar.UseVisualStyleBackColor = false;
            this.btnFormBuscar.Click += new System.EventHandler(this.btnFormBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 441);
            this.Controls.Add(this.btnFormBuscar);
            this.Controls.Add(this.btnPestaña);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnDequeue);
            this.Controls.Add(this.btnTope);
            this.Controls.Add(this.btnEnqueue);
            this.Controls.Add(this.lstFacturas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstFacturas;
        private System.Windows.Forms.Button btnEnqueue;
        private System.Windows.Forms.Button btnTope;
        private System.Windows.Forms.Button btnDequeue;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Button btnPestaña;
        private System.Windows.Forms.Button btnFormBuscar;
    }
}

