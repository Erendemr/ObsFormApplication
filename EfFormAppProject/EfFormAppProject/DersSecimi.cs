using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class DersSecimi : Form
    {
        int studentId = 0;
        public DersSecimi(Student student)
        {
            InitializeComponent();
            if (student == null)
            {
                MessageBox.Show("Geçersiz öğrenci");
                return;
            }
            lblOgrenciBilgi.Text = $"Seçilen Öğrenci: {student.StudentName} {student.StudentSurname}";
            studentId = student.StudentId;
        }

        private void DersSecimi_Load(object sender, EventArgs e)
        {
            try
            {
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Data yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void LoadData()
        {
            using (var context = new ObsDbContext())
            {
                try
                {
                    var dersler = context.Lessons.ToList();
                    if (dersler == null || !dersler.Any())
                    {
                        MessageBox.Show("Ders bulunamadı.");
                        return;
                    }

                    dGWDersler.DataSource = dersler;
                    dGWDersler.Columns["StudentLessons"].Visible = false;

                    dGWDersler.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dGWDersler.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Dersler yüklenirken bir hata oluştu: {ex.Message}");
                }
            }
        }

        private void btnogrDersKaydet_Click(object sender, EventArgs e)
        {
            if (studentId <= 0)
            {
                MessageBox.Show("Geçersiz öğrenci ID");
                return;
            }

            try
            {
                using (var context = new ObsDbContext())
                {
                    for (int i = 0; i < dGWDersler.SelectedRows.Count; i++)
                    {
                        DataGridViewRow selectedRow = dGWDersler.SelectedRows[i];

                        if (selectedRow.Cells["LessonId"].Value == null)
                        {
                            MessageBox.Show("Ders ID'si eksik.");
                            continue;
                        }

                        int lessonId = Convert.ToInt32(selectedRow.Cells["LessonId"].Value);
                        if (!context.StudentLessons.Any(s => s.StudentId == studentId && s.LessonId == lessonId))
                        {
                            StudentLesson newLesson = new StudentLesson()
                            {
                                StudentId = studentId,
                                LessonId = lessonId,
                            };
                            context.StudentLessons.Add(newLesson);
                            MessageBox.Show("Başarıyla Kaydedildi");
                        }
                        else
                        {
                            MessageBox.Show("Bu Ders Zaten Alınmış");
                        }
                    }

                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders kaydedilirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnDersIslemleri_Click(object sender, EventArgs e)
        {
            try
            {
                AddDeleteLesson addDeleteLesson = new AddDeleteLesson();
                addDeleteLesson.FormClosed += (s, args) => LoadData();
                addDeleteLesson.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders işlemleri sırasında bir hata oluştu: {ex.Message}");
            }
        }
    }
}