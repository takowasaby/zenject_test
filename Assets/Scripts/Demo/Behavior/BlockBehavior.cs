using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BlockBehavior : MonoBehaviour, IInitializable
{
    private IBlockManager blockManager;
    private BallBehaviour ball;

    private int blockID;

    [Inject]
    public void Construct(IBlockManager blockManager, BallBehaviour ball)
    {
        this.blockManager = blockManager;
        this.ball = ball;
    }

    public void Initialize()
    {
        this.blockID = this.blockManager.AddAndGetID();
    }

    void Start()
    {
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.GetInstanceID() == this.ball.GetInstanceID())
        {
            this.blockManager.RemoveByID(this.blockID);
            Destroy(base.gameObject);
        }
    }
}
