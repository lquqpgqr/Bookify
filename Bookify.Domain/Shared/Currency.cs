namespace Bookify.Domain.Shared;

public record Currency
{
    internal static readonly Currency None = new("");
    public static readonly Currency Usd = new("USD");
    public static readonly Currency Bdt = new("BDT");

    private Currency(string code) => Code = code;

    public string Code { get; set; }

    public static Currency FromCode(string code)
    {
        return All.FirstOrDefault(x => x.Code == code) ??
            throw new ApplicationException("Currency not supported by the system");
    }

    public static readonly IReadOnlyCollection<Currency> All = new[] { Usd, Bdt };
}
