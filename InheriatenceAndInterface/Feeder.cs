using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheriatenceAndInterface
{
    /*
     * A class to represent an animal feeder
     * this class is sealed so no other class can inherit from it
     */
    public sealed class Feeder
    {
        public void FeedAnimal(IFeedable animal)
        {
            animal.Feed();
        }
    }
}
