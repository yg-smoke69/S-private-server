using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E29")]
public class TeamClothPrivilegeDetail
{
	[Token(Token = "0x400BE7F")]
	[FieldOffset(Offset = "0x8")]
	public TeamClothPrivilegeType Type;

	[Token(Token = "0x400BE80")]
	[FieldOffset(Offset = "0xC")]
	public ResourceID IconID;

	[Token(Token = "0x400BE81")]
	[FieldOffset(Offset = "0x10")]
	public string Title;

	[Token(Token = "0x400BE82")]
	[FieldOffset(Offset = "0x14")]
	public string Desc;

	[Token(Token = "0x600906B")]
	[Address(RVA = "0x289A9C4", Offset = "0x289A9C4", VA = "0x289A9C4")]
	public TeamClothPrivilegeDetail(TeamClothPrivilegeType type, string iconName, string title, string desc)
	{
	}
}
