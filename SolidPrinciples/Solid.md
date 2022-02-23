# Solid Prensipleri
## Solid Prensipleri nedir ve neden kullanılır?
### Solid prensipleri;geliştirilen yazılımın esnek,yeniden kullanılabilir,sürdürülebilir ve anlaşılır olmasını sağlayan,kod tekrarlarını önleyen ve 2000 yılında Robert C. Martin tarafından öne sürülen prensipler bütünüdür.

![alt text](https://dijitalseruven.com/wp-content/uploads/2021/02/SOLID-1024x341.jpg)
### İlk Olarak S harfi olan Single Responsibility Principle(Srp) ile başlayalım...
## 1) Single Responsibility Principle(SRP)

### Türkçe anlamı "Tek Sorumluluk" olan SRP'ye göre,her method ve class'ın tek bir görevi ve sorumluluğu vardır.Bu prensibe göre,classın değişmesi için tek bir nedeni olmalıdır.
### Örneğin; Aşçı sınıfında Yemek pişir methodu olabilir ama Malzeme Al methodunun Aşçı sınıfında olmaması gerekir.Çünkü aşçı yemek pişirmesi asıl görevidir ama malzeme alması asıl görevi değildir.

![alt text](https://uploads.toptal.io/blog/image/91846/toptal-blog-image-1449597577848-60a7b4874d676e754260b05866cf967f.jpg)

## 2) Open/Closed Principle
![alt text](https://yazilimcigenclik.com.tr/wp-content/uploads/2021/02/1_0MtFBmm6L2WVM04qCJOZPQ-1024x584.png)

### Türkçe anlamı Açık/Kapalı olan bu prensip projede kullanılan nesnelerin gelişime açık ama değişime kapalı olmaları gerektiğini savunur.
### Peki nedir bu gelişime açık değişime kapalı olmak ? Gelin bir örnek ile inceleyelim.
### Worker adında bir sınıfımız olsun.Bu sınıfın özellikleri neler olmalı? İsim ,Yaş,Departman vs olabilir.Daha sonra Worker sınıfına deneyim düzeylerini belirleyecek bir özellik ekledik ve bunu enum olarak almak istiyoruz.

## public Enum Experience Level 
```
{
Junior,
Mid,
Senior}
```
### Diyelim ki bu özelliklere göre maaşını hesaplayan bir calculate sınıf daha yazdık.Bu sınıf worker nesnesinden üretilen bir referansın deneyim düzeyine göre maaş hesabı yapsın.
### Peki her şey çok güzel.Daha sonra başka bir deneyim düzeyi daha eklemek istedik.Bu sefer calculate sınıfını değiştirmemiz gerekecek değil mi?

### Evet sevgili  dostlar bu olay Open/Closed ilkesine ters düşmektedir.Peki bu durumda ne yapmalıyız?

### öncelikle birden fazla experience level varsa burdaki örnekte class olarak kullanmamız daha iyi olacaktır.
```
public abstract class ExperienceLevel{
    public abstract int  GetSalaryMultiplier(int Salary);
}
```
### Daha sonra bir level eklemek istediğimizde yapmamız gereken sadece;

```
public abstract class NewExperienceLevel:ExperienceLevel{}
```
### Görüldüğü üzere yeni experience leveli eklerken calculate sınıfında değişiklik yapmamıza gerek kalmamaktadır.

## 3) Liskov Substitution Principle(LSP)
![alt text](https://yazilimcigenclik.com.tr/wp-content/uploads/2021/02/1_yKk2XKJaCLNlDxQMx1r55Q-1024x918.png)

### Türkçe anlamı "Yerine Geçme" olan bu prensibe göre,Türeyen sınıfın yani alt sınıflar ana(üst) sınıfın özelliklerini ve metotlarını aynı işlevi görecek şekilde kullanabilme ve kendine ait yeni özellikler barındırabilmelidir.

### Örnek olarak bir tamirci ustası ve oğlu hayal edelim.Baba arızalı arabaları tamir etmektedir.Belirli bir süreden sonra baba işe devam edemedi ve oğlunun yerine geçmesini istedi.Oğlunun tamircilik özelliği varsa babasının işlerini devam ettirebilir değil mi?
### Peki ya yoksa o zaman devam ettiremez ve artık bu dükkan yani sınıf çalışmamaktadır.Liskov prensibinde alt sınıflar üst sınıfın yaptığı işin davranışını bozmadan devam ettirebilmelidir.
## 4) Interface Segregation Principle(ISP)
![alt text](https://blog.ndepend.com/wp-content/uploads/ISP.png)
### Bir sınıf ,bir interface'i implement ettiğinde o interfaceden gelen tüm fonksiyonlar kullanılabilir olmalıdır.

### Örnek olarak bir futbolcu interfaceimiz olsun.Bu interface'de koş(),pasAt(),şutçek(),kurtar(),bekle() adında metodları olduğunu varsayalım.Peki bir kaleci sınıfı oluşturduğumuzda ve bu kaleci sınıfı futbolcu interfaceini implement ettiğinde kaleci bu metodların hepsini kullabilir mi ?
### Tabiki hayır,değil mi? Peki bu durumda ne yapmalıyız ? Futbolcu interfaceini düzeltmemiz gerekiyor sevgili dostlar.Yani her futbolcu özelliği olan nesne; kurtarmak veya koşmak zorunda değildir.O halde düşünelim hangi metodlar futbolcu interfaceinde olmalı.
### Her futbolcu pozisyon almalı ve pasatmalı ve zamanı geldiğinde beklemeli değil mi? o zaman sadece bu 3 metod futbolcu interfaceinde olmalı.Diğer metodlar ise ayrı interfaceler içerisinde olmalı.Mesela IRunnable adında bir interface oluşturup içerisine hızlı koşma yavaş koşma gibi metodlar koyup koşması gereken nesnelere implement edersek bu prensibe uyarız.

## 5) Dependency Inversion Principle
![alt text](https://yazilimcigenclik.com.tr/wp-content/uploads/2021/02/1_Qk8tDmjQlyvwKxNTfXIo0Q-1024x637.png)
### Türkçe anlamı "Bağımlılığın Ters Çevrilmesi" olan bu prensibe göre,alt sınıflarda yapılan değişiklikler üst sınıfı etkilememelidir.Sınıflar arası bağımlılıklar olabildiğince az olmalıdır ve özellikle üst seviye sınıflar,alt seviye sınıflara bağımlı olmamalıdır.Kısaca yüksek seviyeli sınıflar,düşük seviyeli sınıflara bağlı olmamalı,her ikisi de soyut kavramlara bağlı olmalıdır.
### Örneğin bir ev aleti düşünelim.Ev aletinin çalışması için bir pile ihtiyacı vardır değil mi? Ama ev aleti için takacağımız pilin markası önemli değildir.Burda ev aleti yüksek sınıf pil düşük sınıftır.Yani çalışması için bir pile ihtiyacı var ama bu ihtiyaç kısıtlı bir ihtiyaç değil herhangi bir pil olabilir.
