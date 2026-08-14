using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002C2B")]
public class UIWorkShopRoomController : UIRoomBaseController, _Attribute
{
	[Token(Token = "0x2002C2C")]
	private sealed class _003COverwriteBackButtonLogic_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010DBB")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupMessageBoxController quitDialog;

		[Token(Token = "0x4010DBC")]
		[FieldOffset(Offset = "0xC")]
		internal UIWorkShopRoomController _0024this;

		[Token(Token = "0x6012693")]
		[Address(RVA = "0x1A21AC4", Offset = "0x1A21AC4", VA = "0x1A21AC4")]
		public _003COverwriteBackButtonLogic_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x6012694")]
		[Address(RVA = "0x1A21F58", Offset = "0x1A21F58", VA = "0x1A21F58")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x6012695")]
		[Address(RVA = "0x1A22050", Offset = "0x1A22050", VA = "0x1A22050")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x4010DB4")]
	[FieldOffset(Offset = "0xB4")]
	private List<CommonPopMenuData> m_PopMenuDataList;

	[Token(Token = "0x4010DB5")]
	[FieldOffset(Offset = "0xB8")]
	private UIModelSceneEdit m_ModelSceneEdit;

	[Token(Token = "0x4010DB6")]
	[FieldOffset(Offset = "0xBC")]
	private byte[] m_MiniMapSettings;

	[Token(Token = "0x4010DB7")]
	[FieldOffset(Offset = "0xC0")]
	private byte[] m_MiniMapObjectSettings;

	[Token(Token = "0x4010DB8")]
	[FieldOffset(Offset = "0xC4")]
	private bool hasOpenChildMapInfo;

	[Token(Token = "0x4010DB9")]
	[FieldOffset(Offset = "0xC8")]
	private List<UIWorkshopModeTagController> m_Tags;

	[Token(Token = "0x4010DBA")]
	[FieldOffset(Offset = "0x0")]
	private static Action _003C_003Ef__am_0024cache0;

	[Token(Token = "0x6012666")]
	[Address(RVA = "0x1A1C014", Offset = "0x1A1C014", VA = "0x1A1C014")]
	public UIWorkShopRoomController()
	{
	}

	[Token(Token = "0x6012667")]
	[Address(RVA = "0x1A1C01C", Offset = "0x1A1C01C", VA = "0x1A1C01C")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012668")]
	[Address(RVA = "0x1A1C0C0", Offset = "0x1A1C0C0", VA = "0x1A1C0C0", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012669")]
	[Address(RVA = "0x1A1CA70", Offset = "0x1A1CA70", VA = "0x1A1CA70")]
	private void InitPopMenuDataList()
	{
	}

	[Token(Token = "0x601266A")]
	[Address(RVA = "0x1A1CE4C", Offset = "0x1A1CE4C", VA = "0x1A1CE4C", Slot = "50")]
	protected override bool IsShowInviteBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x601266B")]
	[Address(RVA = "0x1A1CEA4", Offset = "0x1A1CEA4", VA = "0x1A1CEA4", Slot = "51")]
	protected override bool IsShowOB()
	{
		return default(bool);
	}

	[Token(Token = "0x601266C")]
	[Address(RVA = "0x1A1CEFC", Offset = "0x1A1CEFC", VA = "0x1A1CEFC", Slot = "53")]
	protected override bool IsShowInfoPanelOpenBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x601266D")]
	[Address(RVA = "0x1A1CF54", Offset = "0x1A1CF54", VA = "0x1A1CF54", Slot = "52")]
	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x601266E")]
	[Address(RVA = "0x1A1CFAC", Offset = "0x1A1CFAC", VA = "0x1A1CFAC", Slot = "54")]
	protected override bool IsShowLoadOut()
	{
		return default(bool);
	}

	[Token(Token = "0x601266F")]
	[Address(RVA = "0x1A1D004", Offset = "0x1A1D004", VA = "0x1A1D004", Slot = "55")]
	protected override EInventory.ItemSubType RoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x6012670")]
	[Address(RVA = "0x1A1D15C", Offset = "0x1A1D15C", VA = "0x1A1D15C", Slot = "49")]
	protected override void RefreshRoomCard()
	{
	}

	[Token(Token = "0x6012671")]
	[Address(RVA = "0x1A1D588", Offset = "0x1A1D588", VA = "0x1A1D588", Slot = "57")]
	protected override void OnBtnGameStartCallBack()
	{
	}

	[Token(Token = "0x6012672")]
	[Address(RVA = "0x1A1D7A4", Offset = "0x1A1D7A4", VA = "0x1A1D7A4")]
	private void DownLoadFailed(object[] data)
	{
	}

	[Token(Token = "0x6012673")]
	[Address(RVA = "0x1A1D80C", Offset = "0x1A1D80C", VA = "0x1A1D80C")]
	private void ShowDownLoadFailedWnd()
	{
	}

	[Token(Token = "0x6012674")]
	[Address(RVA = "0x1A1DB60", Offset = "0x1A1DB60", VA = "0x1A1DB60", Slot = "56")]
	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	[Token(Token = "0x6012675")]
	[Address(RVA = "0x1A1E0F0", Offset = "0x1A1E0F0", VA = "0x1A1E0F0", Slot = "58")]
	protected override void OnBtnCustomize()
	{
	}

	[Token(Token = "0x6012676")]
	[Address(RVA = "0x1A1E220", Offset = "0x1A1E220", VA = "0x1A1E220", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6012677")]
	[Address(RVA = "0x1A1E400", Offset = "0x1A1E400", VA = "0x1A1E400", Slot = "46")]
	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	[Token(Token = "0x6012678")]
	[Address(RVA = "0x1A1F68C", Offset = "0x1A1F68C", VA = "0x1A1F68C")]
	private void OnAuthorBtnClick()
	{
	}

	[Token(Token = "0x6012679")]
	[Address(RVA = "0x1A1F8F8", Offset = "0x1A1F8F8", VA = "0x1A1F8F8")]
	private void OnPreviewClick()
	{
	}

	[Token(Token = "0x601267A")]
	[Address(RVA = "0x1A1FD18", Offset = "0x1A1FD18", VA = "0x1A1FD18")]
	private void OnWorkShopShareClick()
	{
	}

	[Token(Token = "0x601267B")]
	[Address(RVA = "0x1A1FD7C", Offset = "0x1A1FD7C", VA = "0x1A1FD7C")]
	private void ShareWorkShopCode(object data)
	{
	}

	[Token(Token = "0x601267C")]
	[Address(RVA = "0x1A20014", Offset = "0x1A20014", VA = "0x1A20014")]
	private void OnSubscriptionBtnClick()
	{
	}

	[Token(Token = "0x601267D")]
	[Address(RVA = "0x1A202C8", Offset = "0x1A202C8", VA = "0x1A202C8")]
	private void OnCopyCodeBtnClick()
	{
	}

	[Token(Token = "0x601267E")]
	[Address(RVA = "0x1A20564", Offset = "0x1A20564", VA = "0x1A20564")]
	private void OnOtherBtnClick()
	{
	}

	[Token(Token = "0x601267F")]
	[Address(RVA = "0x1A206D4", Offset = "0x1A206D4", VA = "0x1A206D4", Slot = "59")]
	protected override void OnInfoPanelOpenClick()
	{
	}

	[Token(Token = "0x6012680")]
	[Address(RVA = "0x1A209E0", Offset = "0x1A209E0", VA = "0x1A209E0", Slot = "60")]
	protected override void OnInfoPanelCloseClick()
	{
	}

	[Token(Token = "0x6012681")]
	[Address(RVA = "0x1A20CD8", Offset = "0x1A20CD8", VA = "0x1A20CD8")]
	private void Report(object data)
	{
	}

	[Token(Token = "0x6012682")]
	[Address(RVA = "0x1A20F5C", Offset = "0x1A20F5C", VA = "0x1A20F5C")]
	private void RefreshWorkShopView()
	{
	}

	[Token(Token = "0x6012683")]
	[Address(RVA = "0x1A2126C", Offset = "0x1A2126C", VA = "0x1A2126C", Slot = "42")]
	public new void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6012684")]
	[Address(RVA = "0x1A21588", Offset = "0x1A21588", VA = "0x1A21588", Slot = "43")]
	public new uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6012685")]
	[Address(RVA = "0x1A2162C", Offset = "0x1A2162C", VA = "0x1A2162C", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6012686")]
	[Address(RVA = "0x1A21ACC", Offset = "0x1A21ACC", VA = "0x1A21ACC", Slot = "48")]
	protected override void InitItemWidthAndHeight()
	{
	}

	[Token(Token = "0x6012687")]
	[Address(RVA = "0x1A21BC4", Offset = "0x1A21BC4", VA = "0x1A21BC4", Slot = "61")]
	public override UIEasyListItemController OpenItemController(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x6012688")]
	[Address(RVA = "0x1A1F000", Offset = "0x1A1F000", VA = "0x1A1F000")]
	private void RefreshTags(uint[] tagsInfo, uint gameMode)
	{
	}

	[Token(Token = "0x6012689")]
	[Address(RVA = "0x1A21E50", Offset = "0x1A21E50", VA = "0x1A21E50")]
	private static void _003CShowDownLoadFailedWnd_003Em__0()
	{
	}

	[Token(Token = "0x601268A")]
	[Address(RVA = "0x1A21F10", Offset = "0x1A21F10", VA = "0x1A21F10")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x601268B")]
	[Address(RVA = "0x1A21F18", Offset = "0x1A21F18", VA = "0x1A21F18")]
	public void _003C_003EiFixBaseProxy_RefreshRoomCard()
	{
	}

	[Token(Token = "0x601268C")]
	[Address(RVA = "0x1A21F20", Offset = "0x1A21F20", VA = "0x1A21F20")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x601268D")]
	[Address(RVA = "0x1A21F28", Offset = "0x1A21F28", VA = "0x1A21F28")]
	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	[Token(Token = "0x601268E")]
	[Address(RVA = "0x1A21F30", Offset = "0x1A21F30", VA = "0x1A21F30")]
	public void _003C_003EiFixBaseProxy_OnInfoPanelOpenClick()
	{
	}

	[Token(Token = "0x601268F")]
	[Address(RVA = "0x1A21F38", Offset = "0x1A21F38", VA = "0x1A21F38")]
	public void _003C_003EiFixBaseProxy_OnInfoPanelCloseClick()
	{
	}

	[Token(Token = "0x6012690")]
	[Address(RVA = "0x1A21F40", Offset = "0x1A21F40", VA = "0x1A21F40")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x6012691")]
	[Address(RVA = "0x1A21F48", Offset = "0x1A21F48", VA = "0x1A21F48")]
	public void _003C_003EiFixBaseProxy_InitItemWidthAndHeight()
	{
	}

	[Token(Token = "0x6012692")]
	[Address(RVA = "0x1A21F50", Offset = "0x1A21F50", VA = "0x1A21F50")]
	public UIEasyListItemController _003C_003EiFixBaseProxy_OpenItemController(Transform P0)
	{
		return null;
	}
}
