﻿namespace Rocket.API.Scheduler
{
    /// <summary>
    ///     Defines when and how an action should be executed.
    /// </summary>
    public enum ExecutionTargetContext
    {
        /// <summary>
        ///     Executes the action on the next frame update in the main thread.
        /// </summary>
        NextFrame,

        /// <summary>
        ///     Executes the action on the next frame update in a separate thread.
        /// </summary>
        NextAsyncFrame,

        /// <summary>
        ///     Executes the action on the next physic update.
        /// </summary>
        NextPhysicsUpdate,

        /// <summary>
        ///     Executes the action on the current thread (will block current thread).
        /// </summary>
        Sync,

        /// <summary>
        ///     Executes the action on every frame update continuously in the main thread.
        /// </summary>
        EveryFrame,

        /// <summary>
        ///     Executes the action on every frame update continuously in a separate thread.
        /// </summary>
        EveryAsyncFrame,

        /// <summary>
        ///     Executes the action on every physics update continuously.
        /// </summary>
        EveryPhysicsUpdate
    }
}