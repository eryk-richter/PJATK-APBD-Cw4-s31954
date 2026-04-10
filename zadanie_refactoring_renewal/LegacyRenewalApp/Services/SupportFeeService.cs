using LegacyRenewalApp.Models;

namespace LegacyRenewalApp.Services;

public class SupportFeeService : ISupportFeeService
{
    public FeeResult Calculate(bool includePremiumSupport, string planCode)
    {
        if (!includePremiumSupport)
            return new FeeResult(0m, string.Empty);

        decimal supportFee = planCode switch
        {
            "START" => 250m,
            "PRO" => 400m,
            "ENTERPRISE" => 700m,
            _ => 0m
        };

        string notes = "premium support included; ";

        return new FeeResult(supportFee, notes);
    }
}
