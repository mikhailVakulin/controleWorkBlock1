# Как я решила задачу? - Ответ на этот животрепещущий вопрос, смотрите ниже!

![изображение автора статьи во время мучительных раздумий над решением](https://oir.mobi/uploads/posts/2021-05/1620900268_10-oir_mobi-p-obezyana-zadumalas-zhivotnie-krasivo-foto-11.jpg)

## Для начала посмотрим условия задачи, которую нам предстоить решить, вот они:
### *Написать програму, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символаю Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.*   

 Первая мысль после прочтения условий задачи- "О, ну тут понятно- проходимся циклом по массиву, далее при помощи оператора- **если**, задаем условие чтоб значение длины строки было равно меньше или равно трём,  далее при выполнении условия присваиваем значение элементу с таким же индексом в результирующий массив... НО, тут приходит осознание, что массивы эти (тот который обрабатываем и резульирующий) имеют разный размер! Потому для начала пробежался циклом по масиву и посчитал количество подходящих элементов,  а на втором этапе создал новый массив уже с нужным размером, далее просто копируем подходящие строки в новый массив и вуаля= **MISSION COMPLETE** !!! "  


![](https://m.buro247.ru/images/leonardo-di-caprio-ruling-wall-street.jpg.webp)