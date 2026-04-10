using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class PlatinumRule 
    : IDiscountRule 
{
    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) 
    {
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (customer.Segment == "Platinum") 
        {
            discountAmount = baseAmount * 0.15m;
            note = "platinum discount; ";
            
        }
        return new DiscountResult(discountAmount, note);

    }


}
