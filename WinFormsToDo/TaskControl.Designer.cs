namespace WinFormsToDo
{
    partial class TaskControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnComplete = new Button();
            label1 = new Label();
            label2 = new Label();
            lblDueDate = new Label();
            lblDescription = new Label();
            SuspendLayout();
            // 
            // btnComplete
            // 
            btnComplete.Location = new Point(248, 3);
            btnComplete.Name = "btnComplete";
            btnComplete.Size = new Size(77, 23);
            btnComplete.TabIndex = 0;
            btnComplete.Text = "Mark Done";
            btnComplete.UseVisualStyleBackColor = true;
            btnComplete.Click += btnComplete_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(2, 3);
            label1.Name = "label1";
            label1.Size = new Size(63, 15);
            label1.TabIndex = 1;
            label1.Text = "Due Date:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(3, 18);
            label2.Name = "label2";
            label2.Size = new Size(34, 15);
            label2.TabIndex = 2;
            label2.Text = "Task:";
            // 
            // lblDueDate
            // 
            lblDueDate.AutoSize = true;
            lblDueDate.Location = new Point(62, 3);
            lblDueDate.Name = "lblDueDate";
            lblDueDate.Size = new Size(65, 15);
            lblDueDate.TabIndex = 3;
            lblDueDate.Text = "2025-01-01";
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDescription.Location = new Point(3, 33);
            lblDescription.MaximumSize = new Size(294, 0);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(42, 25);
            lblDescription.TabIndex = 4;
            lblDescription.Text = "test";
            // 
            // TaskControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(lblDescription);
            Controls.Add(lblDueDate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnComplete);
            Name = "TaskControl";
            Size = new Size(334, 66);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnComplete;
        private Label label1;
        private Label label2;
        private Label lblDueDate;
        private Label lblDescription;
    }
}
