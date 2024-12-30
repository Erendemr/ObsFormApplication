using EfFormAppProject.Data;
using EfFormAppProject.Models;

namespace EfFormAppProject
{
    public partial class RegisterForm : Form
    {
        private Student? currentStudent;
        Student? std;
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadComboBox();
                cmbList.Items.AddRange(new string[] { "Öðrenciler", "Dersler", "Sýnýflar" });
                cmbList.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Hata oluþtu: {ex.Message}");
            }
        }

        private void LoadComboBox()
        {
            try
            {
                using (var context = new ObsDbContext())
                {
                    var siniflar = context.Classrooms.ToList();
                    if (siniflar != null)
                    {
                        cmbClasses.DataSource = siniflar;
                        cmbClasses.DisplayMember = "ClassName";
                        cmbClasses.ValueMember = "ClassId";
                        cmbClasses.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabaný yüklenirken hata oluþtu: {ex.Message}");
            }
        }

        private void LoadStudent(Student student)
        {
            try
            {
                if (student != null)
                {
                    txtAd.Text = student.StudentName;
                    txtSoyad.Text = student.StudentSurname;
                    txtNumara.Text = student.StudentNumber;

                    using (var context = new ObsDbContext())
                    {
                        var siniflar = context.Classrooms.ToList();
                        cmbClasses.DataSource = siniflar;
                        cmbClasses.DisplayMember = "ClassName";
                        cmbClasses.ValueMember = "ClassId";

                        var selectedClass = siniflar.FirstOrDefault(c => c.ClassId == student.ClassId);
                        if (selectedClass != null)
                        {
                            cmbClasses.SelectedItem = selectedClass;
                        }
                        else
                        {
                            cmbClasses.SelectedIndex = -1;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öðrenci bilgileri yüklenirken hata oluþtu: {ex.Message}");
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();
                string numara = txtNumara.Text.Trim();
                var selectedClass = cmbClasses.SelectedItem as Classroom;

                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(numara) || selectedClass == null)
                {
                    MessageBox.Show("Lütfen boþ alan býrakmayýn");
                    return;
                }

                using (var context = new ObsDbContext())
                {
                    var classQuota = context.Classrooms.Find(selectedClass.ClassId);
                    if (classQuota != null)
                    {
                        var studentCountInClass = context.Students.Count(s => s.ClassId == selectedClass.ClassId);

                        if (studentCountInClass >= classQuota.Quota)
                        {
                            MessageBox.Show("Bu sýnýfýn kotasý dolmuþtur. Lütfen baþka bir sýnýf seçiniz.");
                            return;
                        }

                        var addStudent = new Student
                        {
                            StudentName = ad,
                            StudentSurname = soyad,
                            StudentNumber = numara,
                            ClassId = selectedClass.ClassId
                        };

                        context.Students.Add(addStudent);

                        classQuota.Quota -= 1;

                        context.SaveChanges();

                        MessageBox.Show("Baþarýyla kaydedildi!");
                        txtAd.Clear();
                        txtSoyad.Clear();
                        txtNumara.Clear();
                        cmbClasses.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen sýnýf bulunamadý.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öðrenci kaydedilirken hata oluþtu: {ex.Message}");
            }
        }

        private void btnBul_Click(object sender, EventArgs e)
        {
            try
            {
                string numara = txtNumara.Text.Trim();
                if (string.IsNullOrEmpty(numara))
                {
                    MessageBox.Show("Lütfen numara giriniz");
                    return;
                }

                using (var context = new ObsDbContext())
                {
                    if (currentStudent != null && currentStudent.StudentNumber == numara)
                    {
                        LoadStudent(currentStudent);
                        return;
                    }

                    var find = context.Students.FirstOrDefault(s => s.StudentNumber == numara);

                    if (find == null)
                    {
                        MessageBox.Show("Bu numarada bir öðrenci bulunamadý.");
                        return;
                    }

                    currentStudent = find;
                    LoadStudent(find);
                    std = find;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öðrenci ararken hata oluþtu: {ex.Message}");
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                string ad = txtAd.Text.Trim();
                string soyad = txtSoyad.Text.Trim();
                string numara = txtNumara.Text.Trim();
                var selectedClass = cmbClasses.SelectedItem as Classroom;

                if (string.IsNullOrEmpty(ad) || string.IsNullOrEmpty(soyad) || string.IsNullOrEmpty(numara) || selectedClass == null)
                {
                    MessageBox.Show("Lütfen boþ alan býrakmayýn");
                    return;
                }

                using (var context = new ObsDbContext())
                {
                    var updatingStudent = context.Students.FirstOrDefault(s => s.StudentNumber == numara);
                    if (updatingStudent == null)
                    {
                        MessageBox.Show("Bu numaraya ait bir öðrenci bulunamadý.");
                        return;
                    }

                    var oldClass = context.Classrooms.Find(updatingStudent.ClassId);
                    if (oldClass != null)
                    {
                        oldClass.Quota += 1;
                    }

                    var newClass = context.Classrooms.Find(selectedClass.ClassId);

                    if (newClass != null)
                    {
                        var classQuota = context.Students.Count(s => s.ClassId == newClass.ClassId);
                        if (classQuota >= newClass.Quota)
                        {
                            MessageBox.Show("Bu sýnýfýn kotasý dolmuþtur. Lütfen baþka bir sýnýf seçiniz.");
                            return;
                        }
                        newClass.Quota -= 1;
                    }

                    updatingStudent.StudentName = ad;
                    updatingStudent.StudentSurname = soyad;
                    updatingStudent.ClassId = selectedClass.ClassId;

                    context.SaveChanges();

                    currentStudent = updatingStudent;

                    MessageBox.Show("Öðrenci baþarýyla güncellendi!");
                    txtAd.Clear();
                    txtSoyad.Clear();
                    cmbClasses.SelectedIndex = -1;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öðrenci güncellenirken bir sorun oluþtu: {ex.Message}");
            }
        }

        private void btnSýnýfEkle_Click(object sender, EventArgs e)
        {
            try
            {
                AddClassForm addClassForm = new AddClassForm();
                addClassForm.ShowDialog();
                LoadComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sýnýf eklenirken bir sorun oluþtu: {ex.Message}");
            }
        }

        private void btnDersSecimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (std != null)
                {
                    DersSecimi dersSecimi = new DersSecimi(std);
                    dersSecimi.Show();
                }
                else
                {
                    MessageBox.Show("Önce Öðrenci seçiniz");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ders seçimi yapýlýrken bir sorun oluþtu: {ex.Message}");
            }
        }

        private void btnDeleteClass_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedClass = cmbClasses.SelectedItem as Classroom;

                if (selectedClass == null)
                {
                    MessageBox.Show("Lütfen silmek için bir sýnýf seçiniz.");
                    return;
                }

                var confirm = MessageBox.Show("Bu sýnýfý silmek istediðinizden emin misiniz?", "Sýnýf Sil", MessageBoxButtons.YesNo);
                if (confirm == DialogResult.Yes)
                {
                    using (var context = new ObsDbContext())
                    {
                        var deletingClass = context.Classrooms.Find(selectedClass.ClassId);
                        if (deletingClass != null)
                        {
                            context.Classrooms.Remove(deletingClass);
                            context.SaveChanges();
                            MessageBox.Show("Baþarýyla Silindi");
                            LoadComboBox();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sýnýf silinirken bir sorun oluþtu: {ex.Message}");
            }
        }

        private void btnDeleteStudent_Click(object sender, EventArgs e)
        {
            try
            {
                OgrList deleteOgr = new OgrList();
                deleteOgr.ShowDialog();
                txtAd.Clear();
                txtSoyad.Clear();
                txtNumara.Clear();
                cmbClasses.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Öðrenci silinirken bir sorun oluþtu: {ex.Message}");
            }
        }

        private void cmbList_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new ObsDbContext())
                {
                    if (cmbList.SelectedItem == null)
                    {
                        MessageBox.Show("Lütfen seçim yapýnýz");
                        return;
                    }

                    string selectedList = cmbList.SelectedItem?.ToString() ?? "Ýþlem Seçiniz";
                    List<string[]> lists = new List<string[]>();
                    string[] headers;

                    if (selectedList == "Öðrenciler")
                    {
                        headers = new string[] { "Ad", "Soyad", "Numara", "Sýnýf", "Dersler" };
                        lists = context.Students.Select(s => new string[]
                        {
                            s.StudentName,
                            s.StudentSurname,
                            s.StudentNumber,
                            s.Classroom.ClassName,
                            string.Join(", ", s.studentLessons.Select(sl => sl.Lesson.LessonName))
                        })
                        .ToList();
                    }
                    else if (selectedList == "Dersler")
                    {
                        headers = new[] { "Ders Adý", "Ders Kodu" };
                        lists = context.Lessons.Select(l => new string[]
                        {
                            l.LessonName,
                            l.LessonCode.ToString()
                        })
                        .ToList();
                    }
                    else if (selectedList == "Sýnýflar")
                    {
                        headers = new[] { "Sýnýf Adý", "Sýnýf Mevcudu" };
                        lists = context.Classrooms.Select(c => new string[]
                        {
                            c.ClassName,
                            c.Quota.ToString()
                        })
                        .ToList();
                    }
                    else
                    {
                        MessageBox.Show("Geçersiz seçim");
                        return;
                    }

                    List listForm = new List(selectedList, lists, headers);
                    listForm.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Listelenirken bir sorun oluþtu: {ex.Message}");
            }
        }
    }
}