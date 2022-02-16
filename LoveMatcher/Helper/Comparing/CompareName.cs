namespace LoveMatcher.Helper.Comparing
{
    public class CompareName
    {
        //skillnad p� l�ngd
        /// <summary>
        /// Calculates the difference between lenght of the names
        /// </summary>
        public int Length(string name)
        {
            var nameLength = name.Length;
            return nameLength;
        }

        //�r l�ngderna udda eller j�mna
        /// <summary>
        /// Checks if lenght of the name is even or not
        /// </summary>
        /// <returns></returns>
        public object LengthIsEven(string name)
        {
            var nameLength = name.Length;
            if (nameLength % 2 == 0) return true;
            else return false;
        }

        //skillnad i m�ngd vokaler
        /// <summary>
        /// Checks the number of vowels in the name.
        /// </summary>
        /// <returns>The amount of vowels.</returns>
        public int NumberOfVowels(string name)
        {
            var vowels = new char[] { 'a', 'e', 'i', 'o', 'u' };
            int vowelSum = name.Count(c => vowels.Contains(c));
            return vowelSum;
        }

        //skillnad i m�ngd konsonanter
        /// <summary>
        /// Checks the number of consonants in the name.
        /// </summary>
        /// <returns>The amount of consonants.</returns>
        public int NumberOfConsonants(string name)
        {
            var consonants = new char[] { 'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'y', 'z'};
            int consonantSum = name.Count(c => consonants.Contains(c));
            return consonantSum;
        }

        //Skillnad i m�ngd dubbla bokst�ver
        /// <summary>
        /// Checks how many same letters the names have.
        /// </summary>
        /// <returns></returns>
        public int NumberOfSameLetters()
        {
            return 0;
        }
    }
}