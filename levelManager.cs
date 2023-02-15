using Godot;
using System;

public class LevelManager : Node2D {
    [Export] private PackedScene _enemyAsset;

    private Path2D _path;
    
    public override void _Ready() {
        _path = GetNode<Path2D>("Path2D");
    }

    private void _OnEnemySpawn() {
        Node enemy = _enemyAsset.Instance();
        _path.AddChild(enemy);
    }
}