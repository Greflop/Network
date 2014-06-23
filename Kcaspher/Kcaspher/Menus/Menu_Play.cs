using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using System.Threading;

namespace Projet_2._0
{
    class Menu_Play
    {
        Rectangle Bouton_Exit, Bouton_Options, Bouton_Solo, Bouton_Multi, lolmulti, client;
        Texture2D Text_Menu_Play;
        Rectangle mouseClick;
        MouseState mouseState, previousmouseState;
        KeyboardState keyboardstate, previouskeyboardstate;

        public Menu_Play(Texture2D Text_Menu_Play)
        {
            this.Text_Menu_Play = Text_Menu_Play;
            Bouton_Options = new Rectangle(Res.gI().ScaleX(955), Res.gI().ScaleY(210), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Solo = new Rectangle(Res.gI().ScaleX(500), Res.gI().ScaleY(525), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Multi = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(680), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Exit = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(280), Res.gI().ScaleX(165), Res.gI().ScaleY(80));
            lolmulti = new Rectangle(0, 0, 200, 200);
            client = new Rectangle(0, 200, 200, 200);

        }

        void MouseClicked(int x, int y, ref GameType gameType)
        {
            mouseClick = new Rectangle(x, y, 10, 10);

            if (mouseClick.Intersects(client))
            {
                System.Diagnostics.Process.Start("C:/Users/epita/Desktop/Kspher/Client/bin/Debug/Client.exe");
            }
            if (mouseClick.Intersects(lolmulti))
            {
                System.Diagnostics.Process.Start("C:/Users/epita/Desktop/Kspher/zbra/bin/Debug/zbra.exe");
            }
            if (mouseClick.Intersects(Bouton_Exit))
            {
                Game1.GetGame().Exit();
            }
            else if (mouseClick.Intersects(Bouton_Options))
            {
                gameType = GameType.Menu_Option_Type;
            }
            else if (mouseClick.Intersects(Bouton_Solo))
            {
                gameType = GameType.Menu_Play_Solo_Type;
            }
            else if (mouseClick.Intersects(Bouton_Multi))
            {
                gameType = GameType.Menu_Play_Multi_Type;
                MediaPlayer.Stop();
                MediaPlayer.Play(SoundManager.ingame);
                MediaPlayer.IsRepeating = true;
            }
        }

        public void update(GameTime gametime, ref GameType gametype, ref GameType previousgametype)
        {
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
            spritebatch.Draw(Text_Menu_Play, new Rectangle(0, 0, Res.gI().ScaleX(1680), Res.gI().ScaleY(1050)), Color.White);
        }
    }
}
