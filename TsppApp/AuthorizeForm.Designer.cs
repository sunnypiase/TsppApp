namespace TsppApp
{
    partial class AuthorizeForm
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
            this.buttonAuthorize = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonAuthorize
            // 
            this.buttonAuthorize.AccessibleRole = System.Windows.Forms.AccessibleRole.Cursor;
            this.buttonAuthorize.Location = new System.Drawing.Point(54, 162);
            this.buttonAuthorize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonAuthorize.Name = "buttonAuthorize";
            this.buttonAuthorize.Size = new System.Drawing.Size(136, 38);
            this.buttonAuthorize.TabIndex = 4;
            this.buttonAuthorize.Text = "Authorize";
            this.buttonAuthorize.UseVisualStyleBackColor = true;
            this.buttonAuthorize.Click += new System.EventHandler(this.buttonAuthorize_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(68, 35);
            this.textBoxLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(110, 23);
            this.textBoxLogin.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(101, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Login";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(68, 98);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(110, 23);
            this.textBoxPassword.TabIndex = 8;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "Password";
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 211);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAuthorize);
            this.Name = "AuthorizeForm";
            this.Text = "AuthorizeForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button buttonAuthorize;
        private TextBox textBoxLogin;
        private Label label1;
        private TextBox textBoxPassword;
        private Label label2;
    }
}