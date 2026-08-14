using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using tcp;

namespace COW;

[Token(Token = "0x2002AEE")]
public class UIRoomListItemController : UIEasyListItemController
{
	[Token(Token = "0x2002AEF")]
	private sealed class _003CJoinProcess_003Ec__AnonStorey0
	{
		[Token(Token = "0x401079D")]
		[FieldOffset(Offset = "0x8")]
		internal bool solo;

		[Token(Token = "0x401079E")]
		[FieldOffset(Offset = "0xC")]
		internal ECustomRoomJoinType joinType;

		[Token(Token = "0x401079F")]
		[FieldOffset(Offset = "0x10")]
		internal UIRoomListItemController _0024this;

		[Token(Token = "0x60119F8")]
		[Address(RVA = "0x23CD2B4", Offset = "0x23CD2B4", VA = "0x23CD2B4")]
		public _003CJoinProcess_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60119F9")]
		[Address(RVA = "0x23D1294", Offset = "0x23D1294", VA = "0x23D1294")]
		internal void _003C_003Em__0(string code, string group, string groupAbbr)
		{
		}
	}

	[Token(Token = "0x2002AF0")]
	private sealed class _003CSpectateProcess_003Ec__AnonStorey1
	{
		[Token(Token = "0x40107A0")]
		[FieldOffset(Offset = "0x8")]
		internal bool solo;

		[Token(Token = "0x40107A1")]
		[FieldOffset(Offset = "0xC")]
		internal UIRoomListItemController _0024this;

		[Token(Token = "0x60119FA")]
		[Address(RVA = "0x23CD9F4", Offset = "0x23CD9F4", VA = "0x23CD9F4")]
		public _003CSpectateProcess_003Ec__AnonStorey1()
		{
		}

		[Token(Token = "0x60119FB")]
		[Address(RVA = "0x23D16E4", Offset = "0x23D16E4", VA = "0x23D16E4")]
		internal void _003C_003Em__0(string code, string group, string groupAbbr)
		{
		}
	}

	[Token(Token = "0x2002AF1")]
	private sealed class _003CGenerateBatchPopMenuData_003Ec__AnonStorey2
	{
		[Token(Token = "0x40107A2")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupMessageBoxController quitDialog;

		[Token(Token = "0x40107A3")]
		[FieldOffset(Offset = "0xC")]
		internal UIRoomListItemController _0024this;

		[Token(Token = "0x60119FC")]
		[Address(RVA = "0x23D1068", Offset = "0x23D1068", VA = "0x23D1068")]
		public _003CGenerateBatchPopMenuData_003Ec__AnonStorey2()
		{
		}

		[Token(Token = "0x60119FD")]
		[Address(RVA = "0x23D11EC", Offset = "0x23D11EC", VA = "0x23D11EC")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x60119FE")]
		[Address(RVA = "0x23D1288", Offset = "0x23D1288", VA = "0x23D1288")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x4010796")]
	[FieldOffset(Offset = "0x38")]
	private UIRoomListItemView m_View;

	[Token(Token = "0x4010797")]
	[FieldOffset(Offset = "0x3C")]
	private RoomBasicInfo m_Data;

	[Token(Token = "0x4010798")]
	[FieldOffset(Offset = "0x40")]
	private UIModelCustomRoom m_Model;

	[Token(Token = "0x4010799")]
	[FieldOffset(Offset = "0x44")]
	private List<CommonPopMenuData> m_List;

	[Token(Token = "0x401079A")]
	[FieldOffset(Offset = "0x48")]
	private uint m_DelayCallID;

	[Token(Token = "0x401079B")]
	[FieldOffset(Offset = "0x4C")]
	private RoomCreateRuleDataManager m_DataManager;

	[Token(Token = "0x401079C")]
	[FieldOffset(Offset = "0x50")]
	private ECustomRoomJoinScene m_CustomRoomJoinScene;

	[Token(Token = "0x60119DB")]
	[Address(RVA = "0x23CC714", Offset = "0x23CC714", VA = "0x23CC714")]
	public UIRoomListItemController()
	{
	}

	[Token(Token = "0x60119DC")]
	[Address(RVA = "0x23CC7A8", Offset = "0x23CC7A8", VA = "0x23CC7A8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60119DD")]
	[Address(RVA = "0x23CC84C", Offset = "0x23CC84C", VA = "0x23CC84C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60119DE")]
	[Address(RVA = "0x23CCA5C", Offset = "0x23CCA5C", VA = "0x23CCA5C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60119DF")]
	[Address(RVA = "0x23CCBBC", Offset = "0x23CCBBC", VA = "0x23CCBBC")]
	private void JoinProcess(bool solo = true, ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	[Token(Token = "0x60119E0")]
	[Address(RVA = "0x23CD464", Offset = "0x23CD464", VA = "0x23CD464")]
	private void SpectateProcess(bool solo = true)
	{
	}

	[Token(Token = "0x60119E1")]
	[Address(RVA = "0x23CD9FC", Offset = "0x23CD9FC", VA = "0x23CD9FC")]
	private void OnRoomItemClick()
	{
	}

	[Token(Token = "0x60119E2")]
	[Address(RVA = "0x23CE2D4", Offset = "0x23CE2D4", VA = "0x23CE2D4")]
	private void GeneratePopMenuData()
	{
	}

	[Token(Token = "0x60119E3")]
	[Address(RVA = "0x23C62A0", Offset = "0x23C62A0", VA = "0x23C62A0")]
	public void JoinRoom(ECustomRoomJoinType joinType = ECustomRoomJoinType.ECustomRoomJoinType_Normal)
	{
	}

	[Token(Token = "0x60119E4")]
	[Address(RVA = "0x23CDCD0", Offset = "0x23CDCD0", VA = "0x23CDCD0")]
	private void GenerateBatchPopMenuData()
	{
	}

	[Token(Token = "0x60119E5")]
	[Address(RVA = "0x23CE7C0", Offset = "0x23CE7C0", VA = "0x23CE7C0", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x60119E6")]
	[Address(RVA = "0x23CF510", Offset = "0x23CF510", VA = "0x23CF510")]
	private void RefreshCDNMap(uint mode)
	{
	}

	[Token(Token = "0x60119E7")]
	[Address(RVA = "0x23CF7B0", Offset = "0x23CF7B0", VA = "0x23CF7B0")]
	private void UpdateGroupModeStatus(RoomBasicInfo data)
	{
	}

	[Token(Token = "0x60119E8")]
	[Address(RVA = "0x23CFC88", Offset = "0x23CFC88", VA = "0x23CFC88")]
	private void UpdateRoomStatus(ERoom.State status)
	{
	}

	[Token(Token = "0x60119E9")]
	[Address(RVA = "0x23CFEA8", Offset = "0x23CFEA8", VA = "0x23CFEA8")]
	private void HighlightRoomItem(RoomBasicInfo info)
	{
	}

	[Token(Token = "0x60119EA")]
	[Address(RVA = "0x23CC1E8", Offset = "0x23CC1E8", VA = "0x23CC1E8")]
	public void SetWidgetWidth(int width)
	{
	}

	[Token(Token = "0x60119EB")]
	[Address(RVA = "0x23CFF88", Offset = "0x23CFF88", VA = "0x23CFF88")]
	public void SetCustomRoomJoinScene(ECustomRoomJoinScene joinScene)
	{
	}

	[Token(Token = "0x60119EC")]
	[Address(RVA = "0x23CB6D4", Offset = "0x23CB6D4", VA = "0x23CB6D4")]
	public void PlayTweenAnim()
	{
	}

	[Token(Token = "0x60119ED")]
	[Address(RVA = "0x23CFFE8", Offset = "0x23CFFE8", VA = "0x23CFFE8")]
	private void _003CGeneratePopMenuData_003Em__0(object obj)
	{
	}

	[Token(Token = "0x60119EE")]
	[Address(RVA = "0x23CFFF0", Offset = "0x23CFFF0", VA = "0x23CFFF0")]
	private void _003CGeneratePopMenuData_003Em__1(object obj)
	{
	}

	[Token(Token = "0x60119EF")]
	[Address(RVA = "0x23D0AF0", Offset = "0x23D0AF0", VA = "0x23D0AF0")]
	private void _003CGenerateBatchPopMenuData_003Em__2(object obj)
	{
	}

	[Token(Token = "0x60119F0")]
	[Address(RVA = "0x23D0B58", Offset = "0x23D0B58", VA = "0x23D0B58")]
	private void _003CGenerateBatchPopMenuData_003Em__3(object obj)
	{
	}

	[Token(Token = "0x60119F1")]
	[Address(RVA = "0x23D0DC8", Offset = "0x23D0DC8", VA = "0x23D0DC8")]
	private void _003CGenerateBatchPopMenuData_003Em__4(object obj)
	{
	}

	[Token(Token = "0x60119F2")]
	[Address(RVA = "0x23D1070", Offset = "0x23D1070", VA = "0x23D1070")]
	private void _003CRefreshCDNMap_003Em__5()
	{
	}

	[Token(Token = "0x60119F3")]
	[Address(RVA = "0x23D1150", Offset = "0x23D1150", VA = "0x23D1150")]
	private void _003CPlayTweenAnim_003Em__6()
	{
	}

	[Token(Token = "0x60119F4")]
	[Address(RVA = "0x23D11CC", Offset = "0x23D11CC", VA = "0x23D11CC")]
	private void _003CGeneratePopMenuData_003Em__7()
	{
	}

	[Token(Token = "0x60119F5")]
	[Address(RVA = "0x23D11D4", Offset = "0x23D11D4", VA = "0x23D11D4")]
	private void _003CGeneratePopMenuData_003Em__8()
	{
	}

	[Token(Token = "0x60119F6")]
	[Address(RVA = "0x23D11DC", Offset = "0x23D11DC", VA = "0x23D11DC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60119F7")]
	[Address(RVA = "0x23D11E4", Offset = "0x23D11E4", VA = "0x23D11E4")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
