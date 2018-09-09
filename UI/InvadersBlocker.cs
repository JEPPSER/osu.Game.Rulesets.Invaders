using OpenTK;
using osu.Framework.Allocation;
using osu.Framework.Graphics;
using osu.Framework.Graphics.Containers;
using osu.Framework.Graphics.Shapes;
using osu.Framework.Graphics.Sprites;
using osu.Framework.Graphics.Textures;
using osu.Framework.Input.EventArgs;
using osu.Framework.Input.States;
using System;
using System.Collections;

namespace osu.Game.Rulesets.Invaders.UI
{
    class InvadersBlocker : Container
    {
        private const float BLOCKER_SIZE = 20;
        private const float ROTATION_RADIUS = 50;

        [BackgroundDependencyLoader]
        private void load()
        {
            Anchor = Anchor.Centre;
            Origin = Anchor.Centre;
            Size = new Vector2(1f);
            Child = new Circle
            {
                Width = BLOCKER_SIZE,
                Height = BLOCKER_SIZE,
                X = -BLOCKER_SIZE / 2,
                Y = -BLOCKER_SIZE / 2,
                RelativeSizeAxes = Axes.Both,
            };
        }

        public bool OnPressed(ArrayList inputs)
        {
            Position = OriginPosition;
            for(int i = 0; i < inputs.Count; i++)
            {
                if ((InvadersAction)inputs[i] == InvadersAction.Right)
                {
                    X = ROTATION_RADIUS;
                }
                if ((InvadersAction)inputs[i] == InvadersAction.Down)
                {
                    Y = ROTATION_RADIUS;
                }
                if((InvadersAction)inputs[i] == InvadersAction.Up)
                {
                    Y = -ROTATION_RADIUS;
                }
                if((InvadersAction)inputs[i] == InvadersAction.Left)
                {
                    X = -ROTATION_RADIUS;
                }
            }
            return false;
        }
    }
}
