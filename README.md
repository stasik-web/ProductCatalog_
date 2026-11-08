# ProductCatalog

ASP.NET Core MVC (.NET 10) қосымшасы. 2-апта: Razor, Strongly Typed View, ViewBag, Layout және Partial View.

## Құрамы

**Зертханалық жұмыс (Lab)**
- `Models/Course.cs`
- `Controllers/CourseController.cs` (`List` әрекеті)
- `Views/Shared/_CourseCard.cshtml` (Partial View)
- `Views/Course/List.cshtml`

**Тапсырма (Assignment)**
- `Models/Product.cs` (Id, Name, Price, Category, IsAvailable)
- `Controllers/ProductController.cs`
- `Views/Shared/_Layout.cshtml` (Bootstrap 5)
- `Views/Shared/_ProductCard.cshtml` (Partial View)
- `Views/Product/Index.cshtml` (Strongly Typed View + ViewBag)

## Іске қосу

Visual Studio-да `ProductCatalog.sln` файлын ашып, `F5` (немесе `Ctrl+F5`) басыңыз. Браузер өзі ашылады.

Немесе терминалда:

```bash
dotnet run
```

Браузерде `http://localhost:5000` (нақты порт консольде көрсетіледі).
