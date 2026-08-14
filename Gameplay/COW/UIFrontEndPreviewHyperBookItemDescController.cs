using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CBA")]
public class UIFrontEndPreviewHyperBookItemDescController : UIFrontEndPreviewItemDescBaseController
{
	[Token(Token = "0x4011123")]
	private const string HIDDEN_PAGE_DESC_TITLE_KEY = "T_34_XY_HYPERBOOK_HIDDENTITLE";

	[Token(Token = "0x4011124")]
	private const string HIDDEN_PAGE_DESC_CONTENT_KEY = "T_34_XY_HYPERBOOK_HIDDENDEC";

	[Token(Token = "0x4011125")]
	[FieldOffset(Offset = "0xA0")]
	private UIFrontEndPreviewHyperBookItemDescView m_UIView;

	[Token(Token = "0x6012B88")]
	[Address(RVA = "0x27FC6D8", Offset = "0x27FC6D8", VA = "0x27FC6D8")]
	public UIFrontEndPreviewHyperBookItemDescController()
	{
	}

	[Token(Token = "0x6012B89")]
	[Address(RVA = "0x27FC75C", Offset = "0x27FC75C", VA = "0x27FC75C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B8A")]
	[Address(RVA = "0x27FC804", Offset = "0x27FC804", VA = "0x27FC804", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B8B")]
	[Address(RVA = "0x27FC8B4", Offset = "0x27FC8B4", VA = "0x27FC8B4", Slot = "35")]
	protected override UIFrontEndPreviewItemDescBaseView InitBaseView()
	{
		return null;
	}

	[Token(Token = "0x6012B8C")]
	[Address(RVA = "0x27FC924", Offset = "0x27FC924", VA = "0x27FC924", Slot = "54")]
	public override void RefreshItemDesc(uint itemid, UIGrid iconGrid)
	{
	}

	[Token(Token = "0x6012B8D")]
	[Address(RVA = "0x27FCCF4", Offset = "0x27FCCF4", VA = "0x27FCCF4")]
	public void _003C_003EiFixBaseProxy_RefreshItemDesc(uint P0, UIGrid P1)
	{
	}
}
