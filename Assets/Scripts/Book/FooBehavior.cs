using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class FooBehavior : MonoBehaviour
{
    private IFoo foo;
    private int i;
    private List<IFoo> foos;

    [Inject]
    public void Construct(IFoo foo, int i, List<IFoo> foos)
    {
        this.foo = foo;
        this.i = i;
        this.foos = foos;

        print(this.foo);
        print(this.i);

        foreach (var foosElem in foos)
        {
            print(foosElem);
        }
    }
}
