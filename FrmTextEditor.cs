using System;

namespace DZTextFileEditor
{
    public partial class FrmTextEditor : Form
    {
        public class TextBuffer
        {
            private List<string> buffer = new List<string>(100);

            public void AddText(string text)
            {
                if (buffer.Count >= 100)
                    buffer.RemoveAt(0);

                buffer.Add(text);

            }
            public string Undo()
            {
                if (buffer.Count > 0)
                {
                    string previousText = buffer[buffer.Count - 1];
                    buffer.RemoveAt(buffer.Count - 1);
                    return previousText;
                }
                return null;
            }
        }


        private TextBuffer buffer;
        private string filePath = string.Empty;

        public FrmTextEditor()
        {
            InitializeComponent();
            buffer = new TextBuffer();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовые файлы (*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                filePath = saveFileDialog.FileName;
                File.WriteAllText(saveFileDialog.FileName, rtbMain.Text);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(filePath))
            {
                File.WriteAllText(filePath, rtbMain.Text);
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filePath = saveFileDialog.FileName;
                    File.WriteAllText(filePath, rtbMain.Text);
                }
            }
        }
        private void btnUndo_Click(object sender, EventArgs e)
        {
            string previousText = buffer.Undo();
            if (previousText != null)
            {
                rtbMain.Text = previousText;
            }
        }

        private void rtbMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            buffer.AddText(rtbMain.Text);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files (*.txt)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string text = File.ReadAllText(filePath);
                rtbMain.Text = text;
            }
        }
    }
}
