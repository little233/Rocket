﻿namespace Rocket.API.Commands
{
    /// <summary>
    ///     Defines a user friendly exception.
    /// </summary>
    public interface ICommandFriendlyException
    {
        /// <summary>
        ///     Sends the error message to the command caller of the command context.
        /// </summary>
        /// <param name="context">The related command context.</param>
        void SendErrorMessage(ICommandContext context);
    }
}