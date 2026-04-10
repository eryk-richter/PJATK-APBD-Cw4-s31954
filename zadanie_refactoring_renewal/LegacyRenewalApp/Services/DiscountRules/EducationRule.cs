using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class EducationRule 
    : IDiscountRule
{
    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) 
    {

        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (customer.Segment == "Education" && plan.IsEducationEligible)
        {
            discountAmount = baseAmount * 0.20m;
            note = "education discount; ";
        }
        
        return new DiscountResult(discountAmount, note);

    }
}