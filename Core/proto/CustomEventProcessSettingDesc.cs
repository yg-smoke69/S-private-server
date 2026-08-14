using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001B31")]
public class CustomEventProcessSettingDesc
{
	[Token(Token = "0x400AAEA")]
	[FieldOffset(Offset = "0x8")]
	public uint custom_event_id;

	[Token(Token = "0x400AAEB")]
	[FieldOffset(Offset = "0xC")]
	public uint process_id;

	[Token(Token = "0x400AAEC")]
	[FieldOffset(Offset = "0x10")]
	public ulong start_value;

	[Token(Token = "0x400AAED")]
	[FieldOffset(Offset = "0x18")]
	public ulong end_value;

	[Token(Token = "0x400AAEE")]
	[FieldOffset(Offset = "0x20")]
	public uint time_span;

	[Token(Token = "0x400AAEF")]
	[FieldOffset(Offset = "0x24")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600818C")]
	[Address(RVA = "0x309E26C", Offset = "0x309E26C", VA = "0x309E26C")]
	public CustomEventProcessSettingDesc()
	{
	}
}
