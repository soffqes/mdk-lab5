/******************************************************************************
Старовойтова 23ИС-21
Лабораторная 5
В качестве пунктов меню предложить: «*.WAV», «*.MP3», «*.FLAC», «*.MID», «Выход».
Реализовать «пролистывание» без перехода через границы 
(стрелка вверх не работает на элементе с нулевым индексом и стрелка вниз не 
работает на элементе с последним индексом). Подтверждение выбранного пункта 
меню реализовать по клавише «Пробел».
*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
       string[] menuItems = { "*.WAV", "*.MP3", "*.FLAC", "*.MID", "Выход" }; //строковый ммассив с пунктами
        int selectedItem = 0;//индекс выбранного пункта
        while (true) //отображение меню и обработка нажатия клавиш
        {
            Console.Clear();
            Console.WriteLine("Выберите формат файла:");
            for (int i = 0; i < menuItems.Length; i++)
            {
                if (i == selectedItem)
                {
                    Console.BackgroundColor = ConsoleColor.White; //изменение цвета фона для выбранного пункта
                    Console.ForegroundColor = ConsoleColor.Black;//изменение цвета текста 
                }
                Console.WriteLine(menuItems[i]);
                Console.ResetColor();
            }

            ConsoleKeyInfo key = Console.ReadKey();

            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    if (selectedItem > 0)
                    {
                        selectedItem--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (selectedItem < menuItems.Length - 1)
                    {
                        selectedItem++;
                    }
                    break;
                case ConsoleKey.Spacebar:
                    if (selectedItem == menuItems.Length - 1) //пробел и выход из цикла
                    {
                        return;
                    }
                    Console.WriteLine($"\nВы выбрали {menuItems[selectedItem]}");//вывод сообщения о выбранном пункте
                    Console.ReadKey();
                    break;
            }
        }
  }
}
