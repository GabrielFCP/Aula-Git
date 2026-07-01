using Godot;
using System;

public partial class PatoScripts : Node
{
	/// <summary>
	/// fazendo umas variaveis aleatórias
	/// </summary>
	/// 
	[Export]
	RigidBody2D PatoTemRb;
	[Export]
	Sprite2D SpritePatoAlterado;
	[Export]
	float vida = 100.0f;
	[Export]
	float dano = 50.0f;
	[Export]
	float walkspeed = 50;
	public bool PatoIsAlive {get; private set;} = true;
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

		if(FlickTime >= 1)
		{
			HitFlick();
			FlickTime = 0;
		}
	}

    public override void _PhysicsProcess(double delta)
	{
		PatoTemRb.ApplyCentralForce(input * walkspeed);
	}


	private void GetInput()
	{
		Vector2 Tempinput = Input.GetVector("Esquerda", "Direita", "Cima", "Baixo");
		Vector2 input = new Vector2 (Tempinput.X * 2, 0).Normalized();
	}

	private void HitFlick()
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
