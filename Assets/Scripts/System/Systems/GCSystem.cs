using UnityEngine;
using System.Collections;
using System;

/// <summary>
/// Forces the garbage collection to run every x seconds
/// This will prevent any potential GC spikes from happening.
/// </summary>
public class GCSystem : GameSystem
{
    public override void OnLoadSystem()
    {
        
    }

    public override void OnTick()
    {
        GC.Collect();
    }
}