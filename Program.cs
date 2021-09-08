using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Giovani
{
    class Program
    {
        static void Main(string[] args)
        {
            string resposta="correto";
            string resposta1="errado";
            Console.WriteLine("Quiz de teste");
            string [] lista = new string[10];
            int notas=0;
            int i=0;
            int meth()
            {
                notas=notas+10;
                lista[i]=resposta;
                System.Console.WriteLine(resposta);
                return(notas);
            }
            int meth2()
            {
                notas=notas+5;
                lista[i]=resposta;
                System.Console.WriteLine(resposta);
                return(notas);
            }
            int meth3()
            {
                notas=notas+0;
                lista[i]=resposta1;
                System.Console.WriteLine(resposta1);
                return(notas);
            }
            string meth4()
            {
                
                Console.WriteLine("Incorreto, tente novamente:");
                lista[i] = Convert.ToString(Console.ReadLine());
                return(lista[i]);
            }
                
            
                Console.WriteLine("Qual é o dispositivo padrão de entrada de dados?");
                    lista[0] = Convert.ToString(Console.ReadLine());
                        if (lista[0]=="teclado")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="teclado"){
                                meth2();
                            } else meth3();
                        }
                    Console.WriteLine(notas);

                Console.WriteLine("Qual é o dispositivo padrão de Saida de dados?");
                    lista[1] = Convert.ToString(Console.ReadLine());
                        if (lista[1]=="monitor")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="monitor"){
                                meth2();
                            } else meth3();
                        }
                        Console.WriteLine(lista[0]);
                        /*

                Console.WriteLine("Qual o nome da funçao que pode chamar ela mesma?");
                    lista[2] = Convert.ToString(Console.ReadLine());
                        if (lista[2]=="recursiva")
                        {
                            meth();
                        } else if(lista[2]=="recursiva") meth2();

                System.Console.WriteLine("Qual o nome da estrutura de dados de variaveis de tipos diferentes?");
                    lista[3] =  Convert.ToString(Console.ReadLine());
                        if(lista[3]=="heterogenea")
                        {
                            meth();
                        } else if(lista[3]=="heterogenea") meth2();

                System.Console.WriteLine("Qual o nome da estrutura de dados de variaveis de tipos iguais?");                                    
                    lista[4] = Convert.ToString(Console.ReadLine());
                        if(lista[4]=="homogenea")
                        {
                            meth();
                        } else if(lista[4]=="homogenea") meth2();

                System.Console.WriteLine("Qual o nome da incognita que não muda seu valor no algoritmo?");
                    lista[5] = Convert.ToString(Console.ReadLine());
                        if(lista[5]=="constante")
                        {
                            meth();
                        } else if (lista[5]=="constante") meth2();

                System.Console.WriteLine("Qual é o nome do tipo que é declarado instável?");
                    lista[6] = Convert.ToString(Console.ReadLine());
                        if(lista[6]=="variavel")
                        {
                            meth();
                        } else if (lista[6]=="variavel") meth2();

                System.Console.WriteLine("O que é uma lista de variavel unidimensional?");
                    lista[7] = Convert.ToString(Console.ReadLine());
                        if(lista[7]=="vetor")
                        {
                            meth();
                        } else if (lista[7]=="vetor") meth2();

                System.Console.WriteLine("Qual o nome da Sub-Rotina que não retorna valores");
                    lista[8] = Convert.ToString(Console.ReadLine());
                        if(lista[8]=="procedimentos")
                        {
                            meth();
                        } else if (lista[8]=="procedimentos") meth2();

                System.Console.WriteLine("Qual é o nome generico do Dado que é passado de um lugar ao outro?");
                    lista[9] = Convert.ToString(Console.ReadLine());
                        if(lista[9]=="parametro")
                        {
                            meth();
                        } else if (lista[9]=="parametro") meth2();

            */
                            
        }
    }
}
