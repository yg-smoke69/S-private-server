using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200156C")]
public class CSGetCupConfigRes
{
	[Token(Token = "0x4009315")]
	[FieldOffset(Offset = "0x8")]
	public CupOpenInfoDesc open_info;

	[Token(Token = "0x4009316")]
	[FieldOffset(Offset = "0xC")]
	public CupSettingDesc cup_setting;

	[Token(Token = "0x4009317")]
	[FieldOffset(Offset = "0x10")]
	public List<CupTierDesc> tiers;

	[Token(Token = "0x4009318")]
	[FieldOffset(Offset = "0x14")]
	public CupCDNSettingDesc cdn_setting;

	[Token(Token = "0x4009319")]
	[FieldOffset(Offset = "0x18")]
	public List<CupNameOverwriteDesc> name_overwrite;

	[Token(Token = "0x400931A")]
	[FieldOffset(Offset = "0x1C")]
	public List<CupChestDesc> chests;

	[Token(Token = "0x400931B")]
	[FieldOffset(Offset = "0x20")]
	public bool is_in_blocklist;

	[Token(Token = "0x6007BB4")]
	[Address(RVA = "0x31835A8", Offset = "0x31835A8", VA = "0x31835A8")]
	public CSGetCupConfigRes()
	{
	}
}
