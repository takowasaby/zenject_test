using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BlockBehavior : MonoBehaviour
{
    private IBlockManager blockManager;
    private int blockID;

    public void Construct(IBlockManager blockManager)
    {
        this.blockManager = blockManager;
    }

    void Start()
    {
        this.blockID = this.blockManager.AddAndGetID();
    }

    private void OnCollisionEnter(Collision _)
    {
        this.blockManager.RemoveByID(this.blockID);
        Destroy(base.gameObject);
    }
}
