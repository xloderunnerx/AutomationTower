using App.Features.Testing;
using App.Features.TouchRaycast;
using App.Features.Tower;
using Composite.Core;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Root : AbstractCompositionRoot
{
    private void Awake()
    {
        BindConfigurations(); 
        BindSignalBus(); 
        BindFeatures(); 
    }

    private void Start()
    {
        DeclareSignals();
        SubscribeToSignals(); 
        InitializeControllers();
    }

    private void Update()
    {
        UpdateControllers();
    }

    public void BindFeatures()
    {
        BindFeature<TestingFeature>();
        BindFeature<TouchRaycastFeature>();
        BindFeature<TowerFeature>();
    }

    private void OnDestroy()
    {
        OnDestroyControllers();
    }
}
