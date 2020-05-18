using System;
using System.Collections.Generic;
using System.Text;

namespace MarieZoo.Interfaces
{
    interface IFeed
    {

        public string FeedMe { get; set; }
        bool YouCanFeedMe();
      
    }
}
