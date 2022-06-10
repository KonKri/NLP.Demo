// See https://aka.ms/new-console-template for more information
// NLP.Demo.NeuralNet

// Simulating the result of tensorflow or other machine learning techniques.

// Getting parameter as tweet text.
var tweet = Environment.GetCommandLineArgs()[1];

if (tweet == null) throw new ArgumentNullException(nameof(tweet));

// Simulating confidence for two categories (Positive or Negative Sentiment)
var rand = new Random();
var positiveConfidence = rand.Next(50);
var negativeConfidence = 100 - positiveConfidence; // positiveConfidence + negativeConfidence = 100 always.

// Simulating processing time...
Thread.Sleep(2000);

// Returing results.
Console.WriteLine("Tweet Analysis complete");
Console.WriteLine($"Class1: Positive Sentitment Confidence: {positiveConfidence:00} %");
Console.WriteLine($"Class2: Negative Sentitment Confidence: {negativeConfidence:00} %");

return 0;