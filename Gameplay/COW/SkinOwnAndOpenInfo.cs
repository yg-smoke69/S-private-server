using System.Collections.Generic;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20032BF")]
public class SkinOwnAndOpenInfo
{
	[Token(Token = "0x4013521")]
	[FieldOffset(Offset = "0x8")]
	public WeaponSkinData SkinData;

	[Token(Token = "0x4013522")]
	[FieldOffset(Offset = "0xC")]
	public bool IsOpening;

	[Token(Token = "0x4013523")]
	[FieldOffset(Offset = "0x10")]
	public long OpenTime;

	[Token(Token = "0x4013524")]
	[FieldOffset(Offset = "0x18")]
	public bool HaveOwned;

	[Token(Token = "0x4013525")]
	[FieldOffset(Offset = "0x19")]
	public bool CanExchange;

	[Token(Token = "0x4013526")]
	[FieldOffset(Offset = "0x1C")]
	public List<int> FeatureInThisLevel;

	[Token(Token = "0x4013527")]
	[FieldOffset(Offset = "0x20")]
	public List<int> Features;

	[Token(Token = "0x4013528")]
	[FieldOffset(Offset = "0x24")]
	public uint RewardItem;

	[Token(Token = "0x6015696")]
	[Address(RVA = "0x20F000C", Offset = "0x20F000C", VA = "0x20F000C")]
	public SkinOwnAndOpenInfo()
	{
	}
}
