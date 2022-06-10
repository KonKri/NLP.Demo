namespace NLP.Demo.Api
{
    public class AnalysisResult
    {
        public string? TweetString { get; set; }
        public int PositiveSentimentConfidence { get; set; }
        public int NegativeSemtimentConfidence { get; set; }
        public string? Result { get; set; }
    }
}
