using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework;
using Gex.Graphics;

namespace MapEditor.Controls
{
    class Control
    {
        protected List<Control> controls;
        protected Rectangle rect;
        protected Color bgColor;

        public Control()
        {
            controls = new List<Control>();
            rect = new Rectangle(0,0,64,64);
            bgColor = Color.Black * 0.6f;
        }

        public void Add(Control control)
        {
            controls.Add(control);
        }
        public void Remove(Control control)
        {
            controls.Remove(control);
        }

        public virtual void Load(ContentManager content)
        {
        }

        public void Move(Vector2 by)
        {
            rect.X += (int)by.X;
            rect.Y += (int)by.Y;
            foreach (var item in controls)
            {
                item.Move(by);
            }
        }

        public virtual void Update(float time)
        {
            foreach (Control item in controls)
            {
                item.Update(time);
            }
        }
        public virtual void Draw(SpriteBatch sb, Texture2D pixel)
        {
            sb.Draw(pixel, rect, bgColor);
            sb.DrawRectangleOutline(pixel, rect, Color.White, 1);
            foreach (Control item in controls)
            {
                item.Draw(sb, pixel);
            }
        }
    }
}
