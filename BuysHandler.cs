﻿using System.ComponentModel;
using TSLab.Script.Handlers.Options;

namespace TSLab.Script.Handlers
{
    [HandlerCategory(HandlerCategories.VolumeAnalysis)]
    [HelperName("Buys", Language = Constants.En)]
    [HelperName("Покупки", Language = Constants.Ru)]
    [InputsCount(1)]
    [Input(0, TemplateTypes.SECURITY, Name = Constants.SecuritySource)]
    [OutputsCount(1)]
    [OutputType(TemplateTypes.DOUBLE)]
    [Description("Показывает характеристики (количество или суммарный объем) сделок на покупку")]
    [HelperDescription("A handler calculates statistics (amount or total volume) of a long trades", Constants.En)]
    public sealed class BuysHandler : BuysSellsHandler
    {
        protected override double GetValue(ICachedTradeHistogram histogram)
        {
            return histogram.AskQuantity;
        }

        protected override int GetCount(ICachedTradeHistogram histogram)
        {
            return histogram.AskTradesCount;
        }
    }
}
