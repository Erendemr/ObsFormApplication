namespace EfFormAppProject
{
    partial class AddDeleteLesson
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
            Dersler = new ListBox();
            btnAddLesson = new Button();
            btnDeleteLesson = new Button();
            SuspendLayout();
            // 
            // Dersler
            // 
            Dersler.FormattingEnabled = true;
            Dersler.ItemHeight = 15;
            Dersler.Location = new Point(32, 31);
            Dersler.Name = "Dersler";
            Dersler.Size = new Size(436, 214);
            Dersler.TabIndex = 0;
            // 
            // btnAddLesson
            // 
            btnAddLesson.Location = new Point(96, 274);
            btnAddLesson.Name = "btnAddLesson";
            btnAddLesson.Size = new Size(95, 23);
            btnAddLesson.TabIndex = 1;
            btnAddLesson.Text = "Ders Ekle";
            btnAddLesson.UseVisualStyleBackColor = true;
            btnAddLesson.Click += btnAddLesson_Click;
            // 
            // btnDeleteLesson
            // 
            btnDeleteLesson.Location = new Point(294, 274);
            btnDeleteLesson.Name = "btnDeleteLesson";
            btnDeleteLesson.Size = new Size(87, 23);
            btnDeleteLesson.TabIndex = 2;
            btnDeleteLesson.Text = "Ders Sil";
            btnDeleteLesson.UseVisualStyleBackColor = true;
            btnDeleteLesson.Click += btnDeleteLesson_Click;
            // 
            // AddDeleteLesson
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(517, 375);
            Controls.Add(btnDeleteLesson);
            Controls.Add(btnAddLesson);
            Controls.Add(Dersler);
            Name = "AddDeleteLesson";
            Text = "AddDeleteLesson";
            ResumeLayout(false);
        }

        #endregion

        private ListBox Dersler;
        private Button btnAddLesson;
        private Button btnDeleteLesson;
    }
}