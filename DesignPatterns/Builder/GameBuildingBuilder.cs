﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class GameBuildingBuilder
    {
        protected readonly GameBuilding building; //if need an inner (nested builder, look here https://dev.to/alialp/builder-design-pattern-for-objects-with-nested-properties-5g3c)
        public GameBuildingBuilder()
        {
            this.building = new GameBuilding();
        }
        public virtual GameBuildingBuilder BuildingType(GameBuildingType type)
        {
            this.building.BuildingType = type;
            return this;
        }
        public virtual GameBuildingBuilder HitPoints(int hitPoints)
        {
            this.building.HitPoints = hitPoints;
            return this;
        }
        public virtual GameBuildingBuilder AttackPoints(int attackPoints)
        {
            this.building.AttackPoints = attackPoints;
            return this;
        }
        public virtual GameBuildingBuilder Range(int range)
        {
            this.building.Range = range;
            return this;
        }
        public virtual GameBuildingBuilder PeopleInsideCapacity(int peopleCapacity)
        {
            this.building.PeopleInsideCapacity = peopleCapacity;
            return this;
        }
        public string Build()
        {            
            return this.ToString();
        }
        public override string ToString()
        {
            var str = $"Building type: {building.BuildingType.ToString()} " +
                $"HitPoints: {building.HitPoints} " +
                $"AttackPoints: {building.AttackPoints} " +
                $"Range: {building.Range} " +
                $"Maximum Inhabitants: {building.PeopleInsideCapacity}";
            return str;
        }
    }
}