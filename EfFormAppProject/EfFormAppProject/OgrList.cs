using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class OgrList : Form
    {
        public OgrList()
        {
            InitializeComponent();
            LoadStudents();
        }

        private void LoadStudents()
        {
            try
            {
                using (var context = new ObsDbContext())
                {
                    var students = context.Students.ToList();
                    if (students == null || !students.Any())
                    {
                        MessageBox.Show("Öğrenciler bulunamadı.");
                        return;
                    }

                    lbOgrList.DataSource = students;
                    lbOgrList.DisplayMember = "StudentName";
                    lbOgrList.ValueMember = "StudentId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öğrenciler yüklenirken bir hata oluştu: {ex.Message}");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lbOgrList.SelectedItem is Student selectedStudent)
            {
                DialogResult result = MessageBox.Show($"Seçilen Öğrenci: {selectedStudent.StudentName} {selectedStudent.StudentSurname}. Silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    try
                    {
                        using (var context = new ObsDbContext())
                        {
                            var ogrDelete = context.Students.FirstOrDefault(s => s.StudentId == selectedStudent.StudentId);

                            if (ogrDelete != null)
                            {
                                var updateClass = context.Classrooms.Find(ogrDelete.ClassId);
                                if (updateClass != null)
                                {
                                    updateClass.Quota += 1;
                                }

                                context.Students.Remove(ogrDelete);
                                context.SaveChanges();
                                MessageBox.Show("Öğrenci Başarıyla Silindi!");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Öğrenci bulunamadı.");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Öğrenci silinirken bir hata oluştu: {ex.Message}");
                    }
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir öğrenci seçiniz.");
            }
        }
    }
}