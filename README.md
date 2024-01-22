A feladat olyan backend írása a már meglévő projektbe, amely a Kreta rendszerben lévő összes szülő adatát adja vissza, illetve egy adott Guid id alapján az adott szülő adatát adja vissza!

Készítse el a Szülő (Parent) osztályt! A szülőket egy Guid id-vel azonosítjuk, minden szülőnek ismert a neve, neme és lakcíme (egy string típusú változóban tárolható).

A feladat megoldásának javasolt lépései:
   -	model osztály elkészítése
   -	a KretaContext osztályba vegye fel az elkészült modelt
   -	repository réteg elkészítése
   -	repository osztály felkészítése a dependency injection-re
   -	controller réteg elkészítése
   -	a controller rétegben a repository réteg injektálása

A feladat megoldása során, ha a repository réteg injektálása nem sikerül, akkor a kérés hibaüzenetet adjon a frontendre!

Tesztelje tesztadatokkal és dokumentálja a feladat megoldását!

