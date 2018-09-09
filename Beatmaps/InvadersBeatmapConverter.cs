using System;
using System.Collections.Generic;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Objects;
using osu.Game.Rulesets.Objects.Types;
using OpenTK;
using osu.Game.Rulesets.Invaders.Objects;

namespace osu.Game.Rulesets.Invaders.Beatmaps
{
    internal class InvadersBeatmapConverter : BeatmapConverter<InvadersHitObject>
    {
        protected override IEnumerable<Type> ValidConversionTypes => new[] {typeof(IHasXPosition)};

        public InvadersBeatmapConverter(IBeatmap beatmap) : base(beatmap) { }

        protected override IEnumerable<InvadersHitObject> ConvertHitObject(HitObject original, IBeatmap beatmap)
        {
            yield return new InvadersHitcircle(original.StartTime, 100f, 100f);
        }
    }
}
