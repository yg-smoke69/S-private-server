using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002605")]
public class UIEmoteSlotDownloadController : UIBaseController
{
	[Token(Token = "0x400EAD6")]
	[FieldOffset(Offset = "0x28")]
	private UIHudEmoteDownLoadStateView m_View;

	[Token(Token = "0x400EAD7")]
	[FieldOffset(Offset = "0x2C")]
	private bool m_CollectionABReady;

	[Token(Token = "0x600E0C5")]
	[Address(RVA = "0x19D6108", Offset = "0x19D6108", VA = "0x19D6108")]
	public UIEmoteSlotDownloadController()
	{
	}

	[Token(Token = "0x600E0C6")]
	[Address(RVA = "0x19D618C", Offset = "0x19D618C", VA = "0x19D618C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E0C7")]
	[Address(RVA = "0x19D6234", Offset = "0x19D6234", VA = "0x19D6234", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E0C8")]
	[Address(RVA = "0x19D62F0", Offset = "0x19D62F0", VA = "0x19D62F0")]
	public void SetDownloadPosition()
	{
	}

	[Token(Token = "0x600E0C9")]
	[Address(RVA = "0x19D63FC", Offset = "0x19D63FC", VA = "0x19D63FC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
