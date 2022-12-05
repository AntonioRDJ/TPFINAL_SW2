
namespace Desktop_TP_Final
{
    partial class FormMain
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
            this.criar_usuario_btn = new System.Windows.Forms.Button();
            this.gerenciar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // criar_usuario_btn
            // 
            this.criar_usuario_btn.Location = new System.Drawing.Point(46, 32);
            this.criar_usuario_btn.Name = "criar_usuario_btn";
            this.criar_usuario_btn.Size = new System.Drawing.Size(75, 23);
            this.criar_usuario_btn.TabIndex = 0;
            this.criar_usuario_btn.Text = "Criar Usuario";
            this.criar_usuario_btn.UseVisualStyleBackColor = true;
            this.criar_usuario_btn.Click += new System.EventHandler(this.criar_usuario_btn_Click);
            // 
            // gerenciar_btn
            // 
            this.gerenciar_btn.Location = new System.Drawing.Point(162, 32);
            this.gerenciar_btn.Name = "gerenciar_btn";
            this.gerenciar_btn.Size = new System.Drawing.Size(130, 23);
            this.gerenciar_btn.TabIndex = 1;
            this.gerenciar_btn.Text = "Gerenciar Usuarios";
            this.gerenciar_btn.UseVisualStyleBackColor = true;
            this.gerenciar_btn.Click += new System.EventHandler(this.gerenciar_btn_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(335, 94);
            this.Controls.Add(this.gerenciar_btn);
            this.Controls.Add(this.criar_usuario_btn);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar/Gerenciar Usuários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button criar_usuario_btn;
        private System.Windows.Forms.Button gerenciar_btn;
    }
}

