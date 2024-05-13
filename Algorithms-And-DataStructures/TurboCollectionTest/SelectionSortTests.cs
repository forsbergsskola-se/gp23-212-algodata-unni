
using TurboCollections;

namespace TurboCollectionTest

{
    [TestFixture]
    public class SelectionSortTests
    {
        [Test]
        public void SortListSmallToBig()
        {

            var list = new List<int> { 5, 3, 1, 2, 4 };
            TurboSort.SelectionSort(list);

        }
    }
}