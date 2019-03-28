namespace Consumindo_WebApiUsuarios
{
    partial class frmUsuariosApi
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtUri = new System.Windows.Forms.TextBox();
            this.dgvDados = new System.Windows.Forms.DataGridView();
            this.btnObterUsuarios = new System.Windows.Forms.Button();
            this.btnUsuarioPorId = new System.Windows.Forms.Button();
            this.btnIncluirUsuario = new System.Windows.Forms.Button();
            this.btnAtualizarUsuario = new System.Windows.Forms.Button();
            this.btnDeletarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "URI - Web API:";
            // 
            // txtUri
            // 
            this.txtUri.Location = new System.Drawing.Point(171, 49);
            this.txtUri.Name = "txtUri";
            this.txtUri.Size = new System.Drawing.Size(667, 26);
            this.txtUri.TabIndex = 1;
            this.txtUri.Text = "http://localhost:33422/api/Usuarios";
            // 
            // dgvDados
            // 
            this.dgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDados.Location = new System.Drawing.Point(29, 84);
            this.dgvDados.Name = "dgvDados";
            this.dgvDados.RowTemplate.Height = 28;
            this.dgvDados.Size = new System.Drawing.Size(809, 365);
            this.dgvDados.TabIndex = 2;
            // 
            // btnObterUsuarios
            // 
            this.btnObterUsuarios.Location = new System.Drawing.Point(29, 455);
            this.btnObterUsuarios.Name = "btnObterUsuarios";
            this.btnObterUsuarios.Size = new System.Drawing.Size(157, 39);
            this.btnObterUsuarios.TabIndex = 3;
            this.btnObterUsuarios.Text = "Usuários";
            this.btnObterUsuarios.UseVisualStyleBackColor = true;
            this.btnObterUsuarios.Click += new System.EventHandler(this.btnObterUsuarios_Click);
            // 
            // btnUsuarioPorId
            // 
            this.btnUsuarioPorId.Location = new System.Drawing.Point(192, 455);
            this.btnUsuarioPorId.Name = "btnUsuarioPorId";
            this.btnUsuarioPorId.Size = new System.Drawing.Size(157, 39);
            this.btnUsuarioPorId.TabIndex = 4;
            this.btnUsuarioPorId.Text = "Usuário Por ID";
            this.btnUsuarioPorId.UseVisualStyleBackColor = true;
            this.btnUsuarioPorId.Click += new System.EventHandler(this.btnUsuarioPorId_Click);
            // 
            // btnIncluirUsuario
            // 
            this.btnIncluirUsuario.Location = new System.Drawing.Point(355, 455);
            this.btnIncluirUsuario.Name = "btnIncluirUsuario";
            this.btnIncluirUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnIncluirUsuario.TabIndex = 5;
            this.btnIncluirUsuario.Text = "Incluir Usuário";
            this.btnIncluirUsuario.UseVisualStyleBackColor = true;
            this.btnIncluirUsuario.Click += new System.EventHandler(this.btnIncluirUsuario_Click);
            // 
            // btnAtualizarUsuario
            // 
            this.btnAtualizarUsuario.Location = new System.Drawing.Point(518, 455);
            this.btnAtualizarUsuario.Name = "btnAtualizarUsuario";
            this.btnAtualizarUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnAtualizarUsuario.TabIndex = 6;
            this.btnAtualizarUsuario.Text = "Atualizar Usuário";
            this.btnAtualizarUsuario.UseVisualStyleBackColor = true;
            this.btnAtualizarUsuario.Click += new System.EventHandler(this.btnAtualizarUsuario_Click);
            // 
            // btnDeletarUsuario
            // 
            this.btnDeletarUsuario.Location = new System.Drawing.Point(681, 455);
            this.btnDeletarUsuario.Name = "btnDeletarUsuario";
            this.btnDeletarUsuario.Size = new System.Drawing.Size(157, 39);
            this.btnDeletarUsuario.TabIndex = 7;
            this.btnDeletarUsuario.Text = "Deleter Usuário";
            this.btnDeletarUsuario.UseVisualStyleBackColor = true;
            this.btnDeletarUsuario.Click += new System.EventHandler(this.btnDeletarUsuario_Click);
            // 
            // frmUsuariosApi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 527);
            this.Controls.Add(this.btnDeletarUsuario);
            this.Controls.Add(this.btnAtualizarUsuario);
            this.Controls.Add(this.btnIncluirUsuario);
            this.Controls.Add(this.btnUsuarioPorId);
            this.Controls.Add(this.btnObterUsuarios);
            this.Controls.Add(this.dgvDados);
            this.Controls.Add(this.txtUri);
            this.Controls.Add(this.label1);
            this.Name = "frmUsuariosApi";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUri;
        private System.Windows.Forms.DataGridView dgvDados;
        private System.Windows.Forms.Button btnObterUsuarios;
        private System.Windows.Forms.Button btnUsuarioPorId;
        private System.Windows.Forms.Button btnIncluirUsuario;
        private System.Windows.Forms.Button btnAtualizarUsuario;
        private System.Windows.Forms.Button btnDeletarUsuario;
    }
}

