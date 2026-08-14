using Il2CppDummyDll;

namespace LitJson;

[Token(Token = "0x2003B7B")]
internal delegate void ExporterFunc(object obj, JsonWriter writer);
[Token(Token = "0x2003B7C")]
public delegate void ExporterFunc<T>(T obj, JsonWriter writer);
