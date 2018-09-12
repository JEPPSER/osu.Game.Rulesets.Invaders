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

        public void SetAngle(float angle)
        {
            float x = -ROTATION_RADIUS * (float) Math.Cos(angle);
            float y = -ROTATION_RADIUS * (float) Math.Sin(angle);
            Position = new Vector2(x, y);
        }
    }
}
