using Microsoft.AspNetCore.Mvc;
using NLP.Demo.Api;
using System.Diagnostics;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

/// <summary>
/// Analyze tweet. User enters the tweet as string and awaits for results.
/// </summary>
app.MapGet("/analyze/tweet", ([FromQuery] string tweet) =>
{
    Process p = new();

    p.StartInfo.UseShellExecute = false;
    p.StartInfo.RedirectStandardOutput = true;
    p.StartInfo.RedirectStandardError = true;
    p.StartInfo.FileName = @"C:\Users\konkr\Desktop\NLP.Demo.NeuralNet\NLP.Demo.NeuralNet.exe"; // First you have to publish the NLP.Demo.NeuralNet console app and change the directory for the web api to function.
    p.StartInfo.Arguments = $"'{tweet}'";
    p.Start();
    p.WaitForExit();

    // read the output stream first and then wait.
    var error = p.StandardError.ReadToEnd();
    string output = p.StandardOutput.ReadToEnd();

    if (error != null) Results.BadRequest("Tweet given was null");

    // parse confidence percentage values.
    var positiveClassOutput = output.Substring(65, 2);
    var negativeClassOutput = output.Substring(111, 2);

    //return obj
    return new AnalysisResult
    {
        TweetString = tweet,
        NegativeSemtimentConfidence = int.Parse(negativeClassOutput),
        PositiveSentimentConfidence = int.Parse(positiveClassOutput)
    };

});

app.Run();