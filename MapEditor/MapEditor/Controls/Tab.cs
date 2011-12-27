using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MapEditor.Controls
{
    class Tab : Control
    {
        public string name;

        public Tab(string name)
            : base()
        {
            this.name = name;
        }
    }
}
