using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2000266")]
public class WeaponSkinUpgradeInfoData : CSVBaseData
{
	[Token(Token = "0x4000EA4")]
	[FieldOffset(Offset = "0x8")]
	public WeaponSkinFeature FeatureInThisLevel;

	[Token(Token = "0x4000EA5")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID Icon;

	[Token(Token = "0x4000EA6")]
	[FieldOffset(Offset = "0x10")]
	public string TitleKey;

	[Token(Token = "0x6000BD0")]
	[Address(RVA = "0x21AB9F0", Offset = "0x21AB9F0", VA = "0x21AB9F0")]
	public WeaponSkinUpgradeInfoData()
	{
	}

	[Token(Token = "0x6000BD1")]
	[Address(RVA = "0x21ABA74", Offset = "0x21ABA74", VA = "0x21ABA74", Slot = "5")]
	public override string GetPrimaryKey()
	{
		return null;
	}

	[Token(Token = "0x6000BD2")]
	[Address(RVA = "0x21ABAF0", Offset = "0x21ABAF0", VA = "0x21ABAF0", Slot = "4")]
	public override void ParseData(long index, int fieldCount, string[] headers, string[] values)
	{
	}
}
