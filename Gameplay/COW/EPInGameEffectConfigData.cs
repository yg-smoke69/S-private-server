using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200011F")]
public class EPInGameEffectConfigData : CSVBaseData
{
	[Token(Token = "0x4000740")]
	[FieldOffset(Offset = "0x8")]
	public string Region;

	[Token(Token = "0x4000741")]
	[FieldOffset(Offset = "0xC")]
	public uint ID;

	[Token(Token = "0x4000742")]
	[FieldOffset(Offset = "0x10")]
	public uint EPEventId;

	[Token(Token = "0x4000743")]
	[FieldOffset(Offset = "0x14")]
	public uint IsOpen;

	[Token(Token = "0x4000744")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID EffectResource;

	[Token(Token = "0x6000702")]
	[Address(RVA = "0x1C9F4B0", Offset = "0x1C9F4B0", VA = "0x1C9F4B0")]
	public EPInGameEffectConfigData()
	{
	}

	[Token(Token = "0x6000703")]
	[Address(RVA = "0x1C9F57C", Offset = "0x1C9F57C", VA = "0x1C9F57C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000704")]
	[Address(RVA = "0x1C9F5E0", Offset = "0x1C9F5E0", VA = "0x1C9F5E0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
