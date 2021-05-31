using System.Windows.Forms;
using VRC.Domain;

namespace VRC.ViewPlugin
{
    public abstract class RecordCardTypeGUI : UserControl
    {
        public abstract RecordCardContent EntnehmeContent();
    }
}
