using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001E62")]
internal class AutoTaskIAPBundleFirstTime : AutoPopupTask
{
	[Token(Token = "0x400BF4F")]
	[FieldOffset(Offset = "0x8")]
	private UIIAPBundleController m_IAPBundleController;

	[Token(Token = "0x60091F7")]
	[Address(RVA = "0x10F5078", Offset = "0x10F5078", VA = "0x10F5078")]
	public AutoTaskIAPBundleFirstTime()
	{
	}

	[Token(Token = "0x60091F8")]
	[Address(RVA = "0x10F5080", Offset = "0x10F5080", VA = "0x10F5080", Slot = "4")]
	public override int[] NeedHttpRequests()
	{
		return null;
	}

	[Token(Token = "0x60091F9")]
	[Address(RVA = "0x10F5168", Offset = "0x10F5168", VA = "0x10F5168", Slot = "5")]
	public override bool Do()
	{
		return default(bool);
	}

	[Token(Token = "0x60091FA")]
	[Address(RVA = "0x10F57F4", Offset = "0x10F57F4", VA = "0x10F57F4", Slot = "6")]
	public override bool IsDone()
	{
		return default(bool);
	}
}
