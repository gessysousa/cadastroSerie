using System.Collections.Generic;

namespace DIO.Series.Interfaces
{
    public interface IRepositorio<T> //quem implementar essa interface vai ser obrigado a implementar. 
    {                                //Vai poder passar o T que é de tipo genérico.      
                                     //Independente do tipo de classe que você estiver implementando
                                     //esse repositorio. Essa classe implementa um repositório dessa outra classe T.
        List<T> Lista();             
        T RetornaPorId(int id);      
        void Insere(T entidade);
        void Exclui(int id);
        void Atualiza(int id, T entidade);
        int ProximoId();
    }                             
}