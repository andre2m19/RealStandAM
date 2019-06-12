namespace RealStandAM__
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.FormGestao = new System.Windows.Forms.Button();
            this.GestorOficina = new System.Windows.Forms.Button();
            this.buttonGestaoVenda = new System.Windows.Forms.Button();
            this.buttonGestaoAluguer = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // FormGestao
            // 
            this.FormGestao.Location = new System.Drawing.Point(78, 39);
            this.FormGestao.Name = "FormGestao";
            this.FormGestao.Size = new System.Drawing.Size(212, 70);
            this.FormGestao.TabIndex = 0;
            this.FormGestao.Text = "Gestao Clientes";
            this.FormGestao.UseVisualStyleBackColor = true;
            this.FormGestao.Click += new System.EventHandler(this.FormGestao_Click);
            // 
            // GestorOficina
            // 
            this.GestorOficina.Location = new System.Drawing.Point(78, 134);
            this.GestorOficina.Name = "GestorOficina";
            this.GestorOficina.Size = new System.Drawing.Size(212, 70);
            this.GestorOficina.TabIndex = 1;
            this.GestorOficina.Text = "Gestor Oficina";
            this.GestorOficina.UseVisualStyleBackColor = true;
            this.GestorOficina.Click += new System.EventHandler(this.GestorOficina_Click);
            // 
            // buttonGestaoVenda
            // 
            this.buttonGestaoVenda.Location = new System.Drawing.Point(78, 314);
            this.buttonGestaoVenda.Name = "buttonGestaoVenda";
            this.buttonGestaoVenda.Size = new System.Drawing.Size(212, 70);
            this.buttonGestaoVenda.TabIndex = 2;
            this.buttonGestaoVenda.Text = "Gestao Vendas";
            this.buttonGestaoVenda.UseVisualStyleBackColor = true;
            this.buttonGestaoVenda.Click += new System.EventHandler(this.buttonGestaoVenda_Click);
            // 
            // buttonGestaoAluguer
            // 
            this.buttonGestaoAluguer.Location = new System.Drawing.Point(78, 222);
            this.buttonGestaoAluguer.Name = "buttonGestaoAluguer";
            this.buttonGestaoAluguer.Size = new System.Drawing.Size(212, 70);
            this.buttonGestaoAluguer.TabIndex = 3;
            this.buttonGestaoAluguer.Text = "Gestao Aluguer";
            this.buttonGestaoAluguer.UseVisualStyleBackColor = true;
            this.buttonGestaoAluguer.Click += new System.EventHandler(this.buttonGestaoAluguer_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(459, 123);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 201);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(562, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "RealStand ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonGestaoAluguer);
            this.Controls.Add(this.buttonGestaoVenda);
            this.Controls.Add(this.GestorOficina);
            this.Controls.Add(this.FormGestao);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button FormGestao;
        private System.Windows.Forms.Button GestorOficina;
        private System.Windows.Forms.Button buttonGestaoVenda;
        private System.Windows.Forms.Button buttonGestaoAluguer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}

