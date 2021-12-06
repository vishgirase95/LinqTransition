using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp21
{
  public  class managemnet
    {
        
        public void TopRecords(List<productreview> productreviewlist)
        {
            var recorddata=(from productreview in productreviewlist orderby
                            productreview.rating descending select productreview).Take(3);
            foreach (var item in recorddata)
            {
                Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");

            }

        }
    }
}
