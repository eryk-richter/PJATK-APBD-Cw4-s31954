using LegacyRenewalApp.Models;
namespace LegacyRenewalApp.Services;

public interface ITaxService {
    public decimal Calculate(string country);
}