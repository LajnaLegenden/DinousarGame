using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace Game1
{
    class SpriteSheet
    {
        Texture2D spriteSheet;

        //Public INFO via Properties
        private int width;
        private int height;

        //Properties
        public int Width
        {
            get;
        }
        public int Height
        {
            get;
        }
    public SpriteSheet(string sheet)
        {
            spriteSheet = Game1.MyContent.Load<Texture2D>(sheet);
            width = spriteSheet.Width;
            height = spriteSheet.Height;
        }

        public void DefineObject(int startX, int startY, int height, int width)
        {
            
        }

        
    }
}
