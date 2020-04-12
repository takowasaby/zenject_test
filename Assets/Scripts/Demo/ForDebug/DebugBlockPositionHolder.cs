using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugBlockPositionHolder : IBlockPositionHolder
{
    public IEnumerable<Vector3> GetPositions() => new Vector3[] { Vector3.zero };
}
