using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.Text; //use Nuget Package "MicroSoft.VisualStudio.Text.Data"

namespace SpellcheckerTest
{

    public class CustomTextBuffer : ITextBuffer
    {
        private StringBuilder buffer;
        public CustomTextBuffer()
        {
            buffer = new StringBuilder();
        }

    }

    public class CustomTextEdit : ITextEdit
    {
        private CustomTextBuffer textBuffer;
        private List<Edit> edits = new List<Edit>();

        public CustomTextEdit(CustomTextBuffer buffer)
        {
            textBuffer = buffer;
        }

    }

    public class CustomTextSnapshot : ITextSnapshot
    {
        private CustomTextBuffer textBuffer;
        private string text;

        public CustomTextSnapshot(CustomTextBuffer buffer, string setText)
        {
            textBuffer = buffer;
            this.text = setText;
        }

    }
}