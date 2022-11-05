using System.Window;

namespace Ace.Window
{
    class App ()
    {
        public static void Main()
        {
            // Initialize window
            Window window = new Window();

            // Show window modelessly
            // NOTE: Returns without waiting for window to close
            window.Show();
        }
    }
}