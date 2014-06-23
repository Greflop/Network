using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using Projet_2._0.Menus;
using Projet_2._0.Levels;
using Projet_2._0.AI;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework.Audio;
using Kcaspher.AI;
using Kcaspher;


namespace Projet_2._0
{
    public enum GameType   // A laisser ici, pas dans la classe
    {
        Exit,
        Menu_Base_Type,
        Menu_Play_Type,
        Menu_Play_Solo_Type,
        Menu_Play_Solo_World1_Type,
        Menu_Play_Solo_World2_Type,
        Menu_Play_Multi_Type,
        Menu_Option_Type,
        Menu_Pause,
        Menu_Pause_Option,
        Menu_Play_Solo_world1_lvl1,
        Menu_Play_Solo_world1_lvl2,
        Menu_Play_Solo_world1_lvl3,
        Menu_Play_Solo_world2_lvl1,
        Menu_Play_Solo_world2_lvl2,
        Menu_Play_Solo_world2_lvl3,
    }

    public class ScreenManager
    {
        public Boolean respawn;
        public Casper casper;
        public Casper casper2;
        public Casper player2;
        AI_basic BigMonster;
        Menu_Base menubase;
        Menu_Options menuoptions;
        GameType gametype, previousgametype;
        Menu_Play menuplay;
        Menu_Play_Solo menuSolo;
        Menu_Play_Multi menuMulti;
        Menu_Play_Solo_World1 menusolo1;
        Menu_Play_Solo_World2 menusolo2;
        Menu_Pause menupause;
        Menu_Pause_Options menupauseoption;
        Decors d_w2l1, d_w2l2, d_w2l3, d_w1l1_1, d_w1l1_2, d_w1l2_1, d_w1l2_2, d_w1l3;
        public Camera camera;
        //AI_basic AI1;
        AI_W1L1 AI_w1l1;
        AI_W1L2 AI_w1l2;
        AI_W2L1 AI_w2l1;
        AI_W2L2_2 AI_w2l2_2;
        AI_W2L2 AI_w2l2;
        AI_W2L3 AI_w2l3;
        KeyboardState keyboardstate, previouskeyboardstate;
        public Controls controls, controlsPlayer2, controlsWorld2;
        W2L1 w2l1;
        W2L2 w2l2;
        W2L3 w2l3;
        W1L1 w1l1;
        W1L2 w1l2;
        Rectangle teleport1, teleport2;
        Boolean isThere;
        W1L3 w1l3;
        Spikes spikes;
        Sw1l2 sw1l2;
        Sw1l3 sw1l3;
        public ParticleEngine tp1,tp2, tp3, tp4;
        Shots shots, shots2, shots3;
        public ScreenManager(GameType gametype, Game1 game)
        {
            menubase = new Menu_Base(Content_Manager.getInstance().Textures["menubase"]);
            menuoptions = new Menu_Options(Content_Manager.getInstance().Textures["menuoptions"]);
            menuplay = new Menu_Play(Content_Manager.getInstance().Textures["menuplay"]);
            menuSolo = new Menu_Play_Solo(Content_Manager.getInstance().Textures["menusolo"]);
            menusolo1 = new Menu_Play_Solo_World1(Content_Manager.getInstance().Textures["solo1"]);
            menusolo2 = new Menu_Play_Solo_World2(Content_Manager.getInstance().Textures["solo2"]);
            menuMulti = new Menu_Play_Multi(Content_Manager.getInstance().Textures["menumulti"]);
            menupauseoption = new Menu_Pause_Options(Content_Manager.getInstance().Textures["menupauseoption"]);
            

            camera = new Camera(Game1.GetGame().GraphicsDevice.Viewport);
            isThere = false;

            d_w1l1_1 = new Decors(Content_Manager.getInstance().Textures["W1L1_1"], new Rectangle(0, 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w1l1_2 = new Decors(Content_Manager.getInstance().Textures["W1L1_2"], new Rectangle(Res.gI().ScaleX(2520), 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w1l2_1 = new Decors(Content_Manager.getInstance().Textures["W1L2_1"], new Rectangle(0, 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w1l2_2 = new Decors(Content_Manager.getInstance().Textures["W1L2_2"], new Rectangle(Res.gI().ScaleX(2520), 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w1l3 = new Decors(Content_Manager.getInstance().Textures["W1L3"], new Rectangle(0, 0, Res.gI().ScaleX(2240), Res.gI().ScaleY(1050)));

            teleport1 = new Rectangle(1240, 400, 80, 80);
            teleport2 = new Rectangle(3480, 480, 80, 280);
            List<Texture2D> textures = new List<Texture2D>();
            textures.Add(Content_Manager.getInstance().Textures["tp"]);
            tp1 = tp2 = tp3=tp4 = new ParticleEngine(textures, new Vector2(0, 0));


            Game1.GetGame().casperr = casper;
            d_w2l1 = new Decors(Content_Manager.getInstance().Textures["W2L1"], new Rectangle(0, 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w2l2 = new Decors(Content_Manager.getInstance().Textures["W2L2"], new Rectangle(0, 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            d_w2l3 = new Decors(Content_Manager.getInstance().Textures["W2L3"], new Rectangle(0, 0, Res.gI().ScaleX(2520), Res.gI().ScaleY(1050)));
            menupause = new Menu_Pause(Content_Manager.getInstance().Textures["menupause"]);
            w1l1 = new W1L1();
            w1l2 = new W1L2();
            w1l3 = new W1L3();
            w2l1 = new W2L1();
            w2l2 = new W2L2();
            w2l3 = new W2L3();
            spikes = new Spikes();
            sw1l2 = new Sw1l2();
            sw1l3 = new Sw1l3();
            previousgametype = GameType.Exit;
            this.gametype = gametype;
            //List<Rectangle> enemies = spikes.getList().Concat<Rectangle>(AI_w1l1.getListRectangle()).ToList<Rectangle>;
        }

        public void update(GameTime gametime)
        {
            camera.update(gametime, new Vector2(Res.gI().ScaleX(840), 0));
            keyboardstate = Keyboard.GetState();
            
            switch (gametype)
            {
                case GameType.Menu_Base_Type:
                    menubase.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Exit;

                    casper = new Casper(Content_Manager.getInstance().Textures["Casper"], new Rectangle(0, 0, Res.gI().ScaleX(16), Res.gI().ScaleY(34)));
                    controls = new Controls(casper.Position, casper.Velocity, casper.Speed, Keys.W, Keys.A, Keys.D, Keys.S);
                    respawn = true;
                    player2 = new Casper(Content_Manager.getInstance().Textures["Casper"], new Rectangle(Res.gI().ScaleX(50), Res.gI().ScaleY(50), Res.gI().ScaleX(16), Res.gI().ScaleY(34)));
                    casper2 = new Casper(Content_Manager.getInstance().Textures["Player1"], new Rectangle(Res.gI().ScaleX(9000), Res.gI().ScaleY(9000), Res.gI().ScaleX(31), Res.gI().ScaleY(50)));
                    controlsPlayer2 = new Controls(player2.Position, player2.Velocity, player2.Speed, Keys.Up, Keys.Left, Keys.Right, Keys.Down);
                    controlsWorld2 = new Controls(casper2.Position, casper2.Velocity, casper2.Speed, Keys.W, Keys.A, Keys.D, Keys.S);

                    shots = new Shots();
                    shots2 = new Shots();
                    shots3 = new Shots();

                    AI_w1l1 = new AI_W1L1();
                    AI_w1l2 = new AI_W1L2();
                    AI_w2l1 = new AI_W2L1();
                    AI_w2l2 = new AI_W2L2();
                    AI_w2l2_2 = new AI_W2L2_2();
                    AI_w2l3 = new AI_W2L3();

                    casper.healthpoint.healthpoint = 15;
                    casper2.healthpoint.healthpoint = 13;
                    //player2.healthpoint.healthpoint = 13;
                    break;
                case GameType.Menu_Play_Type:
                    menuplay.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Base_Type;
                    break;
                case GameType.Menu_Play_Solo_Type:
                    menuSolo.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Play_Type;
                    break;
                case GameType.Menu_Play_Solo_World1_Type:
                    menusolo1.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Play_Solo_Type;
                    break;
                case GameType.Menu_Play_Solo_World2_Type:
                    menusolo2.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Play_Solo_Type;
                    break;
                case GameType.Menu_Play_Multi_Type:
                    // menuMulti.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Play_Solo_World1_Type;
                    if (previousgametype == GameType.Menu_Play_Solo_World1_Type && respawn == true)
                    {
                        controls.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(924));
                        respawn = false;
                    }
                    if (casper.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper.Position);
                    if (casper.Position.X > Res.gI().ScaleX(4200))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(4200), 0));
                    casper.update(gametime, controls, gametype, w1l1.getList(), spikes.getList());
                    player2.update(gametime, controlsPlayer2, gametype, w1l1.getList(), spikes.getList());

                    Game1.GetGame().IsMouseVisible = false;
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        previousgametype = GameType.Menu_Play_Multi_Type;
                        casper.update(gametime, controls, gametype, w1l1.getList(), spikes.getList());
                        player2.update(gametime, controlsPlayer2, gametype, w1l1.getList(), spikes.getList());

                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;

                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Option_Type:
                    menuoptions.update(gametime, ref gametype, ref previousgametype);
                    previousgametype = GameType.Menu_Base_Type;
                    break;
                case GameType.Menu_Play_Solo_world1_lvl1:
                    previousgametype = GameType.Menu_Play_Solo_World1_Type;
                    if (respawn == true || casper.healthpoint.respawn == true)
                    {
                        controls.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(924));
                        respawn = false;
                        casper.healthpoint.respawn = false;
                    }
                    if (casper.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper.Position);
                    if (casper.Position.X > Res.gI().ScaleX(4200))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(4200), 0));

                    Game1.GetGame().casperr = casper;
                    AI_w1l1.update(gametime);
                    casper.update(gametime, controls, gametype, w1l1.getList(), spikes.getList().Concat<Rectangle>(AI_w1l1.getListRectangle()));
                    Game1.GetGame().IsMouseVisible = false;
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world1_lvl1;
                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Play_Solo_world1_lvl2:
                    previousgametype = GameType.Menu_Play_Solo_World1_Type;
                    if (respawn == true || casper.healthpoint.respawn == true)
                    {
                        controls.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(244));
                        respawn = false;
                        casper.healthpoint.respawn = false;
                    }
                    if (casper.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper.Position);
                    if (casper.Position.X > Res.gI().ScaleX(4200))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(4200), 0));

                    Game1.GetGame().casperr = casper;
                    AI_w1l2.update(gametime);
                    tp1.EmitterLocation = new Vector2(Res.gI().ScaleX(1280), Res.gI().ScaleY(450));
                    tp1.Update();
                    tp2.EmitterLocation = new Vector2(Res.gI().ScaleX(3490), Res.gI().ScaleY(530));
                    tp2.Update();
                    tp3.EmitterLocation = new Vector2(Res.gI().ScaleX(3490), Res.gI().ScaleY(630));
                    tp3.Update();
                    tp4.EmitterLocation = new Vector2(Res.gI().ScaleX(3490), Res.gI().ScaleY(730));
                    tp4.Update();
                    casper.update(gametime, controls, gametype, w1l2.getList(), sw1l2.getList().Concat<Rectangle>(AI_w1l2.getListRectangle()));
                    Game1.GetGame().IsMouseVisible = false;
                    if (casper.Hitbox.Intersects(teleport1))
                        controls.Position = new Vector2(Res.gI().ScaleX(500), Res.gI().ScaleY(726));
                    if (casper.Hitbox.Intersects(teleport2))
                        controls.Position = new Vector2(Res.gI().ScaleX(3025), Res.gI().ScaleY(366));
                    if (casper.Hitbox.X > 1320 && isThere == false)
                    {
                        BigMonster = new AI_basic(Content_Manager.getInstance().Textures["Wall"], Content_Manager.getInstance().Textures["enemy2"], new Rectangle(Res.gI().ScaleX(500), Res.gI().ScaleY(0), Res.gI().ScaleX(160), Res.gI().ScaleY(1050)), new Vector2(4, 0), 30000);
                        isThere = true;
                    }
                    if (BigMonster != null)
                        BigMonster.update(gametime);
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world1_lvl2;
                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Play_Solo_world1_lvl3:
                    previousgametype = GameType.Menu_Play_Solo_World1_Type;
                    if (respawn == true || casper.healthpoint.respawn == true)
                    {
                        controls.Position = new Vector2(Res.gI().ScaleX(80), Res.gI().ScaleY(644));//spawn position
                        respawn = false;
                        casper.healthpoint.respawn = false;
                    }
                    if (casper.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper.Position);
                    if (casper.Position.X > Res.gI().ScaleX(1400))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(1400), 0));

                    Game1.GetGame().casperr = casper;
                    casper.update(gametime, controls, gametype, w1l3.getList(), sw1l3.getList());

                    Game1.GetGame().IsMouseVisible = false;
                    // IA
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world1_lvl3;
                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Play_Solo_world2_lvl1:
                    previousgametype = GameType.Menu_Play_Solo_World1_Type;
                    if (respawn == true || casper2.healthpoint.respawn == true)
                    {
                        controlsWorld2.Position = new Vector2(Res.gI().ScaleX(55), Res.gI().ScaleY(924));
                        respawn = false;
                        casper2.healthpoint.respawn = false;
                    }
                    if (casper2.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper2.Position);
                    if (casper2.Position.X > Res.gI().ScaleX(1680))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(1680), 0));
                    AI_w2l1.update(gametime, casper2);
                    Game1.GetGame().casperr = casper2;
                    casper2.update(gametime, controlsWorld2, gametype, w2l1.getList(), AI_w2l1.getListRectangle());
                    Game1.GetGame().IsMouseVisible = true;
                    shots.update(gametime, casper2.Position, AI_w2l1.AI_w2l1);
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world2_lvl1;
                    }
                    previouskeyboardstate = keyboardstate;

                    break;
                case GameType.Menu_Play_Solo_world2_lvl2:
                    previousgametype = GameType.Menu_Play_Solo_World2_Type;
                    if (respawn == true || casper2.healthpoint.respawn == true)
                    {
                        controlsWorld2.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(924));
                        respawn = false;
                        casper2.healthpoint.respawn = false;
                    }
                    if (casper2.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper2.Position);
                    if (casper2.Position.X > Res.gI().ScaleX(1680))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(1680), 0));
                    AI_w2l2.update(gametime,casper2);
                    AI_w2l2_2.update(gametime);
                    Game1.GetGame().casperr = casper2;
                    Game1.GetGame().IsMouseVisible = true;
                    shots2.update(gametime, casper2.Position, AI_w2l2.AI_w2l2);
                    casper2.update(gametime, controlsWorld2, gametype, w2l2.getList(), AI_w2l2_2.getListRectangle().Concat<Rectangle>(AI_w2l2.getListRectangle()));
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        //casper.update(gametime);
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world2_lvl2;
                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Play_Solo_world2_lvl3:
                    previousgametype = GameType.Menu_Play_Solo_World2_Type;
                    if (respawn == true || casper2.healthpoint.respawn == true)
                    {
                        controlsWorld2.Position = new Vector2(Res.gI().ScaleX(200), Res.gI().ScaleY(924));
                        respawn = false;
                        casper2.healthpoint.respawn = false;
                    }
                    if (casper2.Position.X > Res.gI().ScaleX(840))
                        camera.update(gametime, casper2.Position);
                    if (casper2.Position.X > Res.gI().ScaleX(1680))
                        camera.update(gametime, new Vector2(Res.gI().ScaleX(1680), 0));
                    AI_w2l3.update(gametime, casper2);
                    Game1.GetGame().casperr = casper2;

                    casper2.update(gametime, controlsWorld2, gametype, w2l3.getList(), AI_w2l3.getListRectangle());
                    Game1.GetGame().IsMouseVisible = true;
                    shots3.update(gametime, casper2.Position, AI_w2l3.AI_w2l3); 
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = true;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.pause);
                        gametype = GameType.Menu_Pause;
                        previousgametype = GameType.Menu_Play_Solo_world2_lvl3;
                    }
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Exit:
                    Game1.GetGame().Exit();
                    break;
                case GameType.Menu_Pause:
                    if (previousgametype == GameType.Menu_Play_Solo_world2_lvl1 || previousgametype == GameType.Menu_Play_Solo_world2_lvl2 || previousgametype == GameType.Menu_Play_Solo_world2_lvl3)
                    {
                        if (casper2.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper2.Position);
                        if (casper2.Position.X > Res.gI().ScaleX(1680))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(1680), 0));
                    }
                    if (previousgametype == GameType.Menu_Play_Solo_world1_lvl3)
                    {
                        if (casper.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper.Position);
                        if (casper.Position.X > Res.gI().ScaleX(1400))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(1400), 0));
                    }
                    if (previousgametype == GameType.Menu_Play_Solo_world1_lvl1 || previousgametype == GameType.Menu_Play_Solo_world1_lvl2)
                    {
                        if (casper.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper.Position);
                        if (casper.Position.X > Res.gI().ScaleX(4200))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(4200), 0));
                    }

                    //camera.update(gametime, casper.Position);
                    if (keyboardstate.IsKeyDown(Keys.Escape) && previouskeyboardstate.IsKeyUp(Keys.Escape))
                    {
                        Game1.GetGame().IsMouseVisible = false;
                        gametype = previousgametype;
                        MediaPlayer.Stop();
                        MediaPlayer.Play(SoundManager.ingame);

                    }
                    menupause.update(gametime, ref gametype, ref previousgametype, camera.centre);
                    previouskeyboardstate = keyboardstate;
                    break;
                case GameType.Menu_Pause_Option:
                    //camera.update(gametime, casper.Position);
                    if (previousgametype == GameType.Menu_Play_Solo_world2_lvl1 || previousgametype == GameType.Menu_Play_Solo_world2_lvl2 || previousgametype == GameType.Menu_Play_Solo_world2_lvl3)
                    {
                        if (casper2.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper2.Position);
                        if (casper2.Position.X > Res.gI().ScaleX(1680))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(1680), 0));
                    }
                    if (previousgametype == GameType.Menu_Play_Solo_world1_lvl3)
                    {
                        if (casper.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper.Position);
                        if (casper.Position.X > Res.gI().ScaleX(1400))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(1400), 0));
                    }
                    if (previousgametype == GameType.Menu_Play_Solo_world1_lvl1 || previousgametype == GameType.Menu_Play_Solo_world1_lvl2)
                    {
                        if (casper.Position.X > Res.gI().ScaleX(840))
                            camera.update(gametime, casper.Position);
                        if (casper.Position.X > Res.gI().ScaleX(4200))
                            camera.update(gametime, new Vector2(Res.gI().ScaleX(4200), 0));
                    }
                    menupauseoption.update(gametime, ref gametype, ref previousgametype, camera.centre);
                    break;
                default:
                    menubase.update(gametime, ref gametype, ref previousgametype);
                    break;
            }
        }
        public void Draw(SpriteBatch spritebatch)
        {
            switch (gametype)
            {
                case GameType.Menu_Base_Type:
                    menubase.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Type:
                    menuplay.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_Type:
                    menuSolo.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_World1_Type:
                    menusolo1.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_World2_Type:
                    menusolo2.Draw(spritebatch);
                    break;
                // world1 lvl 3
                case GameType.Menu_Play_Multi_Type:
                    d_w1l1_1.Draw(spritebatch);
                    d_w1l1_2.Draw(spritebatch);
                    casper.Draw(spritebatch, Color.White);
                    player2.Draw(spritebatch, Color.CornflowerBlue);
                    break;
                case GameType.Menu_Option_Type:
                    menuoptions.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_world1_lvl1:
                    d_w1l1_1.Draw(spritebatch);
                    d_w1l1_2.Draw(spritebatch);
                    casper.Draw(spritebatch, Color.White);
                    AI_w1l1.Draw(spritebatch);
                    casper.healthpoint.draw(spritebatch, camera);
                    break;
                case GameType.Menu_Play_Solo_world1_lvl2:
                    d_w1l2_1.Draw(spritebatch);
                    d_w1l2_2.Draw(spritebatch);
                    casper.Draw(spritebatch, Color.White);
                    tp1.Draw(spritebatch);
                    tp2.Draw(spritebatch);
                    tp3.Draw(spritebatch);
                    tp4.Draw(spritebatch);
                    if (BigMonster != null)
                        BigMonster.Draw(spritebatch);

                    AI_w1l2.Draw(spritebatch);
                    casper.healthpoint.draw(spritebatch, camera);
                    break;
                case GameType.Menu_Play_Solo_world1_lvl3:
                    d_w1l3.Draw(spritebatch);
                    casper.Draw(spritebatch, Color.White);
                    casper.healthpoint.draw(spritebatch, camera);
                    // IA
                    break;
                case GameType.Menu_Play_Solo_world2_lvl1:
                    d_w2l1.Draw(spritebatch);
                    casper2.Draw(spritebatch, Color.White);
                    AI_w2l1.Draw(spritebatch);
                    casper2.healthpoint.draw(spritebatch, camera);
                    shots.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_world2_lvl2:
                    d_w2l2.Draw(spritebatch);
                    casper2.Draw(spritebatch, Color.White);
                    casper2.healthpoint.draw(spritebatch, camera);
                    shots2.Draw(spritebatch);
                    AI_w2l2.Draw(spritebatch);
                    AI_w2l2_2.Draw(spritebatch);
                    break;
                case GameType.Menu_Play_Solo_world2_lvl3:
                    d_w2l3.Draw(spritebatch);
                    casper2.Draw(spritebatch, Color.White);
                    casper2.healthpoint.draw(spritebatch, camera);
                    shots3.Draw(spritebatch);
                    AI_w2l3.Draw(spritebatch);
                    break;
                case GameType.Menu_Pause:
                    switch (previousgametype)
                    {
                        case GameType.Menu_Play_Solo_world1_lvl1:
                            d_w1l1_1.Draw(spritebatch);
                            d_w1l1_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world1_lvl2:
                            d_w1l2_1.Draw(spritebatch);
                            d_w1l2_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world1_lvl3:
                            d_w1l3.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl1:
                            d_w2l1.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl2:
                            d_w2l2.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl3:
                            d_w2l3.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Multi_Type:
                            d_w1l1_1.Draw(spritebatch);
                            d_w1l1_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            player2.Draw(spritebatch, Color.CornflowerBlue);
                            break;
                        default:
                            break;
                    }
                    //casper.Draw(spritebatch, Color.White);
                    //player2.Draw(spritebatch, Color.CornflowerBlue);
                    menupause.Draw(spritebatch);
                    break;
                case GameType.Menu_Pause_Option:
                    switch (previousgametype)
                    {
                        case GameType.Menu_Play_Solo_world1_lvl1:
                            d_w1l1_1.Draw(spritebatch);
                            d_w1l1_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world1_lvl2:
                            d_w1l2_1.Draw(spritebatch);
                            d_w1l2_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world1_lvl3:
                            d_w1l3.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            // IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl1:
                            d_w2l1.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            //IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl2:
                            d_w2l2.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            //IA
                            break;
                        case GameType.Menu_Play_Solo_world2_lvl3:
                            d_w2l3.Draw(spritebatch);
                            casper2.Draw(spritebatch, Color.White);
                            //IA
                            break;
                        case GameType.Menu_Play_Multi_Type:
                            d_w1l1_1.Draw(spritebatch);
                            d_w1l1_2.Draw(spritebatch);
                            casper.Draw(spritebatch, Color.White);
                            player2.Draw(spritebatch, Color.CornflowerBlue);
                            //IA
                            break;
                        default:
                            break;
                    }
                    //casper.Draw(spritebatch, Color.White);
                    //player2.Draw(spritebatch, Color.CornflowerBlue);
                    menupauseoption.Draw(spritebatch);
                    break;
                default:
                    menubase.Draw(spritebatch);
                    break;
            }
        }
    }
}
