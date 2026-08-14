using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002056")]
internal class UIHudCSSOHoldController : UIBaseController
{
	[Token(Token = "0x400CAB0")]
	[FieldOffset(Offset = "0x28")]
	private uint m_DelayCall;

	[Token(Token = "0x600A521")]
	[Address(RVA = "0x1F1B64C", Offset = "0x1F1B64C", VA = "0x1F1B64C")]
	public UIHudCSSOHoldController()
	{
	}

	[Token(Token = "0x600A522")]
	[Address(RVA = "0x1F1B6D0", Offset = "0x1F1B6D0", VA = "0x1F1B6D0")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A523")]
	[Address(RVA = "0x1F1B778", Offset = "0x1F1B778", VA = "0x1F1B778", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600A524")]
	[Address(RVA = "0x1F1B8F4", Offset = "0x1F1B8F4", VA = "0x1F1B8F4", Slot = "19")]
	protected override void OnVisibilityChanged()
	{
	}

	[Token(Token = "0x600A525")]
	[Address(RVA = "0x1F1B7E4", Offset = "0x1F1B7E4", VA = "0x1F1B7E4")]
	private void CancelDelayCall()
	{
	}

	[Token(Token = "0x600A526")]
	[Address(RVA = "0x1F1BA74", Offset = "0x1F1BA74", VA = "0x1F1BA74")]
	private void _003COnVisibilityChanged_003Em__0()
	{
	}

	[Token(Token = "0x600A527")]
	[Address(RVA = "0x1F1BA84", Offset = "0x1F1BA84", VA = "0x1F1BA84")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600A528")]
	[Address(RVA = "0x1F1BA8C", Offset = "0x1F1BA8C", VA = "0x1F1BA8C")]
	public void _003C_003EiFixBaseProxy_OnVisibilityChanged()
	{
	}
}
