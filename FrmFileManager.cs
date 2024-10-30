using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace DZTextFileEditor
{
    public partial class FrmFileManager : Form
    {
        public FrmFileManager()
        {
            InitializeComponent();
        }
        private void AddSubItems(ListViewItem item, DirectoryInfo directory)
        {
            try
            {

                foreach (DirectoryInfo subDir in directory.GetDirectories())
                {
                    ListViewItem subItem = new ListViewItem(subDir.Name);
                    subItem.Tag = subDir;
                    lvMain.Items.Add(subItem);
                    // Рекурсивный вызов функции для получения всех вложенных папок
                    // Код не оптимизирован, но работает, так что иерархическое дерево не
                    //строится. Вместо этого по папке можно пройти даблкликом
                    //AddSubItems(subItem, subDir);
                }

                foreach (FileInfo file in directory.GetFiles())
                {
                    ListViewItem subItem = new ListViewItem(file.Name);
                    subItem.Tag = file;
                    lvMain.Items.Add(subItem);
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                // Console.WriteLine($"Ошибка доступа к директории: {directory.FullName}");
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            DriveInfo[] drives = DriveInfo.GetDrives();
            //Код полуает информацию по всем дискам, но спотыкается, если диск невозможно
            //открыть. Поэтому код выполняется только для диска C
            //foreach (DriveInfo drive in drives)
            //{
            //    ListViewItem item = new ListViewItem(drive.Name);
            //    item.Tag = drive.RootDirectory;
            //    lvMain.Items.Add(item);

            //    AddSubItems(item, drive.RootDirectory);
            //}
            var cDrive = drives.FirstOrDefault(d => d.Name == "C:\\");
            if (cDrive != null)
            {
                ListViewItem item = new ListViewItem(cDrive.Name);
                item.Tag = cDrive.RootDirectory;
                lvMain.Items.Add(item);
                AddSubItems(item, cDrive.RootDirectory);
            }
        }

        private void lvMain_DoubleClick(object sender, EventArgs e)
        {
            if (lvMain.SelectedItems.Count > 0)
            {
                ListViewItem item = lvMain.SelectedItems[0];
                if (item.Tag is DirectoryInfo directory)
                {
                    if (directory.GetDirectories().Any())
                    {
                        lvMain.Items.Clear();
                        AddSubItems(null, directory);
                    }
                }
            }
        }

        
    }
}
