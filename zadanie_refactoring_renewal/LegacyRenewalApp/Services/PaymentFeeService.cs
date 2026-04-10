using System;
using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public class PaymentFeeService 
    : IPaymentFeeService 
{
    public FeeResult Calculate(string paymentMethod, decimal subtotal, decimal supportFee) {
        
        string notes = string.Empty;
        
        decimal paymentFee = 0m;
        
        if (paymentMethod == "CARD")
        {
            paymentFee = (subtotal + supportFee) * 0.02m;
            notes += "card payment fee; ";
        }
        else if (paymentMethod == "BANK_TRANSFER")
        {
            paymentFee = (subtotal + supportFee) * 0.01m;
            notes += "bank transfer fee; ";
        }
        else if (paymentMethod == "PAYPAL")
        {
            paymentFee = (subtotal + supportFee) * 0.035m;
            notes += "paypal fee; ";
        }
        else if (paymentMethod == "INVOICE")
        {
            paymentFee = 0m;
            notes += "invoice payment; ";
        }
        else
        {
            throw new ArgumentException("Unsupported payment method");
        }
        return new FeeResult(paymentFee, notes);
        
    }
    
}