using System;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            List<productreview> ListProductReview = new List<productreview>()
            {
                new productreview(){productid=1,userid=1,rating=5,review="good",islike=true},
                new productreview(){productid=2,userid=2,rating=4,review="good",islike=true},
                new productreview(){productid=3,userid=3,rating=4,review="good",islike=true},
                new productreview(){productid=4,userid=4,rating=5,review="better",islike=false},
                new productreview(){productid=5,userid=5,rating=2,review="good",islike=false},
                new productreview(){productid=6,userid=6,rating=3,review="good",islike=true},
                new productreview(){productid=7,userid=7,rating=1,review="bad",islike=true},
                new productreview(){productid=8,userid=8,rating=2,review="better",islike=false}
            };

            //foreach (var item in productreviewlist)
            //{
            //    Console.Write($"\n\nproductid= {item.productid}\nuserid= {item.userid}\nrating= {item.rating}\nreview= {item.review}\nisLike= {item.islike}");
            //}
            managemnet obj = new managemnet();
            obj.TopRecords(ListProductReview);
        }
    }
}
