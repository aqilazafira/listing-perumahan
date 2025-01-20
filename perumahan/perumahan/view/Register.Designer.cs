namespace perumahan.view
{
    partial class Register
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
            textBoxPassword = new TextBox();
            textBoxUsername = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label4 = new Label();
            textBoxConfirmPassword = new TextBox();
            SuspendLayout();
            // 
            // textBoxPassword
            // 
            textBoxPassword.Location = new Point(321, 193);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.Size = new Size(205, 23);
            textBoxPassword.TabIndex = 9;
            // 
            // textBoxUsername
            // 
            textBoxUsername.Location = new Point(321, 131);
            textBoxUsername.Name = "textBoxUsername";
            textBoxUsername.Size = new Size(205, 23);
            textBoxUsername.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Location = new Point(198, 196);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 7;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(198, 134);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 6;
            label2.Text = "Username";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(318, 75);
            label1.Name = "label1";
            label1.Size = new Size(108, 22);
            label1.TabIndex = 5;
            label1.Text = "REGISTER";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Location = new Point(198, 258);
            label4.Name = "label4";
            label4.Size = new Size(104, 15);
            label4.TabIndex = 10;
            label4.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            textBoxConfirmPassword.Location = new Point(321, 255);
            textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            textBoxConfirmPassword.Size = new Size(205, 23);
            textBoxConfirmPassword.TabIndex = 11;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.bg2;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(745, 405);
            Controls.Add(textBoxConfirmPassword);
            Controls.Add(label4);
            Controls.Add(textBoxPassword);
            Controls.Add(textBoxUsername);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxPassword;
        private TextBox textBoxUsername;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox textBoxConfirmPassword;
    }
}