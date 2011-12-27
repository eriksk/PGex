using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapEditor.Controls;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace MapEditor.ControlImpl
{
    class Sidebar : TabControl
    {
        public Sidebar()
        {
            rect = new Rectangle(500, 100, 300, 500);
        }

        public override void Load(ContentManager content)
        {
            Tab basics = new Tab("Basics");
            Add(basics);

            Tab options = new Tab("Options");
            Add(options);

            Tab tiles = new Tab("Tiles");
            Add(tiles);

            Tab scripts = new Tab("Script");
            Add(scripts);

            base.Load(content);
        }

        public override void Draw(SpriteBatch sb, Texture2D pixel)
        {
            base.Draw(sb, pixel);
        }
    }
}
