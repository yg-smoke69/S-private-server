using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x200216A")]
internal class UILadderMatchRewardListController : UIPreviewNavigationController, _Attribute
{
	[Token(Token = "0x200216B")]
	private sealed class _003CRefreshBRData_003Ec__AnonStorey0
	{
		[Token(Token = "0x400D1D2")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelLadderMatch m_LadderModel;

		[Token(Token = "0x600B0E5")]
		[Address(RVA = "0x22C456C", Offset = "0x22C456C", VA = "0x22C456C")]
		public _003CRefreshBRData_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600B0E6")]
		[Address(RVA = "0x22C4814", Offset = "0x22C4814", VA = "0x22C4814")]
		internal bool _003C_003Em__0(LadderLevelData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200216C")]
	private sealed class _003CRefreshCSData_003Ec__AnonStorey1
	{
		[Token(Token = "0x400D1D3")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelCSLadderMatch ladderModel;

		[Token(Token = "0x600B0E7")]
		[Address(RVA = "0x22C4574", Offset = "0x22C4574", VA = "0x22C4574")]
		public _003CRefreshCSData_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x600B0E8")]
		[Address(RVA = "0x22C486C", Offset = "0x22C486C", VA = "0x22C486C")]
		internal bool _003C_003Em__0(LadderLevelData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x200216D")]
	private sealed class _003CRefreshPeriodicData_003Ec__AnonStorey2
	{
		[Token(Token = "0x400D1D4")]
		[FieldOffset(Offset = "0x8")]
		internal UIModelPeriodicLadderMatch ladderModel;

		[Token(Token = "0x600B0E9")]
		[Address(RVA = "0x22C4688", Offset = "0x22C4688", VA = "0x22C4688")]
		public _003CRefreshPeriodicData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x600B0EA")]
		[Address(RVA = "0x22C48DC", Offset = "0x22C48DC", VA = "0x22C48DC")]
		internal bool _003C_003Em__0(LadderLevelData a)
		{
			return default(bool);
		}
	}

	[Token(Token = "0x400D1D1")]
	[FieldOffset(Offset = "0x7C")]
	private LadderMatchReviewRewardListView m_View;

	[Token(Token = "0x600B0D4")]
	[Address(RVA = "0x22C1280", Offset = "0x22C1280", VA = "0x22C1280")]
	public UILadderMatchRewardListController()
	{
	}

	[Token(Token = "0x600B0D5")]
	[Address(RVA = "0x22C1288", Offset = "0x22C1288", VA = "0x22C1288")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600B0D6")]
	[Address(RVA = "0x22C132C", Offset = "0x22C132C", VA = "0x22C132C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600B0D7")]
	[Address(RVA = "0x22C1618", Offset = "0x22C1618", VA = "0x22C1618")]
	private void ShowPreviewItem(object[] data)
	{
	}

	[Token(Token = "0x600B0D8")]
	[Address(RVA = "0x22C17AC", Offset = "0x22C17AC", VA = "0x22C17AC", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x600B0D9")]
	[Address(RVA = "0x22C18E0", Offset = "0x22C18E0", VA = "0x22C18E0")]
	public void SetViewData(DGNDKMLMLPM ladderMatchType)
	{
	}

	[Token(Token = "0x600B0DA")]
	[Address(RVA = "0x22C44A4", Offset = "0x22C44A4", VA = "0x22C44A4", Slot = "42")]
	protected override UIWidget GetFrontEndPreviewBorder()
	{
		return null;
	}

	[Token(Token = "0x600B0DB")]
	[Address(RVA = "0x22C4514", Offset = "0x22C4514", VA = "0x22C4514", Slot = "43")]
	protected override FrontendPreviewType GetPreviewUIType()
	{
		return default(FrontendPreviewType);
	}

	[Token(Token = "0x600B0DC")]
	[Address(RVA = "0x22C14C0", Offset = "0x22C14C0", VA = "0x22C14C0")]
	private void UpdateScrollViewPosition()
	{
	}

	[Token(Token = "0x600B0DD")]
	[Address(RVA = "0x22C1978", Offset = "0x22C1978", VA = "0x22C1978")]
	private void RefreshBRData()
	{
	}

	[Token(Token = "0x600B0DE")]
	[Address(RVA = "0x22C29DC", Offset = "0x22C29DC", VA = "0x22C29DC")]
	private void RefreshCSData()
	{
	}

	[Token(Token = "0x600B0DF")]
	[Address(RVA = "0x22C457C", Offset = "0x22C457C", VA = "0x22C457C")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x600B0E0")]
	[Address(RVA = "0x22C3AF8", Offset = "0x22C3AF8", VA = "0x22C3AF8")]
	private void RefreshPeriodicData()
	{
	}

	[Token(Token = "0x600B0E1")]
	[Address(RVA = "0x22C4690", Offset = "0x22C4690", VA = "0x22C4690", Slot = "64")]
	public UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600B0E2")]
	[Address(RVA = "0x22C4788", Offset = "0x22C4788", VA = "0x22C4788", Slot = "65")]
	public void CloseItemController(UIEasyListItemController itemController)
	{
	}

	[Token(Token = "0x600B0E3")]
	[Address(RVA = "0x22C4804", Offset = "0x22C4804", VA = "0x22C4804")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600B0E4")]
	[Address(RVA = "0x22C480C", Offset = "0x22C480C", VA = "0x22C480C")]
	public new void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}
}
