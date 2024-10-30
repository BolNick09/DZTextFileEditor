namespace DZTextFileEditor
{
    partial class FrmFileManager
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
            lvMain = new ListView();
            btnStart = new Button();
            SuspendLayout();
            // 
            // lvMain
            // 
            lvMain.Dock = DockStyle.Top;
            lvMain.Location = new Point(0, 0);
            lvMain.Name = "lvMain";
            lvMain.Size = new Size(277, 388);
            lvMain.TabIndex = 0;
            lvMain.UseCompatibleStateImageBehavior = false;
            lvMain.View = View.List;
            lvMain.DoubleClick += lvMain_DoubleClick;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(171, 394);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(94, 29);
            btnStart.TabIndex = 1;
            btnStart.Text = "Запустить";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // FrmFileManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(277, 431);
            Controls.Add(btnStart);
            Controls.Add(lvMain);
            Name = "FrmFileManager";
            Text = "Проводник";
            ResumeLayout(false);
        }

        #endregion

        private ListView lvMain;
        private Button btnStart;
    }
}