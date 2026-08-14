using Il2CppDummyDll;
using LitJson;

namespace COW;

[Token(Token = "0x2002E5D")]
public class GeneralComponentData
{
	[Token(Token = "0x4011B66")]
	[FieldOffset(Offset = "0x8")]
	public ModeVariables ContextVariables;

	[Token(Token = "0x4011B67")]
	[FieldOffset(Offset = "0xC")]
	public string type;

	[Token(Token = "0x4011B68")]
	[FieldOffset(Offset = "0x10")]
	public string labelKey;

	[Token(Token = "0x4011B69")]
	[FieldOffset(Offset = "0x14")]
	public string tipKey;

	[Token(Token = "0x4011B6A")]
	[FieldOffset(Offset = "0x18")]
	public ModeVariableBinding enabled;

	[Token(Token = "0x6013647")]
	[Address(RVA = "0x2590190", Offset = "0x2590190", VA = "0x2590190")]
	public GeneralComponentData()
	{
	}

	[Token(Token = "0x6013648")]
	[Address(RVA = "0x2590198", Offset = "0x2590198", VA = "0x2590198")]
	public bool FromJsonData(ModeVariables contextVariables, JsonData jsonData)
	{
		return default(bool);
	}
}
