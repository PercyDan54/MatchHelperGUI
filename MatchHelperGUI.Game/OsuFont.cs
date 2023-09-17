// Copyright (c) ppy Pty Ltd <contact@ppy.sh>. Licensed under the MIT Licence.
// See the LICENCE file in the repository root for full licence text.

#nullable disable

using osu.Framework.Graphics.Sprites;

namespace MatchHelperGUI.Game
{
    public static class OsuFont
    {
        /// <summary>
        /// The default font size.
        /// </summary>
        public const float DEFAULT_FONT_SIZE = 20;

        /// <summary>
        /// The default font.
        /// </summary>
        public static FontUsage Default => GetFont();

        /// <summary>
        /// Retrieves a <see cref="FontUsage"/>.
        /// </summary>
        /// <param name="typeface">The font typeface.</param>
        /// <param name="size">The size of the text in local space. For a value of 16, a single line will have a height of 16px.</param>
        /// <param name="weight">The font weight.</param>
        /// <param name="italics">Whether the font is italic.</param>
        /// <param name="fixedWidth">Whether all characters should be spaced the same distance apart.</param>
        /// <returns>The <see cref="FontUsage"/>.</returns>
        public static FontUsage GetFont(float size = DEFAULT_FONT_SIZE, string weight = "Regular", bool italics = false, bool fixedWidth = false)
        {
            return new FontUsage("Harmony", size, weight, false, fixedWidth);
        }
    }

    public enum FontWeight
    {
        /// <summary>
        /// Equivalent to weight 300.
        /// </summary>
        Light = 300,

        /// <summary>
        /// Equivalent to weight 400.
        /// </summary>
        Regular = 400,

        /// <summary>
        /// Equivalent to weight 500.
        /// </summary>
        Medium = 500,

        /// <summary>
        /// Equivalent to weight 600.
        /// </summary>
        SemiBold = 600,

        /// <summary>
        /// Equivalent to weight 700.
        /// </summary>
        Bold = 700,

        /// <summary>
        /// Equivalent to weight 900.
        /// </summary>
        Black = 900
    }
}
