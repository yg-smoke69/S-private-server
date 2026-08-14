using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002CB0")]
public class UIFrontEndPreviewHackerStoreItemDescController : UIFrontEndPreviewItemDescBaseController
{
	[Token(Token = "0x4011106")]
	private const int PROPERTYPANELHALFBGWIDTH = 53;

	[Token(Token = "0x4011107")]
	[FieldOffset(Offset = "0xA0")]
	private UIFrontEndPreviewHackerStoreItemDescView m_UIView;

	[Token(Token = "0x6012B52")]
	[Address(RVA = "0x27F8A28", Offset = "0x27F8A28", VA = "0x27F8A28")]
	public UIFrontEndPreviewHackerStoreItemDescController()
	{
	}

	[Token(Token = "0x6012B53")]
	[Address(RVA = "0x27F8AAC", Offset = "0x27F8AAC", VA = "0x27F8AAC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012B54")]
	[Address(RVA = "0x27F8B54", Offset = "0x27F8B54", VA = "0x27F8B54", Slot = "31")]
	protected override void InitBaseUIView()
	{
	}

	[Token(Token = "0x6012B55")]
	[Address(RVA = "0x27F8C04", Offset = "0x27F8C04", VA = "0x27F8C04", Slot = "35")]
	protected override UIFrontEndPreviewItemDescBaseView InitBaseView()
	{
		return null;
	}

	[Token(Token = "0x6012B56")]
	[Address(RVA = "0x27F8C74", Offset = "0x27F8C74", VA = "0x27F8C74", Slot = "44")]
	public override void SetNewQuaityIcon(uint id)
	{
	}

	[Token(Token = "0x6012B57")]
	[Address(RVA = "0x27F9034", Offset = "0x27F9034", VA = "0x27F9034", Slot = "45")]
	protected override void SetItemDescBg()
	{
	}

	[Token(Token = "0x6012B58")]
	[Address(RVA = "0x27F9588", Offset = "0x27F9588", VA = "0x27F9588", Slot = "46")]
	protected override void OnItemDescBgChanged()
	{
	}

	[Token(Token = "0x6012B59")]
	[Address(RVA = "0x27F9C28", Offset = "0x27F9C28", VA = "0x27F9C28")]
	public void _003C_003EiFixBaseProxy_SetNewQuaityIcon(uint P0)
	{
	}

	[Token(Token = "0x6012B5A")]
	[Address(RVA = "0x27F9C30", Offset = "0x27F9C30", VA = "0x27F9C30")]
	public void _003C_003EiFixBaseProxy_SetItemDescBg()
	{
	}

	[Token(Token = "0x6012B5B")]
	[Address(RVA = "0x27F9C38", Offset = "0x27F9C38", VA = "0x27F9C38")]
	public void _003C_003EiFixBaseProxy_OnItemDescBgChanged()
	{
	}
}
