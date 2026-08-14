using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001381")]
public class AvatarProfile
{
	[Token(Token = "0x40089AF")]
	[FieldOffset(Offset = "0x8")]
	public uint avatar_id;

	[Token(Token = "0x40089B0")]
	[FieldOffset(Offset = "0xC")]
	public uint unlocked_level;

	[Token(Token = "0x40089B1")]
	[FieldOffset(Offset = "0x10")]
	public uint skin_color;

	[Token(Token = "0x40089B2")]
	[FieldOffset(Offset = "0x14")]
	public uint[] clothes;

	[Token(Token = "0x40089B3")]
	[FieldOffset(Offset = "0x18")]
	public List<AvatarSkillSlot> equiped_skills;

	[Token(Token = "0x40089B4")]
	[FieldOffset(Offset = "0x1C")]
	public bool is_selected;

	[Token(Token = "0x40089B5")]
	[FieldOffset(Offset = "0x20")]
	public uint pve_primary_weapon;

	[Token(Token = "0x40089B6")]
	[FieldOffset(Offset = "0x24")]
	public bool is_selected_awaken;

	[Token(Token = "0x40089B7")]
	[FieldOffset(Offset = "0x28")]
	public uint end_time;

	[Token(Token = "0x40089B8")]
	[FieldOffset(Offset = "0x2C")]
	public EProfile.UnlockType unlock_type;

	[Token(Token = "0x40089B9")]
	[FieldOffset(Offset = "0x30")]
	public uint unlock_time;

	[Token(Token = "0x40089BA")]
	[FieldOffset(Offset = "0x34")]
	public bool is_marked_star;

	[Token(Token = "0x6007A82")]
	[Address(RVA = "0x317B228", Offset = "0x317B228", VA = "0x317B228")]
	public AvatarProfile()
	{
	}
}
