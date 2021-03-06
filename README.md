# DACS

## Задания к курсу “Разработка прикладных компьютерных систем” 3 курс, 2021-2022 уч. г. (Часть 1)

1. Реализуйте набор сборок с типами, предназначенными для использования
архитектурного паттерна MVVM в приложениях WPF. Основные сборки:
- <YourSurname>.Wpf.MVVM.Core: содержит базовые классы для
ViewModel, конвертеров значений (ValueConverter), конвертеров из
множества значений (MultiValueConverter), а также команд
(DelegateCommand или RelayCommand);
- <YourSurname>.Wpf.MVVM: содержит классы конвертеров,
пронаследованных от базовых классов из вышеописанной сборки:<br/>
  ● Арифметический (операторы +, -, *, /, %);<br/>
  ● Проверки на равенство (операторы ==, !=);<br/>
  ● Проверки на отношение порядка (операторы >, >=, <, <=);<br/>
  ● Логический (операторы ||, &&, !);<br/>
  ● Поразрядный (операторы |, &, ~, ^);<br/>
  ● Проверки на null;<br/>
  ● Из значения типа bool;<br/>
  
, а также расширение разметки для поддержки вложенных
MultiBinding’ов.
2. Добавьте к сборкам, реализованным в задании 1, сборку с именем
<YourSurname>.Wpf.Styles, предоставляющую словарь ресурсов со стилями для
элементов управления:
- ScrollViewer: стиль, предоставляющий возможность привязки цветов
трека и ползунка горизонтальной и вертикальной прокруток;
- Button: стиль, предоставляющий возможность привязки параметров
шрифта (размер, толщина, семейство), а также цвета фона и шрифта для
состояний Enabled и !Enabled кнопки (при помощи триггеров);
Также добавьте сборку с именем <YourSurname>.Wpf.Controls,
предоставляющую пользовательские элементы управления:
- NumericUpDown: элемент управления для изменения значения типа int
(зарегестрированного в виде свойства зависимости), с возможностью
настройки через свойства зависимости минимального и максимального
значений в диапазоне (предусмотрите использование соответствующих
ValidateValueCallback и CoerceValueCallback), шага инкремента /
декремента;
- Spinner: элемент управления для отображения кругов различных
радиусов, движущихся по кругу с центром в точке центра элемента
управления, с функционалом привязки извне количества кругов, цвета
кругов, прозрачности кругов, размеров кругов, направления движения
кругов (по часовой стрелке, против часовой стрелки - через enum),
скорости вращения;
- NumericKeyboard: элемент управления для отображения клавиатуры с
цифрами от 0 до 9 и кнопки C (стирания последней цифры), с
возможностью привязки стилей для кнопок и команд нажатия на кнопки;
- LetterKeyboard: элемент управления для отображения клавиатуры с
русским и английским алфавитом (переключение языка ввода - по
отдельной кнопке с картинкой), единовременно отображаются кнопки
только для одного языка (по умолчанию - английский), с возможностью
ввода строчных или прописных букв (кнопка CapsLock, по умолчанию -
строчные буквы), с кнопкой стирания, с возможностью привязки стилей
для кнопок и команд нажатия на кнопки;
- DialogHost: элемент управления для диалогов: белый прямоугольник со
скруглёнными углами поверх фона - чёрного прямоугольника, с
возможностью настройки извне: радиуса закругления углов рабочей
области (каждого по отдельности, по умолчанию 0.0), прозрачности фона
(по умолчанию 0.4), команды нажатия на фон диалога, с возможностью
внедрения внешнего содержимого (ContentPresenter);
- MessageDialog: DialogHost с содержимым для диалога с текстом
(TextBlock, завёрнутый в ScrollViewer, с автопереносом текста и
выравниванием по ширине) и кнопками (настройка при помощи свойства
зависимости для своего типа перечисления: Ok, Ok/Cancel, Yes/No), с
возможностью привязки параметров шрифта текста и кнопок (цвет,
размер, толщина, семейство), а также стиля ScrollViewer;
- LoadingDialog: DialogHost с содержимым для диалога загрузки (Spinner с
подписью внизу (по умолчанию “Please, wait...”), с возможностью
привязки параметров шрифта подписи (цвет, размер, толщина,
семейство), а также привязки свойств элемента управления типа Spinner.
3. Реализуйте приложение для визуализации сортировок. Сортируемыми данными
являются числа в диапазоне от 1 до n. Приложение должно предоставлять
следующий функционал:
- задание значения n (в диапазоне от 1 до 10000) при помощи элемента
управления NumericUpDown (из задания 1)
- задание сортировки (вставками, выбором, поразрядная, слиянием,
пирамидальная) при помощи элемента управления ComboBox;
- задание вида отображения сортируемых данных (в виде гистограммы, в
виде круговой диаграммы) при помощи пунктов меню;
- перемешивание данных случайным образом (с отображением процесса
перемешивания, по кнопке);
- запуск и остановка сортировки (по кнопке);
- задание интервала задержки между операциями сравнения элементов и
обмена элементов местами (при помощи элемента управления Slider);<br/>
  
Изменение параметров во время работы сортировки должно быть запрещено.
После запуска выполнения сортировки (по кнопке), необходимо отображать
сравнение элементов коллекции при помощи перекрашивания отображения
элементов, а также обмен элементов местами (использование анимации
необязательно). По нажатию кнопки паузы, выполнение алгоритма
приостанавливается, и пользователь имеет возможность настроить параметры и
по завершению настройки продолжить выполнение сортировки.
Приложение должно быть построено на базе архитектуры MVVM с
использованием функционала, реализованного в заданиях 1 и 2.
