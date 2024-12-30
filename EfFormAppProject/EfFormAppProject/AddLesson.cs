using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class AddLesson : Form
    {
        public AddLesson()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lessonName = txtLName.Text.Trim();
            int lessonCode;

            if (string.IsNullOrEmpty(lessonName) || !int.TryParse(txtLCode.Text,out lessonCode))
            {
                MessageBox.Show("Lütfen geçerli bir ders adı ve kodu giriniz.");
                return;
            }
            try
            {
                using (var context = new ObsDbContext())
                {
                    var newLesson = new Lesson()
                    {
                        LessonName = lessonName,
                        LessonCode = lessonCode
                    };
                    context.Lessons.Add(newLesson);
                    context.SaveChanges();
                    MessageBox.Show("Ders Başarıyla Eklendi");

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders eklenirken bir sorun oluştu {ex.Message}");
            }
        }
    }
}
