using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A59")]
public class AvatarAwaken
{
	[Token(Token = "0x400A4FD")]
	[FieldOffset(Offset = "0x8")]
	public uint awaken_avatar_id;

	[Token(Token = "0x400A4FE")]
	[FieldOffset(Offset = "0xC")]
	public uint original_avatar_id;

	[Token(Token = "0x400A4FF")]
	[FieldOffset(Offset = "0x10")]
	public string awaken_cdn;

	[Token(Token = "0x400A500")]
	[FieldOffset(Offset = "0x14")]
	public string unlock_time;

	[Token(Token = "0x400A501")]
	[FieldOffset(Offset = "0x18")]
	public List<AwardDesc> awards;

	[Token(Token = "0x400A502")]
	[FieldOffset(Offset = "0x1C")]
	public string awaken_description;

	[Token(Token = "0x400A503")]
	[FieldOffset(Offset = "0x20")]
	public string awaken_title;

	[Token(Token = "0x400A504")]
	[FieldOffset(Offset = "0x24")]
	public string go_pos;

	[Token(Token = "0x400A505")]
	[FieldOffset(Offset = "0x28")]
	public string end_time;

	[Token(Token = "0x60080B1")]
	[Address(RVA = "0x317B03C", Offset = "0x317B03C", VA = "0x317B03C")]
	public AvatarAwaken()
	{
	}
}
