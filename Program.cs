using System;

namespace list
{
    public class Program
    {
        public static void Main()
        {
            //CellService cellService = new CellService();

            CellList cellList = new CellList();

            cellList.Add(1);
            cellList.Add(2);
            cellList.Add(3);
            cellList.Add(4);

            //cellList.Pop();
            //cellList.Remove(3);

            //Cell findedCell = cellList.Find(4);

            //if (findedCell != null)
            //  Console.WriteLine(findedCell.Value);

            cellList.Insert(2, 10);

            cellList.Iterate();
        }
    }
}