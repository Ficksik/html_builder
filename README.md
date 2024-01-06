# HTML Builder Library

Эта библиотека представляет собой инструмент для создания HTML документов на языке C#. Она позволяет программистам динамически создавать HTML-код, облегчая процесс генерации веб-страниц прямо из кода.

## Особенности

- **Простота использования:** Простой и интуитивно понятный интерфейс для создания HTML элементов и их атрибутов.
- **Гибкость и настраиваемость:** Возможность создавать как простые, так и сложные HTML структуры, а также добавлять пользовательские атрибуты и стили.
- **Консистентность:** Безопасное формирование HTML кода с помощью объектов C# для предотвращения ошибок.

## Пример использования

```csharp
using HTMLBuilder;

class Program
{
    static void Main(string[] args)
    {
        var htmlBuilder = new HtmlBuilder("Main Page");
        BuildPage(htmlBuilder.Body);
        Console.WriteLine(htmlBuilder.ToString());
        Console.ReadLine();
    }
    
    static void BuildPage(Body body)
    {
        BuildH2Title(body,"Main page");
        BuildTable(body);
    }
   
    static void BuildH2Title(Body body,string title)
    {
        var h2 = new H2Element();
        var span = new SpanElement
        {
            Style = "background-color:hsl(0, 0%, 0%);color:hsl(0, 0%, 100%);",
            Text = title
        };

        h2.Add(span);
        body.Add(h2);
    }
    
    static void BuildTable(Body body)
    {
        var figure = new FigureElement();
        var table = new TableElement();
        
        table.Add(new THeadElement("Prop","Value"));
        
        var tbody = new TBodyElement()
            .AddRow("Сейчас присоединено клиентов", ServerLogic.ConnectionsCount.ToString())
            .AddRow( "Кол-во комнат на сервере", ServerLogic.LobbyManager.GetRoomsCount.ToString())
            .AddRow( "Макс. кол-во комнат в лобби одновременно", Statistic.MaxRoomsInLobby.ToString())
            .AddRow("Макс. кол-во игроков на сервере одновременно", Statistic.MaxPlayers.ToString())
 
        table.Add(tbody);
        figure.Add(table);
        
        figure.Add(new H4Element(){Text = "Server Options"});            
        body.Add(figure);
    }
}
```
## Вклад и обратная связь

Мы приветствуем любые предложения и улучшения! Если у вас есть идеи или обнаружены ошибки, пожалуйста, создайте issue или pull request в этом репозитории.