using System.Collections.Generic;
using DuoCode.Runtime;
using Milkshake.Externs.Pixi.Geom;
using Milkshake.Externs.Pixi.Interaction;
using Milkshake.Externs.Pixi.Textures;

namespace Milkshake.Externs.Pixi.Display
{
    [Js(Extern = true, Name = "Pixi.DisplayObject")]
    public class DisplayObject
    {
        [Js(Name = "displayObject")]
        public extern DisplayObject();

        [Js(Name = "click")]
        public extern void Click(InteractionData interactionData);
        [Js(Name = "mousedown")]
        public extern void MouseDown(InteractionData interactionData);
        [Js(Name = "mouseout")]
        public extern void MouseOut(InteractionData interactionData);
        [Js(Name = "mouseover")]
        public extern void MouseOver(InteractionData interactionData);
        [Js(Name = "mouseup")]
        public extern void MouseUp(InteractionData interactionData);
        [Js(Name = "mouseupoutside")]
        public extern void MouseUpOutside(InteractionData interactionData);

        [Js(Name = "rightclick")]
        public extern void RightClick(InteractionData interactionData);
        [Js(Name = "rightdown")]
        public extern void RightDown(InteractionData interactionData);
        [Js(Name = "rightout")]
        public extern void RightOut(InteractionData interactionData);
        [Js(Name = "rightover")]
        public extern void RightOver(InteractionData interactionData);
        [Js(Name = "rightup")]
        public extern void RightUp(InteractionData interactionData);
        [Js(Name = "rightupoutside")]
        public extern void RightUpOutside(InteractionData interactionData);

        [Js(Name = "tap")]
        public extern void Tap(InteractionData interactionData);
        [Js(Name = "touchstart")]
        public extern void TouchStart(InteractionData interactionData);
        [Js(Name = "touchend")]
        public extern void TouchEnd(InteractionData interactionData);
        [Js(Name = "touchendoutside")]
        public extern void TouchEndOutside(InteractionData interactionData);

        [Js(Name = "generateTexture")]
        public extern Texture GenerateTexture(float resolution, float scaleMode);
        [Js(Name = "getBounds")]
        public extern Rectangle GetBounds();
        [Js(Name = "getLocalBounds")]
        public extern Rectangle GetLocalBounds();

        [Js(Name = "toLocal")]
        public extern Point ToLocal();
        [Js(Name = "toGlobal")]
        public extern Point ToGlobal();
        [Js(Name = "updateCache")]
        public extern void UpdateCache();

        [Js(Name = "parent")]
        public extern DisplayObjectContainer Parent { get; }
        [Js(Name = "stage")]
        public extern Stage Stage { get; }
        [Js(Name = "worldAlpha")]
        public extern float WorldAlpha { get; }
        [Js(Name = "worldVisible")]
        public extern float WorldVisible { get; }

        public extern float Alpha;
        public extern bool ButtonMode;
        public extern bool CacheAsBitmap;
        public extern string DefaultCursor;

        public extern Rectangle FilterArea;
        public extern List<AbstractFilter> Filters;
        public extern dynamic Hitarea;
        public extern bool Interactive;
        public extern Graphics Mask;

        public extern Point Pivot;
        public extern Point Position;
        public extern bool Renderable;
        public extern float Rotation;
        public extern Point Scale;
        public extern bool Visible;

        public extern float X;
        public extern float Y;

        public extern dynamic WorldTransform;
    }
}