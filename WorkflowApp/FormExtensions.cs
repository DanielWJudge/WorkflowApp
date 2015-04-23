using System;
using System.Drawing;
using System.Windows.Forms;

namespace WorkflowApp
{
    public static class FormExtensions
    {
        /// <summary>
        /// Sets the correct background color of a tab control and it's tabs for the OS;
        /// Vista+ gets a white background color (KnownColor.Window) while XP uses VisualStyleBackColor.
        /// </summary>
        /// <param name="tabControl"></param>
        /// <param name="allowVisualStyle">Allows visual style (XP shows a gradient).  Allow if the tab pages are full screen to a bordered edge,
        /// if they are 'wizard pages' with no border you want this to be false.</param>
        public static void SetTabBackColorForOS(this TabControl tabControl, bool allowVisualStyle = true)
        {
            //switch to a windows 7 'white bg' when in Vista/7
            if (!IsWindowsXP)
            {
                foreach (Control c in tabControl.TabPages)
                    c.BackColor = Color.FromKnownColor(KnownColor.Window);
                tabControl.BackColor = Color.FromKnownColor(KnownColor.Window); //get rid of transparent under 7/vista
            }

            foreach (TabPage t in tabControl.TabPages)
                t.UseVisualStyleBackColor = allowVisualStyle && IsWindowsXP;

        }

        public static bool IsWindowsXP { get { return Environment.OSVersion.Platform == PlatformID.Win32NT && Environment.OSVersion.Version < new Version(6, 0, 6000); } }
    }
}