using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;
using System.Threading;
using Microsoft.Xna.Framework.Content;

namespace Projet_2._0
{
    public class Controls
    {
        public Vector2 Position, previousPosition;
        public Vector2 Velocity;
        public Vector2 Acceleration;
        public GameType gametype;
        public float speed;
        public float maxspeed;
        bool hasJumped; //, isontop;
        KeyboardState previousKeyboardState;
        KeyboardState keyboardState;
        Keys Up, Left, Right, Down;
        //Casper casper;


        public Controls(Vector2 Position, Vector2 Velocity, float speed, Keys Up, Keys Left, Keys Right, Keys Down)
        {
            this.Up = Up;
            this.Left = Left;
            this.Right = Right;
            this.Down = Down;
            this.Position = Position;
            this.Velocity = Velocity;
            Acceleration = new Vector2(10, 10);
            this.speed = speed;
            maxspeed = 500f;
            hasJumped = true;
            previousPosition = Position;
        }


        public void update(GameTime gametime, GameType gametype, Casper casper, List<Rectangle> level)
        {
            keyboardState = Keyboard.GetState();
            int delta = gametime.ElapsedGameTime.Milliseconds;
            previousPosition = Position;

            if (gametype == GameType.Menu_Play_Solo_world1_lvl1 || gametype == GameType.Menu_Play_Solo_world1_lvl2 || gametype == GameType.Menu_Play_Solo_world1_lvl3 || gametype == GameType.Menu_Play_Multi_Type)
            {
                if ((keyboardState.IsKeyUp(Left) && keyboardState.IsKeyUp(Right)) || (keyboardState.IsKeyDown(Left) && keyboardState.IsKeyDown(Right)))
                {
                    if (Velocity.X > 0)
                    {
                        Velocity.X += -Acceleration.X * 3;
                        if (Velocity.X < 0)
                            Velocity.X = 0f;
                    }
                    else
                    {
                        Velocity.X += Acceleration.X * 3;
                        if (Velocity.X > 0)
                            Velocity.X = 0f;
                    }
                }
                else if (keyboardState.IsKeyDown(Left))
                {
                    if (Velocity.X > 0)
                        Velocity.X += -Acceleration.X * 3;
                    else if (Velocity.X > -maxspeed)
                        Velocity.X += -Acceleration.X;
                }
                else if (keyboardState.IsKeyDown(Right))
                {
                    if (Velocity.X < 0)
                        Velocity.X += Acceleration.X * 3;
                    else if (Velocity.X < maxspeed)
                        Velocity.X += Acceleration.X;
                }


                previousKeyboardState = keyboardState;
                hasJumped = true;
                Velocity = Collision(casper.Hitbox, level);
                if (keyboardState.IsKeyDown(Up) && hasJumped == false)
                {
                    SoundManager.jump.Play();
                    Velocity.Y += -600;
                    hasJumped = true;
                }
                if (keyboardState.IsKeyDown(Down) && hasJumped == true)
                {
                    Velocity.Y += Acceleration.Y;
                }
                if (hasJumped == true)
                {
                    Velocity.Y += Acceleration.Y;
                }

                Position += Velocity * speed;
                //previousPosition = Position;

            }
            else if (gametype == GameType.Menu_Play_Solo_world2_lvl1 || gametype == GameType.Menu_Play_Solo_world2_lvl2 || gametype == GameType.Menu_Play_Solo_world2_lvl3)
            {
                if ((keyboardState.IsKeyUp(Left) && keyboardState.IsKeyUp(Right)) || (keyboardState.IsKeyDown(Left) && keyboardState.IsKeyDown(Right)))
                {
                    if (Velocity.X > 0)
                    {
                        Velocity.X += -Acceleration.X * 3;
                        if (Velocity.X < 0)
                            Velocity.X = 0f;
                    }
                    else
                    {
                        Velocity.X += Acceleration.X * 3;
                        if (Velocity.X > 0)
                            Velocity.X = 0f;
                    }
                }
                else if (keyboardState.IsKeyDown(Left))
                {
                    if (Velocity.X > 0)
                        Velocity.X += -Acceleration.X * 3;
                    else if (Velocity.X > -maxspeed)
                        Velocity.X += -Acceleration.X;
                }
                else if (keyboardState.IsKeyDown(Right))
                {
                    if (Velocity.X < 0)
                        Velocity.X += Acceleration.X * 3;
                    else if (Velocity.X < maxspeed)
                        Velocity.X += Acceleration.X;
                }

                if ((keyboardState.IsKeyUp(Up) && keyboardState.IsKeyUp(Down)) || (keyboardState.IsKeyDown(Up) && keyboardState.IsKeyDown(Down)))
                {
                    if (Velocity.Y > 0)
                    {
                        Velocity.Y += -Acceleration.Y * 3;
                        if (Velocity.Y < 0)
                            Velocity.Y = 0f;
                    }
                    else
                    {
                        Velocity.Y += Acceleration.Y * 3;
                        if (Velocity.Y > 0)
                            Velocity.Y = 0f;
                    }
                }
                else if (keyboardState.IsKeyDown(Up))
                {
                    if (Velocity.Y > 0)
                        Velocity.Y += -Acceleration.Y * 3;
                    else if (Velocity.Y > -maxspeed)
                        Velocity.Y += -Acceleration.Y;
                }
                else if (keyboardState.IsKeyDown(Down))
                {
                    if (Velocity.Y < 0)
                        Velocity.Y += Acceleration.Y * 3;
                    else if (Velocity.Y < maxspeed)
                        Velocity.Y += Acceleration.Y;
                }

                previousKeyboardState = keyboardState;
                Collision2(casper.Hitbox, level);
                Position += Velocity * speed;
            }
        }

        public Vector2 Collision(Rectangle casperHitbox, List<Rectangle> level)
        {
            //bool prevhasJumped;
            foreach (Rectangle rect in level)
            {
                //if (!(undercasper.Intersects(rect)))
                //  hasJumped = true;

                if (casperHitbox.Intersects(rect))
                {

                    if (Velocity.Y < 700)
                    {
                        if (casperHitbox.Bottom <= rect.Top + Res.gI().ScaleY(7) && casperHitbox.Bottom >= rect.Top)
                        {
                            Position.Y = rect.Top - Res.gI().ScaleY(35);
                            Velocity.Y = 0f;
                            hasJumped = false;
                        }
                    }
                    else
                    {
                        if (casperHitbox.Bottom <= rect.Top + Res.gI().ScaleX(50) && casperHitbox.Bottom >= rect.Top)
                        {
                            Position.Y = rect.Top - Res.gI().ScaleY(casperHitbox.Height);
                            Velocity.Y = 0f;
                            hasJumped = false;
                        }
                    }
                    if (casperHitbox.Right <= rect.Left + Res.gI().ScaleX(10) && casperHitbox.Right >= rect.Left)
                    {
                        //Position.X = rect.X - 17;
                        //Velocity.X = -Acceleration.X;
                        Position.X = rect.X - Res.gI().ScaleX(casperHitbox.Width);
                        //Velocity.X = - Acceleration.X;
                    }
                    if (casperHitbox.Left >= rect.Right - Res.gI().ScaleX(10) && casperHitbox.Left <= rect.Right)
                    {
                        Position.X = rect.Right + Res.gI().ScaleX(1);
                        //Velocity.X = Acceleration.X;
                    }
                    if (casperHitbox.Top >= rect.Bottom - Res.gI().ScaleY(10) && casperHitbox.Top <= rect.Bottom)
                    {
                        Position.Y = rect.Bottom + Res.gI().ScaleY(1);
                        Velocity.Y = 1f;
                    }
                }
                if (Position.Y == rect.Top - Res.gI().ScaleY(35))
                {
                    if (casperHitbox.Right >= rect.Left && casperHitbox.Left <= rect.Right)
                        hasJumped = false;
                }
            }
            return Velocity;
        }

        public Vector2 getPosition()
        {
            return Position;
        }

        public Vector2 getVelocity()
        {
            return Velocity;
        }

        public Boolean getHasJumped()
        {
            return hasJumped;
        }

        public void Collision2(Rectangle casperHitbox, List<Rectangle> level)
        {
            foreach (Rectangle rect in level)
            {


                if (casperHitbox.Intersects(rect))
                {
                    if (casperHitbox.Bottom <= rect.Top + Res.gI().ScaleY(7) && casperHitbox.Bottom >= rect.Top)
                    {
                        Position.Y = previousPosition.Y - 1;
                        Velocity.Y = 0;
                    }
                    if (casperHitbox.Right <= rect.Left + Res.gI().ScaleX(10) && casperHitbox.Right >= rect.Left)
                    {
                        Position.X = previousPosition.X - 1;
                        Velocity.X = 0;
                    }
                    if (casperHitbox.Left >= rect.Right - Res.gI().ScaleX(10) && casperHitbox.Left <= rect.Right)
                    {
                        Position.X = previousPosition.X + 1;
                        Velocity.X = 0;
                    }
                    if (casperHitbox.Top >= rect.Bottom - Res.gI().ScaleY(10) && casperHitbox.Top <= rect.Bottom)
                    {
                        Position.Y = previousPosition.Y + 1;
                        Velocity.Y = 0;
                    }
                }
            }
        }
    }
}
