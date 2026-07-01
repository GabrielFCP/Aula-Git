using Godot;
using System;

public partial class PatoScripts : Node2D
{

	/// <summary>
	/// fazendo umas variaveis aleatórias
	/// </summary>
	/// 
	[Export]
	RigidBody2D PatoRb;
	private float vida = 100.0f;
	[Export]
	public float dano = 50.0f;
	public bool PatoIsAlive = true;

	Vector2 input;
	// Called when the node enters the scene tree for the first time.
	public override void _Ready()
	{
	}

	// Called every frame. 'delta' is the elapsed time since the previous frame.
	public override void _Process(double delta)
	{
		GetInput();
	}

	private void GetInput()
	{
		Vector2 Tempinput = Input.GetVector("Esquerda", "Direita", "Cima", "Baixo");
		Vector2 input = new Vector2 (Tempinput.X * 2, 0).Normalized();
	}

	private void PrintFunction()
	{
		GD.Print("Teste conflito");
		
	}

}
