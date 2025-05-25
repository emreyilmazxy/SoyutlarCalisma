# Soyutlar (Abstraction) - C# Konsol Uygulaması

Bu projede, C# dilinde **soyut sınıflar (abstract class)** kullanılarak bir şirketin çalışan yapısı modellenmiştir.  
Amaç, her çalışanın `Work()` metodunu kendine özgü şekilde uygulamasıdır.

## Yapı

- `Person`: Soyut sınıf, tüm çalışanlar bu sınıftan türetilir.
- `SoftwareDeveloper`, `SoftwareTester`, `ScrumMaster`: `Person` sınıfından türeyen alt sınıflardır.
- Her sınıf, kendi `Work()` metodunu override ederek görevini tanımlar.

## Kullanım

```bash
dotnet run
