using Gladiators.Infrastructure;

namespace Gladiators.Gameplay.Buildings
{
    public class BuildingTypeIdRegistrar : EntityComponentRegistrar
    {
        public BuildingTypeIdMarker BuildingTypeIdMarker;
        
        public override void RegisterComponents()
        {
            Entity.isBuilding = true;
            Entity.AddBuildingTypeId(BuildingTypeIdMarker.BuildingTypeId);
            Entity.isInteractable = true;
            Entity.isShowBuildingWindowInteractable = true;
        }

        public override void UnregisterComponents()
        {
            if (Entity.hasBuildingTypeId)
                Entity.RemoveBuildingTypeId();
            Entity.isBuilding = false;
            Entity.isInteractable = true;
            Entity.isShowBuildingWindowInteractable = true;
        }
    }
}