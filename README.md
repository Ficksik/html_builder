# HTML Builder Library

This library is a tool for creating HTML documents in C#. It allows programmers to dynamically generate HTML code, making it easier to generate web pages directly from code.
## Installation
Download the dll file from the latest release: [Last Release](https://github.com/Ficksik/html_builder/releases/tag/v1)

## Peculiarities

- **Ease of use:** Simple and intuitive interface for creating HTML elements and their attributes.
- **Flexibility and Customizability:** Ability to create both simple and complex HTML structures, as well as add custom attributes and styles.

## Usage example
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
           .AddRow( "Currently connected clients", ServerLogic.ConnectionsCount.ToString())
           .AddRow( "Number of rooms on server", ServerLogic.LobbyManager.GetRoomsCount.ToString())
           .AddRow( "Max. number of rooms in the lobby at the same time", Statistic.MaxRoomsInLobby.ToString())
           .AddRow( "Max. number of players on the server at the same time", Statistic.MaxPlayers.ToString())
        table.Add(tbody);
        figure.Add(table);
        
        figure.Add(new H4Element(){Text = "Server Options"});            
        body.Add(figure);
    }
}
```
You can also set each element Text, Class, Href, Style, just assign values to these fields

## Custom Elements
Inherit your element from **HtmlBaseElement(string openingTag, string closingTag)** like:
```csharp
public class AElement : HtmlBaseElement
{
    public AElement() : base("<a>", "</a>") {}
}
```

## Contribution and feedback

We welcome any suggestions and improvements! If you have ideas or find bugs, please create an issue or pull request in this repository.