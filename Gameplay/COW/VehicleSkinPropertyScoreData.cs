using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200025F")]
public class VehicleSkinPropertyScoreData : CSVBaseData
{
	[Token(Token = "0x4000E69")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E6A")]
	[FieldOffset(Offset = "0xC")]
	public string Name;

	[Token(Token = "0x4000E6B")]
	[FieldOffset(Offset = "0x10")]
	public string Region;

	[Token(Token = "0x4000E6C")]
	[FieldOffset(Offset = "0x14")]
	public int Damage;

	[Token(Token = "0x4000E6D")]
	[FieldOffset(Offset = "0x18")]
	public int Speed;

	[Token(Token = "0x4000E6E")]
	[FieldOffset(Offset = "0x1C")]
	public int Acceleration;

	[Token(Token = "0x4000E6F")]
	[FieldOffset(Offset = "0x20")]
	public int ReduceDamage;

	[Token(Token = "0x4000E70")]
	[FieldOffset(Offset = "0x24")]
	public int HP;

	[Token(Token = "0x4000E71")]
	[FieldOffset(Offset = "0x28")]
	public int Controllabilty;

	[Token(Token = "0x6000BBD")]
	[Address(RVA = "0x219FCDC", Offset = "0x219FCDC", VA = "0x219FCDC")]
	public VehicleSkinPropertyScoreData()
	{
	}

	[Token(Token = "0x6000BBE")]
	[Address(RVA = "0x219FD60", Offset = "0x219FD60", VA = "0x219FD60")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000BBF")]
	[Address(RVA = "0x219FDB8", Offset = "0x219FDB8", VA = "0x219FDB8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BC0")]
	[Address(RVA = "0x219FE1C", Offset = "0x219FE1C", VA = "0x219FE1C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
