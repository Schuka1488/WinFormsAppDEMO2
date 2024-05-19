namespace WinFormsAppDEMO2
{
    partial class ShiftsForm
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
            dateTimePicker1 = new DateTimePicker();
            DescriptionTextBox = new TextBox();
            WaiterComboBox = new ComboBox();
            ChefComboBox = new ComboBox();
            AddShiftsButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 210);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(1205, 228);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(31, 174);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 1;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(303, 174);
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(100, 23);
            DescriptionTextBox.TabIndex = 2;
            // 
            // WaiterComboBox
            // 
            WaiterComboBox.FormattingEnabled = true;
            WaiterComboBox.Location = new Point(525, 174);
            WaiterComboBox.Name = "WaiterComboBox";
            WaiterComboBox.Size = new Size(121, 23);
            WaiterComboBox.TabIndex = 3;
            // 
            // ChefComboBox
            // 
            ChefComboBox.FormattingEnabled = true;
            ChefComboBox.Location = new Point(794, 174);
            ChefComboBox.Name = "ChefComboBox";
            ChefComboBox.Size = new Size(121, 23);
            ChefComboBox.TabIndex = 4;
            // 
            // AddShiftsButton
            // 
            AddShiftsButton.Location = new Point(12, 22);
            AddShiftsButton.Name = "AddShiftsButton";
            AddShiftsButton.Size = new Size(1205, 70);
            AddShiftsButton.TabIndex = 5;
            AddShiftsButton.Text = "Добавить смену";
            AddShiftsButton.UseVisualStyleBackColor = true;
            AddShiftsButton.Click += AddShiftsButton_Click;
            // 
            // ShiftsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1229, 450);
            Controls.Add(AddShiftsButton);
            Controls.Add(ChefComboBox);
            Controls.Add(WaiterComboBox);
            Controls.Add(DescriptionTextBox);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView1);
            Name = "ShiftsForm";
            Text = "ShiftsForm";
            Load += ShiftsForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private TextBox DescriptionTextBox;
        private ComboBox WaiterComboBox;
        private ComboBox ChefComboBox;
        private Button AddShiftsButton;
    }
}