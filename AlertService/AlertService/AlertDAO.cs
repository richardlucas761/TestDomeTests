namespace AlertService
{
    /// <summary>
    /// Alert data access.
    /// </summary>
    public class AlertDao : IAlertDao
    {
        /// <summary>
        /// Expecting the DateTime to be UTC here, simpler to store everything as UTC.
        /// </summary>
        private readonly Dictionary<Guid, DateTime> alerts = [];

        /// <inheritdoc/>
        public Guid AddAlert(DateTime time)
        {
            var identifier = Guid.NewGuid();
            alerts.Add(identifier, time);
            return identifier;
        }

        /// <inheritdoc/>
        public DateTime GetAlert(Guid identifier)
        {
            return alerts[identifier];
        }
    }
}
