using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi
{
    [Js(Extern = true, Name = "PIXI")]
    public class Pixi
    {
        [Js(Name = "sayHello")]
        public static extern void SayHello();

        [Js(Name = "autoDetectRenderer")]
        public static extern dynamic AutoDetectRenderer(int width, int height);
    }
}