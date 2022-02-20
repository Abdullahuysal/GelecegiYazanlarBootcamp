namespace SingleResponsibilityPrinciple
{
    public class Worker
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public WorkerType Type { get; set; }
       
    }
    public class Cooker : Worker
    {
        public Experience ExperienceLevel { get; set; }
    }
    public class Mechanic : Worker
    {
        public int RepairTime { get; set; }
    } 
    public class Cleaner : Worker
    {
        public Cleaningdegrees Cleaningdegree { get; set; }
    }
    public enum Experience
    {
        Beginner,
        Intermediate,
        Expert,
    }
    public enum Cleaningdegrees
    {
        Verygood,
        Good,
        NotBad,
        Bad,
        Terrible
    }
    public enum WorkerType
    {
        Cooker,
        Mechanic,
        Cleaner
    }
   
}
