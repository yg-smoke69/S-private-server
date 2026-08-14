using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B83")]
public class UITrialCdkeyPopupWindowController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x4010A7F")]
	[FieldOffset(Offset = "0x48")]
	private UITrialCdkeyPopupWindowView m_View;

	[Token(Token = "0x4010A80")]
	[FieldOffset(Offset = "0x4C")]
	private string websiteUrl;

	[Token(Token = "0x6011FA9")]
	[Address(RVA = "0x1C2EC8C", Offset = "0x1C2EC8C", VA = "0x1C2EC8C")]
	public UITrialCdkeyPopupWindowController()
	{
	}

	[Token(Token = "0x6011FAA")]
	[Address(RVA = "0x1C2EC94", Offset = "0x1C2EC94", VA = "0x1C2EC94")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011FAB")]
	[Address(RVA = "0x1C2ED38", Offset = "0x1C2ED38", VA = "0x1C2ED38", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011FAC")]
	[Address(RVA = "0x1C2EF24", Offset = "0x1C2EF24", VA = "0x1C2EF24", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011FAD")]
	[Address(RVA = "0x1C2F054", Offset = "0x1C2F054", VA = "0x1C2F054")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x6011FAE")]
	[Address(RVA = "0x1C2F40C", Offset = "0x1C2F40C", VA = "0x1C2F40C", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011FAF")]
	[Address(RVA = "0x1C2F864", Offset = "0x1C2F864", VA = "0x1C2F864", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011FB0")]
	[Address(RVA = "0x1C2F8F8", Offset = "0x1C2F8F8", VA = "0x1C2F8F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011FB1")]
	[Address(RVA = "0x1C2F900", Offset = "0x1C2F900", VA = "0x1C2F900")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
