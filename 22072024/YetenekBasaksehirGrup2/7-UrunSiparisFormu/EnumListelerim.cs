using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_UrunSiparisFormu
{
    /*
     Enumeration (enum) bir türdür ve genellikle gruplandırılması veya birbirine bağlı olması gereken durumlar için kullanılır:

    1-Durumları belirtirken: (beklemede, tamamlandı, iptal edildi)
    2- Seçenekler   : (kadın, erkek)
    3-Sabitler      : (aylar, haftanın günleri)

     */
    enum Aylar
    {
        Ocak,
        Şubat,
        Mart
    }

    enum Kategoriler : byte
    {
        Elektronik = 1,
        EvEşyalari = 2,
        BahçeMalzemeleri = 3
    }
}
