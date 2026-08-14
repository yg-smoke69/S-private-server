using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000221")]
public class RushingPetsRoomSettingData : CSVBaseData
{
	[Token(Token = "0x4000CAA")]
	[FieldOffset(Offset = "0x8")]
	public int TypeID;

	[Token(Token = "0x4000CAB")]
	[FieldOffset(Offset = "0xC")]
	public string LocKey;

	[Token(Token = "0x4000CAC")]
	[FieldOffset(Offset = "0x10")]
	public uint DefaultValue;

	[Token(Token = "0x4000CAD")]
	[FieldOffset(Offset = "0x14")]
	public uint MinValue;

	[Token(Token = "0x4000CAE")]
	[FieldOffset(Offset = "0x18")]
	public uint MaxValue;

	[Token(Token = "0x4000CAF")]
	[FieldOffset(Offset = "0x1C")]
	public uint StepValue;

	[Token(Token = "0x4000CB0")]
	[FieldOffset(Offset = "0x20")]
	public uint[] OptionValues;

	[Token(Token = "0x4000CB1")]
	[FieldOffset(Offset = "0x24")]
	public int Enable;

	[Token(Token = "0x4000CB2")]
	[FieldOffset(Offset = "0x28")]
	public bool IsEnable;

	[Token(Token = "0x6000AD1")]
	[Address(RVA = "0x241BF8C", Offset = "0x241BF8C", VA = "0x241BF8C")]
	public RushingPetsRoomSettingData()
	{
	}

	[Token(Token = "0x6000AD2")]
	[Address(RVA = "0x241C010", Offset = "0x241C010", VA = "0x241C010", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000AD3")]
	[Address(RVA = "0x241C074", Offset = "0x241C074", VA = "0x241C074", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
