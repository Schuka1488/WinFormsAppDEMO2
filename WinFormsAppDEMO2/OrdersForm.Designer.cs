namespace WinFormsAppDEMO2
{
    partial class OrdersForm
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
            dataGridView1 = new DataGridView();
            AddOrdersButton = new Button();
            dateTimePicker1 = new DateTimePicker();
            TableTextBox = new TextBox();
            CountTextBox = new TextBox();
            WaiterComboBox = new ComboBox();
            StatusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 188);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1188, 250);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // AddOrdersButton
            // 
            AddOrdersButton.Location = new Point(15, 10);
            AddOrdersButton.Name = "AddOrdersButton";
            AddOrdersButton.Size = new Size(1185, 51);
            AddOrdersButton.TabIndex = 1;
            AddOrdersButton.Text = "Добавить заказ";
            AddOrdersButton.UseVisualStyleBackColor = true;
            AddOrdersButton.Click += AddOrdersButton_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(15, 94);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // TableTextBox
            // 
            TableTextBox.Location = new Point(288, 98);
            TableTextBox.Name = "TableTextBox";
            TableTextBox.Size = new Size(100, 23);
            TableTextBox.TabIndex = 3;
            // 
            // CountTextBox
            // 
            CountTextBox.Location = new Point(459, 98);
            CountTextBox.Name = "CountTextBox";
            CountTextBox.Size = new Size(100, 23);
            CountTextBox.TabIndex = 4;
            // 
            // WaiterComboBox
            // 
            WaiterComboBox.FormattingEnabled = true;
            WaiterComboBox.Location = new Point(606, 97);
            WaiterComboBox.Name = "WaiterComboBox";
            WaiterComboBox.Size = new Size(121, 23);
            WaiterComboBox.TabIndex = 5;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(780, 98);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(121, 23);
            StatusComboBox.TabIndex = 6;
            // 
            // OrdersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1212, 450);
            Controls.Add(StatusComboBox);
            Controls.Add(WaiterComboBox);
            Controls.Add(CountTextBox);
            Controls.Add(TableTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(AddOrdersButton);
            Controls.Add(dataGridView1);
            Name = "OrdersForm";
            Text = "OrdersForm";
            Load += OrdersForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button AddOrdersButton;
        private DateTimePicker dateTimePicker1;
        private TextBox TableTextBox;
        private TextBox CountTextBox;
        private ComboBox WaiterComboBox;
        private ComboBox StatusComboBox;
    }
}