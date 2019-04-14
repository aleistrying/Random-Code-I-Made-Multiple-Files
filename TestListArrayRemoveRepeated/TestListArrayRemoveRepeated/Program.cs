using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TestListArrayRemoveRepeated
{
    class Program
    {
        static string[] testArrayList = { "hola", "hola", "hola", "hello", "hola", "hello" };
        static List<string> testList = new List<string>(testArrayList.ToList<string>());
        static private void QuitarDuplicados(List<string> List)
        {
            for(int i = List.Count() - 1; i >= 0; i--)
            {
                for (int count = List.Count() - 1; count >= 0; count--)
                {
                    if (List[i] == List[count] && count != i)
                    {
                        List.Remove(List[count]);
                        count = List.Count() - 1;
                        i = List.Count() - 1;
                    }
            }
            }
        }
        static void Main(string[] args)
        {
            
            string input = "";
            while (input != "stop @all")
            {
                string[] stuff ={    "Copias", "Copias", "Copias", "Copias", "Copias",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "Cartulina",
                "",
                "",
                "Agendas",
                "Agendas",
                "Agendas",
                "",
                "Botones",
                "",
                "Carnet PVC",
                "Carnet PVC",
                "Carnet PVC",
                "Carnet PVC",
                "",
                "Carpetas",
                "Carpetas",
                "Carpetas",
                "Carpetas",
                "Carpetas",
                "",
                "",
                "Ampliación - Reducción",
                "Ampliación - Reducción",
                "Ampliación - Reducción",
                "Ampliación - Reducción",
                "Ampliación - Reducción",
                "Ampliación - Reducción",
                "",
                "Encuadernado",
                "Encuadernado",
                "Encuadernado",
                "Encuadernado",
                "Encuadernado",
                "Encuadernado",
                "",
                "",
                "Papel Adhesivo",
                "Papel Adhesivo",
                "Papel Adhesivo",
                "Papel Adhesivo",
                "Papel Adhesivo",
                "Papel Adhesivo",
                "",
                "",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads sin copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
                "Pads con 1 copia",
               " Pads con 1 copia B/ N",
                "Pads con 1 copia B/ N",
                "Pads con 1 copia B/ N",
                "Pads con 1 copia B/ N",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads con 2 copias",
                "Pads 2 Copia Original Color - Copia B / N",
                "",
                "",
                "Pads 2 Copia Original Color - Copia B / N",
                "",
                "",
                "Pads 2 Copia Original Color - Copia B / N",
                "",
                "",
                "Pads 2 Copia Original Color - Copia B / N",
                "",
                "",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 copias",
                "Pads con 3 Copias Original Color - Copia B / N",
                "Pads con 3 Copias Original Color - Copia B / N",
                "Pads con 3 Copias Original Color - Copia B / N",
                "Pads con 3 Copias Original Color - Copia B / N",
                "",
                "Tipo",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "Gran Formato",
                "",
                "",
                "Plastificado",
                "Plastificado",
                "Plastificado",
                "Plastificado",
                "Plastificado"
                };
                List<string> data = new List<string>();
                //while (true)
                //{
                //    input = Console.ReadLine();
                //    if (input != "stop")
                //    {
                //        data.Add(input);
                //    }
                //    else if(input == "stop")
                //    {
                //        input = "";
                //        break;
                //    }
                //}
                //string[] arrayData = data.ToArray();

                data.InsertRange(0, stuff);
                QuitarDuplicados(data);


                foreach (string str in data)
                {
                    Console.WriteLine(str);
                }
                Console.WriteLine("");
                Console.ReadLine();
                Console.WriteLine("");
                

            }
        }
    }
}
