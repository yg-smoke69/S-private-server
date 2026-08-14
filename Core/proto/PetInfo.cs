using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001397")]
public class PetInfo
{
	[Token(Token = "0x4008A15")]
	[FieldOffset(Offset = "0x8")]
	public uint id;

	[Token(Token = "0x4008A16")]
	[FieldOffset(Offset = "0xC")]
	public string name;

	[Token(Token = "0x4008A17")]
	[FieldOffset(Offset = "0x10")]
	public uint level;

	[Token(Token = "0x4008A18")]
	[FieldOffset(Offset = "0x14")]
	public uint exp;

	[Token(Token = "0x4008A19")]
	[FieldOffset(Offset = "0x18")]
	public bool is_selected;

	[Token(Token = "0x4008A1A")]
	[FieldOffset(Offset = "0x1C")]
	public uint skin_id;

	[Token(Token = "0x4008A1B")]
	[FieldOffset(Offset = "0x20")]
	public uint[] actions;

	[Token(Token = "0x4008A1C")]
	[FieldOffset(Offset = "0x24")]
	public List<PetSkillInfo> skills;

	[Token(Token = "0x4008A1D")]
	[FieldOffset(Offset = "0x28")]
	public uint selected_skill_id;

	[Token(Token = "0x6007A92")]
	[Address(RVA = "0x33DF63C", Offset = "0x33DF63C", VA = "0x33DF63C")]
	public PetInfo()
	{
	}
}
