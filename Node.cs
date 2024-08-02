public partial class LinkedList
{
    public class Node
	{
		public int Value {  get; set; }
		public Node Prev { get; set; }
		public Node Next {  get; set; }  

        public Node()
        {
            Value = 0;
            Prev = null;
            Next = null;
        }
        public Node(int value) : this()
        {
            this.Value = value;
        }

      
    }
}
