using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000120")]
public class EPMaxRewardData : CSVBaseData
{
	[Token(Token = "0x4000745")]
	[FieldOffset(Offset = "0x8")]
	private uint _003CEPEventID_003Ek__BackingField;

	[Token(Token = "0x4000746")]
	[FieldOffset(Offset = "0xC")]
	private uint _003CBadgeNum_003Ek__BackingField;

	[Token(Token = "0x4000747")]
	[FieldOffset(Offset = "0x10")]
	private uint _003CRewardId_003Ek__BackingField;

	[Token(Token = "0x17000118")]
	public uint EPEventID
	{
		[Token(Token = "0x6000706")]
		[Address(RVA = "0x1C9F8B8", Offset = "0x1C9F8B8", VA = "0x1C9F8B8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000707")]
		[Address(RVA = "0x1C9F8C0", Offset = "0x1C9F8C0", VA = "0x1C9F8C0")]
		private set
		{
		}
	}

	[Token(Token = "0x17000119")]
	public uint BadgeNum
	{
		[Token(Token = "0x6000708")]
		[Address(RVA = "0x1C9F8C8", Offset = "0x1C9F8C8", VA = "0x1C9F8C8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x6000709")]
		[Address(RVA = "0x1C9F8D0", Offset = "0x1C9F8D0", VA = "0x1C9F8D0")]
		private set
		{
		}
	}

	[Token(Token = "0x1700011A")]
	public uint RewardId
	{
		[Token(Token = "0x600070A")]
		[Address(RVA = "0x1C9F8D8", Offset = "0x1C9F8D8", VA = "0x1C9F8D8")]
		get
		{
			return default(uint);
		}
		[Token(Token = "0x600070B")]
		[Address(RVA = "0x1C9F8E0", Offset = "0x1C9F8E0", VA = "0x1C9F8E0")]
		private set
		{
		}
	}

	[Token(Token = "0x6000705")]
	[Address(RVA = "0x1C9F834", Offset = "0x1C9F834", VA = "0x1C9F834")]
	public EPMaxRewardData()
	{
	}

	[Token(Token = "0x600070C")]
	[Address(RVA = "0x1C9F8E8", Offset = "0x1C9F8E8", VA = "0x1C9F8E8", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600070D")]
	[Address(RVA = "0x1C9F964", Offset = "0x1C9F964", VA = "0x1C9F964", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
