using System;
using System.Linq;
using System.Text;
using Entitas;
using Gladiators.Common;
using Gladiators.Common.Entity;
using Gladiators.Gameplay.Buildings;
using UnityEngine;

// ReSharper disable once CheckNamespace
public sealed partial class GameEntity : INamedEntity
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
                    case nameof(Building):
                        return PrintBuilding();
                }
            }
        }
        catch (Exception exception)
        {
            Debug.LogError(exception.Message);
        }

        return components.First().GetType().Name;
    }
    
    private string PrintBuilding()
    {
        return new StringBuilder()
            .With(s => s.Append($"Id: {Id} "), when: hasId)
            .Append("Building ")
            .With(s => s.Append($"Type: {BuildingTypeId} "), when: hasBuildingTypeId)
            .ToString();
    }

    public string BaseToString() => base.ToString();
}