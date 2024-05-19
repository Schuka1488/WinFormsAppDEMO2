namespace WinFormsAppDEMO2
{
    partial class AddUsersForm
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
            LoginTextBox2 = new TextBox();
            PasswordTextBox2 = new TextBox();
            TypeComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            AddUsersButton = new Button();
            SuspendLayout();
            // 
            // LoginTextBox2
            // 
            LoginTextBox2.Location = new Point(29, 36);
            LoginTextBox2.Name = "LoginTextBox2";
            LoginTextBox2.Size = new Size(100, 23);
            LoginTextBox2.TabIndex = 0;
            // 
            // PasswordTextBox2
            // 
            PasswordTextBox2.Location = new Point(29, 93);
            PasswordTextBox2.Name = "PasswordTextBox2";
            PasswordTextBox2.Size = new Size(100, 23);
            PasswordTextBox2.TabIndex = 1;
            // 
            // TypeComboBox
            // 
            TypeComboBox.FormattingEnabled = true;
            TypeComboBox.Location = new Point(29, 149);
            TypeComboBox.Name = "TypeComboBox";
            TypeComboBox.Size = new Size(121, 23);
            TypeComboBox.TabIndex = 2;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(29, 209);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 3;
            // 
            // AddUsersButton
            // 
            AddUsersButton.Location = new Point(40, 272);
            AddUsersButton.Name = "AddUsersButton";
            AddUsersButton.Size = new Size(75, 23);
            AddUsersButton.TabIndex = 4;
            AddUsersButton.Text = "Добавить";
            AddUsersButton.UseVisualStyleBackColor = true;
            AddUsersButton.Click += AddUsersButton_Click;
            // 
            // AddUsersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(180, 331);
            Controls.Add(AddUsersButton);
            Controls.Add(StatusComboBox);
            Controls.Add(TypeComboBox);
            Controls.Add(PasswordTextBox2);
            Controls.Add(LoginTextBox2);
            Name = "AddUsersForm";
            Text = "AddUsersForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox LoginTextBox2;
        private TextBox PasswordTextBox2;
        private ComboBox TypeComboBox;
        private ComboBox StatusComboBox;
        private Button AddUsersButton;
    }
}