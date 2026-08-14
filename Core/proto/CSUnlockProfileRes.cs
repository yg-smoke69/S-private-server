using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x200166F")]
public class CSUnlockProfileRes
{
	[Token(Token = "0x400962B")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarProfile> affected_profiles;

	[Token(Token = "0x400962C")]
	[FieldOffset(Offset = "0xC")]
	public List<Item> award_items;

	[Token(Token = "0x6007CB9")]
	[Address(RVA = "0x309A4B4", Offset = "0x309A4B4", VA = "0x309A4B4")]
	public CSUnlockProfileRes()
	{
	}
}
