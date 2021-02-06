using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===================================== Kayıt işlemleri =====================================");

            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            Gamer gamer1 = new Gamer { Id = 1, BirthYear = 1985, FirstName = "Engin", LastName = "Demiroğ", IdentityNumber = 12345 };
            Gamer gamer2 = new Gamer { Id = 2, BirthYear = 1995, FirstName = "Kamran", LastName = "Hashimov", IdentityNumber = 123456 };
            Gamer[] gamers = new Gamer[] { gamer1, gamer2 };
            gamerManager.Add(gamer1);
            gamerManager.Add(gamer2);

            Console.WriteLine("===================================== Kampanya işlemleri =====================================");

            CampaignManager campaignManager = new CampaignManager();
            Campaign campaign = new Campaign { CampaignId = 1, CampaignName = "%50 indirim", Discount = 50, CampaignDetail = "Kampanya 2021 Ekim sonunda sona erecek" };
            campaignManager.Add(campaign);

            Console.WriteLine("===================================== Oyun işlemleri =====================================");

            OrderManager orderManager = new OrderManager();
            Products products = new Products { ProductId = 1, ProductName = "Forza Horizon 4", UnitPrice = 600, Stock = 50 };
            orderManager.Add(products);


            Console.WriteLine("===================================== Satış işlemleri =====================================");

            foreach (Gamer gamer in gamers)
            {
                IOrderService orderService = new OrderManager(gamer, campaign);
                orderService.MakeSale(products);
            }
        }
    }
}