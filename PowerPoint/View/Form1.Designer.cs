
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
            this._manualButton = new System.Windows.Forms.ToolStripMenuItem();
            this._aboutButton = new System.Windows.Forms.ToolStripMenuItem();
            this._controlManualButton = new System.Windows.Forms.ToolStripMenuItem();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._undoButton = new System.Windows.Forms.ToolStripButton();
            this._redoButton = new System.Windows.Forms.ToolStripButton();
            this._addPageButton = new System.Windows.Forms.ToolStripButton();
            this._arrowButton = new System.Windows.Forms.ToolStripButton();
            this._lineButton = new System.Windows.Forms.ToolStripButton();
            this._rectangleButton = new System.Windows.Forms.ToolStripButton();
            this._ellipseButton = new System.Windows.Forms.ToolStripButton();
            this._pagePanel = new System.Windows.Forms.Panel();
            this._pageContainerSplitter = new System.Windows.Forms.Splitter();
            this._dataPanel = new System.Windows.Forms.Panel();
            this._dataButtonPanel = new System.Windows.Forms.Panel();
            this._containerDataSplitter = new System.Windows.Forms.Splitter();
            this._containerPanel = new System.Windows.Forms.Panel();
            this._addButton = new System.Windows.Forms.Button();
            this._clearButton = new System.Windows.Forms.Button();
            this._shapeTypeCombo = new System.Windows.Forms.ComboBox();
            this._gridPanel = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._menuStrip.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this._dataPanel.SuspendLayout();
            this._dataButtonPanel.SuspendLayout();
            this._gridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // _menuStrip
            // 
            this._menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this._menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._manualButton});
            this._menuStrip.Location = new System.Drawing.Point(0, 0);
            this._menuStrip.Name = "_menuStrip";
            this._menuStrip.Size = new System.Drawing.Size(800, 27);
            this._menuStrip.TabIndex = 0;
            this._menuStrip.Text = "menuStrip1";
            // 
            // _manualButton
            // 
            this._manualButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._aboutButton,
            this._controlManualButton});
            this._manualButton.Name = "_manualButton";
            this._manualButton.Size = new System.Drawing.Size(53, 23);
            this._manualButton.Text = "說明";
            // 
            // _aboutButton
            // 
            this._aboutButton.Image = global::PowerPoint.Properties.Resources.Question;
            this._aboutButton.Name = "_aboutButton";
            this._aboutButton.Size = new System.Drawing.Size(152, 26);
            this._aboutButton.Text = "關於";
            this._aboutButton.Click += new System.EventHandler(this.ClickAboutButton);
            // 
            // _controlManualButton
            // 
            this._controlManualButton.Image = global::PowerPoint.Properties.Resources.Question;
            this._controlManualButton.Name = "_controlManualButton";
            this._controlManualButton.Size = new System.Drawing.Size(152, 26);
            this._controlManualButton.Text = "操作說明";
            this._controlManualButton.Click += new System.EventHandler(this.ClickControlManualButton);
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
            this._toolStrip.Location = new System.Drawing.Point(0, 27);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(800, 27);
            this._toolStrip.TabIndex = 1;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _undoButton
            // 
            this._undoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._undoButton.Image = global::PowerPoint.Properties.Resources.Undo;
            this._undoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._undoButton.Name = "_undoButton";
            this._undoButton.Size = new System.Drawing.Size(29, 24);
            this._undoButton.Text = "復原";
            // 
            // _redoButton
            // 
            this._redoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._redoButton.Image = global::PowerPoint.Properties.Resources.Redo;
            this._redoButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._redoButton.Name = "_redoButton";
            this._redoButton.Size = new System.Drawing.Size(29, 24);
            this._redoButton.Text = "重做";
            // 
            // _addPageButton
            // 
            this._addPageButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._addPageButton.Image = global::PowerPoint.Properties.Resources.AddPage;
            this._addPageButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._addPageButton.Name = "_addPageButton";
            this._addPageButton.Size = new System.Drawing.Size(29, 24);
            this._addPageButton.Text = "新增投影片";
            // 
            // _arrowButton
            // 
            this._arrowButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._arrowButton.Image = global::PowerPoint.Properties.Resources.Arrow;
            this._arrowButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._arrowButton.Name = "_arrowButton";
            this._arrowButton.Size = new System.Drawing.Size(29, 24);
            this._arrowButton.Text = "鼠標";
            // 
            // _lineButton
            // 
            this._lineButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._lineButton.Image = global::PowerPoint.Properties.Resources.Line;
            this._lineButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._lineButton.Name = "_lineButton";
            this._lineButton.Size = new System.Drawing.Size(29, 24);
            this._lineButton.Text = "線";
            // 
            // _rectangleButton
            // 
            this._rectangleButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._rectangleButton.Image = global::PowerPoint.Properties.Resources.Rectangle;
            this._rectangleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._rectangleButton.Name = "_rectangleButton";
            this._rectangleButton.Size = new System.Drawing.Size(29, 24);
            this._rectangleButton.Text = "矩形";
            // 
            // _ellipseButton
            // 
            this._ellipseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._ellipseButton.Image = global::PowerPoint.Properties.Resources.Ellipse;
            this._ellipseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._ellipseButton.Name = "_ellipseButton";
            this._ellipseButton.Size = new System.Drawing.Size(29, 24);
            this._ellipseButton.Text = "橢圓";
            // 
            // _pagePanel
            // 
            this._pagePanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this._pagePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this._pagePanel.Location = new System.Drawing.Point(0, 54);
            this._pagePanel.Name = "_pagePanel";
            this._pagePanel.Size = new System.Drawing.Size(200, 396);
            this._pagePanel.TabIndex = 2;
            // 
            // _pageContainerSplitter
            // 
            this._pageContainerSplitter.Location = new System.Drawing.Point(200, 54);
            this._pageContainerSplitter.Name = "_pageContainerSplitter";
            this._pageContainerSplitter.Size = new System.Drawing.Size(3, 396);
            this._pageContainerSplitter.TabIndex = 3;
            this._pageContainerSplitter.TabStop = false;
            // 
            // _dataPanel
            // 
            this._dataPanel.BackColor = System.Drawing.SystemColors.ControlLight;
            this._dataPanel.Controls.Add(this._gridPanel);
            this._dataPanel.Controls.Add(this._dataButtonPanel);
            this._dataPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this._dataPanel.Location = new System.Drawing.Point(600, 54);
            this._dataPanel.Name = "_dataPanel";
            this._dataPanel.Size = new System.Drawing.Size(200, 396);
            this._dataPanel.TabIndex = 4;
            // 
            // _dataButtonPanel
            // 
            this._dataButtonPanel.Controls.Add(this._shapeTypeCombo);
            this._dataButtonPanel.Controls.Add(this._addButton);
            this._dataButtonPanel.Controls.Add(this._clearButton);
            this._dataButtonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this._dataButtonPanel.Location = new System.Drawing.Point(0, 0);
            this._dataButtonPanel.Name = "_dataButtonPanel";
            this._dataButtonPanel.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this._dataButtonPanel.Size = new System.Drawing.Size(200, 49);
            this._dataButtonPanel.TabIndex = 0;
            // 
            // _containerDataSplitter
            // 
            this._containerDataSplitter.Dock = System.Windows.Forms.DockStyle.Right;
            this._containerDataSplitter.Location = new System.Drawing.Point(597, 54);
            this._containerDataSplitter.Name = "_containerDataSplitter";
            this._containerDataSplitter.Size = new System.Drawing.Size(3, 396);
            this._containerDataSplitter.TabIndex = 5;
            this._containerDataSplitter.TabStop = false;
            // 
            // _containerPanel
            // 
            this._containerPanel.BackColor = System.Drawing.SystemColors.ControlDark;
            this._containerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._containerPanel.Location = new System.Drawing.Point(203, 54);
            this._containerPanel.Name = "_containerPanel";
            this._containerPanel.Size = new System.Drawing.Size(394, 396);
            this._containerPanel.TabIndex = 6;
            this._containerPanel.Resize += new System.EventHandler(this.ResizeContainerPanel);
            // 
            // _addButton
            // 
            this._addButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._addButton.Location = new System.Drawing.Point(63, 3);
            this._addButton.Name = "_addButton";
            this._addButton.Size = new System.Drawing.Size(60, 43);
            this._addButton.TabIndex = 0;
            this._addButton.Text = "新增";
            this._addButton.UseVisualStyleBackColor = false;
            // 
            // _clearButton
            // 
            this._clearButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this._clearButton.Dock = System.Windows.Forms.DockStyle.Left;
            this._clearButton.Location = new System.Drawing.Point(3, 3);
            this._clearButton.Name = "_clearButton";
            this._clearButton.Size = new System.Drawing.Size(60, 43);
            this._clearButton.TabIndex = 1;
            this._clearButton.Text = "清空";
            this._clearButton.UseVisualStyleBackColor = false;
            // 
            // _shapeTypeCombo
            // 
            this._shapeTypeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._shapeTypeCombo.FormattingEnabled = true;
            this._shapeTypeCombo.Items.AddRange(new object[] {
            "線",
            "矩形",
            "橢圓"});
            this._shapeTypeCombo.Location = new System.Drawing.Point(129, 14);
            this._shapeTypeCombo.Name = "_shapeTypeCombo";
            this._shapeTypeCombo.Size = new System.Drawing.Size(62, 23);
            this._shapeTypeCombo.TabIndex = 2;
            // 
            // _gridPanel
            // 
            this._gridPanel.Controls.Add(this.dataGridView1);
            this._gridPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this._gridPanel.Location = new System.Drawing.Point(0, 49);
            this._gridPanel.Name = "_gridPanel";
            this._gridPanel.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this._gridPanel.Size = new System.Drawing.Size(200, 347);
            this._gridPanel.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(5, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(190, 342);
            this.dataGridView1.TabIndex = 0;
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
            this._dataPanel.ResumeLayout(false);
            this._dataButtonPanel.ResumeLayout(false);
            this._gridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Splitter _pageContainerSplitter;
        private System.Windows.Forms.Panel _dataPanel;
        private System.Windows.Forms.Splitter _containerDataSplitter;
        private System.Windows.Forms.Panel _containerPanel;
        private System.Windows.Forms.ToolStripMenuItem _controlManualButton;
        private System.Windows.Forms.Panel _dataButtonPanel;
        private System.Windows.Forms.ComboBox _shapeTypeCombo;
        private System.Windows.Forms.Button _addButton;
        private System.Windows.Forms.Button _clearButton;
        private System.Windows.Forms.Panel _gridPanel;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

