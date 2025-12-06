using System;
using System.Diagnostics;
using System.Threading;

Color color = Color.Red;
const int cycles = 6;

for (int i = 0; i < cycles; i++)
{
    Action action = GetAction(color);
    Console.WriteLine($"Color: {ColorOutput(color)}");
    Thread.Sleep(1000);
    Console.WriteLine($"Action: {ActionOutput(action)}");
    Thread.Sleep(3000);
    color = NextColor(color);
}

static Action GetAction(Color c)
    {
        switch (c)
        {
            case Color.Red:
            {
                return Action.Stop;
            }
            case Color.Yellow:
            {
                return Action.Prepare;
            }
            case Color.Green:
            {
                return Action.Go;
            }
            default:
            {
                Debug.Fail("No such color");
                return Action.Stop;
            }
        }
    }

static Color NextColor(Color c)
    {
        int nextcolor = ((int)c + 1) % (int)Color.Count;
        return (Color)nextcolor; 
    }

static string ColorOutput(Color c)
    {
        switch (c)
        {
            case Color.Red:
            {
                return "Red";
            }
            case Color.Yellow:
            {
                return "Yellow";
            }
            case Color.Green:
            {
                return "Green";
            }
            default:
            {
                Debug.Fail("No such color");
                return "";
            }
        }
    }

static string ActionOutput(Action act)
    {
        switch (act)
        {
            case Action.Stop:
            {
                return "Stop";
            }
            case Action.Prepare:
            {
                return "Prepare";
            }
            case Action.Go:
            {
                return "Go";
            }
            default:
            {
                Debug.Fail("No such action");
                return "";
            }
        }
    }

enum Color 
{
    Red,
    Yellow,
    Green,
    Count
}

enum Action
{
    Stop,
    Prepare,
    Go
}