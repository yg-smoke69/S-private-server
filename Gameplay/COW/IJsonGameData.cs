using Il2CppDummyDll;
using SimpleJSON;

namespace COW;

[Token(Token = "0x2000249")]
public interface IJsonGameData
{
	[Token(Token = "0x6000B73")]
	void LoadDataFromJsonData(JSONNode jObject);
}
