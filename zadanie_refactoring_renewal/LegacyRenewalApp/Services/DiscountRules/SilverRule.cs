using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class SilverRule 
    : IDiscountRule
{
    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) 
    {
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (customer.Segment == "Silver") 
        {
                discountAmount = baseAmount * 0.05m;
                note = "silver discount; ";
            
        }
        return  new DiscountResult(discountAmount, note);

    }

}