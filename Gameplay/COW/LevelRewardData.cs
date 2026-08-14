using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x200016F")]
public class LevelRewardData : CSVBaseData
{
	[Token(Token = "0x400093E")]
	[FieldOffset(Offset = "0x8")]
	public uint m_TargetLevel;

	[Token(Token = "0x400093F")]
	[FieldOffset(Offset = "0xC")]
	public uint m_AwardType1;

	[Token(Token = "0x4000940")]
	[FieldOffset(Offset = "0x10")]
	public uint m_AwardID1;

	[Token(Token = "0x4000941")]
	[FieldOffset(Offset = "0x14")]
	public uint m_AwardNum1;

	[Token(Token = "0x4000942")]
	[FieldOffset(Offset = "0x18")]
	public uint m_AwardMaxNum1;

	[Token(Token = "0x4000943")]
	[FieldOffset(Offset = "0x1C")]
	public uint m_AwardType2;

	[Token(Token = "0x4000944")]
	[FieldOffset(Offset = "0x20")]
	public uint m_AwardID2;

	[Token(Token = "0x4000945")]
	[FieldOffset(Offset = "0x24")]
	public uint m_AwardNum2;

	[Token(Token = "0x4000946")]
	[FieldOffset(Offset = "0x28")]
	public uint m_AwardMaxNum2;

	[Token(Token = "0x4000947")]
	[FieldOffset(Offset = "0x2C")]
	public uint m_AwardType3;

	[Token(Token = "0x4000948")]
	[FieldOffset(Offset = "0x30")]
	public uint m_AwardID3;

	[Token(Token = "0x4000949")]
	[FieldOffset(Offset = "0x34")]
	public uint m_AwardNum3;

	[Token(Token = "0x400094A")]
	[FieldOffset(Offset = "0x38")]
	public uint m_AwardMaxNum3;

	[Token(Token = "0x400094B")]
	[FieldOffset(Offset = "0x3C")]
	public List<AwardDesc> m_AwardList;

	[Token(Token = "0x6000872")]
	[Address(RVA = "0xEBEA6C", Offset = "0xEBEA6C", VA = "0xEBEA6C")]
	public LevelRewardData()
	{
	}

	[Token(Token = "0x6000873")]
	[Address(RVA = "0xEBEB24", Offset = "0xEBEB24", VA = "0xEBEB24", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000874")]
	[Address(RVA = "0xEBEB88", Offset = "0xEBEB88", VA = "0xEBEB88", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x6000875")]
	[Address(RVA = "0xEBEE94", Offset = "0xEBEE94", VA = "0xEBEE94")]
	private void BuildRewardList()
	{
	}
}
