﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Galaxy.Base.Data.DAL;
using Galaxy.Base.Domain;

namespace Galaxy.Base.Service
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var UnitOfWork = new UnitOfWork())
            {
                var measurmentKg = new Measurement { Code = 11111, Name = "Kg" };
                var measurmentMeter = new Measurement { Code = 22222, Name = "Meter" };
                var product1 = new Product { Code = 33333, Name = "Meat", measurement = measurmentKg };
                var product2 = new Product { Code = 44444, Name = "Rice", measurement = measurmentKg };
                var product3 = new Product { Code = 55555, Name = "Textile", measurement = measurmentMeter };
                var product4 = new Product { Code = 66666, Name = "Pipe", measurement = measurmentMeter };
                //UnitOfWork.MeasurementRepository.Add(measurmentKg);
                //UnitOfWork.MeasurementRepository.Add(measurmentMeter);
                //UnitOfWork.ProductRepository.Add(product1);
                //UnitOfWork.ProductRepository.Add(product4);
                Guid x = new Guid("0893CAAF-8F61-47EC-8D9A-F06282FCCB5E");
                var product5 = new Product { Code = 77777, Name = "Textilenew", measurement = measurmentMeter };
                var product6 = new Product { Id = x,Code = 66666, Name = "PipeChanged", measurement = measurmentMeter };
                UnitOfWork.ProductRepository.Update(product5);
                UnitOfWork.ProductRepository.Update(product6);
                UnitOfWork.CommitTransaction();
            }
        }
    }
}
