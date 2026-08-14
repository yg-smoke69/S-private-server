using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001B3")]
public class MysteryMallLuckyDrawThemeData : CSVBaseData
{
	[Token(Token = "0x20001B4")]
	public enum ECustomLabelType
	{
		[Token(Token = "0x4000A88")]
		LabelCongratulation,
		[Token(Token = "0x4000A89")]
		LabelSuperLuckTip,
		[Token(Token = "0x4000A8A")]
		LabelBtnGoMystery,
		[Token(Token = "0x4000A8B")]
		LabelLuckNum,
		[Token(Token = "0x4000A8C")]
		Upper
	}

	[Token(Token = "0x4000A7F")]
	[FieldOffset(Offset = "0x8")]
	public int ThemeType;

	[Token(Token = "0x4000A80")]
	[FieldOffset(Offset = "0xC")]
	private List<Dictionary<string, string>> m_LabelStyleList;

	[Token(Token = "0x4000A81")]
	[FieldOffset(Offset = "0x10")]
	public bool IsUseDiscountShow;

	[Token(Token = "0x4000A82")]
	[FieldOffset(Offset = "0x14")]
	public string SpriteGetLuckTip;

	[Token(Token = "0x4000A83")]
	[FieldOffset(Offset = "0x18")]
	public string SpriteLuckNum;

	[Token(Token = "0x4000A84")]
	[FieldOffset(Offset = "0x1C")]
	public string SpriteGoMystery;

	[Token(Token = "0x4000A85")]
	[FieldOffset(Offset = "0x20")]
	public ResourceID DrawingMaskEffectID;

	[Token(Token = "0x4000A86")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID StopDrawEffectID;

	[Token(Token = "0x6000948")]
	[Address(RVA = "0x2291EF8", Offset = "0x2291EF8", VA = "0x2291EF8")]
	public MysteryMallLuckyDrawThemeData()
	{
	}

	[Token(Token = "0x6000949")]
	[Address(RVA = "0x2291FB0", Offset = "0x2291FB0", VA = "0x2291FB0", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600094A")]
	[Address(RVA = "0x2292014", Offset = "0x2292014", VA = "0x2292014", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}

	[Token(Token = "0x600094B")]
	[Address(RVA = "0x2292490", Offset = "0x2292490", VA = "0x2292490")]
	private Dictionary<string, string> ReadLabelParams(string str)
	{
		return null;
	}

	[Token(Token = "0x600094C")]
	[Address(RVA = "0x2292688", Offset = "0x2292688", VA = "0x2292688")]
	public object GetLabelStyle(ECustomLabelType luckyDrawLabel, EMysteryMallLabelStyle drawLabelStyle, out bool isSucceed)
	{
		return null;
	}
}
