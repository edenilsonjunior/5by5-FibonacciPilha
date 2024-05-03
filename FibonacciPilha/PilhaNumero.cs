using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciPilha
{
    internal class PilhaNumero
    {
        Numero? topo;
        int tamanho;

        public PilhaNumero()
        {
            topo = null;
            tamanho = 0;
        }

        public void Push(Numero aux)
        {
            if (IsEmpty())
            {
                topo = aux;
            }
            else
            {
                aux.SetAnterior(topo);
                topo = aux;
            }

            tamanho++;
        }

        public Numero? Pop()
        {
            Numero? removido = null;

            if (!IsEmpty())
            {
                removido = topo;
                topo = topo.GetAnterior();

                tamanho--;
            }
            removido.SetAnterior(null);
            return removido;
        }

        public int GetTamanho()
        {
            return tamanho;
        }

        public bool IsEmpty()
        {
            return topo == null;
        }

        public void Print()
        {

            if (IsEmpty())
            {
                Console.WriteLine("-->Pilha vazia!");
            }
            else
            {
                Numero aux = topo;

                while (aux != null)
                {
                    Console.WriteLine($"--> {aux}");
                    aux = aux.GetAnterior();
                }
            }
        }
    }
}
