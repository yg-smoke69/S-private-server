using System.Collections.Generic;
using Il2CppDummyDll;

namespace proto;

[Token(Token = "0x2001675")]
public class CSUnlockSkillSlotRes
{
	[Token(Token = "0x400963C")]
	[FieldOffset(Offset = "0x8")]
	public ExchangeChangeData change_data;

	[Token(Token = "0x400963D")]
	[FieldOffset(Offset = "0xC")]
	public List<AvatarProfile> profiles;

	[Token(Token = "0x6007CBF")]
	[Address(RVA = "0x309A57C", Offset = "0x309A57C", VA = "0x309A57C")]
	public CSUnlockSkillSlotRes()
	{
	}
}
