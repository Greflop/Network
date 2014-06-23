using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Projet_2._0
{
    class Menu_Play_Solo
    {
        Rectangle Bouton_Play, Bouton_Exit, Bouton_Options, Bouton_Multi, Bouton_World1, Bouton_World2;
        Texture2D Text_Menu_Play_Solo;
        Rectangle mouseClick;
        MouseState mouseState, previousmouseState;
        KeyboardState keyboardstate, previouskeyboardstate;

        public Menu_Play_Solo(Texture2D Text_Menu_Play_Solo)
        {
            this.Text_Menu_Play_Solo = Text_Menu_Play_Solo;
            Bouton_Options = new Rectangle(Res.gI().ScaleX(955), Res.gI().ScaleY(210), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Multi = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(680), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
            Bouton_Exit = new Rectangle(Res.gI().ScaleX(755), Res.gI().ScaleY(280), Res.gI().ScaleX(165), Res.gI().ScaleY(80));
            Bouton_Play = new Rectangle(Res.gI().ScaleX(500), Res.gI().ScaleY(210), Res.gI().ScaleX(225), Res.gI().ScaleY(310));
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
            if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
            {
                gametype = previousgametype;
            }
            previouskeyboardstate = keyboardstate;
        }

        public void Draw(SpriteBatch spritebatch)
        {
            spritebatch.Draw(Text_Menu_Play_Solo, new Rectangle(0, 0, Res.gI().ScaleX(1680), Res.gI().ScaleY(1050)), Color.White);
        }
    }
}
