using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManager : IInitializable
{
    private IBall ball;
    private IPlayer player;
    private IBlockSpawner blockSpawner;

    public GameManager(IBall ball, IPlayer player, IBlockSpawner blockSpawner)
    {
        this.ball = ball;
        this.player = player;
        this.blockSpawner = blockSpawner;
    }

    public void Initialize()
    {
        this.blockSpawner.Spawn();
        this.ball.StartMove();
        this.player.SubscribeInput();
    }
}
