using GCommon;
using Il2CppDummyDll;

[Token(Token = "0x200256C")]
public class UIClickMaskController : UIPopupWindowController
{
	[Token(Token = "0x400E7A2")]
	[FieldOffset(Offset = "0x48")]
	private UIWidget m_GuideWidget;

	[Token(Token = "0x600DA94")]
	[Address(RVA = "0x1469A50", Offset = "0x1469A50", VA = "0x1469A50")]
	public UIClickMaskController()
	{
	}

	[Token(Token = "0x600DA95")]
	[Address(RVA = "0x1469A58", Offset = "0x1469A58", VA = "0x1469A58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DA96")]
	[Address(RVA = "0x1469ABC", Offset = "0x1469ABC", VA = "0x1469ABC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DA97")]
	[Address(RVA = "0x1469BA8", Offset = "0x1469BA8", VA = "0x1469BA8", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DA98")]
	[Address(RVA = "0x1469C94", Offset = "0x1469C94", VA = "0x1469C94")]
	private void OnClickMask(object[] args)
	{
	}

	[Token(Token = "0x600DA99")]
	[Address(RVA = "0x146A110", Offset = "0x146A110", VA = "0x146A110")]
	public void SetGuideWidget(UIWidget widget)
	{
	}
}
