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
            this.FormGestao = new System.Windows.Forms.Button();
            this.GestorOficina = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FormGestao
            // 
            this.FormGestao.Location = new System.Drawing.Point(112, 207);
            this.FormGestao.Name = "FormGestao";
            this.FormGestao.Size = new System.Drawing.Size(202, 23);
            this.FormGestao.TabIndex = 0;
            this.FormGestao.Text = "Gestao Clientes";
            this.FormGestao.UseVisualStyleBackColor = true;
            this.FormGestao.Click += new System.EventHandler(this.FormGestao_Click);
            // 
            // GestorOficina
            // 
            this.GestorOficina.Location = new System.Drawing.Point(452, 173);
            this.GestorOficina.Name = "GestorOficina";
            this.GestorOficina.Size = new System.Drawing.Size(198, 23);
            this.GestorOficina.TabIndex = 1;
            this.GestorOficina.Text = "Gestor Oficina";
            this.GestorOficina.UseVisualStyleBackColor = true;
            this.GestorOficina.Click += new System.EventHandler(this.GestorOficina_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(345, 86);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(361, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.GestorOficina);
            this.Controls.Add(this.FormGestao);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FormGestao;
        private System.Windows.Forms.Button GestorOficina;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

