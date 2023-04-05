
  Thread[] thread = new Thread[10];

  int evenNum = 0;
  int oddNum = 0;
  object lockObj = new object();

for (int i = 0; i < thread.Length; i++)
{
    thread[i] = new Thread(GenerateNumbers);
    thread[i].Start();
}

for (int i = 0; i < thread.Length; i++)
{
    thread[i].Join();
}
Console.WriteLine($"Even num: {evenNum}");
Console.WriteLine($"Odd num: {oddNum}");

void GenerateNumbers()
{
    Random random = new Random();

    for (int i = 0; i < 100; i++)
    {
        int numbers = random.Next(1, 101);
        lock (lockObj)
        {
            if (numbers % 2 == 0)
            {
                evenNum++;
            }
            else
            {
                oddNum++;
            }
        }
    }
   
}



