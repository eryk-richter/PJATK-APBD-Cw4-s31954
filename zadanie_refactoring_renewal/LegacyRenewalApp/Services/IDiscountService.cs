using LegacyRenewalApp.Models;

namespace LegacyRenewalApp.Services;

public interface IDiscountService {
    
    public string Normalize(string value);
    
    public DiscountResult CalculateDiscount(Customer customer, SubscriptionPlan subscriptionPlan, int seatCount, bool useLoyaltyPoints);
    
}