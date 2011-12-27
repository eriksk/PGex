using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using MapEditor.Utility;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace MapEditor.Controls
{
    class Button : Control
    {
        private string text;
        public event OnClick OnClicked;
        public delegate void OnClick();

        public Button(string text, Vector2 position)
            :base()
        {
            this.text = text;
        }

        public void LoadContent(ContentManager content)
        {

        }

        public override void Update(float time)
        {
            if (rect.Contains(InputSingleton.I.MouseState.X, InputSingleton.I.MouseState.Y))
            {
                if (InputSingleton.I.LMClick())
                {
                    if (OnClicked != null)
                    {
                        OnClicked();
                    }
                }
            }
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb, Texture2D pixel)
        {
            Vector2 pos = Vector2.Zero;
            pos.X = rect.Center.X;
            pos.Y = rect.Center.Y;
            if (rect.Contains(InputSingleton.I.MouseState.X, InputSingleton.I.MouseState.Y))
            {
                sb.DrawString(Game1.font, text, pos, Color.Yellow, 0f, Game1.font.MeasureString(text) / 2f, 1f, SpriteEffects.None, 1f);
            }
            else
            {
                sb.DrawString(Game1.font, text, pos, Color.White, 0f, Game1.font.MeasureString(text) / 2f, 1f, SpriteEffects.None, 1f);
            }
            

            base.Draw(sb, pixel);
        }
    }
}
