namespace AlertService
{
    /// <summary>
    /// Alert data access.
    /// </summary>
    public class AlertDao
    {
        /// <summary>
        /// Expecting the DateTime to be UTC here, simpler to store everything as UTC.
        /// </summary>
        private readonly Dictionary<Guid, DateTime> alerts = [];

        /// <summary>
        /// Add a new alert.
        /// </summary>
        /// <param name="time">The time this alert occurred.</param>
        /// <returns>The identifier of the new alert.</returns>
        /// <remarks>We are expecting the time to be UTC here.</remarks>
        public Guid AddAlert(DateTime time)
        {
            var identifier = Guid.NewGuid();
            alerts.Add(identifier, time);
            return identifier;
        }

        /// <summary>
        /// Get the time an alert occurred.
        /// </summary>
        /// <param name="identifier">Identifier of the alert.</param>
        /// <returns>The time an alert occurred.</returns>
        public DateTime GetAlert(Guid identifier)
        {
            return alerts[identifier];
        }
    }
}
