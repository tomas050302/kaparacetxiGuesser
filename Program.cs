using System;

namespace Kapa {
    static class Program {
        static void Main() {
            const string frase = "Por favor, senhor kaparacetxi diz-me qualquer coisa";

            Console.Write("Pergunta: ");
            Console.ReadLine();
            Console.Write("Pede com jeitinho: ");
            ConsoleKeyInfo key;
            int i = 0;
            bool val = false;

            do {
                key = Console.ReadKey();
                i++; //contador da frase
                if(key.Key == ConsoleKey.Enter) {
                    val = true;
                    break;
                } else if(key.Key == ConsoleKey.Backspace) {
                    i--;
                    Console.Write(" \b");
                }
            } while(key.Key != ConsoleKey.Home && i < frase.Length);
            if(!val) {
                string res = null;
                if(i == frase.Length) {
                    Console.WriteLine("\nCom esse jeitinho não vais a lado nenhum...");
                    Console.ReadKey();
                } else {
                    int j = 0; //contador da resposta
                    i--;
                    Console.Write("\b");
                    do {
                        key = Console.ReadKey(true);
                        j++;
                        if(key.Key == ConsoleKey.Backspace && j > 0) {
                            Console.Write(" \b");
                            j--;
                            res.Remove(j);
                            i--;
                        } else {
                            Console.Write(frase[i]);
                            i++;
                            res += key.KeyChar;
                        }
                    } while(key.Key != ConsoleKey.End);
                    for(int k = i; k < frase.Length; k++) {
                        Console.ReadKey(true);
                        Console.Write(frase[k]);
                    }
                    Console.WriteLine("\nEstá preparado?");
                    Console.ReadKey();
                    Console.WriteLine("\nReposta: {0}", res);
                    Console.ReadKey();
                }
            } else {
                Console.WriteLine("\nCom esse jeitinho não vais a lado nenhum...");
                Console.ReadKey();
            }
        }
    }
}