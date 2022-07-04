namespace Moamen.Training.DataStructures.Tests
{
    public class LinkedListTests
    {
        [Fact]
        public void AddLast()
        {
            var ll = new LinkedList.LinkedList<int>();

            ll.AddLast(1);

            Assert.Equal(ll.Head.Value, 1);

            Assert.NotEqual(ll.Tail,null);

            Assert.Equal(ll.Count,1);
        }

        [Fact]
        public void AddFirst()
        {
            var ll = new LinkedList.LinkedList<int>();

            ll.AddFirst(2);

            Assert.Equal(ll.Head.Value, 2);

            Assert.Equal(ll.Tail.Value,2);

            Assert.Equal(ll.Count,1);
        }

        [Fact]
        public void Test()
        {
            var ll = new LinkedList.LinkedList<int>();

            ll.AddFirst(1);
            ll.AddLast(2);

            Assert.Equal(ll.Head.Value, 1);

            Assert.Equal(ll.Tail.Value,2);
         
            Assert.Equal(ll.Count,2);
        }


    }
}