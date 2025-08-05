# Пример работы с веб-сервисом для получения информации на .NET C#

### Описание

Веб-сервис для получения ежедневных данных, таких как курсы валют, учетные цены драгоценных металлов и другие финансовые данные.

- **Веб-сервис:** [http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx](http://www.cbr.ru/DailyInfoWebServ/DailyInfo.asmx)

### Установка

При работе без использования .NET Framework для доступа к веб-сервису необходимо установить:

- **SOAP Toolkit 3.0**
- **MSXML 4.0**

### Описание методов сервиса

#### 1. Получение курсов валют

- **Методы:**
  - `GetCursOnDate(On_date)` - получение курсов валют на определенную дату (ежедневные курсы валют).
  - `GetSeldCursOnDate` - получение ежемесячных курсов валют.

- **Аргументы:**
  - `On_date` — Дата запроса для курсов, формат — `System.DateTime`.

- **Результат:**
  - XML документ в формате `System.Data.Dataset`, содержащий таблицу `[ValuteCursOnDate]` с полями:
    - `Vname` — Название валюты
    - `Vnom` — Номинал
    - `Vcurs` — Курс
    - `Vcode` — ISO Цифровой код валюты
    - `VchCode` — ISO Символьный код валюты
    - `VunitRate` — Курс за 1 единицу валюты

#### 2. Справочник по кодам валют

- **Метод:**
  - `EnumValutes(Seld)`

- **Аргументы:**
  - `Seld` — формат - boolean
    - `False` — перечень ежедневных валют
    - `True` — перечень ежемесячных валют

- **Результат:**
  - XML документ в формате `System.Data.Dataset`, содержащий таблицу `[EnumValutes]` с полями:
    - `Vcode` — Внутренний код валюты
    - `Vname` — Название валюты
    - `VEngname` — Англ. название валюты
    - `Vnom` — Номинал
    - `VcommonCode` — Внутренний код базовой валюты
    - `VnumCode` — цифровой код ISO
    - `VcharCode` — 3-х буквенный код ISO

### Получение последней даты публикации курсов валют

- **Методы:**
  - `GetLatestDateTime()`
  - `GetLatestDateTimeSeld()`
  - `GetLatestDate()`
  - `GetLatestDateSeld()`

- **Результат:**
  - Формат — `System.DateTime` или `String`.

### Динамика курсов валют

- **Метод:**
  - `GetCursDynamic(FromDate, ToDate, ValutaCode)`

- **Аргументы:**
  - `FromDate` — Дата начала, тип `System.DateTime`
  - `ToDate` — Дата окончания, тип `System.DateTime`
  - `ValutaCode` — Внутренний код валюты, тип `String`

- **Результат:**
  - XML документ в формате `System.Data.Dataset`, содержащий таблицу `[ValuteCursDynamic]`.

### Динамика учетных цен на драгоценные металлы

- **Метод:**
  - `DragMetDynamic(FromDate, ToDate)`

- **Аргументы:**
  - `FromDate` — Дата начала, тип `System.DateTime`
  - `ToDate` — Дата окончания, тип `System.DateTime`

- **Результат:**
  - XML документ в формате `System.Data.Dataset`, содержащий таблицу `[DrgMet]`.

### Получение новостей сервера

- **Метод:**
  - `NewsInfo(FromDate, ToDate)`

- **Аргументы:**
  - `FromDate` — Дата начала, тип `System.DateTime`
  - `ToDate` — Дата окончания, тип `System.DateTime`

- **Результат:**
  - XML документ в формате `System.Data.Dataset`, содержащий таблицу `[News]`.

> Код взят с сайта центробанка и сохранён ради истории.
