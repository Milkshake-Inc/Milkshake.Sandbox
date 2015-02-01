using DuoCode.Runtime;

namespace Milkshake.Externs.Pixi.Display
{
    [Js(Extern = true, Name = "PIXI.DisplayObjectContainer")]
    public class DisplayObjectContainer : DisplayObject
    {
        [Js(Name = "DisplayObjectContainer")]
        public extern DisplayObjectContainer();
        [Js(Name = "addChild")]
        public extern void AddChild(DisplayObject child);
        [Js(Name = "addChildAt")]
        public extern void AddChild(DisplayObject child, int index);
        [Js(Name = "getChildAt")]
        public extern void GetChild(int index);
        [Js(Name = "removeChild")]
        public extern void RemoveChild(DisplayObject child);
        [Js(Name = "removeChildren")]
        public extern void RemoveChildren();
        [Js(Name = "swapChildren")]
        public extern void SwapChildren(DisplayObject child1, DisplayObject child2);
        [Js(Name = "setChildIndex")]
        public extern void SetChildIndex(DisplayObject child, int index);
    }
}