using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B4E")]
internal delegate object ImporterFunc(object input);
[Token(Token = "0x2003B4F")]
public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
