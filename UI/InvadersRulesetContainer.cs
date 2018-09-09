using osu.Framework.Input;
using osu.Game.Beatmaps;
using osu.Game.Rulesets.Invaders.Objects;
using osu.Game.Rulesets.Invaders.Scoring;
using osu.Game.Rulesets.Objects.Drawables;
using osu.Game.Rulesets.Scoring;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Invaders.UI
{
    internal class InvadersRulesetContainer : RulesetContainer<InvadersHitObject>
    {
        public InvadersRulesetContainer(Ruleset ruleset, WorkingBeatmap workingBeatmap) : base(ruleset, workingBeatmap)
        {

        }

        public override PassThroughInputManager CreateInputManager() => new InvadersInputManager(Ruleset.RulesetInfo);

        public override ScoreProcessor CreateScoreProcessor() => new InvadersScoreProcessor(this);

        protected override Playfield CreatePlayfield() => new InvadersPlayfield(Beatmap);

        protected override DrawableHitObject<InvadersHitObject> GetVisualRepresentation(InvadersHitObject obj)
        {
            return null;
        }
    }
}
