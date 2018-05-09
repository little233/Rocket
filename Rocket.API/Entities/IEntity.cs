﻿namespace Rocket.API.Entities
{
    /// <summary>
    ///     A game entitiy. Players, Monsters, Animals, Vehicles, Zombies, etc...
    /// </summary>
    public interface IEntity
    {
        /// <summary>
        ///     The type name of the entitiy. "Zombie", "Player", "Animal", etc...
        /// </summary>
        string EntityTypeName { get; }
    }
}