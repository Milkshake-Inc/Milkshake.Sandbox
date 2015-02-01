using DuoCode.Dom;
using DuoCode.Runtime;
using Milkshake.Externs.Pixi.Geom;

namespace Milkshake.Externs.Pixi.Textures
{
    [Js(Export = true, Name = "PIXI.Texture")]
    public class Texture : EventTarget
    {
        [Js(Name = "Texture")]
	    public extern Texture(BaseTexture baseTexture, Rectangle frame, Rectangle crop, Rectangle trim);

        [Js(Name = "addTextureToCache")]
	    public extern static void AddTextureToCache(Texture texture, String id);
        [Js(Name = "removeTextureFromCache")]
	    public extern static void RemoveTextureFromCache(String id);
        [Js(Name = "fromFrame")]
	    public extern static Texture FromFrame(String frameId);

        [Js(Name = "setFrame")]
	    public extern Rectangle SetFrame(Rectangle frame);
        [Js(Name = "destroy")]
        public extern void Destroy();

        [Js(Name = "baseTexture")]
	    public BaseTexture BaseTexture;
        [Js(Name = "crop")]
	    public Rectangle Crop;
        [Js(Name = "frame")]
	    public Rectangle Frame;
        [Js(Name = "trim")]
	    public Rectangle Trim;

        [Js(Name = "width")]
        public extern int Width;
        [Js(Name = "height")]
        public extern int Height;

        [Js(Name = "noFrame")]
	    public extern bool NoFrame;
        [Js(Name = "requiresUpdate")]
	    public extern bool RequiresUpdate;
        [Js(Name = "valid")]
	    public extern bool Valid;
    }
}