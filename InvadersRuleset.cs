using System.Collections.Generic;
using osu.Framework.Graphics;
using osu.Framework.Input.Bindings;
using osu.Game.Beatmaps;
using osu.Game.Graphics;
using osu.Game.Rulesets.Difficulty;
using osu.Game.Rulesets.Invaders.Beatmaps;
using osu.Game.Rulesets.Invaders.Difficulty;
using osu.Game.Rulesets.Invaders.UI;
using osu.Game.Rulesets.Mods;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Invaders
{
    public class InvadersRuleset : Ruleset
    {
        public override string Description => "osu!defender";
        public override string ShortName => "defender";

        public InvadersRuleset(RulesetInfo rulesetInfo = null) : base(rulesetInfo)
        {

        }

        public override IEnumerable<KeyBinding> GetDefaultKeyBindings(int variant = 0) => new[]
        {
            new KeyBinding(InputKey.A, InvadersAction.Left),
            new KeyBinding(InputKey.S, InvadersAction.Down),
            new KeyBinding(InputKey.W, InvadersAction.Up),
            new KeyBinding(InputKey.D, InvadersAction.Right)
        };

        public override IEnumerable<Mod> GetModsFor(ModType type) => new Mod[0];

        public override RulesetContainer CreateRulesetContainerWith(WorkingBeatmap beatmap) => new InvadersRulesetContainer(this, beatmap);

        public override IBeatmapConverter CreateBeatmapConverter(IBeatmap beatmap) => new InvadersBeatmapConverter(beatmap);

        public override DifficultyCalculator CreateDifficultyCalculator(WorkingBeatmap beatmap) => new InvadersDifficultyCalculator(this, beatmap);

        public override Drawable CreateIcon() => new SpriteIcon { Icon = FontAwesome.fa_dot_circle_o };
    }
}
