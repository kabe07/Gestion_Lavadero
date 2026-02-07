namespace GestionLavadero
{
    partial class VentanaCliente
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
            this.tbnombre = new System.Windows.Forms.TextBox();
            this.tbdni = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btagregar = new System.Windows.Forms.Button();
            this.btcancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbnombre
            // 
            this.tbnombre.Location = new System.Drawing.Point(125, 38);
            this.tbnombre.Name = "tbnombre";
            this.tbnombre.Size = new System.Drawing.Size(100, 20);
            this.tbnombre.TabIndex = 0;
            // 
            // tbdni
            // 
            this.tbdni.Location = new System.Drawing.Point(125, 97);
            this.tbdni.Name = "tbdni";
            this.tbdni.Size = new System.Drawing.Size(100, 20);
            this.tbdni.TabIndex = 1;
            this.tbdni.TextChanged += new System.EventHandler(this.tbdni_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Dni:";
            // 
            // btagregar
            // 
            this.btagregar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btagregar.Location = new System.Drawing.Point(25, 147);
            this.btagregar.Name = "btagregar";
            this.btagregar.Size = new System.Drawing.Size(75, 23);
            this.btagregar.TabIndex = 4;
            this.btagregar.Text = "Agregar";
            this.btagregar.UseVisualStyleBackColor = true;
            this.btagregar.Click += new System.EventHandler(this.btagregar_Click);
            // 
            // btcancelar
            // 
            this.btcancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btcancelar.Location = new System.Drawing.Point(150, 147);
            this.btcancelar.Name = "btcancelar";
            this.btcancelar.Size = new System.Drawing.Size(75, 23);
            this.btcancelar.TabIndex = 5;
            this.btcancelar.Text = "Cancelar";
            this.btcancelar.UseVisualStyleBackColor = true;
            // 
            // VentanaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 225);
            this.Controls.Add(this.btcancelar);
            this.Controls.Add(this.btagregar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbdni);
            this.Controls.Add(this.tbnombre);
            this.Name = "VentanaCliente";
            this.Text = "VentanaCliente";
            this.Load += new System.EventHandler(this.VentanaCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox tbnombre;
        public System.Windows.Forms.TextBox tbdni;
        public System.Windows.Forms.Button btagregar;
        public System.Windows.Forms.Button btcancelar;
    }
}