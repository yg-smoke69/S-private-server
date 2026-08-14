using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B18")]
internal class UISetFriendAliasPopUpController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x401085D")]
	[FieldOffset(Offset = "0x48")]
	private UISetFriendAliasPopUpView m_View;

	[Token(Token = "0x401085E")]
	[FieldOffset(Offset = "0x4C")]
	private UIModelFriends m_Model;

	[Token(Token = "0x401085F")]
	[FieldOffset(Offset = "0x50")]
	private bool m_HasAlias;

	[Token(Token = "0x4010860")]
	[FieldOffset(Offset = "0x54")]
	private string m_Alias;

	[Token(Token = "0x4010861")]
	[FieldOffset(Offset = "0x58")]
	private ulong m_ID;

	[Token(Token = "0x6011B6E")]
	[Address(RVA = "0x1A533E8", Offset = "0x1A533E8", VA = "0x1A533E8")]
	public UISetFriendAliasPopUpController()
	{
	}

	[Token(Token = "0x6011B6F")]
	[Address(RVA = "0x1A53488", Offset = "0x1A53488", VA = "0x1A53488")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011B70")]
	[Address(RVA = "0x1A53530", Offset = "0x1A53530", VA = "0x1A53530", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011B71")]
	[Address(RVA = "0x1A53860", Offset = "0x1A53860", VA = "0x1A53860", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x6011B72")]
	[Address(RVA = "0x1A538C4", Offset = "0x1A538C4", VA = "0x1A538C4", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011B73")]
	[Address(RVA = "0x1A53928", Offset = "0x1A53928", VA = "0x1A53928")]
	public void SetViewData(ulong friend_ID)
	{
	}

	[Token(Token = "0x6011B74")]
	[Address(RVA = "0x1A543B0", Offset = "0x1A543B0", VA = "0x1A543B0")]
	private void OnCanelBtnClick()
	{
	}

	[Token(Token = "0x6011B75")]
	[Address(RVA = "0x1A54414", Offset = "0x1A54414", VA = "0x1A54414")]
	private void OnOKtBtnClick()
	{
	}

	[Token(Token = "0x6011B76")]
	[Address(RVA = "0x1A54614", Offset = "0x1A54614", VA = "0x1A54614")]
	private void OnCountDownBtnClick()
	{
	}

	[Token(Token = "0x6011B77")]
	[Address(RVA = "0x1A547A4", Offset = "0x1A547A4", VA = "0x1A547A4", Slot = "47")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011B78")]
	[Address(RVA = "0x1A5488C", Offset = "0x1A5488C", VA = "0x1A5488C", Slot = "46")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011B79")]
	[Address(RVA = "0x1A53C3C", Offset = "0x1A53C3C", VA = "0x1A53C3C")]
	public void RefreshUI()
	{
	}

	[Token(Token = "0x6011B7A")]
	[Address(RVA = "0x1A54CA4", Offset = "0x1A54CA4", VA = "0x1A54CA4")]
	private void _003CRefreshUI_003Em__0()
	{
	}

	[Token(Token = "0x6011B7B")]
	[Address(RVA = "0x1A54CA8", Offset = "0x1A54CA8", VA = "0x1A54CA8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011B7C")]
	[Address(RVA = "0x1A54CB0", Offset = "0x1A54CB0", VA = "0x1A54CB0")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}

	[Token(Token = "0x6011B7D")]
	[Address(RVA = "0x1A54CB8", Offset = "0x1A54CB8", VA = "0x1A54CB8")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
