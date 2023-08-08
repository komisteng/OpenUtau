using OpenUtau.Api;
using OpenUtau.Core.G2p;

namespace OpenUtau.Core.Enunu
{
    [Phonemizer("Enunu Portuguese Phonemizer", "ENUNU PT", "O3", language:"PT")]
    public class EnunuPortuguesePhonemizer: EnunuG2pPhonemizer
    {
        protected override string GetDictionaryName()=>"enudict-pt.yaml";
        protected override IG2p LoadBaseG2p() => new PortugueseG2p();
        protected override string[] GetBaseG2pVowels() => new string[] {
            "E", "O", "a", "a~", "e", "e~", "i", "i~", "o", "o~", "u", "u~"
        };

        protected override string[] GetBaseG2pConsonants() => new string[] {
            "J", "L", "R", "S", "X", "Z", "b", "d", "dZ", "f", "g", "j", "j~", 
            "k", "l", "m", "n", "p", "r", "s", "t", "tS", "v", "w", "w~", "z"
        };
    }
}