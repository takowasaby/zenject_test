using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using Zenject;


public interface IPlayer
{
    void SubscribeInput();
}

public class PlayerBehaviour : MonoBehaviour, IPlayer
{
    public void SubscribeInput()
    {
        var everyFrame = Observable.EveryFixedUpdate().Select(_ => Unit.Default);

        everyFrame
            .Where(_ => Input.GetKey(KeyCode.RightArrow))
            .Subscribe(_ => base.transform.position = base.transform.position + new Vector3(0.1f, 0f, 0f));

        everyFrame
            .Where(_ => Input.GetKey(KeyCode.LeftArrow))
            .Subscribe(_ => base.transform.position = base.transform.position + new Vector3(-0.1f, 0f, 0f));
    }
}
