﻿using Microsoft.AspNetCore.Components.Rendering;

namespace Tabler.Components
{
    public class TablerCardBody : TablerBaseComponent
    {
        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            base.BuildRenderTree(builder);

            var seq = 0;
            var cardClassBuilder = new ClassBuilder(Class)
                .Add("card-body")
                .Add(TextColor.GetColorClass("text"))
                .Add(BackgroundColor.GetColorClass("bg"));

            builder.OpenElement(seq++, ElementType);
            builder.AddAttribute(seq++, "class", cardClassBuilder.ToString());
            builder.AddContent(seq++, ChildContent);
            builder.CloseElement();
        }
    }
}