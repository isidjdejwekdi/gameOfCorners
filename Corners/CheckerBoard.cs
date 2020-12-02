using System.Windows.Controls;

namespace Corners
{
    public class CheckerBoard
    {
        public StackPanel StPanel { get; private set; }
        public CheckerColor Col { get; set; } = CheckerColor.Unknown;

        public CheckerBoard(StackPanel sp, CheckerColor col)
        {
            StPanel = sp;
            Col = col;
        }
    }
}
