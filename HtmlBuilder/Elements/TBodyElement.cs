namespace HtmlBuilder;

public class TBodyElement: HtmlBaseElement
{
    public TBodyElement() : base("<tbody>", "</tbody>" )
    {
    }

    public TBodyElement AddRow(params string[] values)
    {
        var tr = new TrElement();
        foreach (var value in values)
        {
            tr.Add(new TdElement(){Text = value}); 
        }
        this.Add(tr);
        return this;
    }
}