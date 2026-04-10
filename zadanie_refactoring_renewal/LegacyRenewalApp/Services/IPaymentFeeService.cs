using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public interface IPaymentFeeService {
    
    public FeeResult Calculate(string paymentMethod, decimal subtotal, decimal supportFee);
}