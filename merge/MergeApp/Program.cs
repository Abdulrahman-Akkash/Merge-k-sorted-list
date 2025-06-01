
var lists = new ListNode[] {
        ListNode.BuildList(new int[] {1, 4, 5}),
        ListNode.BuildList(new int[] {1, 3, 4}),
        ListNode.BuildList(new int[] {2, 6})
    };

var merged = ListNode.MergeKLists(lists);
ListNode.PrintList(merged);  // Output: 1 -> 1 -> 2 -> 3 -> 4 -> 4 -> 5 -> 6 -> null
