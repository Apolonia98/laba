# Лаб 2. Реалізація патерну Фабричний метод

Виконав: Хмелівський Станіслав, варіант 27 (столи).

Рішення `FactoryMethodTables.sln` складається з двох проєктів:

* `TablesLibrary` (бібліотека класів, збирається в `TablesLibrary.dll`) містить класи патерну:
  * `Table` (абстрактний продукт) і конкретні продукти `DiningTable`, `Desk`, `CoffeeTable`;
  * `TableWorkshop` (абстрактний творець) з фабричним методом `CreateTable()` і методом `Order()`, який його використовує;
  * конкретні творці `DiningTableWorkshop`, `DeskWorkshop`, `CoffeeTableWorkshop`.
* `TablesApp` (Windows Forms) підключає `TablesLibrary.dll`. Користувач вибирає майстерню і замовляє стіл, а форма показує список замовлень і загальну суму.

Запуск: відкрити `FactoryMethodTables.sln` у Visual Studio і натиснути F5, або виконати `dotnet run --project TablesApp`.
