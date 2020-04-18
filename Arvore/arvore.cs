using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arvore
{
    class arvore
    {
        public no raiz = null;

        public bool vazia() //verifica se a árvore está vazia
        {
            return (raiz == null);
        }
        public bool existe(int num, no n) //verifica se um elemento existe na árvore
        {
            if (n == null)
            {
                return (false);
            }                
            else if (n.numero == num)
            {
                return (true);
            }                
            else if (n.numero > num)
            {
                return (existe(num, n.direita));
            }
            else
            {
                return (existe(num, n.esquerda));
            }                
        }
        public void inserir(int num) //insere um elemento na árvore
        {
            no novo;
            no pai = null;
            no aux = raiz;

            if (existe(num, aux) == true) //verifica se o elemento já existe na árvore
            {
                Console.WriteLine("O elemento já existe");
            }                
            else
            {
                while (aux != null)
                {
                    pai = aux;
                    if (num > aux.numero)
                    {
                        aux = aux.direita;
                    }                        
                    else
                    {
                        aux = aux.esquerda;
                    }                        
                }

                novo = new no();
                novo.numero = num;
                novo.esquerda = null;
                novo.direita = null;
                novo.pai = pai;

                if (raiz == null) //primeiro nó
                {
                    raiz = novo;
                }                    
                else if (num > pai.numero)
                {
                    pai.direita = novo;
                }
                else
                {
                    pai.esquerda = novo;
                }                

                //Console.WriteLine("Elemento inserido");
            }
        }
        public void remover(int num) //remover um elemento da árvore
        {
            no aux = raiz; //nó a ser removido
            no pai = null; //pai do nó a ser removido
            no sub; //substituto do nó a ser removido
            no paiSub; //pai do substituto do nó a ser removido

            while (aux.numero != num) //faz a busca pelo nó a ser removido
            {
                pai = aux;
                if (num > aux.numero)
                {
                    aux = aux.direita;
                }                    
                else
                {
                    aux = aux.esquerda;
                }                    
            }

            if (aux.esquerda == aux.direita) //nó que não tem filho (tipo folha)
            {
                if (aux == raiz) //só tem um elemento
                {
                    raiz = null;
                }                    
                else if (num > pai.numero) //remove filho da direita 
                {
                    pai.direita = null;
                }
                else
                {
                    pai.esquerda = null; //remove filho da esquerda
                }                     
            }

            else if (aux.direita == null) //só tem filho a esquerda
            {
                if (aux == raiz) //só tem um filho
                {
                    raiz = aux.esquerda;
                }                    
                else if (num > pai.numero) //o nó a ser removido possui um filho maior
                {
                    pai.direita = aux.esquerda;
                }                    
                else //o nó a ser removido possui um filho menor
                {
                    pai.esquerda = aux.esquerda;
                }                    
            }

            else if (aux.esquerda == null) //só tem filho a direita
            {
                if (aux == raiz) //só tem um filho
                {
                    raiz = aux.direita;
                }                    
                else if (num > pai.numero)
                {
                    pai.direita = aux.direita; //o nó a ser removido possui um filho maior
                }                    
                else //o nó a ser removido possui um filho menor
                {
                    pai.esquerda = aux.direita;
                }                 
            }

            else //nó substituto tem os dois filhos
            {
                sub = aux.direita;
                paiSub = aux;

                while (sub.esquerda != null) //busca o nó substituto
                {
                    paiSub = aux;
                    sub = sub.esquerda;
                }

                if (aux == raiz) //nó removido é a raíz
                {
                    if (aux == paiSub)//nó substituto é o filho
                    {
                        sub.esquerda = aux.esquerda;
                        raiz = sub;
                    }
                    else //nó substituto está em nível inferior
                    {
                        paiSub.esquerda = sub.direita;
                        sub.esquerda = aux.esquerda;
                        sub.direita = aux.direita;
                        raiz = sub;
                    }
                }
                else //nó removido não é a raiz
                {
                    if (aux == paiSub) //nó substituto é o filho
                    {
                        sub.esquerda = aux.esquerda;
                        if (sub.numero > pai.numero)
                        {
                            pai.direita = sub;
                        }                            
                        else
                        {
                            pai.esquerda = sub;
                        }                            
                    }
                    else //nó substituto está em nível inferior
                    {
                        paiSub.esquerda = sub.direita;
                        sub.esquerda = aux.esquerda;
                        sub.direita = aux.direita;

                        if (sub.numero > pai.numero)
                        {
                            pai.direita = sub;
                        }                            
                        else
                        {
                            pai.esquerda = sub;
                        }                            
                    }
                }
            }
            Console.WriteLine("Elemento removido");
        }
        public void exibirEmOrdem(no n) //exibe em ordem
        {
            if (n != null)
            {
                exibirEmOrdem(n.esquerda);
                Console.WriteLine(n.numero);
                exibirEmOrdem(n.direita);
            }
        }
        public void exibirPreOrdem(no n) //exibe em pré ordem
        {
            if (n != null)
            {
                Console.WriteLine(n.numero);
                exibirPreOrdem(n.esquerda);
                exibirPreOrdem(n.direita);
            }
        }
        public void exibirPosOrdem(no n) //exibe em pós ordem
        {
            if (n != null)
            {
                exibirPosOrdem(n.esquerda);
                exibirPosOrdem(n.direita);
                Console.WriteLine(n.numero);
            }
        }
        public void esvaziar(no n) //esvazia a árvore
        {
            raiz = null;
        }
        public int contagemElementos(no n) //contar elementos da árvore
        {
            if (n == null)
                return (0);
            else
                return (1 + contagemElementos(n.direita) + contagemElementos(n.esquerda));
        }
        public int contagemFolhas(no n) //conta quantos nós do tipo folha possuem na árvore
        {
            if (n == null)
            {
                return (0);
            }                
            else if ((n.direita) == (n.esquerda))
            {
                return (1);
            }                
            else
            {
                return (contagemFolhas(n.direita) + contagemFolhas(n.esquerda));
            }                
        }
        public int altura(no n) //calcula a altura da árvore
        {
            if (n == null)
                return (0);
            else
            {
                if (altura(n.esquerda) > altura(n.direita))
                    return (altura(n.esquerda) + 1);
                else
                    return (altura(n.direita) + 1);
            }
        }
        public int somaElementos(no n) //soma os elementos da árvore
        {
            if (n == null)
            {
                return (0);
            }                
            else
            {
                return (n.numero + somaElementos(n.esquerda) + somaElementos(n.direita));
            }                
        }
        public int nivel(int num, no n) //calcula em que nível um elemento está
        {
            if (num == n.numero)
            {
                return (1);
            }                
            else if (num > n.numero)
            {
                return (1 + nivel(num, n.direita));
            }
            else
            {
                return (1 + nivel(num, n.esquerda));
            }                
        }
        public int quantosMaiores(int num, no n) //conta quantos nós são maiores que um número informado
        {
            if (n == null)
            {
                return (0);
            }                
            else if (num < n.numero)
            {
                return (1 + quantosMaiores(num, n.esquerda) + quantosMaiores(num, n.direita));
            }             
            else
            {
                return (quantosMaiores(num, n.esquerda) + quantosMaiores(num, n.direita));
            }                
        }
        public int maiorElemento(no n) //determina o maior elemento da árvore
        {
            if (n == null) //retorna a raíz se não tiver filho a direita
            {
                return (raiz.numero);
            }                
            else
            {
                if (n == raiz)
                {
                    return (maiorElemento(n.direita));
                }                    
                else
                {
                    if ((n.direita != null) && (n.numero > raiz.numero))
                    {
                        return (maiorElemento(n.direita));
                    }                        
                    else
                    {
                        return (n.numero);
                    }                        
                }
            }
        }
        public int menorElemento(no n) //determina o menor elemento da árvore
        {
            if (n == null) //retorna a raíz se não tiver filho a esquerda
            {
                return (raiz.numero);
            }                
            else
            {
                if (n == raiz)
                {
                    return (menorElemento(n.esquerda));
                }                    
                else
                {
                    if ((n.esquerda != null) && (n.numero > raiz.numero))
                    {
                        return (menorElemento(n.esquerda));
                    }                        
                    else
                    {
                        return (n.numero);
                    }                        
                }
            }
        }
        public void multiplicaElementos(int num, no n) //multipla os nós da árvore por um valor informado
        {
            if (n != null)
            {
                n.numero = n.numero * num;
                multiplicaElementos(num, n.esquerda);
                multiplicaElementos(num, n.direita);
            }
        }
        public void percursoAncestrais(int num) //mostra o percurso de um elemento até a raiz
        {
            no aux = raiz;

            while ((aux != null) && (aux.numero != num))
            {
                if (num > aux.numero)
                {
                    aux = aux.direita;
                }                    
                else
                {
                    aux = aux.esquerda;
                }                    
            }
            if (aux == null) //o elemento não existe na árvore
            {
                Console.WriteLine("Elemento não encontrado");
            }                
            else if (num == raiz.numero) //o elemento é a própria raiz
            {
                Console.WriteLine("Não tem ancestral, o número informado é a própria raiz");
            }                
            else
            {
                while (aux.pai != null)
                {
                    Console.WriteLine("Ancestral vale {0}", aux.pai.numero);
                    aux = aux.pai;
                }
            }
        }
    }
}
