namespace TextureMapConverter
{
    partial class ConvertTool
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConvertTool));
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InputTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_InputMap = new System.Windows.Forms.ToolStripMenuItem();
            this.menu_OutputMap = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuSaveNewTexture = new System.Windows.Forms.ToolStripMenuItem();
            this.OutputMapPath = new System.Windows.Forms.TextBox();
            this.InputMapPath = new System.Windows.Forms.TextBox();
            this.ImageIn = new System.Windows.Forms.PictureBox();
            this.btn_InputTexture = new System.Windows.Forms.Button();
            this.ImageOut = new System.Windows.Forms.PictureBox();
            this.btn_OutputTexture = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.hidden = new System.Windows.Forms.Button();
            this.MenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOut)).BeginInit();
            this.SuspendLayout();
            // 
            // MenuStrip
            // 
            this.MenuStrip.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Padding = new System.Windows.Forms.Padding(5, 1, 0, 1);
            this.MenuStrip.Size = new System.Drawing.Size(577, 26);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.AutoSize = false;
            this.fileToolStripMenuItem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu_InputTexture,
            this.menu_InputMap,
            this.menu_OutputMap,
            this.toolStripSeparator2,
            this.menuSaveNewTexture});
            this.fileToolStripMenuItem.Margin = new System.Windows.Forms.Padding(0, 2, 0, 2);
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // menu_InputTexture
            // 
            this.menu_InputTexture.Name = "menu_InputTexture";
            this.menu_InputTexture.Size = new System.Drawing.Size(206, 22);
            this.menu_InputTexture.Text = "Input Texture";
            this.menu_InputTexture.Click += new System.EventHandler(this.menuInputTexture_Click);
            // 
            // menu_InputMap
            // 
            this.menu_InputMap.Name = "menu_InputMap";
            this.menu_InputMap.Size = new System.Drawing.Size(206, 22);
            this.menu_InputMap.Text = "Input Map";
            this.menu_InputMap.Click += new System.EventHandler(this.menuInputMap_Click);
            // 
            // menu_OutputMap
            // 
            this.menu_OutputMap.Name = "menu_OutputMap";
            this.menu_OutputMap.Size = new System.Drawing.Size(206, 22);
            this.menu_OutputMap.Text = "Output Map";
            this.menu_OutputMap.Click += new System.EventHandler(this.menuOutputMap_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(203, 6);
            // 
            // menuSaveNewTexture
            // 
            this.menuSaveNewTexture.Name = "menuSaveNewTexture";
            this.menuSaveNewTexture.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.menuSaveNewTexture.Size = new System.Drawing.Size(206, 22);
            this.menuSaveNewTexture.Text = "Save New Texture";
            this.menuSaveNewTexture.Click += new System.EventHandler(this.menuSaveNewTexture_Click);
            // 
            // OutputMapPath
            // 
            this.OutputMapPath.Enabled = false;
            this.OutputMapPath.Location = new System.Drawing.Point(18, 429);
            this.OutputMapPath.Name = "OutputMapPath";
            this.OutputMapPath.Size = new System.Drawing.Size(538, 20);
            this.OutputMapPath.TabIndex = 9;
            // 
            // InputMapPath
            // 
            this.InputMapPath.CausesValidation = false;
            this.InputMapPath.Enabled = false;
            this.InputMapPath.Location = new System.Drawing.Point(18, 363);
            this.InputMapPath.Name = "InputMapPath";
            this.InputMapPath.Size = new System.Drawing.Size(538, 20);
            this.InputMapPath.TabIndex = 1;
            this.InputMapPath.TabStop = false;
            // 
            // ImageIn
            // 
            this.ImageIn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageIn.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageIn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImageIn.Location = new System.Drawing.Point(18, 61);
            this.ImageIn.Name = "ImageIn";
            this.ImageIn.Size = new System.Drawing.Size(256, 256);
            this.ImageIn.TabIndex = 10;
            this.ImageIn.TabStop = false;
            // 
            // btn_InputTexture
            // 
            this.btn_InputTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_InputTexture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InputTexture.Location = new System.Drawing.Point(18, 32);
            this.btn_InputTexture.Name = "btn_InputTexture";
            this.btn_InputTexture.Size = new System.Drawing.Size(92, 23);
            this.btn_InputTexture.TabIndex = 2;
            this.btn_InputTexture.Text = "Input Texture";
            this.btn_InputTexture.UseVisualStyleBackColor = true;
            this.btn_InputTexture.Click += new System.EventHandler(this.menuInputTexture_Click);
            // 
            // ImageOut
            // 
            this.ImageOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ImageOut.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ImageOut.Cursor = System.Windows.Forms.Cursors.Default;
            this.ImageOut.Location = new System.Drawing.Point(300, 61);
            this.ImageOut.Name = "ImageOut";
            this.ImageOut.Size = new System.Drawing.Size(256, 256);
            this.ImageOut.TabIndex = 12;
            this.ImageOut.TabStop = false;
            // 
            // btn_OutputTexture
            // 
            this.btn_OutputTexture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_OutputTexture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OutputTexture.Location = new System.Drawing.Point(300, 32);
            this.btn_OutputTexture.Name = "btn_OutputTexture";
            this.btn_OutputTexture.Size = new System.Drawing.Size(92, 23);
            this.btn_OutputTexture.TabIndex = 5;
            this.btn_OutputTexture.Text = "Output Texture";
            this.btn_OutputTexture.UseVisualStyleBackColor = true;
            this.btn_OutputTexture.Click += new System.EventHandler(this.menuSaveNewTexture_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(18, 334);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Input Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.menuInputMap_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(18, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Output Map";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.menuOutputMap_Click);
            // 
            // hidden
            // 
            this.hidden.Location = new System.Drawing.Point(0, 0);
            this.hidden.Margin = new System.Windows.Forms.Padding(0);
            this.hidden.Name = "hidden";
            this.hidden.Size = new System.Drawing.Size(0, 0);
            this.hidden.TabIndex = 1;
            this.hidden.Text = "hidden";
            this.hidden.UseVisualStyleBackColor = true;
            // 
            // ConvertTool
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(577, 461);
            this.Controls.Add(this.hidden);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_OutputTexture);
            this.Controls.Add(this.ImageOut);
            this.Controls.Add(this.btn_InputTexture);
            this.Controls.Add(this.ImageIn);
            this.Controls.Add(this.OutputMapPath);
            this.Controls.Add(this.InputMapPath);
            this.Controls.Add(this.MenuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.MinimumSize = new System.Drawing.Size(568, 406);
            this.Name = "ConvertTool";
            this.Text = "Texture Map Converter";
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageIn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menu_InputTexture;
        private System.Windows.Forms.ToolStripMenuItem menu_InputMap;
        private System.Windows.Forms.ToolStripMenuItem menu_OutputMap;
        private System.Windows.Forms.ToolStripMenuItem menuSaveNewTexture;
        private System.Windows.Forms.TextBox OutputMapPath;
        private System.Windows.Forms.TextBox InputMapPath;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.PictureBox ImageIn;
        private System.Windows.Forms.Button btn_InputTexture;
        private System.Windows.Forms.PictureBox ImageOut;
        private System.Windows.Forms.Button btn_OutputTexture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button hidden;
    }
}

