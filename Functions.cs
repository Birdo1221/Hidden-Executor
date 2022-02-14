using System;
using System.IO;
using System.Windows.Forms;

namespace Hidden
{
    class Functions
    {

        public static void PopulateListBox(ListBox lsb, string Folder, String FileType)
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }
    }
}
