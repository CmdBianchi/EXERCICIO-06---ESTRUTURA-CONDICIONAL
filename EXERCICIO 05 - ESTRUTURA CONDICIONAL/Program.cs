using System;
class Program{
    /// -------> START / MAIN 
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Main(string[] args){
        Msg();
        Conditional();
    }
    /// -------> FUNCTIONS
    /////////////////////////////////////////////////////////////////////////////////////////////
    static void Msg(){
        Console.WriteLine("Programa que leia o código de um item e a quantidade deste item");
    }
    //------------------------------------------------------------------------------------------//
    static void Conditional(){
        int order;
        double total, amount;

        Console.Write("DIGITE O NUMERO DA ORDEM: ");
        order = int.Parse(Console.ReadLine());
        Console.Write("DIGITE A QUANTIDADE: ");
        amount = double.Parse(Console.ReadLine());
       
        if (order == 1){
            total = 4 * amount;
            Console.WriteLine("VALOR TOTAL: " + total);
        }
        else if (order == 2){
            total = 4.5 * amount;
            Console.WriteLine("VALOR TOTAL: " + total);
        }
        else if (order == 3){
            total = 5 * amount;
            Console.WriteLine("VALOR TOTAL: " + total);
        }
        else if (order == 4){
            total = 2 * amount;
            Console.WriteLine("VALOR TOTAL: " + total);
        }
        else if (order == 5){
            total = 1.5 * amount;
            Console.WriteLine("VALOR TOTAL: " + total);
        }
        else {
            Console.WriteLine("CODIGO INVALIDO !");
        }
    }
    /////////////////////////////////////////////////////////////////////////////////////////////
    /// -------> END
}
