using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class BarBehavior : MonoBehaviour
{
    public FooBehavior fooBehavior;

    [Inject]
    public void Construct(FooBehavior fooBehavior)
    {
        this.fooBehavior = fooBehavior;
    }
}
