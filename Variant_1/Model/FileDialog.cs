using System.IO;
using Microsoft.Win32;

namespace Variant_1.Model
{
    public struct FileDialog
    {
        public static string fileFilter = "Text files (*.TXT)|*.txt|All Files (*.*)|*.*";
        private static OpenFileDialog _opener = new OpenFileDialog();
        private static SaveFileDialog _saver = new SaveFileDialog();
        public string selectAndReadTextFile()
        {
            string txt = "";
            _opener.Filter = fileFilter;
            if (_opener.ShowDialog() == true)
            {
                StreamReader reader = new StreamReader(_opener.FileName);
                txt = reader.ReadToEnd();
                reader.Close();
            }
            else txt = null;
            return txt;
        }

        public bool saveTextFile(string file)
        {
            _saver.Filter = fileFilter;
            if (_saver.ShowDialog() == true)
            {
                StreamWriter writer = new StreamWriter(_saver.FileName);
                writer.WriteLine(file);
                writer.Close();
                return true;
            }
            else return false;
        }
    }
}