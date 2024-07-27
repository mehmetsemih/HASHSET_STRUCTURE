using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHSET_STRUCTURE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HASHSET DESCRIBING
            var sesliharf=new HashSet<char>()
            {
                'a','b','c','d','e',
            };
             //ADDING
             sesliharf.Add( 'f' );

            //REMOVE
            sesliharf.Remove('a');
            koleksiyonyazdır(sesliharf);

            
                var alfabe = new List<char>();
            for (int i = 97; i < 123; i++)
            {
                alfabe.Add((char)i);
            }
            koleksiyonyazdır(alfabe);

            Console.ReadLine();
        }
        static void koleksiyonyazdır(IEnumerable koleksiyon)
        {
            Console.WriteLine();
            foreach (char i in koleksiyon)
            {
                Console.WriteLine($"{i,-5}");
            }
            Console.WriteLine();
            Console.WriteLine("koleksiyondaki eleman sayısı: {0}",koleksiyon.Count);

        }
    }
}
