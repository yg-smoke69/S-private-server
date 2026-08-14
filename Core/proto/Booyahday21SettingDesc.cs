using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BC7")]
public class Booyahday21SettingDesc
{
	[Token(Token = "0x400AECE")]
	[FieldOffset(Offset = "0x8")]
	public uint exchange_token;

	[Token(Token = "0x400AECF")]
	[FieldOffset(Offset = "0xC")]
	public uint sugar_token;

	[Token(Token = "0x400AED0")]
	[FieldOffset(Offset = "0x10")]
	public uint loop_round_after_max;

	[Token(Token = "0x400AED1")]
	[FieldOffset(Offset = "0x14")]
	public List<AwardDesc> loop_reward_items;

	[Token(Token = "0x400AED2")]
	[FieldOffset(Offset = "0x18")]
	public List<BISVideoDesc> BIS_videos;

	[Token(Token = "0x400AED3")]
	[FieldOffset(Offset = "0x1C")]
	public uint process_start_timestamp;

	[Token(Token = "0x400AED4")]
	[FieldOffset(Offset = "0x20")]
	public uint premium_store_start_timestamp;

	[Token(Token = "0x6008222")]
	[Address(RVA = "0x317CC7C", Offset = "0x317CC7C", VA = "0x317CC7C")]
	public Booyahday21SettingDesc()
	{
	}
}
