using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public class SupportFeeService : ISupportFeeService {

    public FeeResult Calculate(bool includePremiumSupport, string planCode) {
        
        decimal supportFee = 0m;
        string notes = string.Empty;
        
        
        if (includePremiumSupport)
        {
            if (planCode == "START")
            {
                supportFee = 250m;
            }
            else if (planCode == "PRO")
            {
                supportFee = 400m;
            }
            else if (planCode == "ENTERPRISE")
            {
                supportFee = 700m;
            }

            notes += "premium support included; ";
        }
        
        return new FeeResult(supportFee, notes);
    }

}