using LegacyRenewalApp.Models;

namespace LegacyRenewalApp.Services.DiscountRules;

public interface IDiscountRule {
    
    public DiscountResult Calculate(
        
        Customer customer, 
        SubscriptionPlan plan, 
        int seatCount, 
        decimal baseAmount, 
        bool useLoyaltyPoints
        
        );
}