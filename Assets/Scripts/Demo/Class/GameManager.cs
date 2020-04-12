using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class GameManager : IInitializable
{
    private IBall ball;
    private IPlayer player;

    public GameManager(IBall ball, IPlayer player)
    {
        this.ball = ball;
        this.player = player;
    }

    public void Initialize()
    {
        this.ball.StartMove();
        this.player.SubscribeInput();
    }
}
