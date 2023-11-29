using Summary.Markdown;
using Summary.Pipelines;
using Summary.Roslyn;

namespace SummaryIdeExtensions.SummaryWatch;

public class SummaryWatch
{
  public static async Task Watch(string input, string output)
  {
    await new SummaryPipeline().UseRoslynParser(input).UseMdRenderer(output).Run();
  }
}
