//App Name: Magic Squares Generator - C#
//App Description: Odd Numbers Magic Squares Generator - Console Application 
//Developper: Larry Georges Muala

using System;

namespace Magic_Square
{
    public class MagicSquare
    {
        private static void Main()
        {
            Console.WriteLine("\nMagic Squares Generator \n");
		
            Console.Write("Please enter the size of your magic squares: ");
            
            int size = Convert.ToInt32(Console.ReadLine());
                    
            int [,] magic_list = new int[size, size];
                
            Console.WriteLine("\n");
            
            //loops to assign magic square values to each entry in magic_list
            //using formula:
            // for Ith row and Jth column
            // value = { n*[(I + J - 1 + (n//2)) % n)] } + { [(I + 2*J - 2) % n] + 1 }, n = size

            for (int row_s = 0; row_s < size; row_s++){
                
                for (int column_s = 0; column_s < size; column_s++){
                
                    int row_value = row_s + 1;
                    int column_value = column_s + 1;

                    int value = ( size * ((row_value + column_value - 1 + (size/2)) % size) ) + ( ((row_value + 2 * column_value - 2) % size) + 1 );
                    
                    magic_list[row_s, column_s] = value;
                }
            }
            
            Console.WriteLine("\nTop Middle Alignment \n");
            
            for (int row_s = 0; row_s < size; row_s++){
                
                for (int column_s = 0; column_s < size; column_s++){
                    
                    if (magic_list[row_s, column_s] < 10){Console.Write(" ");} 
                    if (magic_list[row_s, column_s] < 100){Console.Write(" ");}
                    
                    Console.Write(Convert.ToString(magic_list[row_s, column_s]).PadRight((1), ' ') + "     "); 
                }
                Console.WriteLine("\n"); 
            }
            
            Console.WriteLine("\nBottom Middle Alignment \n");
            
            for (int row_s = size - 1; row_s >= 0; row_s--){
                
                for (int column_s = size - 1; column_s >= 0; column_s--){
                    
                    if (magic_list[row_s, column_s] < 10){Console.Write(" ");} 
                    if (magic_list[row_s, column_s] < 100){Console.Write(" ");}
                    
                    Console.Write(Convert.ToString(magic_list[row_s, column_s]).PadRight((1), ' ') + "     "); 
                }
                Console.WriteLine("\n"); 
            }
            
            Console.WriteLine("\nLeft Middle Alignment \n");
            
            for (int row_s = 0; row_s < size; row_s++){
                
                for (int column_s = 0; column_s < size; column_s++){
                    
                    if (magic_list[column_s, row_s] < 10){Console.Write(" ");} 
                    if (magic_list[column_s, row_s] < 100){Console.Write(" ");}
                    
                    Console.Write(Convert.ToString(magic_list[column_s, row_s]).PadRight((1), ' ') + "     "); 
                }
                Console.WriteLine("\n"); 
            }
            
            Console.WriteLine("\nRight Middle Alignment \n");
            
            for (int row_s = size - 1; row_s >= 0; row_s--){
                
                for (int column_s = size - 1; column_s >= 0; column_s--){
                    
                    if (magic_list[column_s, row_s] < 10){Console.Write(" ");} 
                    if (magic_list[column_s, row_s] < 100){Console.Write(" ");}
                    
                    Console.Write(Convert.ToString(magic_list[column_s, row_s]).PadRight((1), ' ') + "     "); 
                }
                Console.WriteLine("\n"); 
            }
            
            Console.ReadKey();
        }
    }
}