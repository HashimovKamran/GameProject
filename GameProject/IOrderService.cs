using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IOrderService
    {
        void Add(Products products);
        void Update(Products products);
        void Delete(Products products);
        void MakeSale(Products products);
    }
}
