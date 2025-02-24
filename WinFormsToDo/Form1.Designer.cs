namespace WinFormsToDo
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
            groupBox1 = new GroupBox();
            btnAdd = new Button();
            btnClear = new Button();
            txtTaskDescription = new TextBox();
            txtDueDate = new TextBox();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            groupBox2 = new GroupBox();
            fpTasks = new FlowLayoutPanel();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(txtTaskDescription);
            groupBox1.Controls.Add(txtDueDate);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(17, 14);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(428, 112);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Task Form";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(334, 78);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add Todo";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += submitForm;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(253, 78);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 4;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // txtTaskDescription
            // 
            txtTaskDescription.Location = new Point(98, 20);
            txtTaskDescription.Name = "txtTaskDescription";
            txtTaskDescription.Size = new Size(306, 23);
            txtTaskDescription.TabIndex = 3;
            txtTaskDescription.KeyPress += Form1_KeyPress;
            // 
            // txtDueDate
            // 
            txtDueDate.Location = new Point(98, 49);
            txtDueDate.Name = "txtDueDate";
            txtDueDate.Size = new Size(306, 23);
            txtDueDate.TabIndex = 2;
            txtDueDate.KeyPress += Form1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 52);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Due Date";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 23);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 0;
            label1.Text = "Task";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(204, 339);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 1;
            label3.Text = "label3";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(fpTasks);
            groupBox2.Location = new Point(17, 135);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(428, 617);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            groupBox2.Text = "Task List";
            // 
            // fpTasks
            // 
            fpTasks.Location = new Point(11, 21);
            fpTasks.Name = "fpTasks";
            fpTasks.Size = new Size(411, 590);
            fpTasks.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(457, 764);
            Controls.Add(groupBox2);
            Controls.Add(label3);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "ToDo App";
            KeyPress += Form1_KeyPress;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private Button btnAdd;
        private Button btnClear;
        private TextBox txtTaskDescription;
        private TextBox txtDueDate;
        private Label label2;
        private Label label1;
        private Label label3;
        private GroupBox groupBox2;
        private FlowLayoutPanel fpTasks;
    }
}
