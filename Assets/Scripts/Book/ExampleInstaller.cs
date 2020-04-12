using System.Collections.Generic;
using UnityEngine;
using Zenject;

public class ExampleInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        this.Container.BindInstance(10).AsCached();
        this.Container.BindInterfacesAndSelfTo<FooBar>().AsCached();
        this.Container.Bind<List<IFoo>>().FromNew().AsCached();
    }
}