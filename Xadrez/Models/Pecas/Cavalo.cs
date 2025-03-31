
namespace Xadrez.Models.Pecas;

public class Cavalo : PecaBase
{
    public Cavalo(Cor cor) : base(TipoPeca.Cavalo, cor)
    {
    }

    public override IEnumerable<Posicao> MovimentosPossiveis => throw new NotImplementedException();
}
