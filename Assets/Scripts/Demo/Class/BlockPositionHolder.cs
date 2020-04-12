using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockPositionHolder
{
    IEnumerable<Vector3> GetPositions();
}

public class BlockPositionHolder : IBlockPositionHolder
{
    public IEnumerable<Vector3> GetPositions()
    {
        for (var i = -1; i < 2; i++)
        {
            for (var j = -1; j < 2; j++)
            {
                yield return new Vector3(i * 3f, 0f, j * 2f + 1);
            }
        }
    }
}
