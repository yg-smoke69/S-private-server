using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001A55")]
public class AvatarHideDesc
{
	[Token(Token = "0x400A4EE")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarHide> avatar_hide;

	[Token(Token = "0x60080AD")]
	[Address(RVA = "0x317B18C", Offset = "0x317B18C", VA = "0x317B18C")]
	public AvatarHideDesc()
	{
	}
}
