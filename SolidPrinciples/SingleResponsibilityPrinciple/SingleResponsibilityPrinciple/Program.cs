using System;
using System.Collections.Generic;

namespace SingleResponsibilityPrinciple
{
    class Program
    {
        public static List<Worker> Workers = new List<Worker>();
        static void Main(string[] args)
        {
            string userAnswer;
            do
            {
              ShowMenu();
               userAnswer = Console.ReadLine();
               directToAction(userAnswer);
            } while (Convert.ToInt32(userAnswer) != 3);
        }

        private static void directToAction(string userAnswer)
        {
            switch (userAnswer)
            {
                case "1":
                    string choose;
                    do
                    {
                        WorkerMenu();
                        
                        choose = Console.ReadLine();
                        switch (Convert.ToInt32(choose))
                        {
                            case 1:
                                GetWorkersInformation(WorkerType.Cooker);
                                break;
                            case 2:
                                GetWorkersInformation(WorkerType.Cleaner);
                                break;
                            case 3:
                                GetWorkersInformation(WorkerType.Mechanic);
                                break;
                            default:
                                break;
                        }
                    } while (Convert.ToInt32(choose)!=4);
                    break;
                case "2":
                    string WorkerName;
                    Console.WriteLine("İş verilecek çalışanın ismini giriniz");
                    WorkerName = Console.ReadLine();
                    Console.WriteLine("Yapmasını istediğiniz iş numarası veriniz(yemek pişirme:1,temizlik:2,tamir:3)");
                    int WorkNumber = Convert.ToInt32(Console.ReadLine());
                    AssignTheWorker(WorkerName,WorkNumber);
                    break;
                default:
                    break;
            }
        }

        private static void AssignTheWorker(string workerName,int WorkNumber)
        {
            Works works = new Works();
            switch (WorkNumber)
            {
                case 1:
                    works.Cook(workerName);
                    break;
                case 2:
                    works.Clean(workerName);
                    break;
                case 3:
                    works.Repair(workerName);
                    break;
                default:
                    break;
            }
        }

        private static void GetWorkersInformation(WorkerType workerType)
        {
            if (workerType == WorkerType.Cooker)
            {
                Cooker cooker = new Cooker();
                Console.WriteLine("Çalışan ismi giriniz");
                cooker.Name = Console.ReadLine();
                Console.WriteLine("Calışan Soyismi giriniz");
                cooker.Surname = Console.ReadLine();
                Console.WriteLine("Çalışanın Yaşını giriniz");
                cooker.Age = Convert.ToInt32(Console.ReadLine());
                cooker.ExperienceLevel = Experience.Beginner;
                Workers.Add(cooker);
            }
            else if (workerType == WorkerType.Cleaner)
            {
                Cleaner cleaner = new Cleaner();
                Console.WriteLine("Çalışan ismi giriniz");
                cleaner.Name = Console.ReadLine();
                Console.WriteLine("Calışan Soyismi giriniz");
                cleaner.Surname = Console.ReadLine();
                Console.WriteLine("Çalışanın Yaşını giriniz");
                cleaner.Age = Convert.ToInt32(Console.ReadLine());
                cleaner.Cleaningdegree = Cleaningdegrees.Verygood;
                Workers.Add(cleaner);
            }
            else if(workerType == WorkerType.Mechanic)
            {
                Mechanic mechanic = new Mechanic();
                Console.WriteLine("Çalışan ismi giriniz");
                mechanic.Name = Console.ReadLine();
                Console.WriteLine("Calışan Soyismi giriniz");
                mechanic.Surname = Console.ReadLine();
                Console.WriteLine("Çalışanın Yaşını giriniz");
                mechanic.Age = Convert.ToInt32(Console.ReadLine());
                mechanic.RepairTime = 50;
                Workers.Add(mechanic);
            }
          
        }

        private static void ShowMenu()
        {
            Console.WriteLine("Yeni Çalışan bilgilerini girmek için : 1 giriniz");
            Console.WriteLine("Çalışana iş vermek için : 2 giriniz");
            Console.WriteLine("Programdan çıkış yapmak için: 3 giriniz");
        }
        private static void WorkerMenu()
        {
            Console.WriteLine("Aşçı bilgilerini girmek için :1");
            Console.WriteLine("Temizlikçi bilgilerini girmek için:2");
            Console.WriteLine("Tamirci bilgilerini girmek için:3");
            Console.WriteLine("Ana menüye dönemk için :4");
        }
    }
}
