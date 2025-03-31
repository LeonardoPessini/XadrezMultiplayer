
namespace Xadrez.Models.Pecas;

public class Peao : PecaBase
{
    public Peao(Cor cor) : base(TipoPeca.Peao, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveis => throw new NotImplementedException();
}
