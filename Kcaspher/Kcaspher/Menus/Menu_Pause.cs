using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Projet_2._0
{
    class Menu_Pause
    {
        Rectangle Bouton_Resume, Bouton_Exit, Bouton_Main,Bouton_Options;
        Rectangle mouseClick;
        MouseState mouseState, previousmouseState;
        KeyboardState keyboardstate, previouskeyboardstate;
        Texture2D Text_Menu_Pause;
        Vector2 Position;

        public Menu_Pause(Texture2D Text_Menu_Pause)
        {
            Position = new Vector2(0, 0);
            this.Text_Menu_Pause = Text_Menu_Pause;
            Bouton_Resume = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(180), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_Options = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(340), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_Main = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(530), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_Exit = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(690), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
        }

        void MouseClicked(int x, int y, ref GameType gametype, GameType previousgametype)
        {
            mouseClick = new Rectangle(x, y, 10, 10);
            if (mouseClick.Intersects(Bouton_Resume))
            {
                gametype = previousgametype;
                MediaPlayer.Stop();
                MediaPlayer.Play(SoundManager.ingame);
            }
            else if (mouseClick.Intersects(Bouton_Exit))
            {
                Game1.GetGame().Exit();
            }
            else if (mouseClick.Intersects(Bouton_Main))
            {
                MediaPlayer.Play(SoundManager.menu);
                gametype = GameType.Menu_Base_Type;

            }
            else if (mouseClick.Intersects(Bouton_Options))
            {
                gametype = GameType.Menu_Pause_Option;
            }
        }

        public void update(GameTime gametime, ref GameType gametype, ref GameType previousgametype, Vector2 CameraPosition)
        {
            Position = CameraPosition;
            keyboardstate = Keyboard.GetState();
            mouseState = Mouse.GetState();
            /// <check if mouseclick>
            if (previousmouseState.LeftButton == ButtonState.Pressed && mouseState.LeftButton == ButtonState.Released)
            {
                MouseClicked(mouseState.X, mouseState.Y, ref gametype,previousgametype);
            }
            /// </check if mouseclick>
            previousmouseState = mouseState;
            
            previouskeyboardstate = keyboardstate;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Text_Menu_Pause, new Rectangle((int)Position.X,(int)Position.Y,Res.gI().ScaleX(1680), Res.gI().ScaleY(1050)), Color.White);
        }
    }
}
