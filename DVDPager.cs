// using System.Collections.Generic;
// using System.Linq;

// namespace genericsIntro

// {
//     public class DVDPager
//     {
//         public int ItemsPerPage { get; set; }
//         public int PageNumber { get; set; }
//         public List<DVD> AllItems { get; set; }

//         public List<DVD> GetPage()
//         {
//             //this method, moves past the items on the list let's say 10 items at a time,
//             //multiplied by the page number it is on, and then displays just the next 10 items
//             return AllItems.Skip(ItemsPerPage * PageNumber)
//                 .Take(ItemsPerPage)
//                 .ToList();
//         }
//     }
// }