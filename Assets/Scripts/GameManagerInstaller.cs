using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using Zenject;

public class GameManagerInstaller : MonoInstaller
{
    [SerializeField]private UnitSpawn _unitSpawn;
    
    public override void InstallBindings()
    {
        Container.Bind<UnitSpawn>().FromInstance(_unitSpawn).AsSingle().NonLazy();
        Container.QueueForInject(_unitSpawn);
    }
}
