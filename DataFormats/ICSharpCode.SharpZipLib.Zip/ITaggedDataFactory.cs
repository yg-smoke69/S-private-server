using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Zip;

[Token(Token = "0x2003C0E")]
internal interface ITaggedDataFactory
{
	[Token(Token = "0x6017FB2")]
	ITaggedData Create(short tag, byte[] data, int offset, int count);
}
