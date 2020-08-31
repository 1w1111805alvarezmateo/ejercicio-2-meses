namespace ejercicio_2_meses
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
            this.lstMeses = new System.Windows.Forms.ListBox();
            this.lstSlectMeses = new System.Windows.Forms.ListBox();
            this.btnQuitarAll = new System.Windows.Forms.Button();
            this.btnQitarSelec = new System.Windows.Forms.Button();
            this.btnAgregarAll = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAgregarSelec = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstMeses
            // 
            this.lstMeses.AccessibleName = "";
            this.lstMeses.FormattingEnabled = true;
            this.lstMeses.Location = new System.Drawing.Point(12, 35);
            this.lstMeses.Name = "lstMeses";
            this.lstMeses.Size = new System.Drawing.Size(118, 212);
            this.lstMeses.TabIndex = 0;
            this.lstMeses.SelectedIndexChanged += new System.EventHandler(this.lstMeses_SelectedIndexChanged);
            // 
            // lstSlectMeses
            // 
            this.lstSlectMeses.AccessibleName = "lstMesesSlec";
            this.lstSlectMeses.FormattingEnabled = true;
            this.lstSlectMeses.Location = new System.Drawing.Point(277, 35);
            this.lstSlectMeses.Name = "lstSlectMeses";
            this.lstSlectMeses.Size = new System.Drawing.Size(118, 212);
            this.lstSlectMeses.TabIndex = 0;
            // 
            // btnQuitarAll
            // 
            this.btnQuitarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuitarAll.Location = new System.Drawing.Point(175, 187);
            this.btnQuitarAll.Name = "btnQuitarAll";
            this.btnQuitarAll.Size = new System.Drawing.Size(62, 23);
            this.btnQuitarAll.TabIndex = 1;
            this.btnQuitarAll.Text = "<<";
            this.btnQuitarAll.UseVisualStyleBackColor = true;
            this.btnQuitarAll.Click += new System.EventHandler(this.btnQuitarAll_Click);
            // 
            // btnQitarSelec
            // 
            this.btnQitarSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQitarSelec.Location = new System.Drawing.Point(175, 144);
            this.btnQitarSelec.Name = "btnQitarSelec";
            this.btnQitarSelec.Size = new System.Drawing.Size(62, 23);
            this.btnQitarSelec.TabIndex = 1;
            this.btnQitarSelec.Text = "<";
            this.btnQitarSelec.UseVisualStyleBackColor = true;
            this.btnQitarSelec.Click += new System.EventHandler(this.btnQitarSelec_Click);
            // 
            // btnAgregarAll
            // 
            this.btnAgregarAll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnAgregarAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarAll.Location = new System.Drawing.Point(175, 56);
            this.btnAgregarAll.Name = "btnAgregarAll";
            this.btnAgregarAll.Size = new System.Drawing.Size(62, 23);
            this.btnAgregarAll.TabIndex = 1;
            this.btnAgregarAll.Text = ">>";
            this.btnAgregarAll.UseVisualStyleBackColor = true;
            this.btnAgregarAll.Click += new System.EventHandler(this.btnAgregarAll_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(307, 307);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAgregarSelec
            // 
            this.btnAgregarSelec.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSelec.Location = new System.Drawing.Point(175, 100);
            this.btnAgregarSelec.Name = "btnAgregarSelec";
            this.btnAgregarSelec.Size = new System.Drawing.Size(62, 23);
            this.btnAgregarSelec.TabIndex = 1;
            this.btnAgregarSelec.Text = ">";
            this.btnAgregarSelec.UseVisualStyleBackColor = true;
            this.btnAgregarSelec.Click += new System.EventHandler(this.btnAgregarSelec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 371);
            this.Controls.Add(this.btnAgregarSelec);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAgregarAll);
            this.Controls.Add(this.btnQitarSelec);
            this.Controls.Add(this.btnQuitarAll);
            this.Controls.Add(this.lstSlectMeses);
            this.Controls.Add(this.lstMeses);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "colecciones";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstMeses;
        private System.Windows.Forms.ListBox lstSlectMeses;
        private System.Windows.Forms.Button btnQuitarAll;
        private System.Windows.Forms.Button btnQitarSelec;
        private System.Windows.Forms.Button btnAgregarAll;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAgregarSelec;
    }
}

