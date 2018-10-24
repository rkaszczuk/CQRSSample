Fabryka
- Tworzymy obiekt bez przekazywania logiki tworzenia do klienta
- Fabryka zawiera metodę, która zwraca stwrzony obiekt bazując na logicę (np. na bazie enuma)

Fabryka abstrakcyjna
- Fabryka, która tworzy inne fabryki

Builder
- Buduje złozony obiekt
- Wiele instancji buildera może tworzyć obiekt tej samej klasy o różnych własciwościach

Prototyp
- Zwraca kopie instniejących obiektów
- Przydatne przy cięzkich obiektach

Adapter
- Łączy niekompatybilne interfejsy
- Obudowuje w interfejs wywołania obiektu innej klasy

Most
- Obudowuje wywołania interfejsu przekazywanego w parametrze

Kompozyt
- Pozwala na budowanie struktur drzewiastych
- Np. struktura katalogów (katalog zawiera interfejs pozwalający na dodawanie innych katalogów oraz plików)
- https://sourcemaking.com/design_patterns/composite/java/1

Dekorator
- Fasada z dodanymi operacjami nieobsługowanymi przez przekazany obiekt
- Często wywołuje coś przed lub po metodach z przekazanego obiektu

Fasada
- Obudowuje logikę kilku obiektów ukrywając ją złozoność

Pyłek
- Lista instancji obiektów przechowywanych w HashTable
- Dostęp za pomocą klucza


