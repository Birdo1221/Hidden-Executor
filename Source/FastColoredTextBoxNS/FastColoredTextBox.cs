using System.Drawing;
using System.Windows.Forms;

namespace FastColoredTextBoxNS
{
    internal class FastColoredTextBox
    {
        public FastColoredTextBox()
        {
        }

        public char[] AutoCompleteBracketsList { get; internal set; }
        public string AutoIndentCharsPatterns { get; internal set; }
        public object BackBrush { get; internal set; }
        public Size AutoScrollMinSize { get; internal set; }
        public Color BackColor { get; internal set; }
        public int CharHeight { get; internal set; }
        public Cursor Cursor { get; internal set; }
        public int CharWidth { get; internal set; }
        public Color DisabledColor { get; internal set; }
        public int Zoom { get; internal set; }
        public string Text { get; internal set; }
        public int TabIndex { get; internal set; }
        public Size Size { get; internal set; }
        public Color SelectionColor { get; internal set; }
        public Padding Paddings { get; internal set; }
        public ServiceColors ServiceColors { get; internal set; }
        public string Name { get; internal set; }
        public Point Location { get; internal set; }
        public bool IsReplaceMode { get; internal set; }
        public Color IndentBackColor { get; internal set; }
        public Color ForeColor { get; internal set; }
        public Font Font { get; internal set; }
    }
}