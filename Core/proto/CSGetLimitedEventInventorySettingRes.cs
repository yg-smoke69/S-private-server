using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200186B")]
public class CSGetLimitedEventInventorySettingRes
{
	[Token(Token = "0x4009CF4")]
	[FieldOffset(Offset = "0x8")]
	public List<BigEventBadgeDesc> badge_descs;

	[Token(Token = "0x6007EC4")]
	[Address(RVA = "0x3186B30", Offset = "0x3186B30", VA = "0x3186B30")]
	public CSGetLimitedEventInventorySettingRes()
	{
	}
}
