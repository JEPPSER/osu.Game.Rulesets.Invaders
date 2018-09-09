using osu.Game.Beatmaps;
using osu.Game.Rulesets.Invaders.Objects;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Invaders.Scoring
{
    internal class InvadersScoreProcessor : ScoreProcessor<InvadersHitObject>
    {
        protected InvadersScoreProcessor() { }

        public InvadersScoreProcessor(RulesetContainer<InvadersHitObject> rulesetContainer) : base(rulesetContainer) { }

        protected override void SimulateAutoplay(Beatmap<InvadersHitObject> beatmap)
        {
            base.SimulateAutoplay(beatmap);
        }
    }
}
