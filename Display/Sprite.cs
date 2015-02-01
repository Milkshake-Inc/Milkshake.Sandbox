using DuoCode.Runtime;

using Milkshake.Externs.Pixi.Consts;
using Milkshake.Externs.Pixi.Geom;
using Milkshake.Externs.Pixi.Textures;

namespace Milkshake.Externs.Pixi.Display
{
    [Js(Extern = true, Name = "PIXI.Sprite")]
    public class Sprite : DisplayObjectContainer
    {
        [Js(Name = "Sprite")]
        public extern Sprite(Texture texture);

        [Js(Name = "fromFrame")]
        public static extern Sprite FromFrame(string frameId);
        [Js(Name = "fromImage")]
        public static extern Sprite FromImage(dynamic image);

        [Js(Name = "setTexture")]
        public extern void SetTexture(Texture texture);

        [Js(Name = "anchor")]
        public Point Anchor;
        [Js(Name = "blendMode")]
        public BlendMode BlendMode;
        [Js(Name = "tint")]
        public int Tint;
    }
}