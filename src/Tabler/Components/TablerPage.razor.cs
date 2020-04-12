﻿namespace Tabler.Components
{
    public partial class TablerPage : TablerBaseComponent
    {
        protected override string ClassNames => ClassBuilder
            .Add("page")
            .Add(BackgroundColor.GetColorClass("bg"))
            .Add(TextColor.GetColorClass("text"))
            .ToString();
    }
}