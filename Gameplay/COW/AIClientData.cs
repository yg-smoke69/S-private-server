using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000099")]
public class AIClientData : CSVBaseData
{
	[Token(Token = "0x400035C")]
	[FieldOffset(Offset = "0x8")]
	public int ID;

	[Token(Token = "0x400035D")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID InGameModel;

	[Token(Token = "0x400035E")]
	[FieldOffset(Offset = "0x10")]
	public float BaseWalkSpeed;

	[Token(Token = "0x400035F")]
	[FieldOffset(Offset = "0x14")]
	public float BaseRunSpeed;

	[Token(Token = "0x4000360")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID[] TransformLevelModels;

	[Token(Token = "0x60003C7")]
	[Address(RVA = "0x14B7C08", Offset = "0x14B7C08", VA = "0x14B7C08")]
	public AIClientData()
	{
	}

	[Token(Token = "0x60003C8")]
	[Address(RVA = "0x14B7C8C", Offset = "0x14B7C8C", VA = "0x14B7C8C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60003C9")]
	[Address(RVA = "0x14B7CF0", Offset = "0x14B7CF0", VA = "0x14B7CF0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
