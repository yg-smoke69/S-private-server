using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B7D")]
internal delegate object ImporterFunc(object input);
[Token(Token = "0x2003B7E")]
public delegate TValue ImporterFunc<TJson, TValue>(TJson input);
