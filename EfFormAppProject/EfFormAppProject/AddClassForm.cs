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
    public partial class AddClassForm : Form
    {
        public AddClassForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string className = txtClassName.Text.Trim();
            int quota;

            if (string.IsNullOrEmpty(className) || !int.TryParse(txtQuota.Text, out quota))
            {
                MessageBox.Show("Lütfen geçerli bir sınıf adı ve mevcud giriniz.");
                return;
            }

            try
            {
                using (var context = new ObsDbContext())
                {
                    var newClass = new Classroom()
                    {
                        ClassName = className,
                        Quota = quota
                    };
                    context.Classrooms.Add(newClass);
                    context.SaveChanges();
                    MessageBox.Show("Sınıf Başarıyla Eklendi");

                    this.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show($"Sınıf eklerken bir hata oluştu {ex.Message}");
            }
        }
    }
}
