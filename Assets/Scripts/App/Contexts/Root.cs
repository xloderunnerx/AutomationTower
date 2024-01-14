using App.Features.Floor;
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
        BindFeature<FloorFeature>();
    }

    private void OnDestroy()
    {
        OnDestroyControllers();
    }
}
