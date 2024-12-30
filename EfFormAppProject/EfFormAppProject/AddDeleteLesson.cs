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
    public partial class AddDeleteLesson : Form
    {
        public AddDeleteLesson()
        {
            InitializeComponent();
            LoadLessons();
        }

        private void LoadLessons()
        {
            try
            {
                using (var context = new ObsDbContext())
                {
                    var lessons = context.Lessons.ToList();
                    Dersler.DataSource = lessons;
                    Dersler.DisplayMember = "LessonName";
                    Dersler.ValueMember = "LessonId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data yüklenirken bir hata oluştu {ex.Message}");
            }
        }

        private void btnAddLesson_Click(object sender, EventArgs e)
        {
            AddLesson addLesson = new AddLesson();
            if (addLesson.ShowDialog() == DialogResult.OK)
            {
                LoadLessons();
            }
        }

        private void btnDeleteLesson_Click(object sender, EventArgs e)
        {
            var selectedLesson = Dersler.SelectedItem as Lesson;
            if (selectedLesson == null)
            {
                MessageBox.Show("Lütfen silmek için bir ders seçiniz");
                return;
            }
            var confirm = MessageBox.Show("Bu dersi silmek istediğinize emin misiniz?","Ders Sil",MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    using (var context = new ObsDbContext())
                    {
                        var deletingLesson = context.Lessons.Find(selectedLesson.LessonId);
                        if (deletingLesson != null)
                        {
                            context.Lessons.Remove(deletingLesson);
                            context.SaveChanges();
                            MessageBox.Show("Başarıyla Silindi");
                            LoadLessons();
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ders silinirken bir hata oluştu {ex.Message}");
                }
            }
        }
    }
}
