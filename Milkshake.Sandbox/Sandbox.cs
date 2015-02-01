using System;

using DuoCode.Dom;
using DuoCode.Runtime;

using Milkshake.Externs.Pixi;
using Milkshake.Externs.Pixi.Display;
using Milkshake.Externs.Pixi.Renderers;
using Milkshake.Externs.Pixi.Textures;

namespace Milkshake.Sandbox
{
    public class Sandbox
    {
        public static Sprite Sloth;

        public static Stage Stage;

        public static Renderer Renderer;

        public Sandbox()
        {
            Stage = new Stage();

            Renderer = Pixi.AutoDetectRenderer(1024, 768);

            Global.document.body.appendChild(Renderer.View);

            var texture = Texture.FromImage("assets/spacesloth.png");

            Sloth = new Sprite(texture);

            Sloth.Anchor.X = Sloth.Anchor.Y = 0.5f;
            Sloth.Position.X = 500;
            Sloth.Position.Y = 300;

            Stage.AddChild(Sloth);

            Js.de.requestAnimationFrame(new Action(Render));
        }

        private static void Render()
        {
            Renderer.Render(Stage);

            Sloth.Rotation += 0.1f;

            Js.de.requestAnimationFrame(new Action(Render));
        }

}