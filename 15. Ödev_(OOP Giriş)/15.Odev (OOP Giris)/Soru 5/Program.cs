using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Soru_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Object-Oriented Programming (OOP)

            ***

            Nesne yönelimli programlama nedir?

            Nesne yönelimli programlama (OOP), yazılım tasarımını fonksiyonlar ve mantık yerine veriler veya nesneler etrafında düzenleyen bir bilgisayar programlama modelidir. Bir nesne, benzersiz nitelikleri ve davranışı olan bir veri alanı olarak tanımlanabilir.

            OOP, geliştiricilerin nesneleri manipüle etmek için gereken mantıktan ziyade manipüle etmek istedikleri bu nesnelerin kendisine odaklanır. Bu programlama yaklaşımı, büyük, karmaşık ve aktif olarak güncellenen veya sürdürülen programlar için çok uygundur. Bu, üretim ve tasarım programlarının yanı sıra mobil uygulamaları içerir; örneğin, üretim sistemi simülasyon yazılımı için OOP kullanılabilir.

            Nesne yönelimli bir programın organizasyonu, bu metodu projelerin gruplara bölündüğü işbirlikçi geliştirme için de faydalı kılar. OOP'nin ek faydaları arasında kodun yeniden kullanılabilirliği, ölçeklenebilirliği ve verimliliği yer alır.

            OOP'deki ilk adım, veri modelleme olarak bilinen bir uygulamadır. Bu uygulamadaki amaç, bir programcının manipüle etmek istediği tüm nesneleri toplamak ve bunların birbirleriyle nasıl ilişkili olduğunu belirlemektir.

            Bir nesnenin örnekleri, ad ve adres gibi özelliklerle tanımlanan bir insan gibi fiziksel varlıklardan, parçacıklar (widgets) gibi küçük bilgisayar programlarına kadar değişebilir.

            Bir nesne bilindiğinde, içerdiği veri türünü ve onu manipüle edebilen herhangi bir mantık dizisini tanımlayan bir nesne sınıfı ile etiketlenir. Her farklı mantık dizisi bir metot olarak bilinir. Nesneler, mesajlar adı verilen iyi tanımlanmış arayüzlerle iletişim kurabilir.

            ***

            Nesne yönelimli programlamanın yapısı nedir?

            Nesne yönelimli programlamanın yapısı veya yapı taşları aşağıdakileri içerir:

            - Sınıflar; bireysel nesneler, nitelikler ve metotlar için şablon görevi gören kullanıcı tanımlı veri türleridir.

            - Nesneler, özel olarak tanımlanmış verilerle oluşturulmuş bir sınıfın örnekleridir. Nesneler, gerçek dünyadaki nesnelere veya soyut bir varlığa karşılık gelebilir. Sınıf başlangıçta tanımlandığında, tanımlanan tek nesne açıklamadır.

            - Metotlar, bir nesnenin davranışlarını tanımlayan ve bir sınıf içinde tanımlanan işlevlerdir. Sınıf tanımlarında yer alan her bir metot, bir örnek nesneye yapılan referansla başlar. Ek olarak, bir nesnede yer alan alt programlara örnek metotlar denir. Programcılar, yeniden kullanılabilirlik veya işlevselliği her seferinde bir nesne içinde kapsüllenmiş halde tutmak için metotlar kullanır.

            - Nitelikler, sınıf şablonunda tanımlanır ve bir nesnenin durumunu temsil eder. Nesneler, nitelikler alanında saklanan verilere sahip olacaktır. Sınıf nitelikleri sınıfın kendisine aittir.

            ***
            
            OOP'nin temel ilkeleri nelerdir?

            Nesne yönelimli programlama aşağıdaki ilkelere dayanmaktadır:

            - Encapsulation: Bu ilke, tüm önemli bilgilerin bir nesnenin içinde bulunduğunu ve yalnızca belirli bilgilerin açığa çıktığını belirtir. Her nesnenin uygulaması ve durumu, tanımlanmış bir sınıf içinde özel olarak tutulur. Diğer nesnelerin bu sınıfa erişimi veya değişiklik yapma yetkisi yoktur. Yalnızca genel fonksiyonların veya metotların bir listesini çağırabilirler. Veri gizlemenin bu özelliği, daha fazla program güvenliği sağlar ve istenmeyen veri bozulmasını önler.

            - Abstraction: Nesneler, yalnızca diğer nesnelerin kullanımıyla ilgili dahili mekanizmaları ortaya çıkarır ve gereksiz uygulama kodlarını gizler. Türetilen sınıfın işlevselliği genişletilebilir. Bu konsept, geliştiricilerin zaman içinde ek değişiklikleri veya eklemeleri daha kolay yapmasına yardımcı olabilir.

            - Inheritance: Sınıflar, diğer sınıfların kodunu yeniden kullanabilir. Nesneler arasında ilişkiler ve alt sınıflar atanabilir, bu da geliştiricilerin benzersiz bir hiyerarşiyi korurken ortak mantığı yeniden kullanmalarını sağlar. OOP'nin bu özelliği, daha kapsamlı bir veri analizini zorunlu kılar, geliştirme süresini azaltır ve daha yüksek bir doğruluk düzeyi sağlar.

            - Polymorphism: Nesneler, davranışları paylaşmak için tasarlanmıştır ve birden fazla biçim alabilirler. Program, bir üst sınıftan, o nesnenin her defa yürütülmesi için hangi anlamın veya kullanımın gerekli olduğunu belirleyerek, kodun yinelenme ihtiyacını azaltır. Daha sonra, üst sınıfın işlevselliğini artıran bir alt sınıf oluşturulur. Polymorphism, farklı türdeki nesnelerin aynı arayüzden geçmesine izin verir.

            ***
            
            OOP'nin faydaları nelerdir?

            - Modularity: Encapsulation, nesnelerin müstakil olmasını sağlayarak sorun gidermeyi ve işbirliğine dayalı geliştirmeyi kolaylaştırır.

            - Reusability: Kod, kalıtım yoluyla yeniden kullanılabilir, yani bir ekibin aynı kodu birden çok kez yazması gerekmez.

            - Productivity: Programcılar, birden çok kitaplık ve yeniden kullanılabilir kod kullanarak yeni programları daha hızlı oluşturabilir.

            - Easily upgradable and scalable: Programcılar, sistem işlevlerini bağımsız olarak uygulayabilir.

            - Interface descriptions: Nesnelerin iletişimi için kullanılan mesaj aktarma teknikleri nedeniyle, harici sistemlerin açıklamaları basittir.

            - Security: Encapsulation ve abstraction kullanılarak karmaşık kod gizlenir, yazılım bakımı daha kolaydır ve internet protokolleri korunur.

            - Flexibility: Polymorphism, tek bir fonksiyonun yerleştirildiği sınıfa uyum sağlamasını sağlar. Farklı nesneler de aynı arayüzden geçebilir.

            */
        }
    }
}
