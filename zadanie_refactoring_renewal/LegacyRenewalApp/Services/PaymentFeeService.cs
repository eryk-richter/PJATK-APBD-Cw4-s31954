using System;
using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public class PaymentFeeService 
    : IPaymentFeeService 
{
    public FeeResult Calculate(string paymentMethod, decimal subtotal, decimal supportFee)
    {
        return paymentMethod switch
        {
            "CARD" => new FeeResult((subtotal + supportFee) * 0.02m, "card payment fee; "),
            "BANK_TRANSFER" => new FeeResult((subtotal + supportFee) * 0.01m, "bank transfer fee; "),
            "PAYPAL" => new FeeResult((subtotal + supportFee) * 0.035m, "paypal fee; "),
            "INVOICE" => new FeeResult(0m, "invoice payment; "),
            _ => throw new ArgumentException("Unsupported payment method")
        };
    }
    
}