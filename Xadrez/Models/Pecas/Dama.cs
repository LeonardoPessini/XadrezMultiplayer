

namespace Xadrez.Models.Pecas;

public class Dama : PecaBase
{
    public Dama(Cor cor) : base(TipoPeca.Dama, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicaoInicial)
    {
        throw new NotImplementedException();
    }
}
