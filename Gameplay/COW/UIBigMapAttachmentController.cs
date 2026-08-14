using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024F9")]
internal class UIBigMapAttachmentController : UIBaseController
{
	[Token(Token = "0x400E588")]
	[FieldOffset(Offset = "0x28")]
	private UIBigMapAttachmentInfoView m_View;

	[Token(Token = "0x600D5BB")]
	[Address(RVA = "0x10C2E48", Offset = "0x10C2E48", VA = "0x10C2E48")]
	public UIBigMapAttachmentController()
	{
	}

	[Token(Token = "0x600D5BC")]
	[Address(RVA = "0x10C2ECC", Offset = "0x10C2ECC", VA = "0x10C2ECC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D5BD")]
	[Address(RVA = "0x10C2F70", Offset = "0x10C2F70", VA = "0x10C2F70", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D5BE")]
	[Address(RVA = "0x10C302C", Offset = "0x10C302C", VA = "0x10C302C")]
	public void RefreshData(LGCOKIBHIJL data)
	{
	}

	[Token(Token = "0x600D5BF")]
	[Address(RVA = "0x10C32D0", Offset = "0x10C32D0", VA = "0x10C32D0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
