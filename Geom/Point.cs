using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi.Geom
{
    [Js(Extern = true, Name = "PIXI.Point")]
    public class Point
    {
        [Js(Name = "Point")]
        public extern Point(float x, float y);
        [Js(Name = "clone")]
        public extern Point Clone();

        [Js(Name = "x")]
        public float X;
        [Js(Name = "y")]
        public float Y;
    }
}