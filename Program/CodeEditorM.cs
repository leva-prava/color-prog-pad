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

            //объявление обработчиков событий
            codeTextBox.KeyDown += CodeTextBox_KeyDown;

            Controls.Add(codeEditor);
        }

         //Обработчики событий
         private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            //Если нажата клавиша Tab, то добавляем отступ в тексте.
            if (e.KeyCode == Keys.Tab)
            {
                int selectionStart = codeTextBox.SelectionStart;
                codeTextBox.Text = codeTextBox.Text.Insert(selectionStart, "    "); // Вставим отступ (4 пробела).
                codeTextBox.SelectionStart = selectionStart + 4; // Переместим курсор после вставленного отступа.
                e.Handled = true; // Предотвратим дальнейшую обработку клавиши Tab.
            }
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