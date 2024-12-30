namespace EfFormAppProject
{
    partial class OgrList
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
            lbOgrList = new ListBox();
            btnDelete = new Button();
            SuspendLayout();
            // 
            // lbOgrList
            // 
            lbOgrList.FormattingEnabled = true;
            lbOgrList.ItemHeight = 15;
            lbOgrList.Location = new Point(31, 12);
            lbOgrList.Name = "lbOgrList";
            lbOgrList.Size = new Size(419, 274);
            lbOgrList.TabIndex = 0;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(145, 312);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(206, 23);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // OgrList
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 402);
            Controls.Add(btnDelete);
            Controls.Add(lbOgrList);
            Name = "OgrList";
            Text = "OgrList";
            ResumeLayout(false);
        }

        #endregion

        private ListBox lbOgrList;
        private Button btnDelete;
    }
}