using System.Collections.Generic;
using CursoCSharp.Entities.Enums;

namespace CursoCSharp.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }
        public double BaseSalary { get; set; }
        //Composição
        public Department Department { get; set; }
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();

        // Construtor
        public Worker(string name, WorkerLevel level, double baseSalary)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
        }

        // Métodos
        public void AddContract(HourContract contract)
        {

        }

        public void RemoveContract(HourContract contract)
        {

        }

        public double Income(int year, int month)
        {
            return
        }
    }
}