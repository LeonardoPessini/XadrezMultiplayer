


namespace Xadrez.Models.Pecas;

public class Rei : PecaBase
{
    private List<Posicao> _movimentos;
    private PosicaoHandler _handler;

    public Rei(Cor cor) :base(TipoPeca.Rei, cor)
    {
        if (cor == Cor.Branca)
            PosicaoAtual = PosicaoFactory.Get("e1")!;
        else
            PosicaoAtual = PosicaoFactory.Get("e8")!;
    }

    public override IEnumerable<Posicao> MovimentosPossiveisAPartirDe(Posicao posicao)
    {
        _movimentos = [];
        _handler = new PosicaoHandler(posicao);

        VerificarMovimentoAcima();
        VerificarMovimentoAbaixo();
        VerificarMovimentoDireita();
        VerificarMovimentoEsquerda();
        VerificarMovimentoDiagonalSuperiorDireita();
        VerificarMovimentoDiagonalSuperiorEsquerda();
        VerificarMovimentoDiagonalInferiorDireita();
        VerificarMovimentoDiagonalinferiorEsquerdo();

        return _movimentos;
    }

    private void SeForValidoSalve()
    {
        if (_handler.Posicao != null)
            _movimentos.Add(_handler.Posicao);
    }

    private void VerificarMovimentoAcima()
    {
        _handler.IncrementarLinha();
        SeForValidoSalve();
        _handler.DecrementarLinha();
    }

    private void VerificarMovimentoAbaixo()
    {
        _handler.DecrementarLinha();
        SeForValidoSalve();
        _handler.IncrementarLinha();
    }

    private void VerificarMovimentoDireita()
    {
        _handler.IncrementarColuna();
        SeForValidoSalve();
        _handler.DecrementarColuna();
    }

    private void VerificarMovimentoEsquerda()
    {
        _handler.DecrementarColuna();
        SeForValidoSalve();
        _handler.IncrementarColuna();
    }

    private void VerificarMovimentoDiagonalSuperiorDireita()
    {
        _handler.IncrementarColuna();
        _handler.IncrementarLinha();
        SeForValidoSalve();
        _handler.DecrementarColuna();
        _handler.DecrementarLinha();
    }

    private void VerificarMovimentoDiagonalSuperiorEsquerda()
    {
        _handler.DecrementarColuna();
        _handler.IncrementarLinha();
        SeForValidoSalve();
        _handler.IncrementarColuna();
        _handler.DecrementarLinha();
    }

    private void VerificarMovimentoDiagonalInferiorDireita()
    {
        _handler.IncrementarColuna();
        _handler.DecrementarLinha();
        SeForValidoSalve();
        _handler.DecrementarColuna();
        _handler.IncrementarLinha();
    }

    private void VerificarMovimentoDiagonalinferiorEsquerdo()
    {
        _handler.DecrementarColuna();
        _handler.DecrementarLinha();
        SeForValidoSalve();
        _handler.IncrementarColuna();
        _handler.IncrementarLinha();
    }

}
