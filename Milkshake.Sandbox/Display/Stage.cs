using DuoCode.Dom;
using DuoCode.Runtime;

using Milkshake.Externs.Pixi.Geom;

namespace Milkshake.Externs.Pixi.Display
{
    [Js(Extern = true, Name = "Pixi.Stage")]
    public class Stage : DisplayObjectContainer
    {
        [Js(Name = "Stage")]
        public extern Stage(int color = 0xFF0000);

        [Js(Name = "getMousePosition")]
        public extern Point GetMousePosition();
        [Js(Name = "setBackgroundColor")]
        public extern void SetBackgroundColor(int color);
        [Js(Name = "setInteractionDelegate")]
        public extern void SetInteractionDelegate(HTMLElement element);
    }
}