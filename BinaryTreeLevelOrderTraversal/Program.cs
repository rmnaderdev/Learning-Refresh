
var root = new TreeNode(3, new TreeNode(9), new TreeNode(20, new TreeNode(15), new TreeNode(7)));

var levelOrder = new Solution().LevelOrder(root);

public class TreeNode
{
    public int val;
    public TreeNode? left;
    public TreeNode? right;

    public TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}

public class Solution
{
    public List<IList<int>> LevelOrder(TreeNode root)
    {
        if (root == null)
            return new List<IList<int>>();
        
        var queue = new Queue<TreeNode>();
        List<IList<int>> res = new List<IList<int>>();
        
        queue.Enqueue(root);
        var currLevel = 0;

        while (queue.Count > 0)
        {
            var len = queue.Count;
            res.Add(new List<int>());

            for (var i = 0; i < len; i++)
            {
                var node = queue.Dequeue();
                
                res[currLevel].Add(node.val);

                if (node.left != null)
                {
                    queue.Enqueue(node.left);
                }

                if (node.right != null)
                {
                    queue.Enqueue(node.right);
                }
            }
            currLevel++;
        }

        return res;
    }
}