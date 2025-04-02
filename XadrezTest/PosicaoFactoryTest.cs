using Xadrez.Posicoes;

namespace XadrezTest;

public class PosicaoFactoryTest
{
    [Fact]
    public void Get_DeveRetornarPosicao()
    {
        var colunaInicial = 'a';
        var linhaInicial = '1';
        var colunaFinal = 'h';
        var linhaFinal = '8';
        Posicao posicao;

        for (char coluna = colunaInicial; coluna <= colunaFinal; ++coluna)
        {
            for (char linha = linhaInicial; linha <= linhaFinal; ++linha)
            {
                posicao = PosicaoFactory.Get(coluna.ToString() + linha.ToString())!;
                Assert.NotNull(posicao);
                Assert.Equal(coluna, posicao.Coluna);
                Assert.Equal(linha, posicao.Linha);
            }
        }
    }
}
