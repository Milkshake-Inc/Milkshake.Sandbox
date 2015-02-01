using DuoCode.Dom;
using DuoCode.Runtime;
using Milkshake.Externs.Pixi.Consts;

namespace Milkshake.Externs.Pixi.Textures
{
    [Js(Extern = true, Name = "PIXI.BaseTexture")]
    public class BaseTexture : EventTarget
    {
        [Js(Name = "BaseTexture")]
        public extern BaseTexture(dynamic source, ScaleMode scaleMode = ScaleMode.Default);

        [Js(Name = "fromCanvas")]
        public extern BaseTexture FromCanvas(HTMLCanvasElement canvas);
        [Js(Name = "fromImage")]
        public extern BaseTexture FromImage(dynamic image);

        [Js(Name = "destroy")]
        public extern void Destroy();
        [Js(Name = "dirty")]
        public extern void Dirty();
        [Js(Name = "updateSourceInterest")]
        public extern void UpdateSourceInterest();

        [Js(Name = "imageURL")]
        public string ImageURL;
        [Js(Name = "source")]
        public ImageData Source;
        [Js(Name = "hasLoaded")]
        public bool HasLoaded;
        [Js(Name = "scaleMode")]
        public ScaleMode ScaleMode;
        [Js(Name = "pemultipliedAlpha")]
        public bool PemultipliedAlpha;
        [Js(Name = "resolution")]
        public float Resolution;
        [Js(Name = "width")]
        public int Width;
        [Js(Name = "height")]
        public int Height;
    }
}