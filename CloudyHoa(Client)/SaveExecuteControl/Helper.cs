using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CloudyHoa_Client_.SaveExecuteControl
{
    internal static class Helper
    {
        public static async Task SafeUIExecuteAsync(this ISafeExecuteControl control,
            Func<Task> task, string errorMessage = "runtime error")
        {
            var parent = control.ContainerForLoading;
            if (control.LockControl != null)
                control.LockControl.Enabled = false;

            LoadingControl loading = new LoadingControl();
            //Anchor = AnchorStyles.None;

            var x = parent.ClientSize.Width / 2 - loading.Width / 2;
            var y = parent.ClientSize.Height / 2 - loading.Height / 2;

            loading.Location = new System.Drawing.Point(x, y);
            parent.Controls.Add(loading);
            parent.Controls.SetChildIndex(loading, 0);

            try
            {
                await task();
            }
            catch
            {
                MessageBox.Show(parent, errorMessage, "error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                parent.Controls.Remove(loading);
                if (control.LockControl != null)
                    control.LockControl.Enabled = true;
            }
        }


    }
}
