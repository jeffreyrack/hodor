﻿/* Helpers.cs
 * 
 * Version - 3.0.0 - Cycle 2 Release
 */
using System;
using System.Windows.Forms;

namespace CSUSM.CS441.SheriffHodor.GUI
{
    internal static class Helpers
    {
        internal static DialogResult DisplayError(string message)
        {
            return MessageBox.Show(MainWindow.Instance, message, "Error", 
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        internal static DialogResult DisplayWarning(string message)
        {
            return MessageBox.Show(MainWindow.Instance, message, "Warning", 
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        internal static DialogResult DisplayInfo(string message)
        {
            return MessageBox.Show(MainWindow.Instance, message, "Info", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        internal static DialogResult AskQuestion(string message)
        {
            return MessageBox.Show(MainWindow.Instance, message, "Question", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }
    }
}
