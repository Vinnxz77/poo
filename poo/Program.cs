using PooPedidos;
using PooPedidos.Entidades;

var cliente1 = new Cliente();
cliente1.Id = 1;
cliente1.Cpf = "111.111.111-11";
cliente1.Nome = "Cliente 1";
cliente1.Email = "cliente1@email.com";
var stringCliente1 = cliente1.ToString();
Console.WriteLine(stringCliente1);

var cliente2 = new Cliente();
cliente2.Id = 2;
cliente2.Cpf = "222.222.222-22";
cliente2.Nome = "Cliente 2";
cliente2.Email = "cliente2@email.com";
var stringCliente2 = cliente1.ToString();
Console.WriteLine(stringCliente2);

var cliente3 = new Cliente();
cliente3.Id = 3;
cliente3.Cpf = "333.333.333-33";
cliente3.Nome = "Cliente 3";
cliente3.Email = "cliente3@email.com";
var stringCliente3 = cliente1.ToString();
Console.WriteLine(stringCliente3);

var listaCliente = new List<Cliente>();
listaCliente.Add(cliente1);
listaCliente.Add(cliente2);
listaCliente.Add(cliente3);

Console.WriteLine("Count:"+listaCliente.Count);

foreach (var cliente in listaCliente)
{
    Console.WriteLine(cliente.Nome);
}

for (int i = 0; i < listaCliente.Count; i++)
{
    Console.WriteLine(listaCliente[i].Nome);
}

listaCliente.ForEach(x => Console.WriteLine(x.Nome));


Console.Write("Informe o ID do cliente: ");
var entrada = Console.ReadLine();
if (int.TryParse(entrada, out int idProcurado))
{
    Cliente selecionado = null;
    foreach (var c in listaCliente)
    {
        if (c.Id == idProcurado)
        {
            selecionado = c;
            break;
        }
    }

    if (selecionado != null)
    {
        Console.WriteLine("Cliente encontrado:");
        Console.WriteLine($"Id: {selecionado.Id}");
        Console.WriteLine($"Nome: {selecionado.Nome}");
        Console.WriteLine($"CPF: {selecionado.Cpf}");
        Console.WriteLine($"Email: {selecionado.Email}");
    }
    else
    {
        Console.WriteLine("Cliente não encontrado.");
    }
}
else
{
    Console.WriteLine("ID inválido.");
}


//var aplicacao = new Aplicacao();
//aplicacao.Executar();
