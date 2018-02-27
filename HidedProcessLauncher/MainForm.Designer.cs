namespace HidedProcessLauncher
{
    partial class MainForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lstBox_Process = new System.Windows.Forms.ListBox();
            this.menuAcciones = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdSelect = new System.Windows.Forms.OpenFileDialog();
            this.tmrUpdateListBox = new System.Windows.Forms.Timer(this.components);
            this.selectedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.togleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.killToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAcciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstBox_Process
            // 
            this.lstBox_Process.ContextMenuStrip = this.menuAcciones;
            this.lstBox_Process.FormattingEnabled = true;
            this.lstBox_Process.Location = new System.Drawing.Point(43, 12);
            this.lstBox_Process.Name = "lstBox_Process";
            this.lstBox_Process.Size = new System.Drawing.Size(347, 277);
            this.lstBox_Process.TabIndex = 0;
            this.lstBox_Process.SelectedIndexChanged += new System.EventHandler(this.lstBox_Process_SelectedIndexChanged);
            // 
            // menuAcciones
            // 
            this.menuAcciones.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.selectedToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.menuAcciones.Name = "contextMenuStrip1";
            this.menuAcciones.Size = new System.Drawing.Size(153, 92);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // ofdSelect
            // 
            this.ofdSelect.FileName = "openFileDialog1";
            this.ofdSelect.Filter = "Binaries|*.exe|All Files (*.*)|*.*";           
            // 
            // selectedToolStripMenuItem
            // 
            this.selectedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.togleToolStripMenuItem,
            this.showToolStripMenuItem,
            this.hideToolStripMenuItem,
            this.killToolStripMenuItem});
            this.selectedToolStripMenuItem.Name = "selectedToolStripMenuItem";
            this.selectedToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.selectedToolStripMenuItem.Text = "Selected";
            this.selectedToolStripMenuItem.Visible = false;
            // 
            // togleToolStripMenuItem
            // 
            this.togleToolStripMenuItem.Name = "togleToolStripMenuItem";
            this.togleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.togleToolStripMenuItem.Text = "Togle";
            this.togleToolStripMenuItem.Click += new System.EventHandler(this.togleToolStripMenuItem_Click);
            // 
            // showToolStripMenuItem
            // 
            this.showToolStripMenuItem.Name = "showToolStripMenuItem";
            this.showToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.showToolStripMenuItem.Text = "Show";
            this.showToolStripMenuItem.Click += new System.EventHandler(this.showToolStripMenuItem_Click);
            // 
            // hideToolStripMenuItem
            // 
            this.hideToolStripMenuItem.Name = "hideToolStripMenuItem";
            this.hideToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.hideToolStripMenuItem.Text = "Hide";
            this.hideToolStripMenuItem.Click += new System.EventHandler(this.hideToolStripMenuItem_Click);
            // 
            // killToolStripMenuItem
            // 
            this.killToolStripMenuItem.Name = "killToolStripMenuItem";
            this.killToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.killToolStripMenuItem.Text = "Kill";
            this.killToolStripMenuItem.Click += new System.EventHandler(this.killToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 325);
            this.Controls.Add(this.lstBox_Process);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Window";
            this.TopMost = true;
            this.menuAcciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstBox_Process;
        private System.Windows.Forms.OpenFileDialog ofdSelect;
        private System.Windows.Forms.Timer tmrUpdateListBox;
        private System.Windows.Forms.ContextMenuStrip menuAcciones;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem togleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem killToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
    }
}

