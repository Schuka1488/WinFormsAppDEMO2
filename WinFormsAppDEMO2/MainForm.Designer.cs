namespace WinFormsAppDEMO2
{
    partial class MainForm
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
            UsersButton = new Button();
            OrdersButton = new Button();
            ShiftsButton = new Button();
            LogoutButton = new Button();
            SuspendLayout();
            // 
            // UsersButton
            // 
            UsersButton.Location = new Point(20, 21);
            UsersButton.Name = "UsersButton";
            UsersButton.Size = new Size(123, 74);
            UsersButton.TabIndex = 0;
            UsersButton.Text = "Управление пользователями";
            UsersButton.UseVisualStyleBackColor = true;
            UsersButton.Click += UsersButton_Click;
            // 
            // OrdersButton
            // 
            OrdersButton.Location = new Point(178, 21);
            OrdersButton.Name = "OrdersButton";
            OrdersButton.Size = new Size(123, 74);
            OrdersButton.TabIndex = 1;
            OrdersButton.Text = "Заказы";
            OrdersButton.UseVisualStyleBackColor = true;
            OrdersButton.Click += OrdersButton_Click;
            // 
            // ShiftsButton
            // 
            ShiftsButton.Location = new Point(349, 21);
            ShiftsButton.Name = "ShiftsButton";
            ShiftsButton.Size = new Size(123, 74);
            ShiftsButton.TabIndex = 2;
            ShiftsButton.Text = "Смены";
            ShiftsButton.UseVisualStyleBackColor = true;
            ShiftsButton.Click += ShiftsButton_Click;
            // 
            // LogoutButton
            // 
            LogoutButton.Location = new Point(528, 21);
            LogoutButton.Name = "LogoutButton";
            LogoutButton.Size = new Size(123, 74);
            LogoutButton.TabIndex = 3;
            LogoutButton.Text = "Выйти";
            LogoutButton.UseVisualStyleBackColor = true;
            LogoutButton.Click += LogoutButton_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 112);
            Controls.Add(LogoutButton);
            Controls.Add(ShiftsButton);
            Controls.Add(OrdersButton);
            Controls.Add(UsersButton);
            Name = "MainForm";
            Text = "MainForm";
            ResumeLayout(false);
        }

        #endregion

        private Button UsersButton;
        private Button OrdersButton;
        private Button ShiftsButton;
        private Button LogoutButton;
    }
}