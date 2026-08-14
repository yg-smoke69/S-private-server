using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002628")]
public class UIFrontEndPreviewHotFixDownloadController : UIFrontEndPreviewHotFixDownloadBaseController
{
	[Token(Token = "0x400EBB2")]
	[FieldOffset(Offset = "0x44")]
	private UIFrontEndPreviewHotFixDownloadView m_UIView;

	[Token(Token = "0x600E299")]
	[Address(RVA = "0x27FC354", Offset = "0x27FC354", VA = "0x27FC354")]
	public UIFrontEndPreviewHotFixDownloadController()
	{
	}

	[Token(Token = "0x600E29A")]
	[Address(RVA = "0x27FC358", Offset = "0x27FC358", VA = "0x27FC358")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E29B")]
	[Address(RVA = "0x27FC400", Offset = "0x27FC400", VA = "0x27FC400", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x600E29C")]
	[Address(RVA = "0x27FC4B0", Offset = "0x27FC4B0", VA = "0x27FC4B0", Slot = "35")]
	protected override UIFrontEndPreviewHotFixDownloadBaseView InitBaseView()
	{
		return null;
	}
}
