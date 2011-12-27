using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MapEditor.Controls;
using MapEditor.ControlImpl;
using Microsoft.Xna.Framework;

namespace MapEditor.UI
{
    class Gui : Control
    {
        private bool hidden;
        Texture2D pixel;

        public Gui()
        {
            hidden = false;
            rect = Rectangle.Empty;
        }

        public void LoadContent(ContentManager content)
        {
            pixel = content.Load<Texture2D>(@"gfx/pixel");
            Sidebar sidebar = new Sidebar();
            sidebar.Load(content);
            Add(sidebar);
        }

        public override void Update(float time)
        {
            base.Update(time);
        }

        public void Draw(SpriteBatch sb)
        {
            if (!hidden)
            {
                base.Draw(sb, pixel);
            }
        }

        public bool Hidden
        {
            get { return Hidden; }
        }
        public void Hide()
        {
            hidden = true;
        }
        public void Show()
        {
            hidden = false;
        }
        public void Toggle()
        {
            hidden = !hidden;
        }
    }
}
