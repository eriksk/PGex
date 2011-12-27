using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MapEditor.UI;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Gex.Graphics;
using MapEditor.Utility;
using Microsoft.Xna.Framework.Input;

namespace MapEditor.Controls
{
    class TabControl : Control
    {
        private List<Tab> tabs;
        private int selectedTab;
        Texture2D pixel;
        Rectangle area;

        public TabControl()
        {
            tabs = new List<Tab>();
            selectedTab = 0;
        }

        public override void Load(ContentManager content)
        {
            pixel = content.Load<Texture2D>(@"gfx/pixel");
            base.Load(content);
        }

        public void Add(Tab tab)
        {
            tabs.Add(tab);
        }
        public void Remove(Tab tab)
        {
            tabs.Remove(tab);
        }

        public override void Update(float time)
        {
            if (InputSingleton.I.MouseState.RightButton == ButtonState.Pressed)
            {
                if (rect.Contains(InputSingleton.I.MouseState.X, InputSingleton.I.MouseState.Y))
                {
                    //Move control
                    Move(InputSingleton.I.MouseDiff);
                }
            }

            foreach (Tab tab in tabs)
            {
                tab.Update(time);
            }
            base.Update(time);
        }

        public override void Draw(SpriteBatch sb, Texture2D pixel)
        {
            DrawHeader(sb, pixel);
            tabs[selectedTab].Draw(sb, pixel);

            base.Draw(sb, pixel);
        }

        private void DrawHeader(SpriteBatch sb, Texture2D pixel)
        {
            int count = tabs.Count;
            int width = rect.Width;
            int tabWidth = width / count;
            area = new Rectangle(rect.X, rect.Y - 30, tabWidth, 30);
            for (int i = 0; i < count; i++)
            {
                if (selectedTab == i)
                {
                    sb.Draw(pixel, area, Color.Black * 0.3f);
                }
                else
                {
                    sb.Draw(pixel, area, Color.Gray * 0.5f);
                }
                sb.DrawRectangleOutline(pixel, area, Color.White, 1);
                sb.DrawString(Game1.font, tabs[i].name, new Vector2(area.X + 4, area.Y + 4), Color.White);
                area.X += tabWidth;
            }
        }
    }
}
