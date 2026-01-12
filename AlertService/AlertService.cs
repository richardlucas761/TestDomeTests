namespace AlertService
{
    /// <summary>
    /// Service for alert related operations.
    /// </summary>
    public class AlertService
    {
        private readonly AlertDao storage = new();

        /// <summary>
        /// Raise an alert.
        /// </summary>
        /// <returns>GUID identifier of a new alert.</returns>
        public Guid RaiseAlert()
        {
            return storage.AddAlert(DateTime.UtcNow);
        }

        /// <summary>
        /// Get the time an alert was raised.
        /// </summary>
        /// <param name="identifier">Identifier of the alert.</param>
        /// <returns>The time an alert was raised.</returns>
        public DateTime GetAlertTime(Guid identifier)
        {
            return storage.GetAlert(identifier);
        }
    }
}
