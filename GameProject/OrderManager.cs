using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class OrderManager : IOrderService
    {
        Gamer _gamer;
        Campaign _campaign;

        public OrderManager()
        {
        }

        public OrderManager(Gamer gamer, Campaign campaign)
        {
            _gamer = gamer;
            _campaign = campaign;
        }

        public void Add(Products products)
        {
            Console.WriteLine("Oyun eklendi");
        }

        public void Delete(Products products)
        {
            Console.WriteLine("Oyun silindi");
        }

        public void MakeSale(Products products)
        {
            Console.WriteLine("Satış işlemi başarıyla tamamlandı");
            Console.WriteLine("Fiyatı " + products.UnitPrice + " TL olan " + products.ProductName + " oyunu " + _campaign.CampaignName + "le " + (products.UnitPrice - (products.UnitPrice * _campaign.Discount / 100)) + " TL'ye " + _gamer.FirstName + " isimli kişiye satıldı.");
            Console.WriteLine("Stokda " + (products.Stock - 1) + " ürün kaldı");
            Console.WriteLine();
        }

        public void Update(Products products)
        {
            Console.WriteLine("Oyun güncellendi");
        }
    }
}
