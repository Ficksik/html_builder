using System.Text;

namespace HtmlBuilder;

public class HtmlBuilder
{
    private readonly StringBuilder _strBuilder;

    public Body Body;

    public HtmlBuilder(string title)
    {
        Body = new Body();
        _strBuilder = new StringBuilder();
        _strBuilder.AppendLine("<!DOCTYPE html>");
        _strBuilder.AppendLine("<style>\ntable, th, td {\nborder:1px solid black;\n}\n</style>");
        _strBuilder.AppendLine("<html lang=\"en\">");
        _strBuilder.AppendLine($"<head>\n<meta charset=\"UTF-8\">\n<title>{title}</title>\n</head>");
    }
    public override string ToString()
    {
        var html = _strBuilder.ToString();
        html += Body.ToString();
        return html + "\n</html>";
    }
}