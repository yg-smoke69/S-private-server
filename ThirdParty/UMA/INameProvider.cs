using Il2CppDummyDll;

namespace UMA;

[Token(Token = "0x2003CAC")]
public interface INameProvider
{
	[Token(Token = "0x6018443")]
	string GetAssetName();

	[Token(Token = "0x6018444")]
	int GetNameHash();
}
