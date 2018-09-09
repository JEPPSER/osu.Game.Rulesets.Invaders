using osu.Framework.Graphics;
using osu.Game.Rulesets.Objects.Drawables;
using OpenTK;

namespace osu.Game.Rulesets.Invaders.Objects.Drawables
{
    internal abstract class InvadersDrawableHitObject : DrawableHitObject<InvadersHitObject>
    {
        protected InvadersDrawableHitObject(InvadersHitObject hitObject, float x, float y) : base(hitObject)
        {
            Alpha = 0;  // Start transparent

            Size = new Vector2(48f);    // TODO: calculate this
            
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
            
            RelativePositionAxes = Axes.Y;
            RelativeSizeAxes = Axes.None;
            
            X = x;
            Y = y;
        }

        protected override void UpdateState(ArmedState state)
        {
            switch (state)
            {
                case ArmedState.Miss:
                    this.FadeOut(150, Easing.In).Expire();
                    break;
                case ArmedState.Hit:
                    this.FadeOut(150, Easing.OutQuint).Expire();
                    break;
            }
        }
    }
}
