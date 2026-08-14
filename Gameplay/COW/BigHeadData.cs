using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20000C5")]
public class BigHeadData : CSVBaseData
{
	[Token(Token = "0x40004AF")]
	[FieldOffset(Offset = "0x8")]
	public uint Lv;

	[Token(Token = "0x40004B0")]
	[FieldOffset(Offset = "0xC")]
	public float HeadScale;

	[Token(Token = "0x40004B1")]
	[FieldOffset(Offset = "0x10")]
	public float HeadShotDamageScale;

	[Token(Token = "0x40004B2")]
	[FieldOffset(Offset = "0x14")]
	public int KillScore;

	[Token(Token = "0x40004B3")]
	[FieldOffset(Offset = "0x18")]
	public int BoostKillScore;

	[Token(Token = "0x40004B4")]
	[FieldOffset(Offset = "0x1C")]
	public uint HeadAvatar;

	[Token(Token = "0x40004B5")]
	[FieldOffset(Offset = "0x20")]
	public int NeedKillCount;

	[Token(Token = "0x40004B6")]
	[FieldOffset(Offset = "0x24")]
	public ResourceID EffectID;

	[Token(Token = "0x40004B7")]
	[FieldOffset(Offset = "0x28")]
	public ResourceID HeadIcon;

	[Token(Token = "0x40004B8")]
	[FieldOffset(Offset = "0x2C")]
	public ResourceID LightHeadIcon;

	[Token(Token = "0x40004B9")]
	[FieldOffset(Offset = "0x30")]
	public ResourceID LightOffHeadIcon;

	[Token(Token = "0x40004BA")]
	[FieldOffset(Offset = "0x34")]
	public string Name;

	[Token(Token = "0x600056F")]
	[Address(RVA = "0x1809714", Offset = "0x1809714", VA = "0x1809714")]
	public BigHeadData()
	{
	}

	[Token(Token = "0x6000570")]
	[Address(RVA = "0x1809798", Offset = "0x1809798", VA = "0x1809798", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000571")]
	[Address(RVA = "0x18097FC", Offset = "0x18097FC", VA = "0x18097FC", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
