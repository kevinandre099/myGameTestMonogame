using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Seguimiento
{
    class Player:Sprite
    {
        /// <summary>
        /// will contain the player
        /// </summary>
        Game1 root;
        /// <summary>
        /// we define variable to only move on the x-axis
        /// </summary>
        Point movimientoV;
        /// <summary>
        /// we define variable to only move on the y-axis
        /// </summary>
        Point movimientoH;
        /// <summary>
        /// Defineof the keyboard status
        /// </summary>
        KeyboardState previousKeyboardState;
        /// <summary>
        /// initialize a player
        /// </summary>
        /// <param name="_root">with this I manipulate the loop of the game</param>
        /// <param name="_position">the player's starting position</param>
        public Player(Game1 _root, Point _position) : base(_position, 150)
        {
            //initialize values
           
            
            this.root = _root;
            imageName = "homero_1";
            movimientoV = new Point(0, 10);
            movimientoH = new Point(10, 0);
            this.LoadContent();
            previousKeyboardState = Keyboard.GetState();
        }
        /// <summary>
        /// we upload external content
        /// </summary>
        private void LoadContent()
        {
            spriteImage = this.root.Content.Load<Texture2D>(imageName);
        }

        /// <summary>
        /// this method detects the keys that are pressed
        /// </summary>
        /// <param name="currentKeyBoardState">current keyboard status</param>
        private void HandleInput(KeyboardState currentKeyBoardState)
        {
            if (currentKeyBoardState.IsKeyDown(Keys.Up))
            {
                if (position.Y > 0)
                {
                    position = position - movimientoV;
                    
                }
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Down))
            {
                if (position.Y < (root.Window.ClientBounds.Height - Size))
                {
                    position = position + movimientoV;
                }
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Left))
            {
                if(position.X > 0)
                {
                    position = position - movimientoH;
                }
            }
            if (currentKeyBoardState.IsKeyDown(Keys.Right))
            {
                if(position.X < 650)
                {
                    position = position + movimientoH;
                }
            }
    
            previousKeyboardState = currentKeyBoardState;
        }

        public void Update(GameTime gameTime)
        {
        
            HandleInput(Keyboard.GetState());
        }
    }
}

