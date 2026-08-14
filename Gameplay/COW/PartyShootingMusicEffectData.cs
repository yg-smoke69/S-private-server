using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20001CB")]
public class PartyShootingMusicEffectData : CSVBaseData
{
	[Token(Token = "0x4000AF9")]
	[FieldOffset(Offset = "0x8")]
	public uint EffectLevel;

	[Token(Token = "0x4000AFA")]
	[FieldOffset(Offset = "0xC")]
	public uint NeedCombo;

	[Token(Token = "0x600099C")]
	[Address(RVA = "0x28D1588", Offset = "0x28D1588", VA = "0x28D1588")]
	public PartyShootingMusicEffectData()
	{
	}

	[Token(Token = "0x600099D")]
	[Address(RVA = "0x28D160C", Offset = "0x28D160C", VA = "0x28D160C", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x600099E")]
	[Address(RVA = "0x28D1670", Offset = "0x28D1670", VA = "0x28D1670", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
