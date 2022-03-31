//Default file. MAKE SURE TO CHANGE THIS LOCATION AND FILE PATH TO YOUR FILE   
try
{
    // Create an instance of StreamReader to read from a file.
    // The using statement also closes the StreamReader.
    using (StreamReader sr = new StreamReader("e:/egypt.txt"))
    {
        string line;

        // Read and display lines from the file until 
        // the end of the file is reached. 
        while ((line = sr.ReadLine()) != null)
        {
            //Console.WriteLine(line);
            string[] words = line.Split(" ");
            if (words.Length != 3)
            {
                Console.WriteLine("Incompatible Format");
                break;
            }
            int[] nums = Array.ConvertAll(words, int.Parse);
            if (nums[0] == 0 && nums[1] == 0 && nums[2] == 0)
            {
                break;
            }
            Boolean isRight = (Math.Pow(nums[0], 2) + Math.Pow(nums[1], 2) == Math.Pow(nums[2], 2)); 
            if (isRight)
                Console.WriteLine("right");
            else
                Console.WriteLine("wrong");

        }
    }
}
catch (Exception e)
{
    // Let the user know what went wrong.
    Console.WriteLine("The file could not be read:");
    Console.WriteLine(e.Message);
}


