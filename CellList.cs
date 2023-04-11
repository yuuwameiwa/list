using list;

namespace list
{
    public class CellList
    {
        //add //pop //remove //find //insertafter
        //count
        public Cell LastSentinel;
        public Cell FirstSentinel;

        public CellList()
        {
            LastSentinel = new Cell(null, null, null);
            FirstSentinel = new Cell(null, LastSentinel, null);

            LastSentinel.Previous = FirstSentinel;
        }

        public void Insert(int index, int value)
        {
            Cell cell = FirstSentinel;

            int i = -1;
            while (cell.Next != null)
            {
                cell = cell.Next;

                i++;

                if (i == index)
                {
                    Cell newCell = new Cell(value, cell, cell.Previous);

                    cell.Previous.Next = newCell;

                    cell.Previous = newCell;
                }
            }
        }

        public Cell Find(int value)
        {
            Cell returnCell = null;

            Cell cell = FirstSentinel;

            while (cell.Next != null)
            {
                cell = cell.Next;

                if (cell.Value == value)
                    returnCell = cell;
            }

            return returnCell;
        }

        public void Remove(int index)
        {
            Cell cell = FirstSentinel;

            int i = 0;
            while (cell.Next != null)
            {
                cell = cell.Next;

                i++;

                if (i == index)
                {
                    cell.Next.Previous = cell.Previous;

                    cell.Previous.Next = cell.Next;

                    return;
                }

            }
        }

        public void Add(int value)
        {
            Cell cell = FirstSentinel;

            while (cell.Next != null)
            {
                cell = cell.Next;
            }

            Cell newCell = new Cell(value, cell, cell.Previous);

            cell.Previous.Next = newCell;

            cell.Previous = newCell;
        }

        public void Pop()
        {
            FirstSentinel.Next = FirstSentinel.Next.Next;
            FirstSentinel.Next.Previous = FirstSentinel.Next;
        }

        public void InsertAtTheBeggining(int value)
        {
            Cell newCell = new Cell(value, FirstSentinel.Next, FirstSentinel);

            FirstSentinel.Next = newCell;
        }

        public void Iterate()
        {
            Cell cell = FirstSentinel;

            while (cell.Next != null)
            {
                Console.WriteLine(cell.Value);
                cell = cell.Next;
            }
        }
    }
}