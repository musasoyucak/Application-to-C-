using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NufusKontrol
{
    /*
       Kontrol sınıfında kontrol et metodu oluşturulacak  kimlikbilgileri nesnesi parametresi alacak 
  mainde kontrol et metodu çalıştırılarak kimlik kontrolü yapılacak 
     */
    internal class Kontrol
    {
        public void KontrolEt(IKimlikBilgileri _kimlik)
        {
            _kimlik.Kullanim();
        }
    }
}
