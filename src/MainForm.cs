using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HidedProcessLauncher
{
    public partial class MainForm : Form
    {
        static List<HideableProcess> m_lstProcess = new List<HideableProcess>();

        public MainForm()
        {
            InitializeComponent();
            lstBox_Process.DisplayMember = "ProcessName";
        }

        private async void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ofdSelect.ShowDialog() == DialogResult.OK)
            {
                HideableProcess hidProcess = new HideableProcess();
                hidProcess.StartInfo.FileName = ofdSelect.FileName;
                await hidProcess.Start();
                m_lstProcess.Add(hidProcess);
                lstBox_Process.Items.Add(hidProcess);
            }
        }

        private void lstBox_Process_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBox_Process.SelectedIndex >= 0)
            {
                HideableProcess currentProc = lstBox_Process.SelectedItem as HideableProcess;
                if (currentProc == null)
                {
                    lstBox_Process.SelectedIndex = -1;
                    return;
                }
                showToolStripMenuItem.Visible = currentProc.IsHideable;
                hideToolStripMenuItem.Visible = currentProc.IsHideable;
                togleToolStripMenuItem.Visible = currentProc.IsHideable;
                selectedToolStripMenuItem.Visible = true;
            }
            else
                selectedToolStripMenuItem.Visible = false;
        }

        private void togleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideableProcess currentProc = lstBox_Process.SelectedItem as HideableProcess;
            if (currentProc != null)
            {
                currentProc.TogleState();
            }
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideableProcess currentProc = lstBox_Process.SelectedItem as HideableProcess;
            if (currentProc != null)
            {
                currentProc.Show();
            }
        }

        private void hideToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideableProcess currentProc = lstBox_Process.SelectedItem as HideableProcess;
            if (currentProc != null)
            {
                currentProc.Hide();
            }
        }

        private void killToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HideableProcess currentProc = lstBox_Process.SelectedItem as HideableProcess;
            if (currentProc != null)
            {
                currentProc.Kill();
                lstBox_Process.Items.Remove(currentProc);
                lstBox_Process.SelectedIndex = -1;
            }
        }          

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = lstBox_Process.Items.Count - 1; i >= 0; i--)
            {
                HideableProcess currentProc = lstBox_Process.Items[i] as HideableProcess;
                if (currentProc == null)
                    continue;                
                if (currentProc.HasExited)
                    lstBox_Process.Items.Remove(currentProc);
            }
        }
    }
}
