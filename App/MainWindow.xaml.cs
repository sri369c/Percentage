using System.Windows;
using static Percentage.App.Properties.Settings;

namespace Percentage.App
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Restore window size from settings
            if (Default.WindowWidth > 0 && Default.WindowHeight > 0)
            {
                this.Width = Default.WindowWidth;
                this.Height = Default.WindowHeight;
            }

            // Save window size on resize
            this.SizeChanged += (s, e) =>
            {
                Default.WindowWidth = (int)this.Width;
                Default.WindowHeight = (int)this.Height;
                Default.Save();
            };
        }
    }
}