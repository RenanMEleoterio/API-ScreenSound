namespace SoundScreen.Models;

//Interface para objetos que são avaliáveis
internal interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    double Media {  get; }
}
