using System;
using System.Collections.Generic;
using System.Text;

namespace atFrameWork2.TestEntities
{
    public class WishlistPresent
    {
        public WishlistPresent(string title, string link, string desc)
        {
            Title = title ?? throw new ArgumentNullException(nameof(title));
            Link = link ?? throw new ArgumentNullException(nameof(link));
            Description = desc ?? throw new ArgumentNullException(nameof(desc));
        }

        public string Title { get; set; }
        public string Link { get; set; }

        public string Description { get; set; }
    }
}
