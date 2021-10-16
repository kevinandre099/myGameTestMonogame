using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;

namespace Seguimiento
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        /// <summary>
        /// I define my number of donuts eaten
        /// </summary>
        private SpriteFont fuente;
        /// <summary>
        /// I define the variable for the position of my counter
        /// </summary>
        private Vector2 positions;
        /// <summary>
        /// I define the remaining variable for when I finish taking all the doughnuts appear game over
        /// </summary>
        private int restantes;
        
        /// <summary>
        /// I define variable for the size of my image
        /// </summary>
        private Vector2 pp;
        /// <summary>
        /// variable definition for the background image
        /// </summary>
        private Texture2D fondo;
        /// <summary>
        /// I define my player
        /// </summary>
        Player myPlayer;
        /// <summary>
        /// I define my doughnut
        /// </summary>
        Rosquilla myRosquilla;
        /// <summary>
        /// I define my donut counter
        /// </summary>
  
        /// <summary>
        /// variable definition for my game over image
        /// </summary>
        private Texture2D gameOver;
        /// <summary>
        /// I define variable for the position in x of my game over image
        /// </summary>
        private int ssX;

        /// <summary>
        /// I define variable for the position in y of my game over image
        /// </summary>
        private int ssY;
        /// <summary>
        /// i define variable for me background music
        /// </summary>
        private Song musicaFondo;
        /// <summary>
        /// Sound effect
        /// </summary>
        private SoundEffect efectoSonido;
        /// <summary>
        /// this function is for the timer
        /// </summary>
        private int contador;
        private String [] contador2;
        private Vector2[] posicionC;


        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;

        }
        /// <summary>
        /// we initialize the aforementioned variables
        /// </summary>
        protected override void Initialize()
        {
           
            posicionC = new Vector2[10];
            contador2 = new string[] {"1","2","3","4","5","6","7","8","9","10"};
            contador = 600;
            restantes = 5;
            myPlayer = new Player(this, new Point(0, 350));
    
            myRosquilla = new Rosquilla(this, new Point(this.Window.ClientBounds.Width, 150));
           
            positions = new Vector2(650, 0);
         
            pp = new Vector2(0, 0);
            base.Initialize();
        }
        /// <summary>
        /// we upload my images and content that I fence to show on the screen
        /// </summary>
        protected override void LoadContent()
        {

            fondo = Content.Load<Texture2D>("casa_homero");
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            fuente = Content.Load<SpriteFont>("arial");
            gameOver = Content.Load<Texture2D>("gameOver");
            musicaFondo = Content.Load<Song>("television-simpsons");
            efectoSonido = Content.Load<SoundEffect>("efectoS");
            MediaPlayer.Play(musicaFondo);
            MediaPlayer.IsRepeating = true;
        }
        
        protected override void Update(GameTime gameTime)
        {

            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
      
            myPlayer.Update(gameTime);
            myRosquilla.Update(gameTime);
            contador--;
           

            if (myPlayer.PositionRectangle.Intersects(myRosquilla.PositionRectangle))
            {
                efectoSonido.CreateInstance().Play();
                restantes--;
                ssX = myRosquilla.PositionRectangle.X + myRosquilla.PositionRectangle.X + 50;
            }
            
           
            
           

            base.Update(gameTime);
        }
      
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.Yellow);
            _spriteBatch.Begin();


            //_spriteBatch.Draw(myFondo,new Vector2(100, 650), Color.White);
            _spriteBatch.Draw(fondo, pp, Color.White);
            myRosquilla.Draw(gameTime, _spriteBatch, Color.White);
            myPlayer.Draw(gameTime, _spriteBatch, Color.White);
            _spriteBatch.DrawString(fuente, "numero de donas: ", new Vector2(400, 0), Color.White);
            _spriteBatch.DrawString(fuente, "temporizador: ", new Vector2(50, 0), Color.White);
            
            if (contador <= 600 & contador > 541)
            {
                _spriteBatch.DrawString(fuente, "10", new Vector2(250, 0), Color.White);
            }
            if (contador <= 540 & contador > 481)
            {
                _spriteBatch.DrawString(fuente, "9", new Vector2(250, 0), Color.White);
            }
            if (contador <= 480 & contador > 421)
            {
                _spriteBatch.DrawString(fuente, "8", new Vector2(250, 0), Color.White);
            }
            if (contador <= 420 & contador > 361)
            {
                _spriteBatch.DrawString(fuente, "7", new Vector2(250, 0), Color.White);
            }
            if (contador <= 360 & contador > 301)
            {
                _spriteBatch.DrawString(fuente, "6", new Vector2(250, 0), Color.White);
            }
            if (contador <= 300 & contador > 241)
            {
                _spriteBatch.DrawString(fuente, "5", new Vector2(250, 0), Color.White);
            }
            if (contador <= 240 & contador > 181)
            {
                _spriteBatch.DrawString(fuente, "4", new Vector2(250, 0), Color.White);
            }
            if (contador <= 180 & contador > 121)
            {
                _spriteBatch.DrawString(fuente, "3", new Vector2(250, 0), Color.White);
            }
            if (contador <= 120 & contador > 61)
            {
                _spriteBatch.DrawString(fuente, "2", new Vector2(250, 0), Color.White);
            }
            if (contador <= 60 )
            {
                _spriteBatch.DrawString(fuente, "1", new Vector2(250, 0), Color.White);
            }
         
            if (restantes == 5)
            {
                _spriteBatch.DrawString(fuente, "5", new Vector2(700, 0), Color.White);
            }
            if (restantes == 4)
            {
                _spriteBatch.DrawString(fuente, "4", new Vector2(700, 0), Color.White);
            }
            if (restantes == 3)
            {
                _spriteBatch.DrawString(fuente, "3", new Vector2(700, 0), Color.White);
            }
            if(restantes == 2)
            {
                _spriteBatch.DrawString(fuente, "2", new Vector2(700, 0), Color.White);
            }
            if(restantes == 1)
            {
                _spriteBatch.DrawString(fuente, "1", new Vector2(700, 0), Color.White);
            }
            //_spriteBatch.DrawString(fuente, "5", new Vector2(700, 0), Color.White);
            if (restantes <= 0)
            {
                _spriteBatch.Draw(gameOver, new Vector2(-550, -350), Color.White);
            }
            
            if (contador <= 0)
            {
                _spriteBatch.Draw(gameOver, new Vector2(-550, -350), Color.White);
            }
            


            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
