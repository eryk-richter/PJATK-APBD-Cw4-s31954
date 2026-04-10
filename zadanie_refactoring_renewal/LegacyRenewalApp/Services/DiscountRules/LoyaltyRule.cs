using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class LoyaltyRule : IDiscountRule {

    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) {
        
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (customer.YearsWithCompany >= 5)
        {
            discountAmount += baseAmount * 0.07m;
            note += "long-term loyalty discount; ";
        }
        else if (customer.YearsWithCompany >= 2)
        {
            discountAmount += baseAmount * 0.03m;
            note += "basic loyalty discount; ";
        }
        
        return new DiscountResult(discountAmount, note);
    }
}