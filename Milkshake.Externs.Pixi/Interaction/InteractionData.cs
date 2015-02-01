﻿using DuoCode.Dom;
using DuoCode.Runtime;
using Milkshake.Externs.Pixi.Display;
using Milkshake.Externs.Pixi.Geom;

namespace Milkshake.Externs.Pixi.Interaction
{
    [Js(Extern = true, Name = "PIXI.InteractionData")]
    public class InteractionData
    {
        [Js(Name = "InteractionData")]
        public extern InteractionData();
        [Js(Name = "getLocalPosition")]
        public extern Point GetLocalPosition(DisplayObject displayObject, Point point);

        [Js(Name = "originalEvent")]
        public extern MouseEvent OriginalEvent;
        [Js(Name = "global")]
        public extern Point Global;
        [Js(Name = "target")]
        public extern Sprite Target;
    }
}