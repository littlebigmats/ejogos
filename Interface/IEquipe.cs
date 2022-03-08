using WebApplication6.Models;
using System.Collections.Generic;
namespace WebApplication6.Interface
{
    public interface IEquipe
    {
        //CONTRATO.
        //Representa os métodos que são obrigatorios em uma classe.

        void Criar(Equipe novaequipe);
        List<Equipe> LerEquipes();
    }
}
