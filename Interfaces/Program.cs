using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args) //Yazılım her değişimde kodlara dokunmadan yapılmasıdır.
        {
            //İnterfaceler newlenemez
            IPersonManager customerManager = new CustomerManager();
            customerManager.Add();

            IPersonManager personelManager = new PersonelManager();
            personelManager.Update();

            ProjectManager projectManager = new ProjectManager();
            projectManager.Add(new CustomerManager());

            projectManager.Add(new InternManager());
        }

        interface IPersonManager //İnterfaceler I ile başlar
        {
            void Add();         //İnterfacelerde yazılanlar implemente edilen classlardada geçerli olur
            void Update();
        }

        class CustomerManager : IPersonManager //implemente edildi. yani interfaceteki kodlar burdada geçerli
        {
            public void Add()
            {
                Console.WriteLine("Müşteri eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Müşteri güncellendi.");
            }
        }

        class PersonelManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Personel eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Personel güncellendi.");
            }
        }

        class InternManager : IPersonManager
        {
            public void Add()
            {
                Console.WriteLine("Stajer eklendi.");
            }

            public void Update()
            {
                Console.WriteLine("Stajer güncellendi.");
            }
        }

        class ProjectManager
        {
            public void Add(IPersonManager personManager)  //Parametreyi interface yazarsak çağırma anında sorun yaşamayız
            {
                personManager.Add();
            }
        }
    }
}
