using System;

namespace PowerPoint.PresentationModel
{
    public class FormPresentationModel
    {
        public FormPresentationModel()
        {

        }

        // Comment
        public Tuple<int, int, int, int> GetDrawPanelTransform(Tuple<int, int> containerSize)
        {
            const int MARGIN = 10;
            const int TWO = 2;
            const double RATIO = 16.0 / 9.0;
            int containerWidth = containerSize.Item1;
            int containerHeight = containerSize.Item2;
            int drawPanelWidth = containerWidth - TWO * MARGIN;
            int drawPanelHeight = (int)(drawPanelWidth / RATIO);
            int drawPanelLeft = MARGIN;
            int drawPanelTop = (containerHeight - drawPanelHeight) / TWO;
            return Tuple.Create(drawPanelLeft, drawPanelTop, drawPanelWidth, drawPanelHeight);
        }
    }
}
