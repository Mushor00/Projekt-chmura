using Xunit;
using prezentacja;
using prezentacja.classes;
public class kalkulatorTest
{
    private readonly Calculator _calculator = new Calculator();

    [Fact]
    public void Add_ReturnsCorrectSum()
    {
        Assert.Equal(5, _calculator.Add(2, 3));
    }

    [Fact]
    public void Subtract_ReturnsCorrectDifference()
    {
        Assert.Equal(1, _calculator.Subtract(3, 2));
    }

    [Fact]
    public void Multiply_ReturnsCorrectProduct()
    {
        Assert.Equal(6, _calculator.Multiply(2, 3));
    }

    [Fact]
    public void Divide_ReturnsCorrectQuotient()
    {
        Assert.Equal(2, _calculator.Divide(6, 3));
    }

    [Fact]
    public async Task Divide_ThrowsDivideByZeroException()
    {
        await Assert.ThrowsAsync<DivideByZeroException>(async () => await Task.Run(() => _calculator.Divide(1, 0)));
    }
}