using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class LoyaltyPointsRule 
    : IDiscountRule
{

    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount,  bool useLoyaltyPoints) {
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (useLoyaltyPoints && customer.LoyaltyPoints > 0)
        {
            int pointsToUse = customer.LoyaltyPoints > 200 ? 200 : customer.LoyaltyPoints;
            discountAmount = pointsToUse;
            note = $"loyalty points used: {pointsToUse}; ";
        }
        
        return new DiscountResult(discountAmount, note);
    }

}