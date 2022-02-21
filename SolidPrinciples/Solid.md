# Solid Prensipleri
## Solid Prensipleri nedir ve neden kullanılır?
Solid prensipleri;geliştirilen yazılımın esnek,yeniden kullanılabilir,sürdürülebilir ve anlaşılır olmasını sağlayan,kod tekrarlarını önleyen ve
2000 yılında Robert C. Martin tarafından öne sürülen prensipler bütünüdür.

![alt text](https://dijitalseruven.com/wp-content/uploads/2021/02/SOLID-1024x341.jpg)
### İlk Olarak S harfi olan Single Responsibility Principle(Srp) ile başlayalım...
## 1) Single Responsibility Principle(SRP)
![alt text](https://uploads.toptal.io/blog/image/91846/toptal-blog-image-1449597577848-60a7b4874d676e754260b05866cf967f.jpg)

Türkçe anlamı "Tek Sorumluluk" olan SRP'ye göre,her method ve class'ın tek bir görevi ve sorumluluğu vardır.Bu prensibe göre,classın değişmesi için tek bir nedeni olmalıdır.
Örneğin; Aşçı sınıfında Yemek pişir methodu olabilir ama Malzeme Al methodunun Aşçı sınıfında olmaması gerekir.Çünkü aşçı yemek pişirmesi asıl görevidir ama malzeme alması asıl görevi değildir.

## 2) Open/Closed Principle
![alt text](https://yazilimcigenclik.com.tr/wp-content/uploads/2021/02/1_0MtFBmm6L2WVM04qCJOZPQ-1024x584.png)

Türkçe anlamı Açık/Kapalı olan bu prensip projede kullanılan nesnelerin gelişime açık ama değişime kapalı olmaları gerektiğini savunur.
#### Peki nedir bu gelişime açık değişime kapalı olmak ? Gelin bir örnek ile inceleyelim.
Worker adında bir sınıfımız olsun.Bu sınıfın özellikleri neler olmalı? İsim ,Yaş,Departman vs olabilir.Daha sonra Worker sınıfına deneyim düzeylerini belirleyecek bir özellik ekledik ve bunu enum olarak almak istiyoruz.

## public Enum Experience Level 
```
{
Junior,
Mid,
Senior}
```
Diyelim ki bu özelliklere göre maaşını hesaplayan bir calculate sınıf daha yazdık.Bu sınıf worker nesnesinden üretilen bir referansın deneyim düzeyine göre maaş hesabı yapsın.
Peki her şey çok güzel.Daha sonra başka bir deneyim düzeyi daha eklemek istedik.Bu sefer calculate sınıfını değiştirmemiz gerekecek değil mi?

Evet sevgili  dostlar bu olay Open/Closed ilkesine ters düşmektedir.Peki bu durumda ne yapmalıyız?

öncelikle birden fazla experience level varsa burdaki örnekte class olarak kullanmamız daha iyi olacaktır.
```
public abstract class ExperienceLevel{
    public abstract int  GetSalaryMultiplier(int Salary);
}
```
Daha sonra bir level eklemek istediğimizde yapmamız gereken sadece;

```
public abstract class NewExperienceLevel:ExperienceLevel{}
```
Görüldüğü üzere yeni experience leveli eklerken calculate sınıfında değişiklik yapmamıza gerek kalmamaktadır.

## 3) Liskov Substitution Principle(LSP)
![alt text](https://yazilimcigenclik.com.tr/wp-content/uploads/2021/02/1_yKk2XKJaCLNlDxQMx1r55Q-1024x918.png)

Türkçe anlamı "Yerine Geçme" olan bu prensibe göre,

