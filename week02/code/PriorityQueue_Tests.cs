using Microsoft.VisualStudio.TestTools.UnitTesting;

public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("Bob", 3);
        pq.Enqueue("Tim", 5);
        pq.Enqueue("Sue", 1);

        Assert.AreEqual("Tim", pq.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_Empty()
    {
        var pq = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            pq.Dequeue();
        });

        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}