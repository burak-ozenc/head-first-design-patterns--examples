﻿using StarBuzz.Coffee;
using StarBuzz.Decorators;

namespace StarBuzz.Condiments;

public class Whip : CondimentDecorator
{
    readonly Beverage _beverage;

    public Whip(Beverage beverage)
    {
        _beverage = beverage;
    }

    public override string GetDescription() => _beverage.GetDescription() + ", Whip";

    public override double Cost() => 0.6 + _beverage.Cost();
}