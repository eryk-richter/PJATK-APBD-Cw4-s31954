using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services.DiscountRules;

public class SeatCountRule 
    : IDiscountRule
{
    public DiscountResult Calculate(Customer customer, SubscriptionPlan plan, int seatCount, decimal baseAmount, bool useLoyaltyPoints) {
        decimal discountAmount = 0;
        string note = string.Empty;
        
        if (seatCount >= 50) 
        { 
            discountAmount += baseAmount * 0.12m; 
            note += "large team discount; ";
        }
        else if (seatCount >= 20) 
        { 
            discountAmount += baseAmount * 0.08m; 
            note += "medium team discount; ";
        }
        else if (seatCount >= 10) 
        { 
            discountAmount += baseAmount * 0.04m; 
            note += "small team discount; ";
        }

        return new DiscountResult(discountAmount, note);
    }

}
