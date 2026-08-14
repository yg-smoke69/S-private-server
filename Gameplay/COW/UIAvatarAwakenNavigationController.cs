using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2001FAF")]
public class UIAvatarAwakenNavigationController : UINavigationController, _Attribute
{
	[Token(Token = "0x400C6B0")]
	[FieldOffset(Offset = "0x68")]
	private UIAvatarAwakenNavigationView m_View;

	[Token(Token = "0x400C6B1")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelAvatarProfile m_Model;

	[Token(Token = "0x400C6B2")]
	[FieldOffset(Offset = "0x70")]
	private AvatarProfile m_CurrentShowAvatar;

	[Token(Token = "0x400C6B3")]
	[FieldOffset(Offset = "0x74")]
	private UIAvatarAwakenController m_AwakenCtrl;

	[Token(Token = "0x400C6B4")]
	[FieldOffset(Offset = "0x78")]
	private UIAvatarAwakenStoryReplayController m_AvakenStoryCtrl;

	[Token(Token = "0x400C6B5")]
	[FieldOffset(Offset = "0x7C")]
	private uint m_CurrentShowStoryID;

	[Token(Token = "0x6009E3B")]
	[Address(RVA = "0x1E80A80", Offset = "0x1E80A80", VA = "0x1E80A80")]
	public UIAvatarAwakenNavigationController()
	{
	}

	[Token(Token = "0x6009E3C")]
	[Address(RVA = "0x1E80B04", Offset = "0x1E80B04", VA = "0x1E80B04")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6009E3D")]
	[Address(RVA = "0x1E80BA8", Offset = "0x1E80BA8", VA = "0x1E80BA8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6009E3E")]
	[Address(RVA = "0x1E81028", Offset = "0x1E81028", VA = "0x1E81028")]
	private void OnClickLeftArea()
	{
	}

	[Token(Token = "0x6009E3F")]
	[Address(RVA = "0x1E81844", Offset = "0x1E81844", VA = "0x1E81844")]
	private void OnClickRightArea()
	{
	}

	[Token(Token = "0x6009E40")]
	[Address(RVA = "0x1E818AC", Offset = "0x1E818AC", VA = "0x1E818AC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6009E41")]
	[Address(RVA = "0x1E81B00", Offset = "0x1E81B00", VA = "0x1E81B00")]
	public void SetAvatar(uint curAvatarID)
	{
	}

	[Token(Token = "0x6009E42")]
	[Address(RVA = "0x1E81B88", Offset = "0x1E81B88", VA = "0x1E81B88")]
	private void ShowAvatarInfo()
	{
	}

	[Token(Token = "0x6009E43")]
	[Address(RVA = "0x1E823D0", Offset = "0x1E823D0", VA = "0x1E823D0")]
	private void ShowCurrentUI()
	{
	}

	[Token(Token = "0x6009E44")]
	[Address(RVA = "0x1E82830", Offset = "0x1E82830", VA = "0x1E82830", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x6009E45")]
	[Address(RVA = "0x1E82894", Offset = "0x1E82894", VA = "0x1E82894", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6009E46")]
	[Address(RVA = "0x1E82ABC", Offset = "0x1E82ABC", VA = "0x1E82ABC")]
	private void OnShowAvatarAwakenStory(object[] data)
	{
	}

	[Token(Token = "0x6009E47")]
	[Address(RVA = "0x1E82B94", Offset = "0x1E82B94", VA = "0x1E82B94")]
	private void OnRefreshAwakenUI(object[] data)
	{
	}

	[Token(Token = "0x6009E48")]
	[Address(RVA = "0x1E82BFC", Offset = "0x1E82BFC", VA = "0x1E82BFC")]
	private void OnExchangeActivityBtnClick(object[] data)
	{
	}

	[Token(Token = "0x6009E49")]
	[Address(RVA = "0x1E81090", Offset = "0x1E81090", VA = "0x1E81090")]
	private void ShowAvatarAwakenStory(uint storyId)
	{
	}

	[Token(Token = "0x6009E4A")]
	[Address(RVA = "0x1E82CCC", Offset = "0x1E82CCC", VA = "0x1E82CCC")]
	private void OnCDNBtnCloseClick()
	{
	}

	[Token(Token = "0x6009E4B")]
	[Address(RVA = "0x1E82D7C", Offset = "0x1E82D7C", VA = "0x1E82D7C", Slot = "43")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6009E4C")]
	[Address(RVA = "0x1E82E10", Offset = "0x1E82E10", VA = "0x1E82E10", Slot = "42")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6009E4D")]
	[Address(RVA = "0x1E82EDC", Offset = "0x1E82EDC", VA = "0x1E82EDC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6009E4E")]
	[Address(RVA = "0x1E82EE4", Offset = "0x1E82EE4", VA = "0x1E82EE4")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6009E4F")]
	[Address(RVA = "0x1E82EEC", Offset = "0x1E82EEC", VA = "0x1E82EEC")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x6009E50")]
	[Address(RVA = "0x1E82EF4", Offset = "0x1E82EF4", VA = "0x1E82EF4")]
	public new void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
