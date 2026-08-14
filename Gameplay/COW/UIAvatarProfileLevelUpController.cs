using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20024C8")]
public class UIAvatarProfileLevelUpController : UIPopupWindowController
{
	[Token(Token = "0x400E411")]
	[FieldOffset(Offset = "0x48")]
	private UIAvatarProfileLevelUpView m_View;

	[Token(Token = "0x400E412")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400E413")]
	[FieldOffset(Offset = "0x50")]
	private BaseItemView[] mLevelUpRewardLst;

	[Token(Token = "0x400E414")]
	[FieldOffset(Offset = "0x54")]
	private int mOldProfileLv;

	[Token(Token = "0x400E415")]
	[FieldOffset(Offset = "0x58")]
	private int mNowProfileLv;

	[Token(Token = "0x600D368")]
	[Address(RVA = "0x2B74844", Offset = "0x2B74844", VA = "0x2B74844")]
	public UIAvatarProfileLevelUpController()
	{
	}

	[Token(Token = "0x600D369")]
	[Address(RVA = "0x2B74858", Offset = "0x2B74858", VA = "0x2B74858")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D36A")]
	[Address(RVA = "0x2B74900", Offset = "0x2B74900", VA = "0x2B74900", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D36B")]
	[Address(RVA = "0x2B74BCC", Offset = "0x2B74BCC", VA = "0x2B74BCC")]
	private void OnConfirmClick()
	{
	}

	[Token(Token = "0x600D36C")]
	[Address(RVA = "0x2B74DE8", Offset = "0x2B74DE8", VA = "0x2B74DE8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
