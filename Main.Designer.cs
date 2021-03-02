
namespace ing_PDF_Reader
{
    partial class Main
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_loadfolder = new System.Windows.Forms.Button();
            this.processbar = new System.Windows.Forms.ProgressBar();
            this.button_destinationfolder = new System.Windows.Forms.Button();
            this.button_convert = new System.Windows.Forms.Button();
            this.label_convertprogress = new System.Windows.Forms.Label();
            this.label_titel = new System.Windows.Forms.Label();
            this.listbox_sourcefiles = new System.Windows.Forms.ListBox();
            this.listbox_destinationfiles = new System.Windows.Forms.ListBox();
            this.button_clear = new System.Windows.Forms.Button();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.linkLabel_folderpath = new System.Windows.Forms.LinkLabel();
            this.label_filename = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_loadfolder
            // 
            this.button_loadfolder.AccessibleName = "";
            this.button_loadfolder.AllowDrop = true;
            this.button_loadfolder.BackColor = System.Drawing.Color.LightGray;
            this.button_loadfolder.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_loadfolder.Location = new System.Drawing.Point(66, 126);
            this.button_loadfolder.Name = "button_loadfolder";
            this.button_loadfolder.Size = new System.Drawing.Size(210, 71);
            this.button_loadfolder.TabIndex = 0;
            this.button_loadfolder.Text = "Open Source Folder";
            this.button_loadfolder.UseVisualStyleBackColor = false;
            this.button_loadfolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.button_loadfolder_DragDrop);
            this.button_loadfolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.button_loadfolder_DragEnter);
            this.button_loadfolder.DragLeave += new System.EventHandler(this.button_loadfolder_DragLeave);
            // 
            // processbar
            // 
            this.processbar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.processbar.Location = new System.Drawing.Point(298, 347);
            this.processbar.Name = "processbar";
            this.processbar.Size = new System.Drawing.Size(480, 21);
            this.processbar.TabIndex = 1;
            // 
            // button_destinationfolder
            // 
            this.button_destinationfolder.AllowDrop = true;
            this.button_destinationfolder.BackColor = System.Drawing.Color.LightGray;
            this.button_destinationfolder.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_destinationfolder.Location = new System.Drawing.Point(66, 223);
            this.button_destinationfolder.Name = "button_destinationfolder";
            this.button_destinationfolder.Size = new System.Drawing.Size(210, 71);
            this.button_destinationfolder.TabIndex = 2;
            this.button_destinationfolder.Text = "Choose Destination Folder";
            this.button_destinationfolder.UseVisualStyleBackColor = false;
            this.button_destinationfolder.DragDrop += new System.Windows.Forms.DragEventHandler(this.button_savefolder_DragDrop);
            this.button_destinationfolder.DragEnter += new System.Windows.Forms.DragEventHandler(this.button_savefolder_DragEnter);
            this.button_destinationfolder.DragLeave += new System.EventHandler(this.button_savefolder_DragLeave);
            // 
            // button_convert
            // 
            this.button_convert.BackColor = System.Drawing.Color.LightGray;
            this.button_convert.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_convert.Location = new System.Drawing.Point(66, 320);
            this.button_convert.Name = "button_convert";
            this.button_convert.Size = new System.Drawing.Size(209, 71);
            this.button_convert.TabIndex = 3;
            this.button_convert.Text = "Convert";
            this.button_convert.UseVisualStyleBackColor = false;
            // 
            // label_convertprogress
            // 
            this.label_convertprogress.AutoSize = true;
            this.label_convertprogress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_convertprogress.Location = new System.Drawing.Point(495, 329);
            this.label_convertprogress.Name = "label_convertprogress";
            this.label_convertprogress.Size = new System.Drawing.Size(64, 15);
            this.label_convertprogress.TabIndex = 4;
            this.label_convertprogress.Text = "Progress";
            // 
            // label_titel
            // 
            this.label_titel.AutoSize = true;
            this.label_titel.BackColor = System.Drawing.Color.DimGray;
            this.label_titel.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_titel.ForeColor = System.Drawing.Color.DarkOrange;
            this.label_titel.Location = new System.Drawing.Point(139, 33);
            this.label_titel.Name = "label_titel";
            this.label_titel.Size = new System.Drawing.Size(528, 57);
            this.label_titel.TabIndex = 5;
            this.label_titel.Text = "ING DiBa PDF Reader";
            // 
            // listbox_sourcefiles
            // 
            this.listbox_sourcefiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listbox_sourcefiles.FormattingEnabled = true;
            this.listbox_sourcefiles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.listbox_sourcefiles.Location = new System.Drawing.Point(298, 126);
            this.listbox_sourcefiles.Name = "listbox_sourcefiles";
            this.listbox_sourcefiles.Size = new System.Drawing.Size(480, 69);
            this.listbox_sourcefiles.TabIndex = 6;
            // 
            // listbox_destinationfiles
            // 
            this.listbox_destinationfiles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.listbox_destinationfiles.FormattingEnabled = true;
            this.listbox_destinationfiles.Location = new System.Drawing.Point(298, 240);
            this.listbox_destinationfiles.Name = "listbox_destinationfiles";
            this.listbox_destinationfiles.Size = new System.Drawing.Size(480, 17);
            this.listbox_destinationfiles.TabIndex = 7;
            // 
            // button_clear
            // 
            this.button_clear.BackColor = System.Drawing.Color.Salmon;
            this.button_clear.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_clear.Location = new System.Drawing.Point(716, 195);
            this.button_clear.Name = "button_clear";
            this.button_clear.Size = new System.Drawing.Size(62, 24);
            this.button_clear.TabIndex = 8;
            this.button_clear.Text = "Clear all";
            this.button_clear.UseVisualStyleBackColor = false;
            this.button_clear.Click += new System.EventHandler(this.button_clear_Click);
            // 
            // textBox_filename
            // 
            this.textBox_filename.BackColor = System.Drawing.Color.White;
            this.textBox_filename.Location = new System.Drawing.Point(298, 273);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.Size = new System.Drawing.Size(480, 20);
            this.textBox_filename.TabIndex = 9;
            // 
            // linkLabel_folderpath
            // 
            this.linkLabel_folderpath.AutoSize = true;
            this.linkLabel_folderpath.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_folderpath.Location = new System.Drawing.Point(295, 224);
            this.linkLabel_folderpath.Name = "linkLabel_folderpath";
            this.linkLabel_folderpath.Size = new System.Drawing.Size(106, 13);
            this.linkLabel_folderpath.TabIndex = 11;
            this.linkLabel_folderpath.TabStop = true;
            this.linkLabel_folderpath.Text = "Open chosen folder";
            this.linkLabel_folderpath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_destfolderpath_LinkClicked);
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.Font = new System.Drawing.Font("Rockwell", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filename.Location = new System.Drawing.Point(295, 260);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(83, 13);
            this.label_filename.TabIndex = 12;
            this.label_filename.Text = "Enter file name";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.linkLabel_folderpath);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.button_clear);
            this.Controls.Add(this.listbox_destinationfiles);
            this.Controls.Add(this.listbox_sourcefiles);
            this.Controls.Add(this.label_titel);
            this.Controls.Add(this.label_convertprogress);
            this.Controls.Add(this.button_convert);
            this.Controls.Add(this.button_destinationfolder);
            this.Controls.Add(this.processbar);
            this.Controls.Add(this.button_loadfolder);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "(inofficial) ING-DiBa - PDF Reader | Let`s convert together";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_loadfolder;
        private System.Windows.Forms.ProgressBar processbar;
        private System.Windows.Forms.Button button_destinationfolder;
        private System.Windows.Forms.Button button_convert;
        private System.Windows.Forms.Label label_convertprogress;
        private System.Windows.Forms.Label label_titel;
        private System.Windows.Forms.ListBox listbox_sourcefiles;
        private System.Windows.Forms.ListBox listbox_destinationfiles;
        private System.Windows.Forms.Button button_clear;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.LinkLabel linkLabel_folderpath;
        private System.Windows.Forms.Label label_filename;
    }
}

