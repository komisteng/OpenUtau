using OpenUtau.Api;
using OpenUtau.Core.G2p;

namespace OpenUtau.Core.Enunu
{
    [Phonemizer("Enunu German Phonemizer", "ENUNU DE", "O3", language:"DE")]
    public class EnunuGermanPhonemizer: EnunuG2pPhonemizer
    {
        readonly string PhonemizerType = "ENUNU DE";
        protected override string GetDictionaryName()=>"enudict-de.yaml";
        protected override IG2p LoadBaseG2p() => new GermanG2p();
        protected override string[] GetBaseG2pVowels() => new string[] {
            "aa", "ae", "ah", "ao", "aw", "ax", "ay", "ee", "eh", "er", "ex",
            "ih", "iy", "oe", "ohh", "ooh", "oy", "ue", "uh", "uw", "yy"
        };

        protected override string[] GetBaseG2pConsonants() => new string[] {
            "b", "cc", "ch", "d", "dh", "f", "g", "hh", "jh", "k", "l", "m",
            "n", "ng", "p", "pf", "q", "r", "rr", "s", "sh", "t", "th", "ts", 
            "v", "w", "x", "y", "z", "zh"
        };
    }
}