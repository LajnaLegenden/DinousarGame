using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game1
{
    class spriteSheetObject
    {
        Texture2D texture;
        GraphicsDevice newGraphicsDevice = new GraphicsDevice(GraphicsAdapter.DefaultAdapter, GraphicsProfile.HiDef, new PresentationParameters());
        private int x, y, w, h;



        public spriteSheetObject()
        {

        }

        public Rectangle GetSourceRect()
        {
            return new Rectangle(x,y,w,h);
        }
        public void Draw()
        {
            Game1.SpriteBatch.Draw();
        }

    }
}
