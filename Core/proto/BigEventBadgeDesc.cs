using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001BA0")]
public class BigEventBadgeDesc
{
	[Token(Token = "0x400ADC8")]
	[FieldOffset(Offset = "0x8")]
	public uint event_id;

	[Token(Token = "0x400ADC9")]
	[FieldOffset(Offset = "0xC")]
	public uint big_event_badge_id;

	[Token(Token = "0x400ADCA")]
	[FieldOffset(Offset = "0x10")]
	public string name;

	[Token(Token = "0x400ADCB")]
	[FieldOffset(Offset = "0x14")]
	public string desc;

	[Token(Token = "0x400ADCC")]
	[FieldOffset(Offset = "0x18")]
	public string icon;

	[Token(Token = "0x400ADCD")]
	[FieldOffset(Offset = "0x1C")]
	public uint rare;

	[Token(Token = "0x400ADCE")]
	[FieldOffset(Offset = "0x20")]
	public List<GoPosShow> go_pos_shows;

	[Token(Token = "0x60081FB")]
	[Address(RVA = "0x317BBF0", Offset = "0x317BBF0", VA = "0x317BBF0")]
	public BigEventBadgeDesc()
	{
	}
}
