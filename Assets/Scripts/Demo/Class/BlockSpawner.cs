using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockSpawner
{
    void Spawn();
}

public class BlockSpawner : IBlockSpawner
{
    private IBlockGenerator blockGenerator; 
    private IBlockPositionHolder positionHolder;

    public BlockSpawner(IBlockGenerator blockGenerator, IBlockPositionHolder positionHolder)
    {
        this.blockGenerator = blockGenerator;
        this.positionHolder = positionHolder;
    }

    public void Spawn()
    {
        foreach (var position in this.positionHolder.GetPositions())
        {
            this.blockGenerator.Generate(position);
        }
    }
}
