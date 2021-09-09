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
                i++;
                System.Console.WriteLine(resposta);
                return(notas);
            }
            int meth2()
            {
                notas=notas+5;
                lista[i]=resposta;
                i++;
                System.Console.WriteLine(resposta);
                return(notas);
            }
            int meth3()
            {
                notas=notas+0;
                lista[i]=resposta1;
                i++;
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

                Console.WriteLine("Qual o nome da funçao que pode chamar ela mesma?");
                    lista[2] = Convert.ToString(Console.ReadLine());
                        if (lista[2]=="recursiva")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="recursiva"){
                                meth2();
                            } else meth3();
                        }

                System.Console.WriteLine("Qual o nome da estrutura de dados de variaveis de tipos diferentes?");
                    lista[3] =  Convert.ToString(Console.ReadLine());
                        if(lista[3]=="heterogenea")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="heterogenea")
                            {
                                meth2();
                            } else meth3();
                        }

                System.Console.WriteLine("Qual o nome da estrutura de dados de variaveis de tipos iguais?");                                    
                    lista[4] = Convert.ToString(Console.ReadLine());
                        if(lista[4]=="homogenea")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4(); 
                            if(lista[i]=="homogenea")  
                            {
                                meth2();
                            } else meth3();
                        } 

                System.Console.WriteLine("Qual o nome da incognita que não muda seu valor no algoritmo?");
                    lista[5] = Convert.ToString(Console.ReadLine());
                        if(lista[5]=="constante")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="constante")
                            {
                                meth2();
                            } else meth3();
                        }

                System.Console.WriteLine("Qual é o nome do tipo que é declarado instável?");
                    lista[6] = Convert.ToString(Console.ReadLine());
                        if(lista[6]=="variavel")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="variavel")
                            {
                                meth2();
                            } else meth3();
                        }

                System.Console.WriteLine("O que é uma lista de variavel unidimensional?");
                    lista[7] = Convert.ToString(Console.ReadLine());
                        if(lista[7]=="vetor")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="vetor")
                            {
                                meth2();
                            } else meth3();
                        }

                System.Console.WriteLine("Qual o nome da Sub-Rotina que não retorna valores");
                    lista[8] = Convert.ToString(Console.ReadLine());
                        if(lista[8]=="procedimentos")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="procedimentos")
                            {
                                meth2();
                            } else meth3();
                        }
                System.Console.WriteLine("Qual é o nome generico do Dado que é passado de um lugar ao outro?");
                    lista[9] = Convert.ToString(Console.ReadLine());
                        if(lista[9]=="parametro")
                        {
                            meth();
                        } 
                        else
                        {
                            meth4();
                            if(lista[i]=="parametro")
                            {
                                meth2();
                            } else meth3();
                        }
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("Notas total: {0}", notas);
                        Console.WriteLine("1- {0}", lista[0]);
                        Console.WriteLine("2- {0}", lista[1]);
                        Console.WriteLine("3- {0}", lista[2]);
                        Console.WriteLine("4- {0}", lista[3]);
                        Console.WriteLine("5- {0}", lista[4]);
                        Console.WriteLine("6- {0}", lista[5]);
                        Console.WriteLine("7- {0}", lista[6]);
                        Console.WriteLine("8- {0}", lista[7]);
                        Console.WriteLine("9- {0}", lista[8]);
                        Console.WriteLine("10- {0}", lista[9]);
        }
    }
}
