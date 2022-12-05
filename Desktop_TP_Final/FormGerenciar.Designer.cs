
namespace Desktop_TP_Final
{
    partial class FormGerenciar
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.deletar_btn = new System.Windows.Forms.Button();
            this.editar_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(97, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(152, 199);
            this.listBox1.TabIndex = 0;
            // 
            // deletar_btn
            // 
            this.deletar_btn.Location = new System.Drawing.Point(274, 153);
            this.deletar_btn.Name = "deletar_btn";
            this.deletar_btn.Size = new System.Drawing.Size(109, 23);
            this.deletar_btn.TabIndex = 6;
            this.deletar_btn.Text = "Deletar Usuario";
            this.deletar_btn.UseVisualStyleBackColor = true;
            this.deletar_btn.Click += new System.EventHandler(this.deletar_btn_Click);
            // 
            // editar_btn
            // 
            this.editar_btn.Location = new System.Drawing.Point(274, 78);
            this.editar_btn.Name = "editar_btn";
            this.editar_btn.Size = new System.Drawing.Size(109, 23);
            this.editar_btn.TabIndex = 7;
            this.editar_btn.Text = "Editar Usuario";
            this.editar_btn.UseVisualStyleBackColor = true;
            this.editar_btn.Click += new System.EventHandler(this.editar_btn_Click);
            // 
            // FormGerenciar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 266);
            this.Controls.Add(this.editar_btn);
            this.Controls.Add(this.deletar_btn);
            this.Controls.Add(this.listBox1);
            this.Name = "FormGerenciar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerenciar Usuários";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button deletar_btn;
        private System.Windows.Forms.Button editar_btn;
    }
}