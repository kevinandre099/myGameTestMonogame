using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Seguimiento
{
    class Rosquilla:Sprite
    {

        /// <summary>
        /// will contain the dona
        /// </summary>
        Game1 root;
        /// <summary>
        /// it works to modify my image path
        /// </summary>
        Point velocity;
        /// <summary>
        /// initialize a dona
        /// </summary>
        /// <param name="_root">with this I manipulate the loop of the game</param>
        /// <param name="_position">the dona starting position</param>
        
        public Rosquilla(Game1 _root, Point _position) : base(_position, 150)
        {
            this.root = _root;
            this.imageName = "dona_1";
            this.velocity = new Point(10,0);
            this.LoadContent();
        }
        /// <summary>
        /// we upload external content
        /// </summary>
        private void LoadContent()
        {
            spriteImage = this.root.Content.Load<Texture2D>(imageName);
        }
        public void Update(GameTime gameTime)
        {


            if (this.position.X > 0 || this.position.Y > 0)
            {
                position = position - velocity;
            }
            if (this.position.X < 0 || this.position.Y < 0)
            {
                position = position + velocity;
            }
            /*
            (this.position.Y <= 0)
            {
                position = position + velocity;
            }
            
            if (this.position.Y > 0 && this.position.Y < this.root.Window.ClientBounds.Height - Size)
            {
                position = position
            }

            










            this.position.X += (int)velocity.X;
            this.position.Y += (int)velocity.Y;

            if(this.position.Y + this.root.Window.ClientBounds.Height > 0 || this.position.Y < 0 )
            {
                velocity.Y = -velocity.Y;
            }
            if(this.position.X + this.root.Window.ClientBounds.Width - Size > 650 || this.position.X < 0 )
            {
                velocity.X = -velocity.X;
            }





            if (this.position.Y + this.root.Window.ClientBounds.Height-Size > 0 || this.position.Y < 0)
            {
                velocity.Y = -velocity.Y;
            }
            */


        }

    }
}

