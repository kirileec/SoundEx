using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace SoundEx.Infrastructure.Interfaces
{
    public interface ISetRichTextBox
    {
        void SetRichTextBox(RichTextBox rtb, StatusBar block = null);
    }
}
