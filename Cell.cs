using list;

namespace list
{
    public class Cell
    {
        public int? Value;

        public Cell? Next;
        public Cell? Previous;

        public Cell(int? value, Cell? next, Cell? previous)
        {
            Value = value;
            Next = next;
            Previous = previous;
        }
    }
}