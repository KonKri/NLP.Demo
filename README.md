# NLP.Demo
This is a simple Backend Solution for analyzing sentiment of tweets.
In this example there is an Web API exposing the functionality of understanding the sentiment of a tweet using *Natural Language Processing*.
For this example we are focusing on the Web API and not on the Machine Learning stuff, thus we run a mock proccess for analyzing the sentiment.

## NLP.Demo.NeuralNet
Mock console application returning random values representing the positive or negative sentiment for a tweet given as an argument.

**Example Usage:**
```
~\NLP.Demo.NeuralNet.exe <tweet>
```

And the output is:
```
Tweet Analysis complete
Class1: Positive Sentitment Confidence: 44 %
Class2: Negative Sentitment Confidence: 56 %
```

## NLP.Demo.Api
Exposing a single endpoint allowing users to have sentiment analysis on a specific tweet.

**ample Usage:**
```GET <host>/analyze/tweet?tweet=<tweet>```

And the response is:
```
{
  "tweetString": "asdf",
  "positiveSentimentConfidence": 44,
  "negativeSemtimentConfidence": 56,
}
```

## Future Implementation TODO:
- Users can upload a ```.csv``` or an ```.xlsx``` file and the Api can return a ```.csv``` or an ```.xlsx``` file containing tweets and sentiment analysis.
- Simple Front End in Flutter. 
