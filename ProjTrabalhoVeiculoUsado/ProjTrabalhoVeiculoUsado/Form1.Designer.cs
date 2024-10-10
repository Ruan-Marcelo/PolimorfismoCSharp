namespace ProjTrabalhoVeiculoUsado
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnVeiculoUsado = new System.Windows.Forms.Button();
            this.btnCaminhao = new System.Windows.Forms.Button();
            this.btnCalcularDepreciação = new System.Windows.Forms.Button();
            this.btnCalcularDepreciaçãoCaminhão = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVeiculoUsado
            // 
            this.btnVeiculoUsado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVeiculoUsado.Location = new System.Drawing.Point(606, 35);
            this.btnVeiculoUsado.Name = "btnVeiculoUsado";
            this.btnVeiculoUsado.Size = new System.Drawing.Size(407, 64);
            this.btnVeiculoUsado.TabIndex = 0;
            this.btnVeiculoUsado.Text = "Dados Veiculos";
            this.btnVeiculoUsado.UseVisualStyleBackColor = true;
            this.btnVeiculoUsado.Click += new System.EventHandler(this.btnVeiculoUsado_Click);
            // 
            // btnCaminhao
            // 
            this.btnCaminhao.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCaminhao.Location = new System.Drawing.Point(77, 35);
            this.btnCaminhao.Name = "btnCaminhao";
            this.btnCaminhao.Size = new System.Drawing.Size(407, 64);
            this.btnCaminhao.TabIndex = 1;
            this.btnCaminhao.Text = "Dados Caminhão";
            this.btnCaminhao.UseVisualStyleBackColor = true;
            this.btnCaminhao.Click += new System.EventHandler(this.btnCaminhao_Click);
            // 
            // btnCalcularDepreciação
            // 
            this.btnCalcularDepreciação.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDepreciação.Location = new System.Drawing.Point(150, 475);
            this.btnCalcularDepreciação.Name = "btnCalcularDepreciação";
            this.btnCalcularDepreciação.Size = new System.Drawing.Size(743, 64);
            this.btnCalcularDepreciação.TabIndex = 2;
            this.btnCalcularDepreciação.Text = "Calcular Depreciação Veiculo";
            this.btnCalcularDepreciação.UseVisualStyleBackColor = true;
            this.btnCalcularDepreciação.Click += new System.EventHandler(this.btnCalcularDepreciação_Click);
            // 
            // btnCalcularDepreciaçãoCaminhão
            // 
            this.btnCalcularDepreciaçãoCaminhão.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularDepreciaçãoCaminhão.Location = new System.Drawing.Point(150, 383);
            this.btnCalcularDepreciaçãoCaminhão.Name = "btnCalcularDepreciaçãoCaminhão";
            this.btnCalcularDepreciaçãoCaminhão.Size = new System.Drawing.Size(738, 64);
            this.btnCalcularDepreciaçãoCaminhão.TabIndex = 3;
            this.btnCalcularDepreciaçãoCaminhão.Text = "Calcular Depreciação Caminhão";
            this.btnCalcularDepreciaçãoCaminhão.UseVisualStyleBackColor = true;
            this.btnCalcularDepreciaçãoCaminhão.Click += new System.EventHandler(this.btnCalcularDepreciaçãoCaminhão_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(518, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(682, 376);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(61, 85);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(393, 329);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1092, 576);
            this.Controls.Add(this.btnCalcularDepreciaçãoCaminhão);
            this.Controls.Add(this.btnCalcularDepreciação);
            this.Controls.Add(this.btnCaminhao);
            this.Controls.Add(this.btnVeiculoUsado);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVeiculoUsado;
        private System.Windows.Forms.Button btnCaminhao;
        private System.Windows.Forms.Button btnCalcularDepreciação;
        private System.Windows.Forms.Button btnCalcularDepreciaçãoCaminhão;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

