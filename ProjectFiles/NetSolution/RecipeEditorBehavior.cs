#region Using directives
using System;
using UAManagedCore;
using OpcUa = UAManagedCore.OpcUa;
using FTOptix.UI;
using FTOptix.HMIProject;
using FTOptix.EventLogger;
using FTOptix.WebUI;
using FTOptix.NativeUI;
using FTOptix.Alarm;
using FTOptix.DataLogger;
using FTOptix.SQLiteStore;
using FTOptix.Store;
using FTOptix.InfluxDBStoreLocal;
using FTOptix.Report;
using FTOptix.Retentivity;
using FTOptix.CoreBase;
using FTOptix.NetLogic;
using FTOptix.InfluxDBStore;
using FTOptix.SerialPort;
using FTOptix.Core;
using FTOptix.RecipeX;
using FTOptix.Recipe;
#endregion

[CustomBehavior]
public class RecipeEditorBehavior : BaseNetBehavior
{
    public override void Start()
    {
        // Insert code to be executed when the user-defined behavior is started
    }

    public override void Stop()
    {
        // Insert code to be executed when the user-defined behavior is stopped
    }

#region Auto-generated code, do not edit!
    protected new RecipeEditor Node => (RecipeEditor)base.Node;
#endregion
}
