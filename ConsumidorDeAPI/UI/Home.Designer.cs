
namespace UI
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnIniciarCaptura = new System.Windows.Forms.Button();
            this.btnFinalizarCaptura = new System.Windows.Forms.Button();
            this.gridClima = new System.Windows.Forms.DataGridView();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblTotalSoleado = new System.Windows.Forms.Label();
            this.lblTotalNublado = new System.Windows.Forms.Label();
            this.lblTotalLluvioso = new System.Windows.Forms.Label();
            this.lblPromedioTemperatura = new System.Windows.Forms.Label();
            this.lblPromedioHumedad = new System.Windows.Forms.Label();
            this.lblPromedioPrecipitaciones = new System.Windows.Forms.Label();
            this.lblEstadoDeModa = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridClima)).BeginInit();
            this.SuspendLayout();
            // 
            // btnIniciarCaptura
            // 
            this.btnIniciarCaptura.Location = new System.Drawing.Point(12, 38);
            this.btnIniciarCaptura.Name = "btnIniciarCaptura";
            this.btnIniciarCaptura.Size = new System.Drawing.Size(133, 23);
            this.btnIniciarCaptura.TabIndex = 0;
            this.btnIniciarCaptura.Text = "Iniciar Captura";
            this.btnIniciarCaptura.UseVisualStyleBackColor = true;
            this.btnIniciarCaptura.Click += new System.EventHandler(this.btnIniciarCaptura_Click);
            // 
            // btnFinalizarCaptura
            // 
            this.btnFinalizarCaptura.Location = new System.Drawing.Point(550, 38);
            this.btnFinalizarCaptura.Name = "btnFinalizarCaptura";
            this.btnFinalizarCaptura.Size = new System.Drawing.Size(157, 23);
            this.btnFinalizarCaptura.TabIndex = 1;
            this.btnFinalizarCaptura.Text = "Finalizar Captura";
            this.btnFinalizarCaptura.UseVisualStyleBackColor = true;
            this.btnFinalizarCaptura.Click += new System.EventHandler(this.btnFinalizarCaptura_Click);
            // 
            // gridClima
            // 
            this.gridClima.AllowUserToAddRows = false;
            this.gridClima.AllowUserToDeleteRows = false;
            this.gridClima.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridClima.Location = new System.Drawing.Point(12, 91);
            this.gridClima.Name = "gridClima";
            this.gridClima.ReadOnly = true;
            this.gridClima.RowTemplate.Height = 25;
            this.gridClima.Size = new System.Drawing.Size(695, 450);
            this.gridClima.TabIndex = 2;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Location = new System.Drawing.Point(755, 91);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(46, 15);
            this.lblTotales.TabIndex = 3;
            this.lblTotales.Text = "Totales:";
            // 
            // lblTotalSoleado
            // 
            this.lblTotalSoleado.AutoSize = true;
            this.lblTotalSoleado.Location = new System.Drawing.Point(793, 106);
            this.lblTotalSoleado.Name = "lblTotalSoleado";
            this.lblTotalSoleado.Size = new System.Drawing.Size(52, 15);
            this.lblTotalSoleado.TabIndex = 4;
            this.lblTotalSoleado.Text = "Soleado:";
            // 
            // lblTotalNublado
            // 
            this.lblTotalNublado.AutoSize = true;
            this.lblTotalNublado.Location = new System.Drawing.Point(793, 121);
            this.lblTotalNublado.Name = "lblTotalNublado";
            this.lblTotalNublado.Size = new System.Drawing.Size(56, 15);
            this.lblTotalNublado.TabIndex = 5;
            this.lblTotalNublado.Text = "Nublado:";
            // 
            // lblTotalLluvioso
            // 
            this.lblTotalLluvioso.AutoSize = true;
            this.lblTotalLluvioso.Location = new System.Drawing.Point(793, 136);
            this.lblTotalLluvioso.Name = "lblTotalLluvioso";
            this.lblTotalLluvioso.Size = new System.Drawing.Size(54, 15);
            this.lblTotalLluvioso.TabIndex = 6;
            this.lblTotalLluvioso.Text = "Lluvioso:";
            // 
            // lblPromedioTemperatura
            // 
            this.lblPromedioTemperatura.AutoSize = true;
            this.lblPromedioTemperatura.Location = new System.Drawing.Point(755, 184);
            this.lblPromedioTemperatura.Name = "lblPromedioTemperatura";
            this.lblPromedioTemperatura.Size = new System.Drawing.Size(134, 15);
            this.lblPromedioTemperatura.TabIndex = 7;
            this.lblPromedioTemperatura.Text = "Promedio Temperatura: ";
            // 
            // lblPromedioHumedad
            // 
            this.lblPromedioHumedad.AutoSize = true;
            this.lblPromedioHumedad.Location = new System.Drawing.Point(755, 216);
            this.lblPromedioHumedad.Name = "lblPromedioHumedad";
            this.lblPromedioHumedad.Size = new System.Drawing.Size(121, 15);
            this.lblPromedioHumedad.TabIndex = 8;
            this.lblPromedioHumedad.Text = "Promedio Humedad: ";
            // 
            // lblPromedioPrecipitaciones
            // 
            this.lblPromedioPrecipitaciones.AutoSize = true;
            this.lblPromedioPrecipitaciones.Location = new System.Drawing.Point(755, 250);
            this.lblPromedioPrecipitaciones.Name = "lblPromedioPrecipitaciones";
            this.lblPromedioPrecipitaciones.Size = new System.Drawing.Size(145, 15);
            this.lblPromedioPrecipitaciones.TabIndex = 9;
            this.lblPromedioPrecipitaciones.Text = "Promedio Precipitaciones:";
            // 
            // lblEstadoDeModa
            // 
            this.lblEstadoDeModa.AutoSize = true;
            this.lblEstadoDeModa.Location = new System.Drawing.Point(755, 283);
            this.lblEstadoDeModa.Name = "lblEstadoDeModa";
            this.lblEstadoDeModa.Size = new System.Drawing.Size(98, 15);
            this.lblEstadoDeModa.TabIndex = 10;
            this.lblEstadoDeModa.Text = "Estado de Moda: ";
            // 
            // timer1
            // 
            this.timer1.Interval = 2000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 574);
            this.Controls.Add(this.lblEstadoDeModa);
            this.Controls.Add(this.lblPromedioPrecipitaciones);
            this.Controls.Add(this.lblPromedioHumedad);
            this.Controls.Add(this.lblPromedioTemperatura);
            this.Controls.Add(this.lblTotalLluvioso);
            this.Controls.Add(this.lblTotalNublado);
            this.Controls.Add(this.lblTotalSoleado);
            this.Controls.Add(this.lblTotales);
            this.Controls.Add(this.gridClima);
            this.Controls.Add(this.btnFinalizarCaptura);
            this.Controls.Add(this.btnIniciarCaptura);
            this.Name = "Home";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.gridClima)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIniciarCaptura;
        private System.Windows.Forms.Button btnFinalizarCaptura;
        private System.Windows.Forms.DataGridView gridClima;
        private System.Windows.Forms.Label lblTotales;
        private System.Windows.Forms.Label lblTotalSoleado;
        private System.Windows.Forms.Label lblTotalNublado;
        private System.Windows.Forms.Label lblTotalLluvioso;
        private System.Windows.Forms.Label lblPromedioTemperatura;
        private System.Windows.Forms.Label lblPromedioHumedad;
        private System.Windows.Forms.Label lblPromedioPrecipitaciones;
        private System.Windows.Forms.Label lblEstadoDeModa;
        private System.Windows.Forms.Timer timer1;
    }
}

