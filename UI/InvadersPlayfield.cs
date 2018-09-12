using System;
using System.Collections;
using OpenTK;
using osu.Framework.Graphics;
using osu.Framework.Input;
using osu.Framework.Input.EventArgs;
using osu.Framework.Input.States;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Invaders.Objects.Drawables;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Invaders.UI
{
    internal class InvadersPlayfield : Playfield
    {
        private IBeatmap _beatmap;
        private readonly InvadersBlocker blocker;
        public static readonly Vector2 BASE_SIZE = new Vector2(512, 384);

        public InvadersPlayfield(IBeatmap bm) : base(BASE_SIZE.X)
        {
            _beatmap = bm;

            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
            RelativePositionAxes = Axes.Both;

            Content.AddRange(new[] {
                blocker = new InvadersBlocker()
            });
        }

        protected override bool OnMouseMove(InputState state)
        {
            Vector2 middle = new Vector2(RelativeToAbsoluteFactor.X * Width / 2, RelativeToAbsoluteFactor.Y * Height / 2);
            float x1 = state.Mouse.Position.X / 2 + middle.X * 0.125f; // Adjusted mouse position.
            float y1 = state.Mouse.Position.Y / 2 + middle.Y * 0.125f;
            float x2 = middle.X;
            float y2 = middle.Y;
            float angle = (float) Math.Atan2(y2 - y1, x2 - x1);
            blocker.SetAngle(angle);
            return false;
        }

        protected override bool OnKeyDown(InputState state, KeyDownEventArgs args)
        {
            /*ArrayList inputs = new ArrayList();
            if (state.Keyboard.IsPressed(OpenTK.Input.Key.D))
            {
                inputs.Add(InvadersAction.Right);
            }
            if (state.Keyboard.IsPressed(OpenTK.Input.Key.W))
            {
                inputs.Add(InvadersAction.Up);
            }
            if (state.Keyboard.IsPressed(OpenTK.Input.Key.A))
            {
                inputs.Add(InvadersAction.Left);
            }
            if (state.Keyboard.IsPressed(OpenTK.Input.Key.S))
            {
                inputs.Add(InvadersAction.Down);
            }
            blocker.OnPressed(inputs);*/
            return false;
        }

        protected override bool OnJoystickPress(InputState state, JoystickEventArgs args)
        {
            Console.WriteLine(state);
            
            return false;
        }

        protected override bool OnKeyUp(InputState state, KeyUpEventArgs args)
        {
            OnKeyDown(state, null);
            return false;
        }

        public override void Add(DrawableHitObject h)
        {
            if (!(h is InvadersDrawableHitObject note))
                throw new Exception("Unexpected hitobject type " + h.GetType().Name);

            base.Add(note);
        }
    }
}
