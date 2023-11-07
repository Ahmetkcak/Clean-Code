
using System;

// Originator class
class Editor
{
    private string _content;

    public EditorState CreateState()
    {
        return new EditorState(_content);
    }

    public void Restore(EditorState state)
    {
        _content = state.GetContent();
    }

    public string GetContent()
    {
        return _content;
    }

    public void SetContent(string content)
    {
        _content = content;
    }
}

// Memento class
class EditorState
{
    private readonly string _content;

    public EditorState(string content)
    {
        _content = content;
    }

    public string GetContent()
    {
        return _content;
    }
}

// Caretaker class
class History
{
    private readonly Editor _editor;
    private readonly List<EditorState> _states = new List<EditorState>();

    public History(Editor editor)
    {
        _editor = editor;
    }

    public void Push(EditorState state)
    {
        _states.Add(state);
    }

    public EditorState Pop()
    {
        var lastIndex = _states.Count - 1;
        var lastState = _states[lastIndex];
        _states.RemoveAt(lastIndex);

        return lastState;
    }
}

// Client code
// class Program
// {
//     static void Main(string[] args)
//     {
//         var editor = new Editor();
//         var history = new History(editor);

//         editor.SetContent("a");
//         history.Push(editor.CreateState());

//         editor.SetContent("b");
//         history.Push(editor.CreateState());

//         editor.SetContent("c");
//         history.Push(editor.CreateState());

//         editor.Restore(history.Pop());
//         Console.WriteLine(editor.GetContent());

//         editor.Restore(history.Pop());
//         Console.WriteLine(editor.GetContent());

//         editor.Restore(history.Pop());
//         Console.WriteLine(editor.GetContent());
//     }
// }
