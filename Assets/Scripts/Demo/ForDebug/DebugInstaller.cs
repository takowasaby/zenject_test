using UnityEngine;
using Zenject;

public class DebugInstaller : MonoInstaller
{
    public DebugBallBehaviour ballPrefab; // Debug
    public PlayerBehaviour playerPrefab;
    public BlockBehavior blockBehavior;

    public override void InstallBindings()
    {
        base.Container.Bind<IInitializable>().To<GameManager>().AsSingle();
        base.Container.Bind<IBall>().To<DebugBallBehaviour>().FromComponentInNewPrefab(this.ballPrefab.gameObject).AsSingle(); // Debug
        base.Container.Bind<IPlayer>().To<PlayerBehaviour>().FromComponentInNewPrefab(this.playerPrefab.gameObject).AsSingle();

        base.Container.Bind<BlockBehavior>().FromInstance(this.blockBehavior).AsSingle();
        base.Container.Bind<IBlockGenerator>().To<BlockGenerator>().AsSingle();
        base.Container.Bind<IBlockManager>().To<BlockManager>().AsSingle();
        base.Container.Bind<IBlockPositionHolder>().To<DebugBlockPositionHolder>().AsSingle(); // Debug
        base.Container.Bind<IBlockSpawner>().To<BlockSpawner>().AsSingle();
    }
}