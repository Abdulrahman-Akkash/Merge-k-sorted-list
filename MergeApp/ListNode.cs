public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
    public static ListNode MergeTwoLists(ListNode l1, ListNode l2)//muntasır
    {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        while (l1 != null && l2 != null)
        {
            if (l1.val < l2.val)
            {
                tail.next = l1;
                l1 = l1.next;
            }
            else
            {
                tail.next = l2;
                l2 = l2.next;
            }
            tail = tail.next;
        }

        tail.next = (l1 != null) ? l1 : l2;
        return dummy.next;
    }
    public static ListNode MergeKLists(ListNode[] lists)
    {
        if (lists == null || lists.Length == 0) return null;
        return MergeKListsHelper(lists, 0, lists.Length - 1);

    }

    private  static ListNode MergeKListsHelper(ListNode[] lists, int left, int right)
    {
        if (left == right) return lists[left];

        int mid = (left + right) / 2;
        ListNode l1 = MergeKListsHelper(lists, left, mid);
        ListNode l2 = MergeKListsHelper(lists, mid + 1, right);
        return MergeTwoLists(l1, l2);

    }
    public static ListNode BuildList(int[] values)
    {
        ListNode dummy = new ListNode();
        ListNode current = dummy;
        foreach (int val in values)
        {
            current.next = new ListNode(val);
            current = current.next;
        }
        return dummy.next;

    }

    public static void PrintList(ListNode head)
    {
        while (head != null)
        {
            Console.Write(head.val + " -> ");
            head = head.next;
        }
        Console.WriteLine("null");

    }


}
