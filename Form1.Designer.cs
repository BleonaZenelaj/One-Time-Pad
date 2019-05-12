namespace OneTimePad
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
            this.btnDekripto = new System.Windows.Forms.Button();
            this.txtTextiDekriptuar = new System.Windows.Forms.TextBox();
            this.lblTextiDekriptuar = new System.Windows.Forms.Label();
            this.btnEnkripto = new System.Windows.Forms.Button();
            this.txtCiphertexti = new System.Windows.Forms.TextBox();
            this.lblCiphertexti = new System.Windows.Forms.Label();
            this.txtPlaintexti = new System.Windows.Forms.TextBox();
            this.lblPlaintexti = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDekripto
            // 
            this.btnDekripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDekripto.Location = new System.Drawing.Point(314, 318);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(111, 48);
            this.btnDekripto.TabIndex = 25;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // txtTextiDekriptuar
            // 
            this.txtTextiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTextiDekriptuar.Location = new System.Drawing.Point(12, 268);
            this.txtTextiDekriptuar.Name = "txtTextiDekriptuar";
            this.txtTextiDekriptuar.Size = new System.Drawing.Size(413, 30);
            this.txtTextiDekriptuar.TabIndex = 24;
            // 
            // lblTextiDekriptuar
            // 
            this.lblTextiDekriptuar.AutoSize = true;
            this.lblTextiDekriptuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTextiDekriptuar.Location = new System.Drawing.Point(7, 240);
            this.lblTextiDekriptuar.Name = "lblTextiDekriptuar";
            this.lblTextiDekriptuar.Size = new System.Drawing.Size(146, 25);
            this.lblTextiDekriptuar.TabIndex = 23;
            this.lblTextiDekriptuar.Text = "Texti dekriptuar";
            // 
            // btnEnkripto
            // 
            this.btnEnkripto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnkripto.Location = new System.Drawing.Point(313, 170);
            this.btnEnkripto.Name = "btnEnkripto";
            this.btnEnkripto.Size = new System.Drawing.Size(112, 47);
            this.btnEnkripto.TabIndex = 22;
            this.btnEnkripto.Text = "Enkripto";
            this.btnEnkripto.UseVisualStyleBackColor = true;
            this.btnEnkripto.Click += new System.EventHandler(this.btnEnkripto_Click);
            // 
            // txtCiphertexti
            // 
            this.txtCiphertexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCiphertexti.Location = new System.Drawing.Point(12, 123);
            this.txtCiphertexti.Name = "txtCiphertexti";
            this.txtCiphertexti.Size = new System.Drawing.Size(413, 30);
            this.txtCiphertexti.TabIndex = 21;
            // 
            // lblCiphertexti
            // 
            this.lblCiphertexti.AutoSize = true;
            this.lblCiphertexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCiphertexti.Location = new System.Drawing.Point(8, 92);
            this.lblCiphertexti.Name = "lblCiphertexti";
            this.lblCiphertexti.Size = new System.Drawing.Size(105, 25);
            this.lblCiphertexti.TabIndex = 20;
            this.lblCiphertexti.Text = "Ciphertexti";
            // 
            // txtPlaintexti
            // 
            this.txtPlaintexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlaintexti.Location = new System.Drawing.Point(12, 44);
            this.txtPlaintexti.Name = "txtPlaintexti";
            this.txtPlaintexti.Size = new System.Drawing.Size(413, 30);
            this.txtPlaintexti.TabIndex = 19;
            // 
            // lblPlaintexti
            // 
            this.lblPlaintexti.AutoSize = true;
            this.lblPlaintexti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaintexti.Location = new System.Drawing.Point(8, 14);
            this.lblPlaintexti.Name = "lblPlaintexti";
            this.lblPlaintexti.Size = new System.Drawing.Size(90, 25);
            this.lblPlaintexti.TabIndex = 18;
            this.lblPlaintexti.Text = "Plaintexti";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 377);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.txtTextiDekriptuar);
            this.Controls.Add(this.lblTextiDekriptuar);
            this.Controls.Add(this.btnEnkripto);
            this.Controls.Add(this.txtCiphertexti);
            this.Controls.Add(this.lblCiphertexti);
            this.Controls.Add(this.txtPlaintexti);
            this.Controls.Add(this.lblPlaintexti);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.TextBox txtTextiDekriptuar;
        private System.Windows.Forms.Label lblTextiDekriptuar;
        private System.Windows.Forms.Button btnEnkripto;
        private System.Windows.Forms.TextBox txtCiphertexti;
        private System.Windows.Forms.Label lblCiphertexti;
        private System.Windows.Forms.TextBox txtPlaintexti;
        private System.Windows.Forms.Label lblPlaintexti;
    }
}

