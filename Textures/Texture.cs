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

        [Js(Name = "fromCanvas")]
        public extern static Texture FromCanvas(HTMLCanvasElement canvas);
        [Js(Name = "fromImage")]
        public extern static Texture FromImage(dynamic image);
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
        public int Width;
        [Js(Name = "height")]
        public int Height;

        [Js(Name = "noFrame")]
	    public bool NoFrame;
        [Js(Name = "requiresUpdate")]
	    public bool RequiresUpdate;
        [Js(Name = "valid")]
	    public bool Valid;
    }
}