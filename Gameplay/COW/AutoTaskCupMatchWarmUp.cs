using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E5B")]
public class AutoTaskCupMatchWarmUp : AutoPopupTask
{
	[Token(Token = "0x400BF48")]
	[FieldOffset(Offset = "0x8")]
	private UICupMatchWarmUpController m_Ctrl;

	[Token(Token = "0x400BF49")]
	[FieldOffset(Offset = "0xC")]
	private UIModelCupMatch m_Model;

	[Token(Token = "0x60091DB")]
	[Address(RVA = "0x10F281C", Offset = "0x10F281C", VA = "0x10F281C")]
	public AutoTaskCupMatchWarmUp()
	{
	}

	[Token(Token = "0x60091DC")]
	[Address(RVA = "0x10F28E4", Offset = "0x10F28E4", VA = "0x10F28E4", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091DD")]
	[Address(RVA = "0x10F29F0", Offset = "0x10F29F0", VA = "0x10F29F0", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091DE")]
	[Address(RVA = "0x10F2E8C", Offset = "0x10F2E8C", VA = "0x10F2E8C", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
