namespace EfFormAppProject
{
    partial class AddLesson
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
            lblLessonName = new Label();
            lblLessonCode = new Label();
            txtLName = new TextBox();
            txtLCode = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblLessonName
            // 
            lblLessonName.AutoSize = true;
            lblLessonName.Location = new Point(35, 52);
            lblLessonName.Name = "lblLessonName";
            lblLessonName.Size = new Size(51, 15);
            lblLessonName.TabIndex = 0;
            lblLessonName.Text = "Ders Adı";
            // 
            // lblLessonCode
            // 
            lblLessonCode.AutoSize = true;
            lblLessonCode.Location = new Point(35, 101);
            lblLessonCode.Name = "lblLessonCode";
            lblLessonCode.Size = new Size(61, 15);
            lblLessonCode.TabIndex = 1;
            lblLessonCode.Text = "Ders Kodu";
            // 
            // txtLName
            // 
            txtLName.Location = new Point(104, 49);
            txtLName.Name = "txtLName";
            txtLName.Size = new Size(125, 23);
            txtLName.TabIndex = 2;
            // 
            // txtLCode
            // 
            txtLCode.Location = new Point(104, 98);
            txtLCode.Name = "txtLCode";
            txtLCode.Size = new Size(125, 23);
            txtLCode.TabIndex = 3;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(104, 160);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(125, 23);
            btnSave.TabIndex = 4;
            btnSave.Text = "Dersi Ekle";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(293, 244);
            Controls.Add(btnSave);
            Controls.Add(txtLCode);
            Controls.Add(txtLName);
            Controls.Add(lblLessonCode);
            Controls.Add(lblLessonName);
            Name = "AddLesson";
            Text = "AddLesson";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLessonName;
        private Label lblLessonCode;
        private TextBox txtLName;
        private TextBox txtLCode;
        private Button btnSave;
    }
}