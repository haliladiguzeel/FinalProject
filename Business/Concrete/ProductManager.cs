using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // Bir iş class'ı başka class'ları new lemez yoksa başka data servislere geçiş olursa
        // problem çıkartır. Burada sadece belleğe bağımlı olur!
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> GetAll()     //İş kodları bu class'ın içine yazılır
        {
            return _productDal.GetAll();
        }
    }
}
