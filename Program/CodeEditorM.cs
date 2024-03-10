using System;
using System.Windows.Forms;
using ScintillaNET;

namespace ColorProgPad
{
    public class CodeEditor : Form
    {
        private Scintilla codeEditor;

        public CodeEditorForm()
        {
            InitializeComponent();
            InitializeCodeEditor();
        }

        private void InitializeCodeEditor()
        {
            codeEditor = new Scintilla();
            codeEditor.Dock = DockStyle.Fill;

            // Настройка Scintilla для поддержки языка C#
            codeEditor.ConfigurationManager.Language = "cs";
            Controls.Add(codeEditor);
        }

         //Обработчики событий

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CodeEditorForm());
        }

    }
}