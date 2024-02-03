Данный проект демонстрирует решение проблемы по защите данных о пробеге автомобиля.

Для решения данной проблемы в проекте реализована передача место положения автомобиля в сервисный цент. По сохранённым координатам рассчитывается путь, пройденный автомобилем, и передается запрашивающему.
Координаты передаются в фоновом режиме от автомобиля в сервисный цент раз в 500 миллисекунд.

**Проект состоит из двух основных модулей:**
1.	CarInfo.Demo – содержит в себе классы автомобиля, покупателя, продавца и хакера.
Цель данного модуля смоделировать ситуацию изменения пробега автомобиля и запрос к сервисному центру автомобиля с целью получения достоверной информации о пробеге автомобиля.
2.	CarInfo.CoreLib – содержит логику по работе с хранилищем данных автомобилей и расчет пройденного пути конкретным автомобилем.
