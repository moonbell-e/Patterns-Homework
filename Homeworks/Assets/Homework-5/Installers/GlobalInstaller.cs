using System;
using UnityEngine;
using Zenject;

public class GlobalInstaller : MonoInstaller
{
    private const string CoroutinePerformerPath = "CoroutinePerformer";

    public override void InstallBindings()
    {
        BindCoroutinePerformer();
    }
    
    private void BindCoroutinePerformer()
    {
        Container
            .Bind<ICoroutinePerformer>()
            .To<CoroutinePerformer>()
            .FromComponentInNewPrefabResource(CoroutinePerformerPath)
            .AsSingle()
            .NonLazy();
    }
}
