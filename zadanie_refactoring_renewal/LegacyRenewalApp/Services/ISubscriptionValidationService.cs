namespace LegacyRenewalApp.Services;

public interface ISubscriptionValidationService {

    public void Validate(
        int customerId,
        string planCode,
        int seatCount,
        string paymentMethod);
    
    public void ValidateCustomerId(int customerId);
    
    public void ValidatePlanCode(string planCode);

    public void ValidateSeatCount(int seatCount);

    public void ValidatePaymentMethod(string paymentMethod);

}