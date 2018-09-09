using System;
using System.Collections.Generic;
using System.ComponentModel;
using osu.Framework.Input.Bindings;
using osu.Framework.Input.EventArgs;
using osu.Framework.Input.StateChanges;
using osu.Framework.Input.States;
using osu.Game.Rulesets.UI;

namespace osu.Game.Rulesets.Invaders
{
    public class InvadersInputManager : RulesetInputManager<InvadersAction>
    {
        public IEnumerable<InvadersAction> PressedActions => KeyBindingContainer.PressedActions;

        public bool AllowUserPresses
        {
            set => ((InvadersKeyBindingContainer)KeyBindingContainer).AllowUserPresses = value;
        }

        protected override RulesetKeyBindingContainer CreateKeyBindingContainer(RulesetInfo ruleset, int variant, SimultaneousBindingMode unique)
            => new InvadersKeyBindingContainer(ruleset, variant, unique);

        public InvadersInputManager(RulesetInfo ruleset)
            : base(ruleset, 0, SimultaneousBindingMode.Unique)
        {
        }

        private class InvadersKeyBindingContainer : RulesetKeyBindingContainer
        {
            public bool AllowUserPresses = true;

            public InvadersKeyBindingContainer(RulesetInfo ruleset, int variant, SimultaneousBindingMode unique)
                : base(ruleset, variant, unique)
            {
            }

            protected override bool OnKeyDown(InputState state, KeyDownEventArgs args) => AllowUserPresses && base.OnKeyDown(state, args);
            protected override bool OnKeyUp(InputState state, KeyUpEventArgs args) => AllowUserPresses && base.OnKeyUp(state, args);
            protected override bool OnJoystickPress(InputState state, JoystickEventArgs args) => AllowUserPresses && base.OnJoystickPress(state, args);
            protected override bool OnJoystickRelease(InputState state, JoystickEventArgs args) => AllowUserPresses && base.OnJoystickRelease(state, args);
            protected override bool OnMouseDown(InputState state, MouseDownEventArgs args) => AllowUserPresses && base.OnMouseDown(state, args);
            protected override bool OnMouseUp(InputState state, MouseUpEventArgs args) => AllowUserPresses && base.OnMouseUp(state, args);
            protected override bool OnScroll(InputState state) => AllowUserPresses && base.OnScroll(state);
        }
    }

    public enum InvadersAction
    {
        [Description("Left Button")]
        Left,

        [Description("Up Button")]
        Up,

        [Description("Right Button")]
        Right,

        [Description("Down Button")]
        Down
    }
}
