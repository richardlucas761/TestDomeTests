namespace GamePlatform
{
    /// <summary>
    /// A class to implement a game platform.
    /// </summary>
    public static class GamePlatform
    {
        private const int ValidInclinations = 90;

        /// <summary>
        /// A method to calculate a final speed based on an initial speed and increases or decreases in speed due to inclination
        /// or declination.
        /// </summary>
        /// <param name="initialSpeed">Initial character speed</param>
        /// <param name="inclinations">An array of inclinations</param>
        /// <returns>A final speed.</returns>
        public static double CalculateFinalSpeed(double initialSpeed, int[] inclinations) // TODO int is a poor choice here for values in the range 0..90
        {
            ValidateInclinations(inclinations);

            var currentSpeed = initialSpeed;

            foreach (int inclination in inclinations)
            {
                currentSpeed += inclination;

                if (currentSpeed <= 0)
                {
                    // The character has lost a life due to the speed being below 0
                    return 0;
                }
            }

            return currentSpeed;
        }

        private static void ValidateInclinations(int[] inclinations)
        {
            if (inclinations.Length == 0)
            {
                return;
            }

            foreach (int inclination in inclinations)
            {
                if (inclination >= ValidInclinations || inclination <= -ValidInclinations)
                {
                    throw new ArgumentOutOfRangeException(nameof(inclinations));
                }
            }
        }
    }
}