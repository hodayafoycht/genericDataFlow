
using GenericDataFlow;

FirstDataFlow<string> dataFlow = new FirstDataFlow<string>();
dataFlow.AddBlock(new UpperCaseBlock());
dataFlow.AddBlock(new ReplaceAWithSixBlock());
dataFlow.AddBlock(new ReverseBlock());
string input = "aaaHello, World!";
string result = dataFlow.RunFlow(input);
Console.WriteLine($"Input: {input}");
Console.WriteLine($"Output: {result}");