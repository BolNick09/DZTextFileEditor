namespace DZTextFileEditor
{
    partial class FrmTextEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmTextEditor));
            pnlMain = new Panel();
            toolStrip1 = new ToolStrip();
            btnCreateNew = new ToolStripButton();
            btnOpen = new ToolStripButton();
            btnSave = new ToolStripButton();
            btnUndo = new ToolStripButton();
            rtbMain = new RichTextBox();
            pnlMain.SuspendLayout();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlMain
            // 
            pnlMain.Controls.Add(toolStrip1);
            pnlMain.Controls.Add(rtbMain);
            pnlMain.Dock = DockStyle.Fill;
            pnlMain.Location = new Point(0, 0);
            pnlMain.Name = "pnlMain";
            pnlMain.Size = new Size(800, 450);
            pnlMain.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { btnCreateNew, btnOpen, btnSave, btnUndo });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // btnCreateNew
            // 
            btnCreateNew.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnCreateNew.Image = (Image)resources.GetObject("btnCreateNew.Image");
            btnCreateNew.ImageTransparentColor = Color.Linen;
            btnCreateNew.Name = "btnCreateNew";
            btnCreateNew.Size = new Size(29, 24);
            btnCreateNew.Text = "Создать файл";
            btnCreateNew.Click += toolStripButton1_Click;
            // 
            // btnOpen
            // 
            btnOpen.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnOpen.Image = (Image)resources.GetObject("btnOpen.Image");
            btnOpen.ImageTransparentColor = Color.Magenta;
            btnOpen.Name = "btnOpen";
            btnOpen.Size = new Size(29, 24);
            btnOpen.Text = "Открыть файл";
            btnOpen.Click += btnOpen_Click;
            // 
            // btnSave
            // 
            btnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnSave.Image = (Image)resources.GetObject("btnSave.Image");
            btnSave.ImageTransparentColor = Color.Magenta;
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(29, 24);
            btnSave.Text = "Сохранить файл";
            btnSave.Click += btnSave_Click;
            // 
            // btnUndo
            // 
            btnUndo.DisplayStyle = ToolStripItemDisplayStyle.Image;
            btnUndo.Image = (Image)resources.GetObject("btnUndo.Image");
            btnUndo.ImageTransparentColor = Color.Magenta;
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(29, 24);
            btnUndo.Text = "Отменить";
            btnUndo.Click += btnUndo_Click;
            // 
            // rtbMain
            // 
            rtbMain.Location = new Point(3, 28);
            rtbMain.Name = "rtbMain";
            rtbMain.Size = new Size(794, 410);
            rtbMain.TabIndex = 0;
            rtbMain.Text = "";
            rtbMain.KeyPress += rtbMain_KeyPress;
            // 
            // FrmTextEditor
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlMain);
            Name = "FrmTextEditor";
            Text = "Текстовый редактор";
            pnlMain.ResumeLayout(false);
            pnlMain.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlMain;
        private RichTextBox rtbMain;
        private ToolStrip toolStrip1;
        private ToolStripButton btnCreateNew;
        private ToolStripButton btnOpen;
        private ToolStripButton btnSave;
        private ToolStripButton btnUndo;
    }
}
