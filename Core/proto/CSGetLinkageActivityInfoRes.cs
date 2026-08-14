using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x20017C3")]
public class CSGetLinkageActivityInfoRes
{
	[Token(Token = "0x4009B57")]
	[FieldOffset(Offset = "0x8")]
	public uint day;

	[Token(Token = "0x4009B58")]
	[FieldOffset(Offset = "0xC")]
	public uint activity_id;

	[Token(Token = "0x4009B59")]
	[FieldOffset(Offset = "0x10")]
	public uint activity_type;

	[Token(Token = "0x4009B5A")]
	[FieldOffset(Offset = "0x14")]
	public uint today_data;

	[Token(Token = "0x4009B5B")]
	[FieldOffset(Offset = "0x18")]
	public uint total_data;

	[Token(Token = "0x4009B5C")]
	[FieldOffset(Offset = "0x1C")]
	public EActivity.State state;

	[Token(Token = "0x4009B5D")]
	[FieldOffset(Offset = "0x20")]
	public long timezone_offset_secs;

	[Token(Token = "0x4009B5E")]
	[FieldOffset(Offset = "0x28")]
	public ulong global_ep_badges;

	[Token(Token = "0x4009B5F")]
	[FieldOffset(Offset = "0x30")]
	public List<LinkageProcessRewards> process_rewards;

	[Token(Token = "0x4009B60")]
	[FieldOffset(Offset = "0x34")]
	public string cdn_url;

	[Token(Token = "0x6007E1D")]
	[Address(RVA = "0x3186ECC", Offset = "0x3186ECC", VA = "0x3186ECC")]
	public CSGetLinkageActivityInfoRes()
	{
	}
}
