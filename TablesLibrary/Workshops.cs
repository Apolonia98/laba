namespace TablesLibrary
{
    //---------------------Creator
    public abstract class TableWorkshop
    {
        public string workshopName;
        public int madeCount;

        public TableWorkshop(string name)
        {
            workshopName = name;
            madeCount = 0;
        }

        // фабричний метод
        public abstract Table CreateTable();

        public Table Order()
        {
            Table table = CreateTable();
            madeCount++;
            return table;
        }
    }

    //---------------------Concrete creators
    public class DiningTableWorkshop : TableWorkshop
    {
        public DiningTableWorkshop() : base("Майстерня обідніх столів") { }

        public override Table CreateTable()
        {
            return new DiningTable();
        }
    }

    public class DeskWorkshop : TableWorkshop
    {
        public DeskWorkshop() : base("Майстерня письмових столів") { }

        public override Table CreateTable()
        {
            return new Desk();
        }
    }

    public class CoffeeTableWorkshop : TableWorkshop
    {
        public CoffeeTableWorkshop() : base("Майстерня журнальних столиків") { }

        public override Table CreateTable()
        {
            return new CoffeeTable();
        }
    }
}
