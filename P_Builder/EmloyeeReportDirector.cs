namespace P_Builder;

public class EmloyeeReportDirector
{
    private readonly IEmployeeReportBuilder _builder;

    public EmloyeeReportDirector(IEmployeeReportBuilder builder)
    {
        _builder = builder;
    }

    public void Build()
    {
        _builder.BuildHeader().BuildBody().BuildFooter();
    }
}