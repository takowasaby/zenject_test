using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IBlockManager
{
    int AddAndGetID();
    void RemoveByID(int id);
}

public class BlockManager : IBlockManager
{
    private int idCount;
    private HashSet<int> existBlockIDs;

    public BlockManager()
    {
        this.idCount = 0;
        this.existBlockIDs = new HashSet<int>();
    }

    public int AddAndGetID()
    {
        var newID = this.idCount++;
        this.existBlockIDs.Add(newID);
        return newID;
    }
    public void RemoveByID(int id)
    {
        if (this.existBlockIDs.Contains(id))
        {
            this.existBlockIDs.Remove(id);
        }
    }
}
