using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi.Geom
{
    [Js(Extern = true, Name = "PIXI.Matrix")]
    public class Matrix
    {
        [Js(Name = "Matrix")]
        public extern Matrix();
        [Js(Name = "identity")]
        public extern void Identity();
        [Js(Name = "translate")]
        public extern void Translate(float x, float y);
    }
}