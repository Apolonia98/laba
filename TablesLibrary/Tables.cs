namespace TablesLibrary
{
    //---------------------Product
    public abstract class Table
    {
        public string name;
        public string material;
        public int price;

        public abstract string Description();

        public string Info()
        {
            return name + " (" + material + "), " + Description() + ", ціна " + price + " грн";
        }
    }

    //---------------------Concrete products
    public class DiningTable : Table
    {
        public int seats;

        public DiningTable()
        {
            name = "Обідній стіл";
            material = "дуб";
            seats = 6;
            price = 12500;
        }

        public override string Description()
        {
            return "місць " + seats;
        }
    }

    public class Desk : Table
    {
        public int drawers;

        public Desk()
        {
            name = "Письмовий стіл";
            material = "бук";
            drawers = 3;
            price = 7800;
        }

        public override string Description()
        {
            return "шухляд " + drawers;
        }
    }

    public class CoffeeTable : Table
    {
        public string shape;

        public CoffeeTable()
        {
            name = "Журнальний столик";
            material = "скло і метал";
            shape = "круглий";
            price = 3500;
        }

        public override string Description()
        {
            return shape;
        }
    }
}
