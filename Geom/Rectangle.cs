using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi.Geom
{
    [Js(Extern = true, Name = "PIXI.Rectangle")]
    public class Rectangle
    {
        [Js(Name = "Rectangle")]
        public extern Rectangle(float x, float y, float width, float height);

        [Js(Name = "clone")]
        public extern Rectangle Clone();

        [Js(Name = "x")]
        public float X;
        [Js(Name = "y")]
        public float Y;
        [Js(Name = "width")]
        public float Width;
        [Js(Name = "height")]
        public float Height;
    }
}