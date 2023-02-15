using Godot;
using System;

public class EnemyManager : PathFollow2D {
	private PathFollow2D _pathFollow;

	// enemy parameters
	private float _speed = 1f;

	public override void _Ready() {
		_pathFollow = GetNode<PathFollow2d>(GetPath());
	}

	public override void _Process(float delta) {
		_pathFollow.UnitOffset += delta * _speed * 0.03f;
	}
}

