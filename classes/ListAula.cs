using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Globalization;

namespace CursoCSharp
{
    class ListAula
    {
        public static void Execute()
        {
            List<string> list = new List<string>();

            // Adicionar elementos na lista (vazia)
            list.Add("Ricardo");
            list.Add("Karen");
            list.Add("Alice");
            list.Add("Aurora");
            list.Add("Maggie");

            // inserir elementos na lista (já criada)
            list.Insert(2, "Rosita");

            // Percorrer a lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("-------------------------------------");

            // Verificar o tamanho da lista
            Console.WriteLine($"List count: {list.Count}");

            Console.WriteLine("-------------------------------------");

            // Encontrar primeiro ou último elemento da lista que satisfaça um predicado:
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine($"First 'A': {s1}");

            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine($"Last 'A': {s2}");

            Console.WriteLine("-------------------------------------");

            // Encontrar primeira ou última posição de elemento da lista que satisfaça um predicado:
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine($"First position 'A': {pos1}");

            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine($"Last position 'A': {pos2}");

            Console.WriteLine("-------------------------------------");
            //Filtrar a lista
            List<string> filteredNames = list.FindAll(x => x.Length == 5);

            foreach (string name in filteredNames)
            {
                Console.WriteLine(name);
            }

            Console.WriteLine("-------------------------------------");
            //Remover elementos da Lista
            list.Remove("Karen");

            foreach (string names in list)
            {
                System.Console.WriteLine($"Updated names: {names}");
            }

            Console.WriteLine("-------------------------------------");
            //Ordena elementos da Lista
            list.Sort();

            foreach (string names in list)
            {
                System.Console.WriteLine($"Updated names: {names}");
            }

            Console.WriteLine("-------------------------------------");
            //Remove todos os elementos da Lista que satisfaça um predicado
            list.RemoveAll(x => x[0] == 'A');

            foreach (string names in list)
            {
                System.Console.WriteLine($"Updated names: {names}");
            }

            Console.WriteLine("-------------------------------------");
            //Remove os elementos da Lista com base na posição
            list.RemoveAt(1);

            foreach (string names in list)
            {
                System.Console.WriteLine($"Updated names: {names}");
            }

            Console.WriteLine("-------------------------------------");
            //Remove um intervalo de elementos
            list.RemoveRange(1, 1);

            foreach (string names in list)
            {
                System.Console.WriteLine($"Updated names list 2: {names}");
            }
        }

        public static void Exercise()
        {
            Employee employee;
            Console.Write("How many employees will be registered? ");
            int n = int.Parse(Console.ReadLine());

            List<Employee> employeesList = new List<Employee>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Employee #{i}");
                Console.Write("Id: ");
                int id = int.Parse(Console.ReadLine());

                Console.Write("Name: ");
                string name = Console.ReadLine();

                Console.Write("Salary: ");
                double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.WriteLine("");
                employeesList.Add(new Employee(id, name, salary));
            }

            Console.Write("Enter the employee id that will have salary increase : ");

            int searchId = int.Parse(Console.ReadLine());

            Employee emp = employeesList.Find(x => x.Id == searchId);

            if (emp != null)
            {
                Console.Write("Enter the percentage: ");
                double percentage = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                emp.IncreaseSalary(percentage);
            }
            else
            {
                Console.WriteLine("This id does not exist!");
            }

            Console.WriteLine("Updated list of Employees");

            foreach (Employee obj in employeesList)
            {
                Console.WriteLine(obj);
            }
        }
    }
}