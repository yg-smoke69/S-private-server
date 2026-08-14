using Il2CppDummyDll;

namespace FFVoice;

[Token(Token = "0x2003B4C")]
internal delegate void ExporterFunc(object obj, JsonWriter writer);
[Token(Token = "0x2003B4D")]
public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
