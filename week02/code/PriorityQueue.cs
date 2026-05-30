using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

public class PriorityQueue
{
    // store items grouped by priority; higher number = higher priority
    private readonly SortedDictionary<int, Queue<string>> _map = new SortedDictionary<int, Queue<string>>(Comparer<int>.Create((a,b) => a.CompareTo(b)));

    public void Enqueue(string item, int priority)
    {
        if (!_map.TryGetValue(priority, out var q))
        {
            q = new Queue<string>();
            _map[priority] = q;
        }
        q.Enqueue(item);
    }

    public string Dequeue()
    {
        if (_map.Count == 0)
            throw new InvalidOperationException("The queue is empty.");

        // since SortedDictionary is ascending, get the last key (highest priority)
        var enumerator = _map.Keys.GetEnumerator();
        int lastKey = 0;
        while (enumerator.MoveNext())
            lastKey = enumerator.Current;

        var q = _map[lastKey];
        var item = q.Dequeue();
        if (q.Count == 0)
            _map.Remove(lastKey);
        return item;
    }
}

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    public void TestPriorityQueue_1()
    {
        var pq = new PriorityQueue();

        pq.Enqueue("Bob", 3);
        pq.Enqueue("Tim", 5);
        pq.Enqueue("Sue", 1);

        Assert.AreEqual("Tim", pq.Dequeue());
    }

    [TestMethod]
    public void TestPriorityQueue_2()
    {
        var pq = new PriorityQueue();

        var ex = Assert.ThrowsException<InvalidOperationException>(() =>
        {
            pq.Dequeue();
        });

        Assert.AreEqual("The queue is empty.", ex.Message);
    }
}