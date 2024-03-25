/**
 * @file CodeEditor.cs
 * @brief Содержит реализацию класса CodeEditor.
 */

using System;
using System.Windows.Forms;
using ScintillaNET;

namespace ColorProgPad
{
    /**
     * @brief Представляет основную форму редактора кода.
     */
    public class CodeEditor : Form
    {
        private Scintilla codeEditor; /**< Контрол Scintilla для редактирования кода. */

        /**
         * @brief Инициализация нового экземпляра класса CodeEditor.
         */
        public CodeEditorForm()
        {
            InitializeComponent();
            InitializeCodeEditor();
        }

        /**
         * @brief Инициализирует редактор кода.
         */
        private void InitializeCodeEditor()
        {
            codeEditor = new Scintilla();
            codeEditor.Dock = DockStyle.Fill;

            // Настройка Scintilla для поддержки языка C#
            codeEditor.ConfigurationManager.Language = "cs";

            // Привязка обработчиков событий
            codeTextBox.KeyDown += CodeTextBox_KeyDown;

            Controls.Add(codeEditor);
        }

         /**
         * @brief Обработчик события KeyDown для клавиши Tab.
         * @param sender Источник события.
         * @param e Объект KeyEventArgs, содержит данные о событии.
         */
         private void CodeTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            // Если нажата клавиша Tab, добавляем отступ в тексте.
            if (e.KeyCode == Keys.Tab)
            {
                int selectionStart = codeTextBox.SelectionStart;
                codeTextBox.Text = codeTextBox.Text.Insert(selectionStart, "    "); // Вставляем отступ (4 пробела).
                codeTextBox.SelectionStart = selectionStart + 4; // Перемещаем курсор после вставленного отступа.
                e.Handled = true; // Предотвращаем дальнейшую обработку клавиши Tab.
            }
        }
    }
}