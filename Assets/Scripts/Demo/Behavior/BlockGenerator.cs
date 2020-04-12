using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public interface IBlockGenerator
{
    void Generate(Vector3 param);
}

public class BlockGenerator : IBlockGenerator
{
    private IBlockManager blockManager;
    private BlockBehavior blockPrefab;

    public BlockGenerator(IBlockManager blockManager, BlockBehavior blockPrefab)
    {
        this.blockManager = blockManager;
        this.blockPrefab = blockPrefab;
    }

    public void Generate(Vector3 param)
    {
        var blockobj = GameObject.Instantiate(this.blockPrefab.gameObject, param, this.blockPrefab.transform.rotation);
        blockobj.GetComponent<BlockBehavior>().Construct(this.blockManager);
    }
}