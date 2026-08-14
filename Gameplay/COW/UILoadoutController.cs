using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002912")]
internal class UILoadoutController : UIPopupWindowController, _Attribute
{
	[Token(Token = "0x400FCE5")]
	[FieldOffset(Offset = "0x48")]
	private UILoadOutView m_View;

	[Token(Token = "0x400FCE6")]
	[FieldOffset(Offset = "0x4C")]
	private List<UILoadoutItemController> m_LoadOutCtrls;

	[Token(Token = "0x400FCE7")]
	[FieldOffset(Offset = "0x50")]
	private List<UILoadoutItemControllerNew> m_LoadOutCtrlsNew;

	[Token(Token = "0x400FCE8")]
	[FieldOffset(Offset = "0x54")]
	private int m_CurrentSelectedLoadoutId;

	[Token(Token = "0x400FCE9")]
	[FieldOffset(Offset = "0x58")]
	private int m_CurrentSelectedLoadoutIdNew;

	[Token(Token = "0x400FCEA")]
	[FieldOffset(Offset = "0x5C")]
	private bool m_RequestedBackpack;

	[Token(Token = "0x400FCEB")]
	[FieldOffset(Offset = "0x5D")]
	private bool m_HasShowGuide;

	[Token(Token = "0x400FCEC")]
	[FieldOffset(Offset = "0x60")]
	private UIGuideTipsController m_GuideTipsCtrl;

	[Token(Token = "0x400FCED")]
	[FieldOffset(Offset = "0x64")]
	private UICommonGuideController m_LoadoutGuideCtrl;

	[Token(Token = "0x400FCEE")]
	[FieldOffset(Offset = "0x68")]
	private UICommonGuideController m_LoadoutGuideCtrlNew;

	[Token(Token = "0x400FCEF")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelUser m_ModelUser;

	[Token(Token = "0x6010488")]
	[Address(RVA = "0x215C200", Offset = "0x215C200", VA = "0x215C200")]
	public UILoadoutController()
	{
	}

	[Token(Token = "0x6010489")]
	[Address(RVA = "0x215C2CC", Offset = "0x215C2CC", VA = "0x215C2CC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x601048A")]
	[Address(RVA = "0x215C370", Offset = "0x215C370", VA = "0x215C370", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x601048B")]
	[Address(RVA = "0x215CB7C", Offset = "0x215CB7C", VA = "0x215CB7C")]
	public void ShowLoadoutGuide()
	{
	}

	[Token(Token = "0x601048C")]
	[Address(RVA = "0x215D50C", Offset = "0x215D50C", VA = "0x215D50C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x601048D")]
	[Address(RVA = "0x215D79C", Offset = "0x215D79C", VA = "0x215D79C", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x601048E")]
	[Address(RVA = "0x215E3CC", Offset = "0x215E3CC", VA = "0x215E3CC")]
	private bool IsItemShow(Item item)
	{
		return default(bool);
	}

	[Token(Token = "0x601048F")]
	[Address(RVA = "0x215C770", Offset = "0x215C770", VA = "0x215C770")]
	private void InitContents()
	{
	}

	[Token(Token = "0x6010490")]
	[Address(RVA = "0x215E6D0", Offset = "0x215E6D0", VA = "0x215E6D0")]
	private List<Item> FilterLoadouts(List<Item> loadoutList)
	{
		return null;
	}

	[Token(Token = "0x6010491")]
	private void BuildLoadoutsUI<T>(List<Item> loadoutList, CSSharedItemDataManager.LoadoutSubType type, UIGrid grid) where T : UILoadoutItemController
	{
	}

	[Token(Token = "0x6010492")]
	[Address(RVA = "0x215E860", Offset = "0x215E860", VA = "0x215E860")]
	private void StopNewbieGuide(object[] args)
	{
	}

	[Token(Token = "0x6010493")]
	[Address(RVA = "0x215EE80", Offset = "0x215EE80", VA = "0x215EE80")]
	private void OnUILoadOutSelected(object[] data)
	{
	}

	[Token(Token = "0x6010494")]
	[Address(RVA = "0x215F5F4", Offset = "0x215F5F4", VA = "0x215F5F4", Slot = "46")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6010495")]
	[Address(RVA = "0x215F71C", Offset = "0x215F71C", VA = "0x215F71C", Slot = "47")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6010496")]
	[Address(RVA = "0x215F7D4", Offset = "0x215F7D4", VA = "0x215F7D4")]
	private void OnConfirmBtnClick()
	{
	}

	[Token(Token = "0x6010497")]
	[Address(RVA = "0x215FB98", Offset = "0x215FB98", VA = "0x215FB98")]
	private void _003CInitContents_003Em__0()
	{
	}

	[Token(Token = "0x6010498")]
	[Address(RVA = "0x2160000", Offset = "0x2160000", VA = "0x2160000")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6010499")]
	[Address(RVA = "0x2160008", Offset = "0x2160008", VA = "0x2160008")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601049A")]
	[Address(RVA = "0x2160010", Offset = "0x2160010", VA = "0x2160010")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
