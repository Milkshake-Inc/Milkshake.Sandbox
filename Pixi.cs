using DuoCode.Runtime;

using Milkshake.Externs.Pixi.Renderers;

namespace Milkshake.Externs.Pixi
{
    [Js(Extern = true, Name = "PIXI")]
    public class Pixi
    {
        [Js(Name = "sayHello")]
        public static extern void SayHello();

        [Js(Name = "autoDetectRenderer")]
        public static extern Renderer AutoDetectRenderer(int width, int height);
    }
}