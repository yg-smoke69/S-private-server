using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E68")]
public class AutoTaskPetLevelUp : AutoPopupTask
{
	[Token(Token = "0x400BF66")]
	[FieldOffset(Offset = "0x8")]
	private UIPetLevelUpController m_PetLevelUpUI;

	[Token(Token = "0x6009218")]
	[Address(RVA = "0x10F885C", Offset = "0x10F885C", VA = "0x10F885C")]
	public AutoTaskPetLevelUp()
	{
	}

	[Token(Token = "0x6009219")]
	[Address(RVA = "0x10F8864", Offset = "0x10F8864", VA = "0x10F8864", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x600921A")]
	[Address(RVA = "0x10F88BC", Offset = "0x10F88BC", VA = "0x10F88BC", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x600921B")]
	[Address(RVA = "0x10F8BB0", Offset = "0x10F8BB0", VA = "0x10F8BB0", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
