/*  
  Copyright 2007-2013 The NGenerics Team
 (https://github.com/ngenerics/ngenerics/wiki/Team)

 This program is licensed under the GNU Lesser General Public License (LGPL).  You should 
 have received a copy of the license along with the source code.  If not, an online copy
 of the license can be found at http://www.gnu.org/copyleft/lesser.html.
*/

namespace NGenerics.Tests.DataStructures.Mathematical.Vector3DTests
{
    using NGenerics.DataStructures.Mathematical;
    using NUnit.Framework;

    [TestFixture]
    public class ZeroVector
    {

        [Test]
        public void Simple()
        {
            var vector = Vector3D.ZeroVector;
            Assert.AreEqual(0, vector.X);
            Assert.AreEqual(0, vector.Y);
            Assert.AreEqual(0, vector.Z);
        }

    }
}