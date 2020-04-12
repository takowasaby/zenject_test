using UnityEngine;
using Zenject;

public class DecoratorInstaller : MonoInstaller
{
    public override void InstallBindings()
    {
        this.Container.BindInterfacesAndSelfTo<Foo>().AsCached();
    }
}