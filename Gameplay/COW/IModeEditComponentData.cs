using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E5C")]
public interface IModeEditComponentData
{
	[Token(Token = "0x17001418")]
	GeneralComponentData GeneralData
	{
		[Token(Token = "0x6013644")]
		get;
		[Token(Token = "0x6013645")]
		set;
	}

	[Token(Token = "0x6013646")]
	bool FromJsonData(ModeVariables contextVariables, JsonData jsonData);
}
