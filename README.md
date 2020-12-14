# Planner by Alim Yusufov (Nevilov)

# Задача: 
> SPA веб-приложение, сервер предоставляет АПИ (ASP.NET Core Web API), информация хранится в объектах, персистентность которых реализуется с помощью использования БД.

# Что можно?
- Добавлять задачи (Заголовок, описание, начальная дата, конечная дата)
- Редактировать задачи (Заголовок, описание, начальная дата, конечная дата, завершено ли)
- Удалять задачи

# Как начать?
Убедитесь, что на вашем компьютере установлен VisualStudio и пакет SDK не меньше .NET Core 3.1. Затем сделайте:
```sh
$ git clone https://github.com/nevilov/Planner.git
```
### - Откройте терминал перейдите в папку PlannerAPI и запустите сервер
```sh
cd PlannerAPI
dotnet run
```
### - Откройте Planner.sln и запустите проект PlannerWASM
Если будут трудности с клонированием, то пишите [мне](https://vk.com/nevilov).

# Скриншоты
> [![N|Solid](https://psv4.userapi.com/c856416/u283181712/docs/d15/777fea814b9c/2.png?extra=H_z5LME4x5nR8Yt1xGVubDt8jHH20JxwDYxxeLGHvthb6WBX5MtyG0bObaLlcQ1x56EWiyzX9ywKegBJuCiWz_zY8dGcRyuVgqFjXy1Yh-WOBsz7599MlQmqR9Nw7XoiQ-aHI9UmwqnLu3Kr3nxegnqC6g)](https://vk.com/nevilov)
>[![N|Solid](https://psv4.userapi.com/c856416/u283181712/docs/d3/b5d28354661f/1.png?extra=ms42MaXuDmC1HrQEZgeGToJtUZXlaBFKKeUA4vKHL5PAkmuIQ57lccbg10omZluJzjQyIRk5zjQJJFISc1aPKJZ6LkharETxj_IHKPynP0oPwAhUIKcp_rzrVYl-hTTnKg74HIHbc2VyfsBIlDaK8GcI9g)](https://vk.com/nevilov)
>[![N|Solid](https://psv4.userapi.com/c856416/u283181712/docs/d14/78bf463cbedc/3.png?extra=buYreSeDhcwYteptD6dIbshK6Hv-sNeqaKfV8ew8JbCnrSnwNPOz8B7BAuoOffoN65X4m2gvfuXdCC3t2WyaKB3EQFkxQ50BI2BqZUxAX2bfXbXLqqHjsabKVlRyHURxuFnyZiCB8zsSLn_2sx2fjK0qFQ)](https://vk.com/nevilov)


# ContinuousIntegration
### *Сборка API(PlannerAPI) и Blazor приложения(PlannerWASM) - происходят в [GitLab](https://gitlab.com/nevilov/planner) репозитории*
