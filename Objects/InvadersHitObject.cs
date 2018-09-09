using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;

namespace osu.Game.Rulesets.Invaders.Objects
{
    public abstract class InvadersHitObject : HitObject, IHasXPosition, IHasYPosition
    {
        public float X { get; }
        public float Y { get; }
        public double TimePreempt { get; }

        public InvadersHitObject(double time, float x, float y)
        {
            StartTime = time;
            X = x;
            Y = y;

            // TODO: this should be dependent on BPM/timingpoint
            TimePreempt = 750;
        }

    }
}
