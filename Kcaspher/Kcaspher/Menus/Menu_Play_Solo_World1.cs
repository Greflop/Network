using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Projet_2._0.Menus;

namespace Projet_2._0
{
    class Menu_Play_Solo_World1
    {
        Rectangle Bouton_Play, Bouton_Exit, Bouton_Options,Bouton_Solo, Bouton_Multi, Bouton_World1, Bouton_World2;
        Texture2D Text_Menu_Play_Solo_World1;
        Triangle w1 = new Triangle(new Vector2(Res.gI().ScaleX(245), Res.gI().ScaleY(351)), new Vector2(Res.gI().ScaleX(408), Res.gI().ScaleY(352)), new Vector2(Res.gI().ScaleX(328), Res.gI().ScaleY(202)), Triangle.Base.down);
        Triangle w2 = new Triangle(new Vector2(Res.gI().ScaleX(335), Res.gI().ScaleY(199)), new Vector2(Res.gI().ScaleX(496), Res.gI().ScaleY(196)), new Vector2(Res.gI().ScaleX(417), Res.gI().ScaleY(344)), Triangle.Base.up);
        Triangle w3 = new Triangle(new Vector2(Res.gI().ScaleX(330), Res.gI().ScaleY(184)), new Vector2(Res.gI().ScaleX(500), Res.gI().ScaleY(184)), new Vector2(Res.gI().ScaleX(417), Res.gI().ScaleY(34)), Triangle.Base.down);
        Rectangle mouseClick;
        KeyboardState keyboardstate, previouskeyboardstate;
        MouseState mouseState, previousmouseState;

        public Menu_Play_Solo_World1(Texture2D Text_Menu_Play_Solo_World1)
        {
            this.Text_Menu_Play_Solo_World1 = Text_Menu_Play_Solo_World1;
            Bouton_Options = new Rectangle(Res.gI().ScaleX(955), Res.gI().ScaleY(210), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Multi = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(680), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Exit = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(280), Res.gI().ScaleX(165), Res.gI().ScaleY(80));
            Bouton_Play = new Rectangle(Res.gI().ScaleX(500), Res.gI().ScaleY(210), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Solo = new Rectangle(Res.gI().ScaleX(500), Res.gI().ScaleY(525), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_World1 = new Rectangle(Res.gI().ScaleX(250), Res.gI().ScaleY(360), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
            Bouton_World2 = new Rectangle(Res.gI().ScaleX(250), Res.gI().ScaleY(520), Res.gI().ScaleX(225), Res.gI().ScaleY(155));
        }

        public void MouseClicked(int x, int y, ref GameType gameType)
        {
            mouseClick = new Rectangle(x, y, 10, 10);

            if (mouseClick.Intersects(Bouton_Exit))
            {
                Game1.GetGame().Exit();
            }
            else if (mouseClick.Intersects(Bouton_Options))
            {
                gameType = GameType.Menu_Option_Type;
            }
            else if (mouseClick.Intersects(Bouton_Multi))
            {
                gameType = GameType.Menu_Play_Multi_Type;
            }
            else if (mouseClick.Intersects(Bouton_Play))
            {
                gameType = GameType.Menu_Play_Type;
            }
            else if (mouseClick.Intersects(Bouton_World1))
            {
                gameType = GameType.Menu_Play_Solo_World1_Type;
            }
            else if (mouseClick.Intersects(Bouton_World2))
            {
                gameType = GameType.Menu_Play_Solo_World2_Type;
            }
            else if (mouseClick.Intersects(Bouton_Solo))
            {
                gameType = GameType.Menu_Play_Solo_Type;
            }
        }

        public void update(GameTime gametime, ref GameType gametype,ref GameType previousgametype)
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
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && w1.Intersect(Mouse.GetState().X, Mouse.GetState().Y))
            {
                gametype = GameType.Menu_Play_Solo_world1_lvl1;
                MediaPlayer.Stop();
                MediaPlayer.Play(SoundManager.ingame);
                MediaPlayer.IsRepeating = true;

            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && w2.Intersect(Mouse.GetState().X, Mouse.GetState().Y))
            {
                gametype = GameType.Menu_Play_Solo_world1_lvl2;
                MediaPlayer.Stop();
                MediaPlayer.Play(SoundManager.ingame);
                MediaPlayer.IsRepeating = true;
            }
            if (Mouse.GetState().LeftButton == ButtonState.Pressed && w3.Intersect(Mouse.GetState().X, Mouse.GetState().Y))
            {
                gametype = GameType.Menu_Play_Solo_world1_lvl3;
                MediaPlayer.Stop();
                MediaPlayer.Play(SoundManager.ingame);
                MediaPlayer.IsRepeating = true;
            }

            if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
            {
                gametype = previousgametype;
            }
            previouskeyboardstate = keyboardstate;

        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Text_Menu_Play_Solo_World1, new Rectangle(0, 0, Res.gI().ScaleX(1680), Res.gI().ScaleY(1050)), Color.White);
        }
    }
}
