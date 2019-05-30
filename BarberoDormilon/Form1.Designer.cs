namespace BarberoDormilon
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.barbero = new System.Windows.Forms.PictureBox();
            this.cliente = new System.Windows.Forms.PictureBox();
            this.line = new System.Windows.Forms.PictureBox();
            this.iniciar = new System.Windows.Forms.Button();
            this.procesos = new System.Windows.Forms.Timer(this.components);
            this.proseso2 = new System.Windows.Forms.Timer(this.components);
            this.proseso3 = new System.Windows.Forms.Timer(this.components);
            this.proseso4 = new System.Windows.Forms.Timer(this.components);
            this.dormilon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.barbero)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormilon)).BeginInit();
            this.SuspendLayout();
            // 
            // barbero
            // 
            this.barbero.Image = ((System.Drawing.Image)(resources.GetObject("barbero.Image")));
            this.barbero.Location = new System.Drawing.Point(172, 12);
            this.barbero.Name = "barbero";
            this.barbero.Size = new System.Drawing.Size(188, 94);
            this.barbero.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.barbero.TabIndex = 0;
            this.barbero.TabStop = false;
            // 
            // cliente
            // 
            this.cliente.Image = ((System.Drawing.Image)(resources.GetObject("cliente.Image")));
            this.cliente.Location = new System.Drawing.Point(83, 8);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(32, 46);
            this.cliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cliente.TabIndex = 1;
            this.cliente.TabStop = false;
            // 
            // line
            // 
            this.line.Image = ((System.Drawing.Image)(resources.GetObject("line.Image")));
            this.line.Location = new System.Drawing.Point(123, -7);
            this.line.Name = "line";
            this.line.Size = new System.Drawing.Size(25, 265);
            this.line.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.line.TabIndex = 2;
            this.line.TabStop = false;
            // 
            // iniciar
            // 
            this.iniciar.BackColor = System.Drawing.Color.Green;
            this.iniciar.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iniciar.ForeColor = System.Drawing.Color.White;
            this.iniciar.Location = new System.Drawing.Point(337, 184);
            this.iniciar.Name = "iniciar";
            this.iniciar.Size = new System.Drawing.Size(73, 28);
            this.iniciar.TabIndex = 3;
            this.iniciar.Text = "Iniciar";
            this.iniciar.UseVisualStyleBackColor = false;
            this.iniciar.Click += new System.EventHandler(this.iniciar_Click);
            // 
            // procesos
            // 
            this.procesos.Tick += new System.EventHandler(this.procesos_Tick);
            // 
            // proseso2
            // 
            this.proseso2.Tick += new System.EventHandler(this.proseso2_Tick);
            // 
            // proseso3
            // 
            this.proseso3.Tick += new System.EventHandler(this.proseso3_Tick);
            // 
            // proseso4
            // 
            this.proseso4.Interval = 700;
            this.proseso4.Tick += new System.EventHandler(this.proseso4_Tick);
            // 
            // dormilon
            // 
            this.dormilon.Image = ((System.Drawing.Image)(resources.GetObject("dormilon.Image")));
            this.dormilon.Location = new System.Drawing.Point(172, 12);
            this.dormilon.Name = "dormilon";
            this.dormilon.Size = new System.Drawing.Size(188, 94);
            this.dormilon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.dormilon.TabIndex = 4;
            this.dormilon.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 242);
            this.Controls.Add(this.dormilon);
            this.Controls.Add(this.iniciar);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.barbero);
            this.Controls.Add(this.line);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Barbero Dormilon";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barbero)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.line)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dormilon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox barbero;
        private System.Windows.Forms.PictureBox cliente;
        private System.Windows.Forms.PictureBox line;
        private System.Windows.Forms.Button iniciar;
        private System.Windows.Forms.Timer procesos;
        private System.Windows.Forms.Timer proseso2;
        private System.Windows.Forms.Timer proseso3;
        private System.Windows.Forms.Timer proseso4;
        private System.Windows.Forms.PictureBox dormilon;
    }
}

