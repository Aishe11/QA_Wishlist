using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestEntities
{
    public class WishlistEvent
    {
        public WishlistEvent(string title, string date)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Date = date ?? throw new ArgumentNullException(nameof(date));
        }

        public string Title { get; set; }
        public string Date { get; set; }
    }
}
