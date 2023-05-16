namespace OrientacaoObjeto.WindowsForms1
{
    partial class Tela01
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
            this.txtVazio = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.Button();
            this.txtNomeCpf = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtVazio
            // 
            this.txtVazio.Location = new System.Drawing.Point(12, 12);
            this.txtVazio.Name = "txtVazio";
            this.txtVazio.Size = new System.Drawing.Size(121, 23);
            this.txtVazio.TabIndex = 0;
            this.txtVazio.Text = "Construtor Vazio";
            this.txtVazio.UseVisualStyleBackColor = true;
            this.txtVazio.Click += new System.EventHandler(this.txtVazio_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(160, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(121, 23);
            this.txtNome.TabIndex = 1;
            this.txtNome.Text = "Construtor Nome";
            this.txtNome.UseVisualStyleBackColor = true;
            this.txtNome.Click += new System.EventHandler(this.txtNome_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(311, 12);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(121, 23);
            this.txtID.TabIndex = 2;
            this.txtID.Text = "Construtor ID";
            this.txtID.UseVisualStyleBackColor = true;
            this.txtID.Click += new System.EventHandler(this.txtID_Click);
            // 
            // txtNomeCpf
            // 
            this.txtNomeCpf.Location = new System.Drawing.Point(469, 12);
            this.txtNomeCpf.Name = "txtNomeCpf";
            this.txtNomeCpf.Size = new System.Drawing.Size(121, 23);
            this.txtNomeCpf.TabIndex = 3;
            this.txtNomeCpf.Text = "Construtor Nome Cpf";
            this.txtNomeCpf.UseVisualStyleBackColor = true;
            this.txtNomeCpf.Click += new System.EventHandler(this.txtNomeCpf_Click);
            // 
            // Tela01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtNomeCpf);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.txtVazio);
            this.Name = "Tela01";
            this.Text = "Tela01";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtVazio;
        private System.Windows.Forms.Button txtNome;
        private System.Windows.Forms.Button txtID;
        private System.Windows.Forms.Button txtNomeCpf;
    }
}