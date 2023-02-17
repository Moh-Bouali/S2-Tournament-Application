namespace DesktopApp_Synthesis_Assignment_DuelSyns.Inc
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelID = new System.Windows.Forms.Label();
            this.labelPsswd = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxPsswd = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.BackColor = System.Drawing.Color.Bisque;
            this.labelID.Location = new System.Drawing.Point(346, 161);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(31, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID :";
            // 
            // labelPsswd
            // 
            this.labelPsswd.AutoSize = true;
            this.labelPsswd.BackColor = System.Drawing.Color.Bisque;
            this.labelPsswd.Location = new System.Drawing.Point(300, 222);
            this.labelPsswd.Name = "labelPsswd";
            this.labelPsswd.Size = new System.Drawing.Size(77, 20);
            this.labelPsswd.TabIndex = 1;
            this.labelPsswd.Text = "Password :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(400, 158);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(125, 27);
            this.textBoxID.TabIndex = 2;
            // 
            // textBoxPsswd
            // 
            this.textBoxPsswd.Location = new System.Drawing.Point(400, 219);
            this.textBoxPsswd.Name = "textBoxPsswd";
            this.textBoxPsswd.PasswordChar = '*';
            this.textBoxPsswd.Size = new System.Drawing.Size(125, 27);
            this.textBoxPsswd.TabIndex = 3;
            // 
            // buttonLogin
            // 
            this.buttonLogin.BackColor = System.Drawing.Color.Bisque;
            this.buttonLogin.Location = new System.Drawing.Point(346, 274);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(113, 37);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Login";
            this.buttonLogin.UseVisualStyleBackColor = false;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(695, 375);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.textBoxPsswd);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelPsswd);
            this.Controls.Add(this.labelID);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label labelID;
        private Label labelPsswd;
        private TextBox textBoxID;
        private TextBox textBoxPsswd;
        private Button buttonLogin;
    }
}