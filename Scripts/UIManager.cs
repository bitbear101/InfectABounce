using Godot;
using System;
using EventCallback;

public class UIManager : Control
{
    // Declare member variables here. Examples:
    // private int a = 2;
    // private string b = "text";

    // Called when the node enters the scene tree for the first time.
    public override void _Ready()
    {
    }

    public void StartPressed()
    {
        UIInputEvent uiiei = new UIInputEvent();
        uiiei.startPressed = true;
    }

    public void ExitPressed()
    {
        GetTree().Quit();
    }

    //  // Called every frame. 'delta' is the elapsed time since the previous frame.
    //  public override void _Process(float delta)
    //  {
    //      
    //  }
}
