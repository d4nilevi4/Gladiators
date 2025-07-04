﻿using System;
using System.Linq;
using Entitas;
using Gladiators.Common.Entity;
using Gladiators.Gameplay.Input;
using UnityEngine;

// ReSharper disable once CheckNamespace
public sealed partial class InputEntity : INamedEntity
{
    private EntityPrinter _printer;

    public override string ToString()
    {
        if (_printer == null)
            _printer = new EntityPrinter(this);

        _printer.InvalidateCache();

        return _printer.BuildToString();
    }

    public string EntityName(IComponent[] components)
    {
        try
        {
            if (components.Length == 1)
                return components[0].GetType().Name;

            foreach (IComponent component in components)
            {
                switch (component.GetType().Name)
                {
                    case nameof(WorldInput): 
                        return nameof(WorldInput);
                    case nameof(CameraRelativeInput): 
                        return nameof(CameraRelativeInput);
                }
            }
        }
        catch (Exception exception)
        {
            Debug.LogError(exception.Message);
        }

        return components.First().GetType().Name;
    }

    public string BaseToString() => base.ToString();
}