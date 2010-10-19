/*  
  Copyright 2007-2010 The NGenerics Team
 (http://code.google.com/p/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/
using NGenerics.DataStructures.Queues;
using NUnit.Framework;

namespace NGenerics.Tests.DataStructures.Queues.CircularQueueTests
{
    [TestFixture]
    public class IsReadOnly
    {

        [Test]
        public void Simple()
        {
            var circularQueue = new CircularQueue<int>(40);
            Assert.IsFalse(circularQueue.IsReadOnly);

            circularQueue = CircularQueueTest.GetFullTestQueue();
            Assert.IsFalse(circularQueue.IsReadOnly);
        }

    }
}