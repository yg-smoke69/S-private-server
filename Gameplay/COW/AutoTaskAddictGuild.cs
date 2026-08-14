using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E48")]
public class AutoTaskAddictGuild : AutoPopupTask
{
	[Token(Token = "0x400BF24")]
	[FieldOffset(Offset = "0x8")]
	private UIAddictGuideController m_UIAddictGuideController;

	[Token(Token = "0x6009186")]
	[Address(RVA = "0x10E9100", Offset = "0x10E9100", VA = "0x10E9100")]
	public AutoTaskAddictGuild()
	{
	}

	[Token(Token = "0x6009187")]
	[Address(RVA = "0x10E9108", Offset = "0x10E9108", VA = "0x10E9108", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x6009188")]
	[Address(RVA = "0x10E9448", Offset = "0x10E9448", VA = "0x10E9448", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}

	[Token(Token = "0x6009189")]
	[Address(RVA = "0x10E9548", Offset = "0x10E9548", VA = "0x10E9548", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}
}
