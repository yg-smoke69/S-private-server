using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001671")]
public class CSEquipSkillRes
{
	[Token(Token = "0x4009632")]
	[FieldOffset(Offset = "0x8")]
	public List<AvatarProfile> profiles;

	[Token(Token = "0x6007CBB")]
	[Address(RVA = "0x317FDE4", Offset = "0x317FDE4", VA = "0x317FDE4")]
	public CSEquipSkillRes()
	{
	}
}
