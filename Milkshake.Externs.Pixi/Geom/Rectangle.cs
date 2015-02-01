using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi.Geom
{
    [Js(Extern = true, Name = "PIXI.Rectangle")]
    public class Rectangle : Point
    {
        [Js(Name = "Rectangle")]
        public extern Rectangle(float x, float y, float width, float height);
        [Js(Name = "clone")]
        public new extern Rectangle Clone();

        [Js(Name = "width")]
        public extern float Width;
        [Js(Name = "height")]
        public extern float Height;
    }
}