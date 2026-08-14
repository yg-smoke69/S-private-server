using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2000250")]
public class TreasureBoxData : CsvDataIndexedReading, _Attribute
{
	[Token(Token = "0x4000E07")]
	[FieldOffset(Offset = "0x8")]
	public uint ID;

	[Token(Token = "0x4000E08")]
	[FieldOffset(Offset = "0xC")]
	public uint AwardID;

	[Token(Token = "0x4000E09")]
	[FieldOffset(Offset = "0x10")]
	public uint AwardNum;

	[Token(Token = "0x4000E0A")]
	[FieldOffset(Offset = "0x14")]
	public uint AwardTime;

	[Token(Token = "0x4000E0B")]
	[FieldOffset(Offset = "0x18")]
	public EInventory.AwardType AwardType;

	[Token(Token = "0x4000E0C")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsPreview;

	[Token(Token = "0x4000E0D")]
	[FieldOffset(Offset = "0x20")]
	public uint PreviewAvatar;

	[Token(Token = "0x4000E0E")]
	[FieldOffset(Offset = "0x24")]
	public bool IsBigReward;

	[Token(Token = "0x4000E0F")]
	[FieldOffset(Offset = "0x28")]
	public uint Rewardlevel;

	[Token(Token = "0x4000E10")]
	[FieldOffset(Offset = "0x2C")]
	public bool ComposeIcon;

	[Token(Token = "0x6000B80")]
	[Address(RVA = "0x232E37C", Offset = "0x232E37C", VA = "0x232E37C")]
	public TreasureBoxData()
	{
	}

	[Token(Token = "0x6000B81")]
	[Address(RVA = "0x232E384", Offset = "0x232E384", VA = "0x232E384", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000B82")]
	[Address(RVA = "0x232E3E8", Offset = "0x232E3E8", VA = "0x232E3E8", Slot = "9")]
	public uint GetId()
	{
		return default(uint);
	}

	[Token(Token = "0x6000B83")]
	[Address(RVA = "0x232E440", Offset = "0x232E440", VA = "0x232E440", Slot = "7")]
	public override string[] GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000B84")]
	[Address(RVA = "0x232E93C", Offset = "0x232E93C", VA = "0x232E93C", Slot = "8")]
	public override void ParseData(IIndexString ss, int[] index)
	{
	}

	[Token(Token = "0x6000B85")]
	[Address(RVA = "0x232F20C", Offset = "0x232F20C", VA = "0x232F20C")]
	public string[] _003C_003EiFixBaseProxy_GetHeadColNames()
	{
		return null;
	}

	[Token(Token = "0x6000B86")]
	[Address(RVA = "0x232F214", Offset = "0x232F214", VA = "0x232F214")]
	public void _003C_003EiFixBaseProxy_ParseData(IIndexString P0, int[] P1)
	{
	}
}
