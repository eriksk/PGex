using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Gex.Input;

namespace MapEditor.Utility
{
    class InputSingleton
    {
        private InputSingleton()
        {
        }

        private static InputManager instance = new InputManager();
        public static InputManager I
        {
            get 
            {
                return instance;
            }
        }
    }
}
