namespace HtmlBuilder;

public class FigureElement : HtmlBaseElement
{
    public FigureElement() : base("<figure>", "</figure>")
    {
        Class = "table";
        Style = "float:left;";
    }
}