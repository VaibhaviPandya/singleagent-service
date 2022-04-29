using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace SingleAgent
{
    internal class MouseDownFilter : IMessageFilter
    {
        public event EventHandler FormClicked;
        private readonly int WM_LBUTTONDOWN = 0x201;
        private readonly Form _form = null;

        [DllImport("user32.dll")]
        public static extern bool IsChild(IntPtr hWndParent, IntPtr hWnd);

        public MouseDownFilter(Form form)
        {
            _form = form;
        }

        public bool PreFilterMessage(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN)
            {
                if (Form.ActiveForm == null || !Form.ActiveForm.Equals(_form))
                {
                    return false;
                }

                OnFormClicked();
                return false;
            }

            return false;
        }

        protected void OnFormClicked()
        {
            FormClicked?.Invoke(_form, EventArgs.Empty);
        }
    }
}
