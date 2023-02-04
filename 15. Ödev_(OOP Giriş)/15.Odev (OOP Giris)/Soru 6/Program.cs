using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            
            SOLID Prensipleri Nedir?

            ***
           
            SOLID yazılım prensipleri diye adlandırılan ve dünya üzerinde, OOP nesne tabanlı yazılım geliştirirken kullanılan standartlaştırılmış 5 önemli tasarım ilkesi vardır.

            Bu 5 tasarım ilkesi, Robert C. Martin tarafından Design Principles and Design Patterns kitabında tanıtılmıştır.

            Bu ilkelerin amacı, yazılım tasarımlarını daha anlaşılır, bakımı daha kolay ve genişletilmesi daha kolay hale getirmektir.

            - Single Responsibility Principle (SRP)
            - Open Closed Principle (OCP)
            - Liskov Substitution Principle (LSP)
            - Interface segregation principle (ISP)
            - Dependency injection principle (DIP)

            ***
            
            1. Single responsibility principle (SRP)

            Bir class bir sorumluluk almalı yani bir class’ın isviçre çakısı gibi bir sürü görevi, özelliği olmamalıdır. Hem nesnesinin özelliklerini barındırıp hem de bir kaç metodun birleşiminden oluşan bir metodumuz olmamalıdır. 

            Öyle bir tasarım yapmalıyız ki, her class veya metodun tek bir sorumluluğu olmalıdır. Yani, class veya metodun değişmek için bir sebebi olmalıdır. Eğer birden fazla sebebi var ise birçok sorumluluğu var demektir ve bu şekilde yazılan kodların anlaşılması veya tekrar kullanılabilmesi neredeyse imkansızdır.

            2. Open Closed Principle (OCP)

            Yazılım varlıkları uzantı (eklenti) için açık ancak değişiklikler için kapalı olmalıdır. OCP, geniş çapta uyarlanabilen ancak aynı zamanda değişmeden kalan varlıkları gerektirir.  Bu noktada, çok şekillilik (polimorfizm) konusu ile  özel davranışlara sahip yinelenen varlıklar yaratmamız gerekir.

            3. Liskov Substitution Principle (LSP)

            Bir class ta bulunan özellikler, kendisinden kalıtım alan class’larda kullanılmayacaksa bu durum LSP’ye aykırı bir durumdur. Yani kalıtım alınan class’ın içindeki özellikler kalıtımı alan class ta kullanılmalıdır. Bir programdaki nesneler, o programın doğruluğunu değiştirmeden alt türlerinin örnekleriyle değiştirilebilir olmalıdır. Alt sınıf, aynı istekleri işleyebilmeli ve üst sınıfıyla aynı görevleri tamamlayabilmelidir.

            LSP’nin avantajı, aynı türdeki tüm alt sınıfların tutarlı bir kullanımı paylaştığı için yeni alt sınıfların geliştirilmesini hızlandırmasıdır. Yeni oluşturulan tüm alt sınıflar mevcut kodla çalışabilir. Yeni bir alt sınıfa ihtiyacınız olduğu zaman mevcut kodu yeniden çalışmadan oluşturabilmenize olanak sağlar.

            4. Interface Segregation Principle (ISP)

            İsteme özel birçok arayüz, tek bir genel amaçlı arayüzden daha iyidir. ISP’de sınıflar kullanmadıkları davranışları içermesi istenmez. Aslında, bu durum ilk SOLID ilkemizle de ilgilidir. Çünkü, bu ilke programa doğrudan katkıda bulunmayan tüm değişkenleri, metotları veya davranışları bir sınıftan çıkarır. ISP ise metotların daha spesifik metotlara dönüştürülmesidir. Bu sayede:

                - Daha az kod taşıyan metotlar elde edilir. Kodun ihtiyaç durumunda güncellemesi hızlanır.
                - Davranıştan bir metot sorumlu olduğu için davranışta karşılaşılan problem hızlı çözülür.

            5. Dependency Inversion Principle (DIP)

            Abstraction (Soyutlama) konusu sınıf ve doğru özelliklerin sınıfa eklenmesi açısından Nesneye Yönelik Programlamanın en önemli konularından biridir. DIP iki kısma sahiptir:

                - Yüksek seviyeli modüller, düşük seviyeli modüllere bağlı olmamalıdır. Bunun yerine, her ikisi de soyutlamalara (Interface) bağlı olmalıdır.

                - Soyutlamalar ayrıntılara bağlı olmamalıdır. Ayrıntılar (somut uygulamalar gibi) soyutlamalara bağlı olmalıdır.

            Yazılımcılar, konuyu parça parça öğrendikleri için sınıflarını yüklenirler. Bir anlamda yüksek seviyeli bileşenlere sahip programlar yazarlar. DIP ilkesinin amacı düşük ve yüksek seviyeli bileşenleri ayırıp her ikisini de soyutlamalara bağlamaktır. Bu durumda, yüksek ve düşük seviyeli bileşenler birbirinden yararlanabilir ama birindeki değişiklik doğrudan diğerini etkilememelidir.

            ***
            
            SOLID prensibine uygun bir şekilde yazdığımızda kodlarımız hem okunabilirlik hem de geliştirebilir açısından çok önde olacaktır. İleride ortaya çıkabilecek sorunları da SOLID prensipleri sayesinde aza indirgemiş oluyoruz.


             */
        }
    }
}
