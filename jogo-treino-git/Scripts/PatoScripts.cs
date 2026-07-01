using Godot;
using System;

public partial class PatoScripts : Node2D
{
	[Export]
	RigidBody2D Rb;
	[Export]
	Sprite2D SpritePato;
	double FlickTime;
	Vector2 input;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		FlickTime += delta;

		GetInput();

		if(FlickTime >= 2)
		{
			TweeeeeeeeenFlick();
			FlickTime = 0;
			GD.Print("Flick!");
		}
	}

    public override void _PhysicsProcess(double delta)
    {
    }


	private void GetInput()
	{
		Vector2 Tempinput = Input.GetVector("Esquerda", "Direita", "Cima", "Baixo");
		Vector2 input = new Vector2 (Tempinput.X * 2, 0).Normalized();
	}

	private void TweeeeeeeeenFlick()
	{
		Tween tween = CreateTween();
		tween.SetLoops(4);

		tween.TweenProperty(SpritePato, "modulate:a", 0.2f, 0.1f);
		tween.TweenProperty(SpritePato, "modulate:a", 1f, 0.1f);
	}

}
