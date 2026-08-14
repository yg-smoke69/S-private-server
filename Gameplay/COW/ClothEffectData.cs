using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000BB")]
public class ClothEffectData : CSVBaseData, _Attribute
{
	[Token(Token = "0x4000490")]
	[FieldOffset(Offset = "0x8")]
	public uint quality;

	[Token(Token = "0x4000491")]
	[FieldOffset(Offset = "0xC")]
	public uint effectMyCloth;

	[Token(Token = "0x4000492")]
	[FieldOffset(Offset = "0x10")]
	public uint effectTeammateCloth;

	[Token(Token = "0x4000493")]
	[FieldOffset(Offset = "0x14")]
	public uint effectEnemyCloth;

	[Token(Token = "0x600054B")]
	[Address(RVA = "0x172E378", Offset = "0x172E378", VA = "0x172E378")]
	public ClothEffectData()
	{
	}

	[Token(Token = "0x600054C")]
	[Address(RVA = "0x172E3FC", Offset = "0x172E3FC", VA = "0x172E3FC", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600054D")]
	[Address(RVA = "0x172E460", Offset = "0x172E460", VA = "0x172E460", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x600054E")]
	[Address(RVA = "0x172E4B8", Offset = "0x172E4B8", VA = "0x172E4B8", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
