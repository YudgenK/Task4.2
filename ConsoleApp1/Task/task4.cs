using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Task
{
    class task4
    {
        public void Run()
        {
            Invoice invoice = new Invoice(
                account: 123456,
                customer: "ТОВ 'Рога і Копита'",
                provider: "ТОВ 'Принтери України'",
                article: "Картридж HP 123",
                quantity: 5
            );

            Console.WriteLine("Введіть ціну за одиницю товару (грн):");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Врахувати ПДВ? (так/ні):");
            bool includeVat = Console.ReadLine().ToLower() == "так";

            Console.WriteLine("\nІнформація про замовлення:");
            invoice.DisplayInvoice(price, includeVat);
        }
       
    }
    class Invoice
    {
        private readonly int account;
        private readonly string customer;
        private readonly string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider, string article, int quantity)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
            this.article = article;
            this.quantity = quantity;
        }

        public (double withoutVat, double withVat) CalculateCost(double pricePerUnit)
        {
            const double VAT_RATE = 0.20; // Ставка ПДВ 20%
            double totalWithoutVat = pricePerUnit * quantity;
            double totalWithVat = totalWithoutVat * (1 + VAT_RATE);

            return (totalWithoutVat, totalWithVat);
        }

        public void DisplayInvoice(double pricePerUnit, bool includeVat)
        {
            var (withoutVat, withVat) = CalculateCost(pricePerUnit);
            Console.WriteLine($"Рахунок: {account}");
            Console.WriteLine($"Замовник: {customer}");
            Console.WriteLine($"Постачальник: {provider}");
            Console.WriteLine($"Товар: {article}");
            Console.WriteLine($"Кількість: {quantity}");
            Console.WriteLine($"Ціна за одиницю: {pricePerUnit} грн");
            Console.WriteLine($"Сума без ПДВ: {withoutVat:F2} грн");
            if (includeVat)
            {
                Console.WriteLine($"Сума з ПДВ: {withVat:F2} грн");
            }
        }
    }

}

