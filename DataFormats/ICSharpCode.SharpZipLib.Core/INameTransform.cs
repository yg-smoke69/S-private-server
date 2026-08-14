using Il2CppDummyDll;

namespace ICSharpCode.SharpZipLib.Core;

[Token(Token = "0x2003BE1")]
public interface INameTransform
{
	[Token(Token = "0x6017E25")]
	string TransformFile(string name);

	[Token(Token = "0x6017E26")]
	string TransformDirectory(string name);
}
