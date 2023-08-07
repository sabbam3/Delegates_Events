using Delegates_Events;


Calculate calculate = DelegateExamples.CalculateSub;
Console.WriteLine(calculate.Invoke(15, 8));

calculate = DelegateExamples.CalculateDer;
Console.WriteLine(calculate.Invoke(15, 2));

DelegateExamples.PrintTextV1.Invoke("Anonymous Method");
DelegateExamples.PrintTextV2.Invoke("Lambda Expresion and Anonymous method");

int multipliedNumber = DelegateExamples.CalculateMultiply(5, 10);
Console.WriteLine(multipliedNumber);

EventExamples eventExamples = new EventExamples();
eventExamples.Event += EventExamples.EventHandler;
eventExamples.CallEvent(5);

