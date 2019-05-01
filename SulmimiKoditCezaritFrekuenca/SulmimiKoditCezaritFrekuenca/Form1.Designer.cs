namespace SulmimiKoditCezaritFrekuenca
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDekripto = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.lblCiphertext = new System.Windows.Forms.Label();
            this.txtCiphertext = new System.Windows.Forms.TextBox();
            this.txtPlaintext = new System.Windows.Forms.TextBox();
            this.lblPlaintext = new System.Windows.Forms.Label();
            this.lblSqarim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(502, 282);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(124, 148);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(383, 185);
            this.btnReset.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 65);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDekripto
            // 
            this.btnDekripto.Location = new System.Drawing.Point(502, 185);
            this.btnDekripto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDekripto.Name = "btnDekripto";
            this.btnDekripto.Size = new System.Drawing.Size(124, 65);
            this.btnDekripto.TabIndex = 2;
            this.btnDekripto.Text = "Dekripto";
            this.btnDekripto.UseVisualStyleBackColor = true;
            this.btnDekripto.Click += new System.EventHandler(this.btnDekripto_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(502, 24);
            this.btnEnter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(124, 150);
            this.btnEnter.TabIndex = 3;
            this.btnEnter.Text = "Enter File";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // lblCiphertext
            // 
            this.lblCiphertext.AutoSize = true;
            this.lblCiphertext.Location = new System.Drawing.Point(19, 9);
            this.lblCiphertext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCiphertext.Name = "lblCiphertext";
            this.lblCiphertext.Size = new System.Drawing.Size(54, 13);
            this.lblCiphertext.TabIndex = 4;
            this.lblCiphertext.Text = "Ciphertext";
            // 
            // txtCiphertext
            // 
            this.txtCiphertext.Location = new System.Drawing.Point(21, 24);
            this.txtCiphertext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtCiphertext.Multiline = true;
            this.txtCiphertext.Name = "txtCiphertext";
            this.txtCiphertext.Size = new System.Drawing.Size(477, 150);
            this.txtCiphertext.TabIndex = 5;
            this.txtCiphertext.TextChanged += new System.EventHandler(this.txtCiphertext_TextChanged);
            // 
            // txtPlaintext
            // 
            this.txtPlaintext.Location = new System.Drawing.Point(21, 282);
            this.txtPlaintext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtPlaintext.Multiline = true;
            this.txtPlaintext.Name = "txtPlaintext";
            this.txtPlaintext.ReadOnly = true;
            this.txtPlaintext.Size = new System.Drawing.Size(477, 148);
            this.txtPlaintext.TabIndex = 6;
            this.txtPlaintext.TextChanged += new System.EventHandler(this.txtPlaintext_TextChanged);
            // 
            // lblPlaintext
            // 
            this.lblPlaintext.AutoSize = true;
            this.lblPlaintext.Location = new System.Drawing.Point(19, 267);
            this.lblPlaintext.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPlaintext.Name = "lblPlaintext";
            this.lblPlaintext.Size = new System.Drawing.Size(47, 13);
            this.lblPlaintext.TabIndex = 7;
            this.lblPlaintext.Text = "Plaintext";
            // 
            // lblSqarim
            // 
            this.lblSqarim.AutoSize = true;
            this.lblSqarim.Location = new System.Drawing.Point(236, 255);
            this.lblSqarim.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSqarim.Name = "lblSqarim";
            this.lblSqarim.Size = new System.Drawing.Size(388, 13);
            this.lblSqarim.TabIndex = 8;
            this.lblSqarim.Text = "* Nese teksti i dekriptuar nuk eshte i duhuri ateher klikoni butonin dekripto per" +
    "seri";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 441);
            this.Controls.Add(this.lblSqarim);
            this.Controls.Add(this.lblPlaintext);
            this.Controls.Add(this.txtPlaintext);
            this.Controls.Add(this.txtCiphertext);
            this.Controls.Add(this.lblCiphertext);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.btnDekripto);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Sulmimi i kodit te Cezarit duke mesuar frekuencat e shkronjave nga ndonje tekst f" +
    "ajll.";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDekripto;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label lblCiphertext;
        private System.Windows.Forms.TextBox txtCiphertext;
        private System.Windows.Forms.TextBox txtPlaintext;
        private System.Windows.Forms.Label lblPlaintext;
        private System.Windows.Forms.Label lblSqarim;
    }
}

