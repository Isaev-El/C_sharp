В этом примере есть три метода: Main, CallMethodThatThrowsException, и ThrowCustomException. 
Метод ThrowCustomException генерирует пользовательское исключение типа CustomException. 
Метод CallMethodThatThrowsException вызывает ThrowCustomException и перехватывает это исключение, а затем "поднимает" его выше с помощью throw. 
В методе Main, мы перехватываем и обрабатываем это исключение.
