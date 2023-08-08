using OpenUtau.Api;
using OpenUtau.Core.G2p;

namespace OpenUtau.Core.Enunu
{
    [Phonemizer("Enunu Russian Phonemizer", "ENUNU RU", "O3", language:"RU")]
    public class EnunuRussianPhonemizer: EnunuG2pPhonemizer
    {
        protected override string GetDictionaryName()=>"enudict-ru.yaml";
        protected override IG2p LoadBaseG2p() => new RussianG2p();
        protected override string[] GetBaseG2pVowels() => new string[] {
            "a", "aa", "ay", "ee", "i", "ii", "ja", "je", "jo", "ju", "oo",
            "u", "uj", "uu", "y", "yy"
        };

        protected override string[] GetBaseG2pConsonants() => new string[] {
            "b", "bb", "c", "ch", "d", "dd", "f", "ff", "g", "gg", "h", "hh",
            "j", "k", "kk", "l", "ll", "m", "mm", "n", "nn", "p", "pp", "r", 
            "rr", "s", "sch", "sh", "ss", "t", "tt", "v", "vv", "z", "zh", "zz"
        };
    }
}