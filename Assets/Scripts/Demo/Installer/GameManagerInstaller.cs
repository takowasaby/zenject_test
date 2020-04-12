using UnityEngine;
using Zenject;

public class GameManagerInstaller : MonoInstaller
{
    public BallBehaviour ballPrefab;
    public PlayerBehaviour playerPrefab;

    public override void InstallBindings()
    {
        base.Container.Bind<IInitializable>().To<GameManager>().AsSingle();
        base.Container.Bind<IBall>().To<BallBehaviour>().FromComponentInNewPrefab(this.ballPrefab.gameObject).AsSingle();
        base.Container.Bind<IPlayer>().To<PlayerBehaviour>().FromComponentInNewPrefab(this.playerPrefab.gameObject).AsSingle();
    }
}