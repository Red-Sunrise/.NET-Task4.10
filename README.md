# .NET-Task4.10
# Классы
### ProgrammerFirstLevel
Поля:
* string surname - Фамилия
* int programs_count - Число программ
* int programming_languages_count - Число языков программирования
* int calculate_quality() - Метод для подсчета качества.
> Q = (число программ)*(число языков)
***
### ProgrammerSecondLevel : ProgrammerFirstLevel
Поля:
* string surname - Фамилия
* int programs_count - Число программ
* int programming_languages_count - Число языков программирования
* int correct_programs - Число правильных программ
* int calculate_quality() - Метод для подсчета качества.
> Qp = Q *(число правильных программ)/(число программ)
