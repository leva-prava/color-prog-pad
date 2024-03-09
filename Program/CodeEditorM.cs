using System;
using System.Windows.Forms;

namespace ColorProgPad
{
    public class CodeEditor : Form
    {
        private TextBox codeTextBox;

        public CodeEditorForm()
        {
            InitializeComponent();
            InitializeCodeEditor();
        }

        private void InitializeCodeEditor()
        {
            codeTextBox = new TextBox();
            codeTextBox.Multiline = true;
            codeTextBox.ScrollBars = ScrollBars.Both;
            codeTextBox.Dock = DockStyle.Fill;

            //Необходимо добавить обработчики событий...

            Controls.Add(codeTextBox);
        }



        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CodeEditorForm());
        }

    }
}