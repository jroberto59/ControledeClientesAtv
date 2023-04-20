using System;
namespace Atividade
{
    class Program
    {
        static void Main(string[] args)
        {
            float val_pag;
            Console.WriteLine("Informar Nome");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereço");
            string var_endereço = Console.ReadLine();
            Console.WriteLine("Pessoa Física (f) ou Pessoa Jurídica (j) ?");
            string var_tipo = Console.ReadLine();
            if (var_tipo == "f")
            {
                // --- Pessoa Física ----
                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereço = var_endereço;
                Console.WriteLine("Informar CPF");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("-------- Pessoa Física --------");
                Console.WriteLine("Nome ..........: " + pf.nome);
                Console.WriteLine("Endereço ......: " + pf.endereço);
                Console.WriteLine("CPF ...........: " + pf.cpf);
                Console.WriteLine("RG ............: " + pf.rg);
                Console.WriteLine("Valor da Compra: " + pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: " + pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total a Pagar  : " + pf.total.ToString("C"));
            }
            if (var_tipo != "j")
            {
                return;
            }
            // --- Pessoa Jurídica ----
            Pessoa_Juridica pj = new Pessoa_Juridica();
            pj.nome = var_nome;
            pj.endereço = var_endereço;
            Console.WriteLine("Informar CNPJ:");
            pj.cnpj = Console.ReadLine();
            Console.WriteLine("Informar IE:");
            pj.ie = Console.ReadLine();
            Console.WriteLine("Informar Valor da Compra:");
            val_pag = float.Parse(Console.ReadLine());
            pj.Pagar_Imposto(val_pag);
            Console.WriteLine("-------- Pessoa Juridica --------");
            Console.WriteLine("Nome .........: " + pj.nome);
            Console.WriteLine("Endereço .....: " + pj.endereço);
            Console.WriteLine("CNPJ .........: " + pj.cnpj);
            Console.WriteLine("IE ...........: " + pj.ie);
            Console.WriteLine("Valor da Compra:" + pj.valor.ToString("C"));
            Console.WriteLine("Imposto .......: " + pj.valor_imposto.ToString("C"));
            Console.WriteLine("Total a Pagar .: " + pj.total.ToString("C"));
        }
    }
}