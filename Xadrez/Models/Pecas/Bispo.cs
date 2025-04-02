

namespace Xadrez.Models.Pecas;

public class Bispo : PecaBase
{
    public Bispo(Cor cor) : base(TipoPeca.Bispo, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicaoInicial)
    {
        throw new NotImplementedException();
    }
}
