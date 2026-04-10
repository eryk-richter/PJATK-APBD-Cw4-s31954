using System.Collections.Generic;
using LegacyRenewalApp.Models;
using LegacyRenewalApp.Services.DiscountRules;

namespace LegacyRenewalApp.Services;

public class DiscountService 
    :IDiscountService 
{
    public string Normalize(string value) 
    {
        return value.Trim().ToUpperInvariant();
    }

    public DiscountResult CalculateDiscount(Customer customer, SubscriptionPlan plan, int seatCount, bool useLoyaltyPoints) 
    {
    decimal baseAmount = (plan.MonthlyPricePerSeat * seatCount * 12m) + plan.SetupFee;

    List<IDiscountRule> rules = new List<IDiscountRule>
    {
        new SilverRule(),
        new GoldRule(),
        new PlatinumRule(),
        new EducationRule(),
        new LoyaltyRule(),
        new SeatCountRule(),
        new LoyaltyPointsRule()
    };
    
    string notes = string.Empty;
    decimal discountAmount = 0;

    foreach (var rule in rules) 
    {
        var res = rule.Calculate(customer, plan, seatCount, baseAmount, useLoyaltyPoints);
        discountAmount += res.discount;
        notes += res.notes;
    }
    
    return new DiscountResult(discountAmount, notes);
    }
}