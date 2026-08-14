using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000235")]
public class SnowManData : CSVBaseData
{
	[Token(Token = "0x4000D85")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CLevel_003Ek__BackingField;

	[Token(Token = "0x4000D86")]
	[FieldOffset(Offset = "0xC")]
	private uint[] _003CClothIDs_003Ek__BackingField;

	[Token(Token = "0x1700016C")]
	public uint Level
	{
		[Token(Token = "0x6000B35")]
		[Address(RVA = "0x20F29B0", Offset = "0x20F29B0", VA = "0x20F29B0")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000B36")]
		[Address(RVA = "0x20F29B8", Offset = "0x20F29B8", VA = "0x20F29B8")]
		set
		{
		}
	}

	[Token(Token = "0x1700016D")]
	public uint[] ClothIDs
	{
		[Token(Token = "0x6000B37")]
		[Address(RVA = "0x20F29C0", Offset = "0x20F29C0", VA = "0x20F29C0")]
		get
		{
			return null;
		}
		[Token(Token = "0x6000B38")]
		[Address(RVA = "0x20F29C8", Offset = "0x20F29C8", VA = "0x20F29C8")]
		set
		{
		}
	}

	[Token(Token = "0x6000B34")]
	[Address(RVA = "0x20F292C", Offset = "0x20F292C", VA = "0x20F292C")]
	public SnowManData()
	{
	}

	[Token(Token = "0x6000B39")]
	[Address(RVA = "0x20F29D0", Offset = "0x20F29D0", VA = "0x20F29D0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B3A")]
	[Address(RVA = "0x20F2A4C", Offset = "0x20F2A4C", VA = "0x20F2A4C", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
