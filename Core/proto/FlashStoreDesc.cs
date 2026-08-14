using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001AAC")]
public class FlashStoreDesc
{
	[Token(Token = "0x400A7B4")]
	[FieldOffset(Offset = "0x8")]
	public uint flash_store_activity_id;

	[Token(Token = "0x400A7B5")]
	[FieldOffset(Offset = "0x10")]
	public long start_time;

	[Token(Token = "0x400A7B6")]
	[FieldOffset(Offset = "0x18")]
	public long end_time;

	[Token(Token = "0x400A7B7")]
	[FieldOffset(Offset = "0x20")]
	public uint flash_store_id;

	[Token(Token = "0x400A7B8")]
	[FieldOffset(Offset = "0x24")]
	public uint flash_gem_id;

	[Token(Token = "0x400A7B9")]
	[FieldOffset(Offset = "0x28")]
	public List<FlashStorePeriodInfo> period_infos;

	[Token(Token = "0x400A7BA")]
	[FieldOffset(Offset = "0x2C")]
	public string store_title_url;

	[Token(Token = "0x400A7BB")]
	[FieldOffset(Offset = "0x30")]
	public string mission_title_url;

	[Token(Token = "0x400A7BC")]
	[FieldOffset(Offset = "0x34")]
	public string language;

	[Token(Token = "0x6008109")]
	[Address(RVA = "0x30A0D74", Offset = "0x30A0D74", VA = "0x30A0D74")]
	public FlashStoreDesc()
	{
	}
}
