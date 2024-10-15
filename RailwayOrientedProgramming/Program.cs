using RailwayOrientedProgramming;
using RailwayOrientedProgramming.Extensions;
using RailwayOrientedProgramming.Results;
using System.Text.Json;

var value = "Burak Zengin";
var mail = value
    .Ensure(_ => _.Length < 3, new Error("Value cannot be less than 3 characters."))
    .Ensure(_ => _.Length > 50, new Error("Value cannot be longer than 50 characters.."))
    .Ensure(_ => _.Contains('@') == false, new Error("Value must contain the @ character."))
    .Map(_ => new Mail(_));

Console.WriteLine(JsonSerializer.Serialize(mail));

Console.ReadLine();