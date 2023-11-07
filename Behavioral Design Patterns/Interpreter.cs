
using System;
using System.Collections.Generic;

// Context sınıfı, yorumlanacak ifadeyi içerir.
public class Contexts
{
    private string _expression;
    private int _result;

    public Contexts(string expression)
    {
        _expression = expression;
    }

    public string Expression
    {
        get { return _expression; }
        set { _expression = value; }
    }

    public int Result
    {
        get { return _result; }
        set { _result = value; }
    }
}

// AbstractExpression sınıfı, yorumlanacak ifade için bir arayüz sağlar.
abstract class AbstractExpression
{
    public abstract void Interpret(Contexts contexts);
}

// TerminalExpression sınıfı, yorumlanacak ifade için bir terminal ifade sağlar.
class TerminalExpression : AbstractExpression
{
    private string _name;

    public TerminalExpression(string name)
    {
        _name = name;
    }

    public override void Interpret(Contexts contexts)
    {
        if (contexts.Expression.Contains(_name))
        {
            contexts.Result += 1;
        }
    }
}

// NonterminalExpression sınıfı, yorumlanacak ifade için bir non-terminal ifade sağlar.
class NonterminalExpression : AbstractExpression
{
    private List<AbstractExpression> _expressions = new List<AbstractExpression>();

    public void Add(AbstractExpression expression)
    {
        _expressions.Add(expression);
    }

    public override void Interpret(Contexts contexts)
    {
        foreach (AbstractExpression expression in _expressions)
        {
            expression.Interpret(contexts);
        }
    }
}

// Interpreter sınıfı, yorumlanacak ifadeyi yorumlar.
class Interpreter
{
    private AbstractExpression _expression;

    public Interpreter()
    {
        // Yorumlanacak ifade için bir örnek oluşturun.
        NonterminalExpression expression = new NonterminalExpression();
        expression.Add(new TerminalExpression("A"));
        expression.Add(new TerminalExpression("B"));
        expression.Add(new TerminalExpression("C"));

        // Yorumlanacak ifadeyi ayarlayın.
        _expression = expression;
    }

    public void Interpret(Contexts contexts)
    {
        _expression.Interpret(contexts);
    }
}

// Kullanımı
// class Program
// {
//     static void Main(string[] args)
//     {
//         // Yorumlanacak ifadeyi oluşturun.
//         Contexts contexts = new Contexts("A B C A B D E");

//         // Interpreter sınıfını oluşturun.
//         Interpreter interpreter = new Interpreter();

//         // Yorumlayın.
//         interpreter.Interpret(contexts);

//         // Sonucu yazdırın.
//         Console.WriteLine("Result: " + contexts.Result);
//     }
// }
