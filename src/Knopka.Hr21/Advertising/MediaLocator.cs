using System;
using System.Collections.Generic;
using System.IO;

namespace Knopka.Hr21.Advertising
{
    public class MediaLocator
    {
        // В конструктор передаются данные о рекламоносителях и локациях.
        // ===== пример данных =====
        // Яндекс.Директ:/ru
        // Бегущая строка в троллейбусах Екатеринбурга:/ru/svrd/ekb
        // Быстрый курьер:/ru/svrd/ekb
        // Ревдинский рабочий:/ru/svrd/revda,/ru/svrd/pervik
        // Газета уральских москвичей:/ru/msk,/ru/permobl/,/ru/chelobl
        // ===== конец примера данных =====
        // inputStream будет уничтожен после вызова конструктора.
        public MediaLocator(Stream inputStream)
        {
        }

        // В метод передаётся локация.
        // Надо вернуть все рекламоносители, которые действуют в этой локации.
        // Например, GetMediasForLocation("/ru/svrd/pervik") должен вернуть две строки:
        // "Яндекс.Директ", "Ревдинский рабочий"
        // Порядок строк не имеет значения.
        public IEnumerable<string> GetMediasForLocation(string location)
        {
            return Array.Empty<string>();
        }
    }
}