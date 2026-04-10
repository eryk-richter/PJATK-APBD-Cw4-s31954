using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class GoldRule 
    : IDiscountRule
{
    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) 
    {
        
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (customer.Segment == "Gold") 
        {
            discountAmount = baseAmount * 0.10m;
            note = "gold discount; ";
                
        
        }
        return new DiscountResult(discountAmount, note);

    }


}