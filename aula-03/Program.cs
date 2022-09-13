using System;

namespace InferenciaTipos
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                Na declaração convencional, o programa reserva
                um espaço na memória de acordo com o tipo, por isso,
                precisamo do tipo antes da variável.
            */
            int idade;

            /*
                No caso da inferência de tipo, é possível fazer o
                processo sem a necessidade de declarar o tipo, porém,
                preciso já atribuir uma valor para a variável para
                a inferência funcionar.
            */
            var idade = 10;

            /*
                Observação... a inferêcia não funciona para null,
                porque null pode ser utilizado para diferentes tipos.
                Logo, para fins de inferência, null não é um valor aceito.

                Fácil dedução também é um importante para saber se
                devemos usar inferência ou não.
            */

        }
    }
}