namespace HtmlBuilder;

public class TableElement: HtmlBaseElement
{
    public TableElement() : base("<table>", "</table>" )
    {
        Style = "border-style:solid;width:110%";
    }
}