using EntityFrameworkHomeWork.Data;
using EntityFrameworkHomeWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkHomeWork
{
    public class Methods
    {
         CompanyDbContext CompanyDbContext = new CompanyDbContext();
        public void MainMenu()
        {
            Console.WriteLine("----------------------------------");
            Console.WriteLine("Tüm Şirketleri Görmek için    =>  1");
            Console.WriteLine("Yeni şirket eklemek için      =>  2");
            Console.WriteLine("Tüm Çalışanları Görmek için   =>  3");
            Console.WriteLine("Yeni Çalışan Eklemek için     =>  4");
            Console.WriteLine("Çıkış Yapmak için             =>  5  giriniz");
      
        }
        public void directToAction(int UserAnswer)
        {
            switch (UserAnswer)
            {
                case 1:
                    ShowCompanies();
                    break;
                case 2:
                    AddCompanies();
                    break;
                case 3:
                    ShowEmployees();
                    break;
                case 4:
                    AddEmployee();
                    break;
                case 5:
                    break;
                default:
                    break;
            }
        }

        private void AddCompanies()
        {
            string CompanyName, CompanyFounder, CompanyMarketValue;
            Console.WriteLine("Şirket Adını giriniz");
            CompanyName = Console.ReadLine();
            Console.WriteLine("Şirketin kurucusunu giriniz");
            CompanyFounder = Console.ReadLine();
            Console.WriteLine("Şirketin market değerini giriniz ($ olarak :) )");
            CompanyMarketValue = Console.ReadLine();
            var company = new Company();
            company.Name = CompanyName;
            company.Founder = CompanyFounder;
            company.MarketValue = Convert.ToInt32(CompanyMarketValue);

            CompanyDbContext.Add<Company>(company);
            CompanyDbContext.SaveChanges();
            Console.WriteLine("Şirket Eklendi");

        }

        public void ShowCompanies()
        {
            var companies = CompanyDbContext.Set<Company>().ToList();
            foreach (var company in companies)
            {
                Console.WriteLine("Şirket Adı: "+company.Name );
                Console.WriteLine(" Kurucusu : "+company.Founder);
                Console.WriteLine(" Market Değeri : "+company.MarketValue+"$");
                Console.WriteLine("---------------------------");
            }
        }
        public void ShowEmployees()
        {
            
            var employees = CompanyDbContext.Set<Employee>().ToList();
            foreach (var employee in employees)
            {
                Console.WriteLine("Çalışan ismi:"+employee.FirstName);
                Console.WriteLine("Çalışan Soyismi:"+employee.LastName);
                Console.WriteLine("Çalışan TelefonNumarası:"+employee.PhoneNumber);
                int employeeCompanyId = employee.CompanyId;
                string employeCompanyName=FoundEmployeeCompanyName(employeeCompanyId);
                Console.WriteLine("Çalışanın bulunduğu şirket"+employeCompanyName);
                Console.WriteLine("---------------");
            }
        }
        public void AddEmployee()
        {
            Employee employee = new Employee();
            string firstName, lastName, companyName;
            int phoneNumber, companyId;
            Console.WriteLine("Çalışan İsmini giriniz");
            firstName = Console.ReadLine();
            Console.WriteLine("Çalışan Soyismi giriniz");
            lastName = Console.ReadLine();
            Console.WriteLine("Telefon numarasını girinsiz (500 ile başlatınız örnk:536...)");
            phoneNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Şirket Adını giriniz");
            companyName = Console.ReadLine();
            companyId=FoundEmployeeCompanyId(companyName);
            employee.FirstName = firstName;
            employee.LastName = lastName;
            employee.PhoneNumber = phoneNumber;
            employee.CompanyId = companyId;
            CompanyDbContext.Add<Employee>(employee);
            CompanyDbContext.SaveChanges();
            Console.WriteLine("Çalışan Eklendi");
        }
        public int FoundEmployeeCompanyId(string companyName)
        {
            var foundCompany = CompanyDbContext.Companies.Where(c => c.Name == companyName).FirstOrDefault();

            return foundCompany.Id;

        }
        public string FoundEmployeeCompanyName(int companyId)
        {
            var foundCompanyName = CompanyDbContext.Companies.Where(c => c.Id == companyId).FirstOrDefault();
            return foundCompanyName.Name;
        }

    }
 
}
