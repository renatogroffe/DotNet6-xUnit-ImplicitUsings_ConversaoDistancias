namespace Groffe.Distancias.Testes;

public class TestesKmParaMilhas
{
    [Theory]
    [InlineData(1, 1.609)]
    [InlineData(62.15, 99.999)]
    [InlineData(1300, 2091.7)]
    [InlineData(124.786, 200.781)]
    [InlineData(3582.324, 5763.959)]
    [InlineData(4661.28, 7500)]
    public void ValidarConversaoKmParaMilhas(
        double Km, double resultadoMilhas)
    {
        Assert.Equal(resultadoMilhas,
            ConversorDistancias.KmParaMilhas(Km));
    }
}