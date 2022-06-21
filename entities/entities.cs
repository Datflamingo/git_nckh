using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NCKH_HANGHOA.entities
{
    public class entities
    {
        private long id;
        private string Product;
        private int Quanlity;
        private string Ex;
        
        entities(long id, string Product, string Ex, int Quanlity)
        {
            this.id = id;
            this.Product = Product;
            this.Ex = Ex;
            this.Quanlity = Quanlity;
        }
    }
}
