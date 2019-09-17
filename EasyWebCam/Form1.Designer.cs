namespace EasyWebCam
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
            this.pbWeb = new System.Windows.Forms.PictureBox();
            this.btnLigarDesligar = new System.Windows.Forms.Button();
            this.btnCapturar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // pbWeb
            // 
            this.pbWeb.Location = new System.Drawing.Point(13, 13);
            this.pbWeb.Name = "pbWeb";
            this.pbWeb.Size = new System.Drawing.Size(514, 244);
            this.pbWeb.TabIndex = 0;
            this.pbWeb.TabStop = false;
            // 
            // btnLigarDesligar
            // 
            this.btnLigarDesligar.Location = new System.Drawing.Point(13, 277);
            this.btnLigarDesligar.Name = "btnLigarDesligar";
            this.btnLigarDesligar.Size = new System.Drawing.Size(514, 23);
            this.btnLigarDesligar.TabIndex = 1;
            this.btnLigarDesligar.Text = "Ligar/Desligar";
            this.btnLigarDesligar.UseVisualStyleBackColor = true;
            this.btnLigarDesligar.Click += new System.EventHandler(this.btnLigarDesligar_Click);
            // 
            // btnCapturar
            // 
            this.btnCapturar.Location = new System.Drawing.Point(13, 317);
            this.btnCapturar.Name = "btnCapturar";
            this.btnCapturar.Size = new System.Drawing.Size(514, 23);
            this.btnCapturar.TabIndex = 2;
            this.btnCapturar.Text = "Capturar";
            this.btnCapturar.UseVisualStyleBackColor = true;
            this.btnCapturar.Click += new System.EventHandler(this.btnCapturar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 352);
            this.Controls.Add(this.btnCapturar);
            this.Controls.Add(this.btnLigarDesligar);
            this.Controls.Add(this.pbWeb);
            this.Name = "Form1";
            this.Text = "EasyWebCam";
            ((System.ComponentModel.ISupportInitialize)(this.pbWeb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbWeb;
        private System.Windows.Forms.Button btnLigarDesligar;
        private System.Windows.Forms.Button btnCapturar;
    }
}

