using ClasseConta;

internal class Program
{

    private static void Main(string[] args)
    {
       // declarao de varialvel

       Conta objetoConta = new Conta();
       // instanciação
      
       
       // manipulacao do objeto

       objetoConta.numero = 101;
       objetoConta.titular = "Rodrigo";
       objetoConta.saldo = 100;
       
       double valorSaque = 20;
       objetoConta.Sacar(valorSaque);

       objetoConta.MostraAtributos();
       objetoConta.Depositar(100);
       objetoConta.MostraAtributos();
     
       //objeto 2
       Conta c1 = new Conta();
       c1.numero = 102; // objeto quando esta com valor e chamado de ESTADO DO OBJETOs
       c1.titular ="Joao";
       c1.saldo = 200;
       c1.MostraAtributos();// nao e mais chamar funcao, se chama ENVIAR MENSAGEM
       
        objetoConta.Transferir(10,c1);
        c1.MostraAtributos();
        objetoConta.MostraAtributos();
        
     

    }
}