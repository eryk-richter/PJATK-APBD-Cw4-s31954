using System;
namespace LegacyRenewalApp.Services;

public class SubscriptionValidationService 
    : ISubscriptionValidationService 
{
    public void Validate(
        int customerId,
        string planCode,
        int seatCount,
        string paymentMethod
    ) 
    {
        ValidateCustomerId(customerId);
        ValidatePlanCode(planCode);
        ValidateSeatCount(seatCount);
        ValidatePaymentMethod(paymentMethod);
    }


    public void ValidateCustomerId(int customerId) 
    {
        if (customerId <= 0)
            throw new ArgumentException("Customer id must be positive");
    }

    public void ValidatePlanCode(string planCode) 
    {
        if (string.IsNullOrWhiteSpace(planCode))
            throw new ArgumentException("Plan code is required");
    }

    public void ValidateSeatCount(int seatCount) 
    {
        if (seatCount <= 0)
            throw new ArgumentException("Seat count must be positive");
    }

    public void ValidatePaymentMethod(string paymentMethod) 
    {
        if (string.IsNullOrWhiteSpace(paymentMethod))
            throw new ArgumentException("Payment method is required");
    }
        
    
    
}