
namespace PowerPoint
{
    partial class MainForm
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this._menuStrip = new System.Windows.Forms.MenuStrip();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._pagePanel = new System.Windows.Forms.Panel();
            this._pageContainerSplitter = new System.Windows.Forms.Splitter();
            this._dataPanel = new System.Windows.Forms.Panel();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this._containerDataSplitter = new System.Windows.Forms.Splitter();
            this._containerPanel = new System.Windows.Forms.Panel();
            this._manualButton = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this._undoButton = new System.Windows.Forms.ToolStripButton();
            this._redoButton = new System.Windows.Forms.ToolStripButton();
            this._addPageButton = new System.Windows.Forms.ToolStripButton();
            this._arrowButton = new System.Windows.Forms.ToolStripButton();
            this._lineButton = new System.Windows.Forms.ToolStripButton();
            this._rectangleButton = new System.Windows.Forms.ToolStripButton();
            this._ellipseButton = new System.Windows.Forms.ToolStripButton();
            this._menuStrip.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this._pagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._manualButton});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 28);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _toolStrip
            // 
            this._toolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._undoButton,
            this._redoButton,
            this._addPageButton,
            this._arrowButton,
            this._lineButton,
            this._rectangleButton,
            this._ellipseButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 28);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(800, 27);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _pagePanel
            // 
            this._pagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this._pagePanel.Controls.Add(this.splitter2);
            this._pagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._pagePanel.Location = new System.Drawing.Point(0, 55);
            this._pagePanel.Name = "_pagePanel";
            this._pagePanel.Size = new System.Drawing.Size(200, 395);
            this._pagePanel.TabIndex = 2;
            // 
            // _pageContainerSplitter
            // 
            this._pageContainerSplitter.Location = new System.Drawing.Point(200, 55);
            this._pageContainerSplitter.Name = "_pageContainerSplitter";
            this._pageContainerSplitter.Size = new System.Drawing.Size(3, 395);
            this._pageContainerSplitter.TabIndex = 3;
            this._pageContainerSplitter.TabStop = false;
            // 
            // _dataPanel
            // 
            this._dataPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this._dataPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._dataPanel.Location = new System.Drawing.Point(600, 55);
            this._dataPanel.Name = "_dataPanel";
            this._dataPanel.Size = new System.Drawing.Size(200, 395);
            this._dataPanel.TabIndex = 4;
            // 
            // splitter2
            // 
            this.splitter2.Location = new System.Drawing.Point(0, 0);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(3, 395);
            this.splitter2.TabIndex = 0;
            this.splitter2.TabStop = false;
            // 
            // _containerDataSplitter
            // 
            this._containerDataSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this._containerDataSplitter.Location = new System.Drawing.Point(597, 55);
            this._containerDataSplitter.Name = "_containerDataSplitter";
            this._containerDataSplitter.Size = new System.Drawing.Size(3, 395);
            this._containerDataSplitter.TabIndex = 5;
            this._containerDataSplitter.TabStop = false;
            // 
            // _containerPanel
            // 
            this._containerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this._containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._containerPanel.Location = new System.Drawing.Point(203, 55);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Size = new System.Drawing.Size(394, 395);
            this._containerPanel.TabIndex = 6;
            // 
            // _manualButton
            // 
            this._manualButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutButton});
            this._manualButton.Name = "_manualButton";
            this._manualButton.Size = new System.Drawing.Size(53, 24);
            this._manualButton.Text = "說明";
            // 
            // _aboutButton
            // 
            this._aboutButton.Name = "_aboutButton";
            this._aboutButton.Size = new System.Drawing.Size(122, 26);
            this._aboutButton.Text = "關於";
            // 
            // _undoButton
            // 
            this._undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._undoButton.Image = global::PowerPoint.Properties.Resources.Undo;
            this._undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._undoButton.Name = "_undoButton";
            this._undoButton.Size = new System.Drawing.Size(29, 24);
            this._undoButton.Text = "toolStripButton1";
            // 
            // _redoButton
            // 
            this._redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._redoButton.Image = global::PowerPoint.Properties.Resources.Redo;
            this._redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._redoButton.Name = "_redoButton";
            this._redoButton.Size = new System.Drawing.Size(29, 24);
            this._redoButton.Text = "toolStripButton2";
            // 
            // _addPageButton
            // 
            this._addPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPageButton.Image = global::PowerPoint.Properties.Resources.AddPage;
            this._addPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPageButton.Name = "_addPageButton";
            this._addPageButton.Size = new System.Drawing.Size(29, 24);
            this._addPageButton.Text = "toolStripButton3";
            // 
            // _arrowButton
            // 
            this._arrowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._arrowButton.Image = global::PowerPoint.Properties.Resources.Arrow;
            this._arrowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._arrowButton.Name = "_arrowButton";
            this._arrowButton.Size = new System.Drawing.Size(29, 24);
            this._arrowButton.Text = "toolStripButton4";
            // 
            // _lineButton
            // 
            this._lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._lineButton.Image = global::PowerPoint.Properties.Resources.Line;
            this._lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._lineButton.Name = "_lineButton";
            this._lineButton.Size = new System.Drawing.Size(29, 24);
            this._lineButton.Text = "toolStripButton5";
            // 
            // _rectangleButton
            // 
            this._rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rectangleButton.Image = global::PowerPoint.Properties.Resources.Rectangle;
            this._rectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rectangleButton.Name = "_rectangleButton";
            this._rectangleButton.Size = new System.Drawing.Size(29, 24);
            this._rectangleButton.Text = "toolStripButton6";
            // 
            // _ellipseButton
            // 
            this._ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._ellipseButton.Image = global::PowerPoint.Properties.Resources.Ellipse;
            this._ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ellipseButton.Name = "_ellipseButton";
            this._ellipseButton.Size = new System.Drawing.Size(29, 24);
            this._ellipseButton.Text = "toolStripButton7";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this._containerPanel);
            this.Controls.Add(this._containerDataSplitter);
            this.Controls.Add(this._dataPanel);
            this.Controls.Add(this._pageContainerSplitter);
            this.Controls.Add(this._pagePanel);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this._menuStrip);
            this.MainMenuStrip = this._menuStrip;
            this.Name = "MainForm";
            this.Text = "PowerPoint";
            this._menuStrip.ResumeLayout(false);
            this._menuStrip.PerformLayout();
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this._pagePanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _menuStrip;
        private System.Windows.Forms.ToolStripMenuItem _manualButton;
        private System.Windows.Forms.ToolStripMenuItem _aboutButton;
        private System.Windows.Forms.ToolStrip _toolStrip;
        private System.Windows.Forms.ToolStripButton _undoButton;
        private System.Windows.Forms.ToolStripButton _redoButton;
        private System.Windows.Forms.ToolStripButton _addPageButton;
        private System.Windows.Forms.ToolStripButton _arrowButton;
        private System.Windows.Forms.ToolStripButton _lineButton;
        private System.Windows.Forms.ToolStripButton _rectangleButton;
        private System.Windows.Forms.ToolStripButton _ellipseButton;
        private System.Windows.Forms.Panel _pagePanel;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.Splitter _pageContainerSplitter;
        private System.Windows.Forms.Panel _dataPanel;
        private System.Windows.Forms.Splitter _containerDataSplitter;
        private System.Windows.Forms.Panel _containerPanel;
    }
}

