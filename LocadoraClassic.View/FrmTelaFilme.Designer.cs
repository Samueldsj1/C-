namespace LocadoraClassic.View
{
    partial class FrmTelaFilme
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCategoriaFilme = new System.Windows.Forms.TextBox();
            this.txtGeneroFilme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNomeFilme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.txtSinopseFilme = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDuracaoFilme = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(66, 363);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(687, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "la";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Categoria";
            // 
            // txtCategoriaFilme
            // 
            this.txtCategoriaFilme.Location = new System.Drawing.Point(66, 40);
            this.txtCategoriaFilme.Name = "txtCategoriaFilme";
            this.txtCategoriaFilme.Size = new System.Drawing.Size(331, 20);
            this.txtCategoriaFilme.TabIndex = 2;
            // 
            // txtGeneroFilme
            // 
            this.txtGeneroFilme.Location = new System.Drawing.Point(66, 79);
            this.txtGeneroFilme.Name = "txtGeneroFilme";
            this.txtGeneroFilme.Size = new System.Drawing.Size(331, 20);
            this.txtGeneroFilme.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(63, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Gênero";
            // 
            // txtNomeFilme
            // 
            this.txtNomeFilme.Location = new System.Drawing.Point(66, 118);
            this.txtNomeFilme.Name = "txtNomeFilme";
            this.txtNomeFilme.Size = new System.Drawing.Size(331, 20);
            this.txtNomeFilme.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome do Filme";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(63, 141);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(48, 13);
            this.label.TabIndex = 7;
            this.label.Text = "Duração";
            // 
            // txtSinopseFilme
            // 
            this.txtSinopseFilme.Location = new System.Drawing.Point(66, 196);
            this.txtSinopseFilme.Multiline = true;
            this.txtSinopseFilme.Name = "txtSinopseFilme";
            this.txtSinopseFilme.Size = new System.Drawing.Size(687, 133);
            this.txtSinopseFilme.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(63, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Sinopse";
            // 
            // txtDuracaoFilme
            // 
            this.txtDuracaoFilme.Location = new System.Drawing.Point(66, 158);
            this.txtDuracaoFilme.Mask = "90:00";
            this.txtDuracaoFilme.Name = "txtDuracaoFilme";
            this.txtDuracaoFilme.Size = new System.Drawing.Size(331, 20);
            this.txtDuracaoFilme.TabIndex = 11;
            this.txtDuracaoFilme.ValidatingType = typeof(System.DateTime);
            // 
            // FrmTelaFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDuracaoFilme);
            this.Controls.Add(this.txtSinopseFilme);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtNomeFilme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtGeneroFilme);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCategoriaFilme);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "FrmTelaFilme";
            this.Text = "FrmTelaFilme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCategoriaFilme;
        private System.Windows.Forms.TextBox txtGeneroFilme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNomeFilme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtSinopseFilme;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox txtDuracaoFilme;
    }
}