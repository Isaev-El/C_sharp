Ветка main отвечает за практику, а ветка home-work за домашку

Описание задачи в практике 5 
{

    В этом примере есть три класса: Worker, Helper и CustomException. CustomException - это пользовательское исключение, которое наследуется от Exception.
    Метод PerformTask в классе Helper генерирует CustomException. 
    Это исключение перехватывается в методе DoWork класса Worker, обрабатывается, а затем "поднимается" выше с использованием throw. 
    Наконец, в методе Main исключение снова перехватывается и обрабатывается.
}
