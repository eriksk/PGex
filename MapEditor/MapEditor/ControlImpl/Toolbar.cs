using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapEditor.Controls;

namespace MapEditor.ControlImpl
{
    class Toolbar : Control
    {

        public Toolbar()
        {
            rect = new Microsoft.Xna.Framework.Rectangle(0,0,120, 300 );
        }

        public override void Load(Microsoft.Xna.Framework.Content.ContentManager content)
        {
            base.Load(content);
        }

        public override void Update(float time)
        {
            base.Update(time);
        }

        public override void Draw(Microsoft.Xna.Framework.Graphics.SpriteBatch sb, Microsoft.Xna.Framework.Graphics.Texture2D pixel)
        {

            base.Draw(sb, pixel);
        }
    }
}
