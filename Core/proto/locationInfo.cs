using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200152B")]
public class locationInfo
{
	[Token(Token = "0x40091EE")]
	[FieldOffset(Offset = "0x8")]
	public uint trigger_name;

	[Token(Token = "0x40091EF")]
	[FieldOffset(Offset = "0xC")]
	public uint damage;

	[Token(Token = "0x40091F0")]
	[FieldOffset(Offset = "0x10")]
	public List<wpIdAndKill> wp_ids_and_kill;

	[Token(Token = "0x40091F1")]
	[FieldOffset(Offset = "0x14")]
	public bool emote_used;

	[Token(Token = "0x40091F2")]
	[FieldOffset(Offset = "0x18")]
	public uint vehicle;

	[Token(Token = "0x40091F3")]
	[FieldOffset(Offset = "0x1C")]
	public uint revival_count;

	[Token(Token = "0x6007B74")]
	[Address(RVA = "0x33E6CE0", Offset = "0x33E6CE0", VA = "0x33E6CE0")]
	public locationInfo()
	{
	}
}
