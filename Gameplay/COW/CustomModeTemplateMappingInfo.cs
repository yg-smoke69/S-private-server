using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E5B")]
public class CustomModeTemplateMappingInfo
{
	[Token(Token = "0x4011B62")]
	[FieldOffset(Offset = "0x8")]
	public string name;

	[Token(Token = "0x4011B63")]
	[FieldOffset(Offset = "0xC")]
	public int index;

	[Token(Token = "0x4011B64")]
	[FieldOffset(Offset = "0x10")]
	public int twoTeamsTemplateId;

	[Token(Token = "0x4011B65")]
	[FieldOffset(Offset = "0x14")]
	public int mulTeamsTemplateId;

	[Token(Token = "0x6013642")]
	[Address(RVA = "0x1C88398", Offset = "0x1C88398", VA = "0x1C88398")]
	public CustomModeTemplateMappingInfo()
	{
	}

	[Token(Token = "0x6013643")]
	[Address(RVA = "0x1C883A0", Offset = "0x1C883A0", VA = "0x1C883A0")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
