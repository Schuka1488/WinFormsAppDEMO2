namespace WinFormsAppDEMO2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            LoginButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox
            // 
            LoginTextBox.Location = new Point(43, 30);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(100, 23);
            LoginTextBox.TabIndex = 0;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(43, 74);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(100, 23);
            PasswordTextBox.TabIndex = 1;
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(52, 133);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(75, 23);
            LoginButton.TabIndex = 2;
            LoginButton.Text = "Войти";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(187, 177);
            Controls.Add(LoginButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button LoginButton;
    }
}
