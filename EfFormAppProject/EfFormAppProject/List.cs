using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EfFormAppProject
{
    public partial class List : Form
    {
        public List(string selectedList, List<string[]> lists, string[] headers)
        {
            InitializeComponent();
            this.Text = selectedList;

            foreach (var header in headers)
            {
                lvLists.Columns.Add(header, -2, HorizontalAlignment.Left);
            }

            foreach (var item in lists)
            {
                ListViewItem listViewItem = new ListViewItem(item);
                lvLists.Items.Add(listViewItem);
            }

            lvLists.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
