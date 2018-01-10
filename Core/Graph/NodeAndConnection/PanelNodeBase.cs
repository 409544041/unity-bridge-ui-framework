﻿using UnityEngine;
using UnityEngine.Events;
using NodeGraph.DataModel;
using NodeGraph;
using System;
using BridgeUI.Model;
using BridgeUI;

public abstract class PanelNodeBase : Node, IPanelInfoHolder
{
    public string description;
    public NodeInfo nodeInfo = new NodeInfo();
    public NodeInfo Info
    {
        get
        {
            return nodeInfo;
        }
    }
}