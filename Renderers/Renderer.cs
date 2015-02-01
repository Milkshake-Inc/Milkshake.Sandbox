using DuoCode.Dom;
using DuoCode.Runtime;

using Milkshake.Externs.Pixi.Display;

namespace Milkshake.Externs.Pixi.Renderers
{
    [Js(Extern = true)]
    public class Renderer
    {
        [Js(Name = "transparent")]
        public extern bool Transparent;
        [Js(Name = "resolution")]
        public extern float Resolution;

        [Js(Name = "width")]
        public extern float Width;
        [Js(Name = "height")]
        public extern float Height;

        [Js(Name = "type")]
        public extern int Type;
        [Js(Name = "view")]
        public extern HTMLCanvasElement View;

        [Js(Name = "render")]
        public extern void Render(Stage stage);
        [Js(Name = "resize")]
        public extern void Resize(float width, float height);
    }
}