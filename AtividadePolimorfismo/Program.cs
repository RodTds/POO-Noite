using AtividadePolimorfismo;
//Funcionario
Funcionario funcionario = new Funcionario(10,"Joao",3000);
// Secretarios
Secretario secretario = new Secretario(1,"Joao",3000);
Secretario secretario2 = new Secretario(6,"Joana",3000);
Secretario secretario3 = new Secretario(7,"Marcela",3000);
// Gerentes
Gerente gerente = new Gerente(2,"Carlos",3000);
Gerente gerente2 = new Gerente(8,"Linda",3000);
Gerente gerente3 = new Gerente(9,"Marcia",3000);
// Diretores
Diretor diretor = new Diretor(3,"Marcos",3000);
Diretor diretor2 = new Diretor(4,"Joao",3000);
Diretor diretor3 = new Diretor(5,"Carlos",3000);

GerenciadorBonificacao gerenciar = new GerenciadorBonificacao();
gerenciar.TotalizadorBonificacao(diretor);
gerenciar.TotalizadorBonificacao(diretor2);
gerenciar.TotalizadorBonificacao(diretor3);

gerenciar.TotalizadorBonificacao(secretario);
gerenciar.TotalizadorBonificacao(secretario2);
gerenciar.TotalizadorBonificacao(secretario3);

gerenciar.TotalizadorBonificacao(gerente2);
gerenciar.TotalizadorBonificacao(gerente);
gerenciar.TotalizadorBonificacao(gerente3);

gerenciar.TotalizadorBonificacao(funcionario);
// Exiber Resultados
System.Console.WriteLine($"Total Bonificação dos Funcionarios: { gerenciar.TotalBonificacao:c}" );



/* 
  Existe uma forma usando Dictionary mas a
  Forma mais simples seria usando na classe GerenciadorBonificacao
  
 public class GerenciadorBonificacao
{
    public double TotalBonificacaoSecretario { get; private set; }
    public double TotalBonificacaoGerente { get; private set; }
    public double TotalBonificacaoDiretor { get; private set; }

    public void TotalizadorBonificacao(Funcionario funcionario)
    {
        if (funcionario is Secretario)
        {
            TotalBonificacaoSecretario += funcionario.CalcularBonificacao();
        }
        else if (funcionario is Gerente)
        {
            TotalBonificacaoGerente += funcionario.CalcularBonificacao();
        }
        else if (funcionario is Diretor)
        {
            TotalBonificacaoDiretor += funcionario.CalcularBonificacao();
        }
    }

    public double TotalBonificacaoGeral => TotalBonificacaoSecretario + TotalBonificacaoGerente + TotalBonificacaoDiretor;
}

PROGRAM.CS

// Secretarios
Secretario secretario = new Secretario(1,"Joao",3000);
Secretario secretario2 = new Secretario(6,"Joana",3000);
Secretario secretario3 = new Secretario(7,"Marcela",3000);

// Gerentes
Gerente gerente = new Gerente(2,"Carlos",3000);
Gerente gerente2 = new Gerente(8,"Linda",3000);
Gerente gerente3 = new Gerente(9,"Marcia",3000);

// Diretores
Diretor diretor = new Diretor(3,"Marcos",3000);
Diretor diretor2 = new Diretor(4,"Joao",3000);
Diretor diretor3 = new Diretor(5,"Carlos",3000);

// Gerenciador
GerenciadorBonificacao gerenciar = new GerenciadorBonificacao();

// Adiciona bonificações
gerenciar.TotalizadorBonificacao(secretario);
gerenciar.TotalizadorBonificacao(secretario2);
gerenciar.TotalizadorBonificacao(secretario3);

gerenciar.TotalizadorBonificacao(gerente);
gerenciar.TotalizadorBonificacao(gerente2);
gerenciar.TotalizadorBonificacao(gerente3);

gerenciar.TotalizadorBonificacao(diretor);
gerenciar.TotalizadorBonificacao(diretor2);
gerenciar.TotalizadorBonificacao(diretor3);

// Exibe Resultados
Console.WriteLine("Bonificação total de Secretários: R$ " + gerenciar.TotalBonificacaoSecretario);
Console.WriteLine("Bonificação total de Gerentes: R$ " + gerenciar.TotalBonificacaoGerente);
Console.WriteLine("Bonificação total de Diretores: R$ " + gerenciar.TotalBonificacaoDiretor);
Console.WriteLine("Bonificação Geral: R$ " + gerenciar.TotalBonificacaoGeral);


*/

