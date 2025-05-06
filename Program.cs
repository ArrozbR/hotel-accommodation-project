using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

List<Pessoa> hospedes = new List<Pessoa>();
int cap, diaria, qt;
string aux;

Console.WriteLine("CADASTRAR HÓSPEDE");
Console.Write("Quantos hóspedes para serem cadastrados: ");
qt = int.Parse(Console.ReadLine());
for(int i = 0; i < qt; i++){
    Console.Write($"Insira o nome do {i + 1}° hóspede: ");
    aux = Console.ReadLine();
    Pessoa pessoa = new Pessoa(nome: aux);
    hospedes.Add(pessoa);
}
Console.Clear();

Console.WriteLine("CADASTRAR SUÍTE");
Console.Write("Insira o tipo da suíte: ");
aux = Console.ReadLine();
Console.Write("Insira a capacidade da suíte: ");
cap = int.Parse(Console.ReadLine());
Console.Write("Insira o valor da diária da suíte: ");
diaria = int.Parse(Console.ReadLine());
Suite suite = new Suite(tipoSuite: aux, capacidade: cap, valorDiaria: diaria);
Console.Clear();

Console.WriteLine("CADASTRAR RESERVA");
Console.Write("Insira quantos dias foram reservados: ");
diaria = int.Parse(Console.ReadLine());
Reserva reserva = new Reserva(diasReservados: diaria);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);
Console.Clear();

Console.WriteLine("Reserva concluída!");
Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria().ToString("R$0.00")}");