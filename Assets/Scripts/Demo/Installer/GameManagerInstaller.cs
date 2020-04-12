using UnityEngine;
using Zenject;

public class GameManagerInstaller : MonoInstaller
{
    public BallBehaviour ballPrefab;
    public PlayerBehaviour playerPrefab;
    public BlockBehavior blockBehavior;

    public override void InstallBindings()
    {
        base.Container.Bind<IInitializable>().To<GameManager>().AsSingle();
        base.Container.Bind<IBall>().To<BallBehaviour>().FromComponentInNewPrefab(this.ballPrefab.gameObject).AsSingle();
        base.Container.Bind<IPlayer>().To<PlayerBehaviour>().FromComponentInNewPrefab(this.playerPrefab.gameObject).AsSingle();

        base.Container.Bind<BlockBehavior>().FromInstance(this.blockBehavior).AsSingle();
        base.Container.Bind<IBlockGenerator>().To<BlockGenerator>().AsSingle();
        base.Container.Bind<IBlockManager>().To<BlockManager>().AsSingle();
        base.Container.Bind<IBlockPositionHolder>().To<BlockPositionHolder>().AsSingle();
        base.Container.Bind<IBlockSpawner>().To<BlockSpawner>().AsSingle();
    }
}