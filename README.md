A kód egy hibával indul, ami a 2. feladat megoldásával oldható majd meg.

Feladatok:

1. Adott a Student osztály a model rétegben.
   1. Készítsen konstruktort, amely a diák minden adatát megkapja!
   1. Készítsen alapértelmezett konstruktort, amelyben egy alapértelmezett diákot hoz létre!
   1. Készítsen egy ToString metódust amely megjeleníti a diák összes adatát!
1. Repository réteg
   1. A StudentRepo osztályban implementálja az IStudent inferface-t!
   1. Írja meg a metódusok kódját, hogy az egyik egy diák adatát adják vissza Guid  id alapján illetve a másik metódus az összes dák adatát adja vissza!
   1. A metódusok async metódusok legyenek!
1. Controller rétegben írja meg a következő metódusok kódját a StudentController fájlba::
    1. Injektálja az osztályba az IStudentRepo interface által leírt osztályt! (lásd KretaBackendExtensions.cs állományt.)
    2. GetBy(Guid id) http get kérést kiszolgáló metódus
      - A kérésre a metódus Ok vagy BadReuqest válaszokat adjon!
      - Ha az injektálás nem sikerül, a metódus az „Az adatok elérhetetlenek!” hibaüzenettel térjen vissza!
      - Ha talál adott guid id-vel rendelkező diákot, a metódust térjen vissza azzal, ha nem akkor térjen vissza egy alapértelmezett üres diák objektummal!
    3. SelectAllRecordToListAsync http get kérést kiszolágó metódus
      - A kérésre a metódus Ok vagy BadReuqest válaszokat adjon!
      - Ha az injektálás nem sikerül, a metódus az „Az adatok elérhetetlenek!” hibaüzenettel térjen vissza!
      - Ha talál diákokat, akkor a diákok listáját adja vissza a kérés, ha nem akkor egy üres diák listát!

Tesztelje és dokumentálja a feladat megoldását!
