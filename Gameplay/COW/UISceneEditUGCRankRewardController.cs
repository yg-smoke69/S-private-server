using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200235D")]
public class UISceneEditUGCRankRewardController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x200235E")]
	private sealed class _003CRefreshRewardRankView_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DC4F")]
		[FieldOffset(Offset = "0x8")]
		internal uint level;

		[Token(Token = "0x600C550")]
		[Address(RVA = "0x1A3DAD0", Offset = "0x1A3DAD0", VA = "0x1A3DAD0")]
		public _003CRefreshRewardRankView_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C551")]
		[Address(RVA = "0x1A3DAD8", Offset = "0x1A3DAD8", VA = "0x1A3DAD8")]
		internal bool _003C_003Em__0(WorkShopLevelExp data)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400DC4E")]
	[FieldOffset(Offset = "0x7C")]
	private UISceneEditUGCRankRewardView m_View;

	[Token(Token = "0x600C53F")]
	[Address(RVA = "0x2DBAA68", Offset = "0x2DBAA68", VA = "0x2DBAA68")]
	public UISceneEditUGCRankRewardController()
	{
	}

	[Token(Token = "0x600C540")]
	[Address(RVA = "0x2DBAA70", Offset = "0x2DBAA70", VA = "0x2DBAA70")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C541")]
	[Address(RVA = "0x2DBAB14", Offset = "0x2DBAB14", VA = "0x2DBAB14", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C542")]
	[Address(RVA = "0x2DBBA80", Offset = "0x2DBBA80", VA = "0x2DBBA80", Slot = "14")]
	protected override void OnUIOpen()
	{
	}

	[Token(Token = "0x600C543")]
	[Address(RVA = "0x2DBBAE4", Offset = "0x2DBBAE4", VA = "0x2DBBAE4")]
	private void OnHelpBtnClick(object[] data)
	{
	}

	[Token(Token = "0x600C544")]
	[Address(RVA = "0x2DBBD48", Offset = "0x2DBBD48", VA = "0x2DBBD48", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600C545")]
	[Address(RVA = "0x2DBBF74", Offset = "0x2DBBF74", VA = "0x2DBBF74")]
	private void OnPreviewBackBtnClick()
	{
	}

	[Token(Token = "0x600C546")]
	[Address(RVA = "0x2DBC050", Offset = "0x2DBC050", VA = "0x2DBC050")]
	private void ShowPreviewItem(object[] data)
	{
	}

	[Token(Token = "0x600C547")]
	[Address(RVA = "0x2DBB718", Offset = "0x2DBB718", VA = "0x2DBB718")]
	private void RefreshRewardRankView()
	{
	}

	[Token(Token = "0x600C548")]
	[Address(RVA = "0x2DBAD8C", Offset = "0x2DBAD8C", VA = "0x2DBAD8C")]
	public void SetViewData()
	{
	}

	[Token(Token = "0x600C549")]
	[Address(RVA = "0x2DBC464", Offset = "0x2DBC464", VA = "0x2DBC464", Slot = "64")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600C54A")]
	[Address(RVA = "0x2DBC55C", Offset = "0x2DBC55C", VA = "0x2DBC55C", Slot = "65")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600C54B")]
	[Address(RVA = "0x2DBC5D8", Offset = "0x2DBC5D8", VA = "0x2DBC5D8", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600C54C")]
	[Address(RVA = "0x2DBC648", Offset = "0x2DBC648", VA = "0x2DBC648", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600C54D")]
	[Address(RVA = "0x2DBC6A0", Offset = "0x2DBC6A0", VA = "0x2DBC6A0")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C54E")]
	[Address(RVA = "0x2DBC6A8", Offset = "0x2DBC6A8", VA = "0x2DBC6A8")]
	public new void _003C_003EiFixBaseProxy_OnUIOpen()
	{
	}

	[Token(Token = "0x600C54F")]
	[Address(RVA = "0x2DBC6B0", Offset = "0x2DBC6B0", VA = "0x2DBC6B0")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
