using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp21
{
    public class managemnet
    {

        public void TopRecords(List<productreview> productreviewlist)
        {
            var recorddata = (from productreview in productreviewlist
                              orderby
productreview.rating descending
                              select productreview).Take(3);
            foreach (var item in recorddata)
            {
                Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");

            }

        }
        public void selectrecords(List<productreview> productreviewlist)
        {
            var recorddata = (from productreview in productreviewlist
                              where (productreview.productid > 3 && productreview.rating == 3 ||
productreview.productid > 3 && productreview.rating == 4 || productreview.productid > 3 && productreview.rating == 9)
                              select productreview);
            foreach (var item in recorddata)
            {
                Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");

            }

        }
    }
}
