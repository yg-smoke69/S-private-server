using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200010F")]
public class DestructibleObjectConfigData : CSVBaseData, _Attribute
{
	[Token(Token = "0x40006DC")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x40006DD")]
	[FieldOffset(Offset = "0xC")]
	public uint HP;

	[Token(Token = "0x40006DE")]
	[FieldOffset(Offset = "0x10")]
	public uint HalfDestroyHP;

	[Token(Token = "0x40006DF")]
	[FieldOffset(Offset = "0x14")]
	public ResourceID HalfDestroyVFX;

	[Token(Token = "0x40006E0")]
	[FieldOffset(Offset = "0x18")]
	public ResourceID DestroyVFX;

	[Token(Token = "0x40006E1")]
	[FieldOffset(Offset = "0x1C")]
	public ResourceID HalfDestroyPrefabResID;

	[Token(Token = "0x40006E2")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID NormalPrefabResID;

	[Token(Token = "0x40006E3")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID HalfDestroySound;

	[Token(Token = "0x40006E4")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID DestroySound;

	[Token(Token = "0x60006BC")]
	[Address(RVA = "0x1C8B9AC", Offset = "0x1C8B9AC", VA = "0x1C8B9AC")]
	public DestructibleObjectConfigData()
	{
	}

	[Token(Token = "0x60006BD")]
	[Address(RVA = "0x1C8BAB4", Offset = "0x1C8BAB4", VA = "0x1C8BAB4", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x60006BE")]
	[Address(RVA = "0x1C8BB0C", Offset = "0x1C8BB0C", VA = "0x1C8BB0C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x60006BF")]
	[Address(RVA = "0x1C8BB70", Offset = "0x1C8BB70", VA = "0x1C8BB70", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
