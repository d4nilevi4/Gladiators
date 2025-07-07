using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Buildings
{
    public class BuildingTypeIdRegistrar : EntityComponentRegistrar
    {
        public BuildingTypeIdMarker BuildingTypeIdMarker;
        
        public override void RegisterComponents()
        {
            Entity.AddBuildingTypeId(BuildingTypeIdMarker.BuildingTypeId);
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasBuildingTypeId)
                Entity.RemoveBuildingTypeId();
        }
    }
}