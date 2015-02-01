using DuoCode.Dom;
using DuoCode.Runtime;

using Milkshake.Externs.Pixi.Display;

namespace Milkshake.Externs.Pixi.Renderers
{
    [Js(Extern = true)]
    public class Renderer
    {
        [Js(Name = "transparent")]
        public bool Transparent;
        [Js(Name = "resolution")]
        public float Resolution;

        [Js(Name = "width")]
        public float Width;
        [Js(Name = "height")]
        public float Height;

        [Js(Name = "type")]
        public int Type;
        [Js(Name = "view")]
        public HTMLCanvasElement View;

        [Js(Name = "render")]
        public extern void Render(Stage stage);
        [Js(Name = "resize")]
        public extern void Resize(float width, float height);
    }
}