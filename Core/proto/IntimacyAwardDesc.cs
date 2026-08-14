using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001ACD")]
public class IntimacyAwardDesc
{
	[Token(Token = "0x400A8C0")]
	[FieldOffset(Offset = "0x8")]
	public EFriend.RelationType relation_type;

	[Token(Token = "0x400A8C1")]
	[FieldOffset(Offset = "0xC")]
	public uint rank;

	[Token(Token = "0x400A8C2")]
	[FieldOffset(Offset = "0x10")]
	public List<AwardDesc> awards;

	[Token(Token = "0x600812A")]
	[Address(RVA = "0x30A3D2C", Offset = "0x30A3D2C", VA = "0x30A3D2C")]
	public IntimacyAwardDesc()
	{
	}
}
