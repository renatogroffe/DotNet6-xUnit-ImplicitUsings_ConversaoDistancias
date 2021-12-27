namespace Groffe.Distancias.Testes;

public class TestesMilhasParaKm
{
    [Theory]
    [InlineData(1, 1.609)]
    [InlineData(10.579, 17.022)]
    [InlineData(500, 804.5)]
    [InlineData(750.5, 1207.554)]
    [InlineData(1300, 2091.7)]
    [InlineData(2000.123, 3218.198)]
    public void ValidarConversaoMilhasParaKm(
        double milhas, double resultadoKm)
    {
        Assert.Equal(resultadoKm,
            ConversorDistancias.MilhasParaKm(milhas));
    }
}