﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework;

namespace Gex.Input
{
    public class InputManager
    {
        protected MouseState mouse, oldMouse;
        protected KeyboardState keys, oldKeys;

        public bool KeyDown(Keys key)
        {
            return keys.IsKeyDown(key);
        }
        public bool KeyUp(Keys key)
        {
            return keys.IsKeyUp(key);
        }
        public bool KeyClicked(Keys key)
        {
            return oldKeys.IsKeyUp(key) && keys.IsKeyDown(key);
        }
        public bool LMClick()
        {
            return oldMouse.LeftButton == ButtonState.Released &&
                mouse.LeftButton == ButtonState.Pressed;
        }
        public bool MMClick()
        {
            return oldMouse.MiddleButton == ButtonState.Released &&
                mouse.MiddleButton == ButtonState.Pressed;
        }
        public bool RMClick()
        {
            return oldMouse.RightButton == ButtonState.Released &&
                mouse.RightButton == ButtonState.Pressed;
        }
        public MouseState MouseState
        {
            get { return mouse; }
        }

        public Vector2 MousePos
        {
            get { return new Vector2(mouse.X, mouse.Y); }
        }
        public Vector2 MouseDiff
        {
            get { return new Vector2(mouse.X - oldMouse.X, mouse.Y - oldMouse.Y); }
        }

        public void Update(float time)
        {
            oldMouse = mouse;
            mouse = Mouse.GetState();
            oldKeys = keys;
            keys = Keyboard.GetState();
        }
    }
}
