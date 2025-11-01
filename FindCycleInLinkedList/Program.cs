
var head = new ListNode(3);
head.next = new ListNode(2);
head.next.next = new ListNode(0);

var hasCycle = new Solution().HasCycle(head);
Console.WriteLine(hasCycle);

public class ListNode
{
    public int val;
    public ListNode? next;

    public ListNode(int x)
    {
        val = x;
        next = null;
    }
}

public class Solution
{
    // Implement using Floyd's Cycle Finding Algorithm
    public bool HasCycle(ListNode head)
    {
        ListNode slow = head;
        ListNode fast  = head;
        
        while (slow != null && fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            
            if (slow == fast)
                return true;
        }
        
        return false;   
    }
}