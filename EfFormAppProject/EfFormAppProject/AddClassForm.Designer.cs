namespace EfFormAppProject
{
    partial class AddClassForm
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
            txtClassName = new TextBox();
            txtQuota = new TextBox();
            btnSave = new Button();
            lblClassName = new Label();
            lblQuota = new Label();
            SuspendLayout();
            // 
            // txtClassName
            // 
            txtClassName.Location = new Point(129, 27);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(200, 23);
            txtClassName.TabIndex = 0;
            // 
            // txtQuota
            // 
            txtQuota.Location = new Point(129, 67);
            txtQuota.Name = "txtQuota";
            txtQuota.Size = new Size(200, 23);
            txtQuota.TabIndex = 1;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(129, 108);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(200, 30);
            btnSave.TabIndex = 2;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.Location = new Point(30, 30);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(51, 15);
            lblClassName.TabIndex = 3;
            lblClassName.Text = "Sınıf Adı";
            // 
            // lblQuota
            // 
            lblQuota.AutoSize = true;
            lblQuota.Location = new Point(30, 70);
            lblQuota.Name = "lblQuota";
            lblQuota.Size = new Size(93, 15);
            lblQuota.TabIndex = 4;
            lblQuota.Text = "Sınıfın Mevcudu";
            // 
            // AddClassForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(345, 183);
            Controls.Add(lblQuota);
            Controls.Add(lblClassName);
            Controls.Add(btnSave);
            Controls.Add(txtQuota);
            Controls.Add(txtClassName);
            Name = "AddClassForm";
            Text = "Sınıf Ekle";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtClassName;
        private TextBox txtQuota;
        private Button btnSave;
        private Label lblClassName;
        private Label lblQuota;
    }
}