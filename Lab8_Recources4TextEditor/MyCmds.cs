using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Lab8_Recources4TextEditor
{
    internal class MyCmds
    {
        public static RoutedUICommand Exit { get; set; }

        static MyCmds()
        {
            InputGestureCollection inputExit = new InputGestureCollection();
            inputExit.Add(new KeyGesture(Key.T,ModifierKeys.Control, "Ctrl+T"));
            Exit = new RoutedUICommand("Выход", "Exit", typeof(MyCmds), inputExit);
        }

    }
}
