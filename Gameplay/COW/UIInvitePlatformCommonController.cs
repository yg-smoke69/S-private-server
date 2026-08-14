using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20028E5")]
internal class UIInvitePlatformCommonController : UIPopupWindowController
{
	[Token(Token = "0x400FB81")]
	[FieldOffset(Offset = "0x48")]
	private UIUtils.ShareUrlType m_ShareUrlType;

	[Token(Token = "0x400FB82")]
	[FieldOffset(Offset = "0x4C")]
	protected UIInvitePlatformCommonView m_View;

	[Token(Token = "0x400FB83")]
	[FieldOffset(Offset = "0x50")]
	private UIModelShare m_ModelShare;

	[Token(Token = "0x400FB84")]
	private const string FACEBOOK_ICON_SPRITENAME = "FF_FaceBookIcon";

	[Token(Token = "0x400FB85")]
	private const string VK_ICON_SPRITENAME = "FF_VKIcon";

	[Token(Token = "0x400FB86")]
	private const string GPLUS_ICON_SPRITENAME = "";

	[Token(Token = "0x400FB87")]
	[FieldOffset(Offset = "0x54")]
	private object[] m_Data;

	[Token(Token = "0x400FB88")]
	[FieldOffset(Offset = "0x58")]
	public bool TriggerShareActivity;

	[Token(Token = "0x601025D")]
	[Address(RVA = "0x1AD9908", Offset = "0x1AD9908", VA = "0x1AD9908")]
	public UIInvitePlatformCommonController()
	{
	}

	[Token(Token = "0x601025E")]
	[Address(RVA = "0x1AD9910", Offset = "0x1AD9910", VA = "0x1AD9910")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601025F")]
	[Address(RVA = "0x1AD99B4", Offset = "0x1AD99B4", VA = "0x1AD99B4", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010260")]
	[Address(RVA = "0x1AD9F84", Offset = "0x1AD9F84", VA = "0x1AD9F84")]
	public void SetViewData(UIUtils.ShareUrlType shareUrlType, object[] data)
	{
	}

	[Token(Token = "0x6010261")]
	[Address(RVA = "0x1ADA1B0", Offset = "0x1ADA1B0", VA = "0x1ADA1B0", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6010262")]
	[Address(RVA = "0x1ADA21C", Offset = "0x1ADA21C", VA = "0x1ADA21C")]
	private void OnLineClick()
	{
	}

	[Token(Token = "0x6010263")]
	[Address(RVA = "0x1ADA390", Offset = "0x1ADA390", VA = "0x1ADA390")]
	private void OnBindInviteClick()
	{
	}

	[Token(Token = "0x6010264")]
	[Address(RVA = "0x1ADA504", Offset = "0x1ADA504", VA = "0x1ADA504")]
	private void OnOtherClick()
	{
	}

	[Token(Token = "0x6010265")]
	[Address(RVA = "0x1ADA678", Offset = "0x1ADA678", VA = "0x1ADA678")]
	private void OnCopyLink()
	{
	}

	[Token(Token = "0x6010266")]
	[Address(RVA = "0x1ADA6F8", Offset = "0x1ADA6F8", VA = "0x1ADA6F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010267")]
	[Address(RVA = "0x1ADA700", Offset = "0x1ADA700", VA = "0x1ADA700")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
