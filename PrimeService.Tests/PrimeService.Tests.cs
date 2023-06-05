namespace Prime.Services.Tests;

public class PrimeServiceUnitTests
{
    private readonly PrimeService _primeService;

    public PrimeServiceUnitTests()
    {
        // prepare for IsPrimeTest
        _primeService = new PrimeService();
    }

    [Theory]
    [InlineData(-1)]
    [InlineData(0)]
    [InlineData(1)]
    public void IsPrimeTest(int value)
    {
        var result = _primeService.IsPrime(value);
        Assert.False(result, $"{value} should not be prime");
    }
}