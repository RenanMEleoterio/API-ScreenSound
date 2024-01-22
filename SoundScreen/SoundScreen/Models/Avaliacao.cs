namespace SoundScreen.Models;
internal class Avaliacao
{
    //Construtor de avaliação que verifica o tamanho da nota
    public Avaliacao(int nota)
    {
        if (nota <= 0) nota = 0;
        else if (nota >= 10) nota = 10;

        Nota = nota;
    }

    public int Nota { get;}

    //Método Parse para que converte uma string para uma nota(inteira)
    public static Avaliacao Parse(string textoNota)
    {
        int nota = int.Parse(textoNota);
        return new Avaliacao(nota);
    }

}
