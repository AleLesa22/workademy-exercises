namespace Workademy_Exercises
{
    public class FirstNonRepeatedCharacter
    {
        public static int Test(string str)
        {
            List<char> listOfChars = new List<char>();
            int counter = 0;
            foreach (char c in str)
            {
                listOfChars.Add(c);
            }
            for (int i = 0; i < str.Length; i++)
            {
                for (int j = 0; j < listOfChars.Count; j++)
                {
                    if (str[i] == str[j])
                    {
                        counter++;
                    }
                }
                if (counter < 2)
                {
                    return i;
                    break;
                }
                else
                {
                    counter = 0;
                }
            }
            return -1;
        }
    }
}
