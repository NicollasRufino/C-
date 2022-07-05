using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
         ContaCorrente conta_01 = new ContaCorrente("Nicollas",1234,2004,25000);
         ContaCorrente conta_02 = new ContaCorrente("Renatim",22,2005,80);
         ContaCorrente conta_03 = new ContaCorrente("Igor",209,2006,250);


         Console.WriteLine("A conta é do (a) " + conta_01.Titular + " A agência é "
            + conta_01.Agencia + " E o numero é " + conta_01.Numero + " O saldo é de " + conta_01.Saldo);
             
             
        Console.WriteLine("A conta é do (a) " + conta_02.Titular + " A agência é "
            + conta_02.Agencia + " E o numero é " + conta_02.Numero + " O saldo é de " + conta_02.Saldo);
            

         Console.WriteLine("A conta é do (a) " + conta_03.Titular + " A agência é "
            + conta_03.Agencia + " E o numero é " + conta_03.Numero + " O saldo é de " + conta_03.Saldo);



        bool sacar_conta1 = conta_01.Sacar(400);
        bool sacar_conta2 = conta_02.Sacar(40);
        bool sacar_conta3 = conta_03.Sacar(220);
        
        //    conta_01.Titular = "Nicollas";
        //    conta_01.Agencia = 1234;
        //    conta_01.Numero = 2004;
        //    conta_01.Saldo = 100;
             
           Console.WriteLine("A conta é do (a) " + conta_01.Titular + " A agência é "
            + conta_01.Agencia + " E o numero é " + conta_01.Numero + " O saldo é de " + conta_01.Saldo);



        //    ContaCorrente conta_02 = new ContaCorrente();
        //    conta_02.Titular = "Carlos";
        //    conta_02.Agencia = 0002;
        //    conta_02.Numero = 2005;
        //    conta_02.Saldo = 25000;


           Console.WriteLine("A conta é do (a) " + conta_02.Titular + " A agência é "
            + conta_02.Agencia + " E o numero é " + conta_02.Numero + " O saldo é de " + conta_02.Saldo);


        //    ContaCorrente conta_03 = new ContaCorrente();
        //    conta_03.Titular = "Igor";
        //    conta_03.Agencia = 0003;
        //    conta_03.Numero = 2004;
        //    conta_03.Saldo = -80;


           Console.WriteLine("A conta é do (a) " + conta_03.Titular + " A agência é "
            + conta_03.Agencia + " E o numero é " + conta_03.Numero + " O saldo é de " + conta_03.Saldo);
        }
    }
}
