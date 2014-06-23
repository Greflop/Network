using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;

namespace Projet_2._0.Menus
{
    class Menu_Pause_Options
    {
        
        Rectangle Bouton_Back, Bouton_Sound, Bouton_screen,Bouton_Resolution;
        Rectangle mouseClick;
        MouseState mouseState, previousmouseState;
        KeyboardState keyboardstate, previouskeyboardstate;
        Texture2D Text_menu_Pause_Option;
        Vector2 Position;

        public Menu_Pause_Options(Texture2D Text_menu_Pause_Option)
        {
            Position = new Vector2(0, 0);
            this.Text_menu_Pause_Option = Text_menu_Pause_Option;
            Bouton_Sound = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(180), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_screen = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(340), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_Resolution = new Rectangle(Res.gI().ScaleX(675),Res.gI().ScaleY(530), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_Back = new Rectangle(Res.gI().ScaleX(675), Res.gI().ScaleY(690), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
        }

        void MouseClicked(int x, int y, ref GameType gametype)
        {
            mouseClick = new Rectangle(x, y, 10, 10);
            if (mouseClick.Intersects(Bouton_Sound))
            {
                SoundEffect.MasterVolume = 1.0f - SoundEffect.MasterVolume;
                MediaPlayer.Volume = 1.0f - MediaPlayer.Volume;
            }
            else if (mouseClick.Intersects(Bouton_screen))
            {
                Game1.GetGame().IsFullScreen = !Game1.GetGame().IsFullScreen;
            }
            else if (mouseClick.Intersects(Bouton_Resolution))
            {
            }
            else if (mouseClick.Intersects(Bouton_Back))
            {
                gametype = GameType.Menu_Pause;
            }
        }

        public void update(GameTime gametime, ref GameType gametype, ref GameType previousgametype, Vector2 cameraPosition)
        {
            Position = cameraPosition;
            keyboardstate = Keyboard.GetState();
            mouseState = Mouse.GetState();
            /// <check if mouseclick>
            if (previousmouseState.LeftButton == ButtonState.Pressed && mouseState.LeftButton == ButtonState.Released)
            {
                MouseClicked(mouseState.X, mouseState.Y, ref gametype);
            }
            /// </check if mouseclick>
            previousmouseState = mouseState;
            if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
            {
                gametype = previousgametype;
            }
            previouskeyboardstate = keyboardstate;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Text_menu_Pause_Option, new Rectangle((int)Position.X, (int)Position.Y, Res.gI().ScaleX(1680), Res.gI().ScaleY(1050)), Color.White);
        }
    }
}
