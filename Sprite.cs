using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;


namespace Seguimiento
{
    class Sprite
    {
        /// <summary>
        /// the current position of the image
        /// </summary>
        protected Point position;
        /// <summary>
        /// the name of the sprite image
        /// </summary>
        protected string imageName;
        /// <summary>
        /// image texture for the sprite
        /// </summary>
        protected Texture2D spriteImage;
        /// <summary>
        /// indicates the size of my sprite
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// position rectanguus for the sprite
        /// </summary>
        public Rectangle PositionRectangle
        {
            get
            {
                return new Rectangle(position, new Point(Size));
                //return new rectangle (position.x  , position.y ,Size , Size);
            }
        }
        /// <summary>
        /// initialize a sprite
        /// </summary>
        /// <param name="_position">initial position of the sprite</param>
        /// <param name="_size">size of my sprite</param>
        public Sprite(Point _position, int _size)
        {
            this.position = _position;
            Size = _size;
        }
        public void Draw(GameTime gameTime, SpriteBatch spriteBatch, Color _color)
        {
            spriteBatch.Draw(spriteImage, PositionRectangle, _color);
        }
    }
}

