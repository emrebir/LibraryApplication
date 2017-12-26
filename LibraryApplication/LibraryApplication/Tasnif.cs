using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApplication
{
    public class Tasnif
    {
        public Tasnif()
        {

        }

        int sayia = 1;
        int sayib = 1;
        int sayic = 1;
        int sayiç = 1;
        int sayid = 1;
        int sayie = 1;
        int sayif = 1;
        int sayig = 1;
        int sayih = 1;
        int sayiı = 1;
        int sayii = 1;
        int sayij = 1;
        int sayik = 1;
        int sayil = 1;
        int sayim = 1;
        int sayin = 1;
        int sayio = 1;
        int sayiö = 1;
        int sayip = 1;
        int sayir = 1;
        int sayis = 1;
        int sayiş = 1;
        int sayit = 1;
        int sayiu = 1;
        int sayiü = 1;
        int sayiv = 1;
        int sayiy = 1;
        int sayiz = 1;
        int sayix = 1;


        public string Tasnifle(string kitapAdi)
        {
            
            char ilkharf = kitapAdi[0];

            switch (ilkharf)
            {
                case 'A':
                    return "A" + sayia.ToString("D3");
                    sayia++;
                    break;
                case 'B':
                    return "B" + sayib.ToString("D3");
                    sayib++;
                    break;
                case 'C':
                    return "C" + sayic.ToString("D3");
                    sayic++;
                    break;
                case 'Ç':
                    return "Ç" + sayiç.ToString("D3");
                    sayiç++;
                    break;
                case 'D':
                    return "D" + sayid.ToString("D3");
                    sayid++;
                    break;
                case 'E':
                    return "E" + sayie.ToString("D3");
                    sayie++;
                    break;
                case 'F':
                    return "F" + sayif.ToString("D3");
                    sayif++;
                    break;
                case 'G':
                    return "G" + sayig.ToString("D3");
                    sayig++;
                    break;
                case 'H':
                    return "H" + sayih.ToString("D3");
                    sayih++;
                    break;
                case 'I':
                    return "I" + sayiı.ToString("D3");
                    sayiı++;
                    break;
                case 'İ':
                    return "İ" + sayii.ToString("D3");
                    sayii++;
                    break;
                case 'J':
                    return "J" + sayij.ToString("D3");
                    sayij++;
                    break;
                case 'K':
                    return "K" + sayik.ToString("D3");
                    sayik++;
                    break;
                case 'L':
                    return "L" + sayil.ToString("D3");
                    sayil++;
                    break;
                case 'M':
                    return "M" + sayim.ToString("D3");
                    sayim++;
                    break;
                case 'N':
                    return "N" + sayin.ToString("D3");
                    sayin++;
                    break;
                case 'O':
                    return "O" + sayio.ToString("D3");
                    sayio++;
                    break;
                case 'Ö':
                    return "Ö" + sayiö.ToString("D3");
                    sayiö++;
                    break;
                case 'P':
                    return "P" + sayip.ToString("D3");
                    sayip++;
                    break;
                case 'R':
                    return "R" + sayir.ToString("D3");
                    sayir++;
                    break;
                case 'S':
                    return "S" + sayis.ToString("D3");
                    sayis++;
                    break;
                case 'Ş':
                    return "Ş" + sayiş.ToString("D3");
                    sayiş++;
                    break;
                case 'T':
                    return "T" + sayit.ToString("D3");
                    sayit++;
                    break;
                case 'U':
                    return "U" + sayiu.ToString("D3");
                    sayiu++;
                    break;
                case 'Ü':
                    return "Ü" + sayiü.ToString("D3");
                    sayiü++;
                    break;
                case 'V':
                    return "V" + sayiv.ToString("D3");
                    sayiv++;
                    break;
                case 'Y':
                    return "Y" + sayiy.ToString("D3");
                    sayiy++;
                    break;
                case 'Z':
                    return "Z" + sayiz.ToString("D3");
                    sayiz++;
                    break;
                case 'X':
                    return "X" + sayix.ToString("D3");
                    sayix++;
                    break;

                default:
                    return "XXX";
                    break;
            }

        }
    }
}
