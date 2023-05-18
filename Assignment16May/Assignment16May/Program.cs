using Assignment16May;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Let's start Thread");

        var test = new TestThread();

        //create a thread
        Thread testThread = new Thread(new ThreadStart(test.TestTime));

        //start thread
        testThread.Start();


        //another thread for priority
        Thread testThread2 = new Thread(test.TestLoop);
        testThread2.Start();
        //thread name
        testThread2.Name = "AnotherThread";
        testThread2.Priority = ThreadPriority.AboveNormal;

        //thread status
        while(testThread2.ThreadState == ThreadState.Running)
        {
            Console.WriteLine("Running!");
        }


        //WeightLifting Problem
        var weightLift = new DoWeightLifting();

        Task t = new Task( () => weightLift.MinimumWeight());
        t.Start();
    }
}