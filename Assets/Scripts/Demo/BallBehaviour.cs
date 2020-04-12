using System.Collections;
using System.Collections.Generic;
using UniRx;
using UnityEngine;
using Zenject;

public class BallBehaviour : MonoBehaviour, IInitializable
{
    private Vector3 velocity;

    public void Initialize()
    {
        this.velocity = new Vector3(0.1f, 0f, 0.1f);

        var everyFrame = Observable.EveryFixedUpdate().Select(_ => Unit.Default);

        everyFrame.Subscribe(_ => base.transform.position = base.transform.position + this.velocity);
    }

    private void Start()
    {
        this.Initialize();
    }

    private void OnCollisionEnter(Collision collision)
    {
        var contactPoint = collision.contacts[0];
        var contctNorm = contactPoint.normal.normalized;
        this.velocity = this.velocity - 2 * Vector3.Dot(this.velocity, contctNorm) * contctNorm;
    }
}
