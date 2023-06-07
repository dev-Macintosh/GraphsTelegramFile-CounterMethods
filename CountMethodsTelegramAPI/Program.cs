
using AngleSharp;

System.Int32 i = 0;


var arrayMethods=getMethods();

while (!arrayMethods.IsCompleted)
{

    switch (i % 4)
    {
        case 0:
            Console.WriteLine("Поиск информации \\");
            break;
        case 1:
            Console.WriteLine("Поиск информации -");
            break;
        case 2:
            Console.WriteLine("Поиск информации /");
            break;
        case 3:
            Console.WriteLine("Поиск информации -");
            break;
    }
    await Task.Delay(40);
    Console.Clear();
    i++;

}

Console.ForegroundColor = ConsoleColor.Blue;
Console.Clear();
Console.Write("Количество методов в документации Telegram: ");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write(arrayMethods.Result.Length);
Console.ForegroundColor = ConsoleColor.Blue;
Console.Write(" на " + DateTime.Now.ToShortDateString());
Console.ReadLine();

static async Task<Array> getMethods()
{
    var config = Configuration.Default.WithDefaultLoader();
    var address = "https://core.telegram.org/methods";
    var document = await BrowsingContext.New(config).OpenAsync(address);
    
    var cellSelector = "td > a";
    var cells = document.QuerySelectorAll(cellSelector);
    var titles = cells.Where(m => m.TextContent.ToString().Contains(".")).Select(m => m.TextContent).ToArray();
    return titles;

}