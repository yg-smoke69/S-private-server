using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002596")]
internal class UICommonSettingContentController : UIBaseController
{
	[Token(Token = "0x2002597")]
	private sealed class _003CGetItemCtrlByType_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E89F")]
		[FieldOffset(Offset = "0x8")]
		internal int type;

		[Token(Token = "0x600DC1B")]
		[Address(RVA = "0x1EB4B40", Offset = "0x1EB4B40", VA = "0x1EB4B40")]
		public _003CGetItemCtrlByType_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DC1C")]
		[Address(RVA = "0x1EB4B58", Offset = "0x1EB4B58", VA = "0x1EB4B58")]
		internal bool _003C_003Em__0(UICommonSettingItemBaseController c)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400E89C")]
	[FieldOffset(Offset = "0x28")]
	private UICommonSettingContentView m_View;

	[Token(Token = "0x400E89D")]
	[FieldOffset(Offset = "0x2C")]
	private CommonSettingContentData m_Data;

	[Token(Token = "0x400E89E")]
	[FieldOffset(Offset = "0x30")]
	private List<UICommonSettingItemBaseController> m_CtrlList;

	[Token(Token = "0x600DC10")]
	[Address(RVA = "0x1EB34B8", Offset = "0x1EB34B8", VA = "0x1EB34B8")]
	public UICommonSettingContentController()
	{
	}

	[Token(Token = "0x600DC11")]
	[Address(RVA = "0x1EB3570", Offset = "0x1EB3570", VA = "0x1EB3570")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DC12")]
	[Address(RVA = "0x1EB3618", Offset = "0x1EB3618", VA = "0x1EB3618", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DC13")]
	[Address(RVA = "0x1EB36C8", Offset = "0x1EB36C8", VA = "0x1EB36C8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x600DC14")]
	[Address(RVA = "0x1EB372C", Offset = "0x1EB372C", VA = "0x1EB372C")]
	public void SetViewData(CommonSettingContentData ContentData)
	{
	}

	[Token(Token = "0x600DC15")]
	[Address(RVA = "0x1EB4164", Offset = "0x1EB4164", VA = "0x1EB4164")]
	public void RefreshData(CommonSettingContentData ContentData)
	{
	}

	[Token(Token = "0x600DC16")]
	[Address(RVA = "0x1EB4350", Offset = "0x1EB4350", VA = "0x1EB4350")]
	public void RefreshContent()
	{
	}

	[Token(Token = "0x600DC17")]
	[Address(RVA = "0x1EB484C", Offset = "0x1EB484C", VA = "0x1EB484C")]
	public void RefreshTipsState()
	{
	}

	[Token(Token = "0x600DC18")]
	[Address(RVA = "0x1EB49F8", Offset = "0x1EB49F8", VA = "0x1EB49F8")]
	public UICommonSettingItemBaseController GetItemCtrlByType(int type)
	{
		return null;
	}

	[Token(Token = "0x600DC19")]
	[Address(RVA = "0x1EB4B48", Offset = "0x1EB4B48", VA = "0x1EB4B48")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DC1A")]
	[Address(RVA = "0x1EB4B50", Offset = "0x1EB4B50", VA = "0x1EB4B50")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}
}
