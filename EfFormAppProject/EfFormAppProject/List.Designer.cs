namespace EfFormAppProject
{
    partial class List
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
            lvLists = new ListView();
            SuspendLayout();
            // 
            // lvLists
            // 
            this.lvLists.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvLists.FullRowSelect = true;
            this.lvLists.GridLines = true;
            this.lvLists.View = System.Windows.Forms.View.Details;
            this.lvLists.Location = new System.Drawing.Point(0, 0);
            this.lvLists.Name = "lvLists";
            this.lvLists.Size = new System.Drawing.Size(600, 400);
            this.lvLists.TabIndex = 0;
            this.lvLists.UseCompatibleStateImageBehavior = false;
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.lvLists);
            this.Name = "List";
            this.Text = "List";
            this.ResumeLayout(false);
        }

        #endregion

        private ListView lvLists;
    }
}