# Диспетчерская служба управления транспортом

## Задание
Реализовать структуру классов, описывающих предметную область, определяемую в задании.
В каждом из заданий присутствует часть, связанная с обработкой данных, представленная в разделе «Запросы».
Данную часть необходимо реализовать в виде unit-тестов: подготовить тестовые данные, выполнить запрос с использованием LINQ, проверить результаты.


## Классы

### Driver
Содержит информацию о водителях:
Id - Уникальный идентификатор
Name - Имя
Surname - Фамилия
Patronymic - Отчество
Passport - Паспорт
DriverLicense - Водительское удостоверение
Address - Адрес
Phone - Телефон

### VehicleModel
Содержит информацию о модели транспортного средства:
Id - Уникальный идентификатор
Name - Название модели
LowFloor - Низкопольная модель или нет
MaxCapacity - Максимальная вместимость

### Vehicle
Содержит информацию о транспортных средствах:
Id - Уникальный идентификатор
RegistrationNumber - Гос. номер транспортного средства
VehicleType - Тип транспортного средства
VehicleModel - Модель транспортного средства
YearOfManufacture - Год выпуска транспортного средства

### RouteAssignment
Содержит информацию о назначении водителя и транспортного средства на маршрут:
Id - Уникальный идентификатор
Vehicle - Транспортное средство
Driver - Водитель
RouteNumber - Номер маршрута
StartTime - Дата и время выхода на рейс
EndTime - Дата и время окончания рейса


## Тесты

### GetInfoAboutVehicleById
Проверка вывода всех сведений о конкретном транспортном средстве

### GetDriversByPeriod
Проверка вывода всех водителей, совершивших поездки за заданный период, упорядоченных по ФИО

### GetTotalTripTimeByVehicleType
Проверка вывода суммарного времени поездок транспортного средства каждого типа

### GetTotalTripTimeByVehicleModel
Проверка вывода суммарного времени поездок транспортного средства каждой модели

### GetTop5DriversByTripCount
Проверка вывода топ 5 водителей по совершенному количеству поездок

### GetDriverTripStats
Проверка вывода информации о количестве поездок, среднем времени и максимальном времени поездки для каждого водителя

### GetVehiclesWithMaxTripsForPeriod
Проверка вывода информации о транспортных средствах, совершивших максимальное число поездок за указанный период
