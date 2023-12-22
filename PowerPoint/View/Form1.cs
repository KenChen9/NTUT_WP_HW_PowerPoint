using System;
using System.Drawing;
using System.Windows.Forms;
using PowerPoint.View;
using PowerPoint.PresentationModel;
using PowerPoint.Model;

namespace PowerPoint
{
    public partial class MainForm : Form
    {
        private readonly DoubleBufferedPanel _drawPanel = new DoubleBufferedPanel();
        private readonly FormPresentationModel _formPresentationModel = new FormPresentationModel();
        private readonly FormModel _formModel = new FormModel();
        
        public MainForm()
        {
            InitializeComponent();
            InitializeDrawPanel();
            _shapeTypeCombo.SelectedIndex = 0;
        }

        // Comment
        private void InitializeDrawPanel()
        {
            const string DRAW_PANEL_NAME = "_drawPanel";
            _drawPanel.Name = DRAW_PANEL_NAME;
            _drawPanel.BackColor = Color.White;
            _drawPanel.Parent = _containerPanel;
            ResizeDrawPanel();
        }

        // Comment
        private void ResizeDrawPanel()
        {
            var containerSize = Tuple.Create(_containerPanel.Width, _containerPanel.Height);
            var drawPanelTransform = _formPresentationModel.GetDrawPanelTransform(containerSize);
            _drawPanel.Left = drawPanelTransform.Item1;
            _drawPanel.Top = drawPanelTransform.Item2;
            _drawPanel.Width = drawPanelTransform.Item3;
            _drawPanel.Height = drawPanelTransform.Item4;
        }

        // Comment
        private void ClickAboutButton(object sender, EventArgs e)
        {
            const string MESSAGE = "NTUT Windows Programming Homework PowerPoint by 110590065.";
            const string CAPTION = "關於";
            MessageBox.Show(MESSAGE, CAPTION);
        }

        // Comment
        private void ClickControlManualButton(object sender, EventArgs e)
        {
            const string MESSAGE = "選擇並使用 Delete 鍵刪除投影片或形狀。";
            const string CAPTION = "操作說明";
            MessageBox.Show(MESSAGE, CAPTION);
        }

        // Comment
        private void ResizeContainerPanel(object sender, EventArgs e)
        {
            if (_formPresentationModel != null)
                ResizeDrawPanel();
        }
    }
}
