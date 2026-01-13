namespace AlertService
{
    /// <summary>
    /// Alert data access.
    /// </summary>
    public interface IAlertDao
    {
        /// <summary>
        /// Add a new alert.
        /// </summary>
        /// <param name="time">The time this alert occurred.</param>
        /// <returns>The identifier of the new alert.</returns>
        /// <remarks>We are expecting the time to be UTC here.</remarks>
        Guid AddAlert(DateTime time);

        /// <summary>
        /// Get the time an alert occurred.
        /// </summary>
        /// <param name="identifier">Identifier of the alert.</param>
        /// <returns>The time an alert occurred.</returns>
        DateTime GetAlert(Guid identifier);
    }
}
