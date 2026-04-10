using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public interface ISupportFeeService {
    public FeeResult Calculate(bool includePremiumSupport, string planCode);
}