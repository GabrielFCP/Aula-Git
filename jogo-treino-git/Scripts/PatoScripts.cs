using Godot;
using System;

public partial class PatoScripts : Node
{
	/// <summary>
	/// fazendo umas variaveis aleatórias
	/// </summary>
	/// 
	[Export]
	RigidBody2D PatoRbAlterado;
	[Export]
	Sprite2D SpritePatoAlterado;
	[Export]
	private float vida = 50.0f;
	[Export]
	public float dano = 1000000.0f;
	public bool PatoIsAlive = true;
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

		tween.TweenProperty(SpritePatoAlterado, "modulate:a", 0.2f, 0.1f);
		tween.TweenProperty(SpritePatoAlterado, "modulate:a", 1f, 0.1f);
	}
	private void PrintFunction()
	{
		GD.Print("Teste conflito");
		
	}

}
