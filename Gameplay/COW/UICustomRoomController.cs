using System.Collections.Generic;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x20025C1")]
public class UICustomRoomController : UIRoomBaseController, _Attribute
{
	[Token(Token = "0x20025C2")]
	private sealed class _003COverwriteBackButtonLogic_003Ec__AnonStorey0
	{
		[Token(Token = "0x400E9A4")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupMessageBoxController quitDialog;

		[Token(Token = "0x400E9A5")]
		[FieldOffset(Offset = "0xC")]
		internal UICustomRoomController _0024this;

		[Token(Token = "0x600DDC6")]
		[Address(RVA = "0x11EBE9C", Offset = "0x11EBE9C", VA = "0x11EBE9C")]
		public _003COverwriteBackButtonLogic_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600DDC7")]
		[Address(RVA = "0x11EBEC4", Offset = "0x11EBEC4", VA = "0x11EBEC4")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600DDC8")]
		[Address(RVA = "0x11EBFBC", Offset = "0x11EBFBC", VA = "0x11EBFBC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400E9A1")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<uint, List<uint>> m_SpecialModeGameSettingPriorityDict;

	[Token(Token = "0x400E9A2")]
	[FieldOffset(Offset = "0xB8")]
	private List<uint> m_CommonModeGameSettingPriority;

	[Token(Token = "0x400E9A3")]
	[FieldOffset(Offset = "0xBC")]
	private Dictionary<uint, bool> m_GameSettingSwitch;

	[Token(Token = "0x600DDB1")]
	[Address(RVA = "0x11E9500", Offset = "0x11E9500", VA = "0x11E9500")]
	public UICustomRoomController()
	{
	}

	[Token(Token = "0x600DDB2")]
	[Address(RVA = "0x11E95C0", Offset = "0x11E95C0", VA = "0x11E95C0")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600DDB3")]
	[Address(RVA = "0x11E9664", Offset = "0x11E9664", VA = "0x11E9664", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600DDB4")]
	[Address(RVA = "0x11EA480", Offset = "0x11EA480", VA = "0x11EA480", Slot = "50")]
	protected override bool IsShowInviteBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDB5")]
	[Address(RVA = "0x11EA4F8", Offset = "0x11EA4F8", VA = "0x11EA4F8", Slot = "51")]
	protected override bool IsShowOB()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDB6")]
	[Address(RVA = "0x11EA550", Offset = "0x11EA550", VA = "0x11EA550", Slot = "52")]
	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDB7")]
	[Address(RVA = "0x11EA5CC", Offset = "0x11EA5CC", VA = "0x11EA5CC", Slot = "53")]
	protected override bool IsShowInfoPanelOpenBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDB8")]
	[Address(RVA = "0x11EA624", Offset = "0x11EA624", VA = "0x11EA624", Slot = "54")]
	protected override bool IsShowLoadOut()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDB9")]
	[Address(RVA = "0x11EA67C", Offset = "0x11EA67C", VA = "0x11EA67C", Slot = "55")]
	protected override EInventory.ItemSubType RoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x600DDBA")]
	[Address(RVA = "0x11E9F8C", Offset = "0x11E9F8C", VA = "0x11E9F8C")]
	private void InitModeGameSetting()
	{
	}

	[Token(Token = "0x600DDBB")]
	[Address(RVA = "0x11EA800", Offset = "0x11EA800", VA = "0x11EA800", Slot = "57")]
	protected override void OnBtnGameStartCallBack()
	{
	}

	[Token(Token = "0x600DDBC")]
	[Address(RVA = "0x11EAA4C", Offset = "0x11EAA4C", VA = "0x11EAA4C", Slot = "56")]
	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	[Token(Token = "0x600DDBD")]
	[Address(RVA = "0x11EAFDC", Offset = "0x11EAFDC", VA = "0x11EAFDC", Slot = "58")]
	protected override void OnBtnCustomize()
	{
	}

	[Token(Token = "0x600DDBE")]
	[Address(RVA = "0x11EB19C", Offset = "0x11EB19C", VA = "0x11EB19C", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600DDBF")]
	[Address(RVA = "0x11EB2D0", Offset = "0x11EB2D0", VA = "0x11EB2D0", Slot = "47")]
	protected override List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	[Token(Token = "0x600DDC0")]
	[Address(RVA = "0x11EBA04", Offset = "0x11EBA04", VA = "0x11EBA04", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600DDC1")]
	[Address(RVA = "0x11E9A1C", Offset = "0x11E9A1C", VA = "0x11E9A1C")]
	private void InitRegionSwitch()
	{
	}

	[Token(Token = "0x600DDC2")]
	[Address(RVA = "0x11EBEA4", Offset = "0x11EBEA4", VA = "0x11EBEA4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600DDC3")]
	[Address(RVA = "0x11EBEAC", Offset = "0x11EBEAC", VA = "0x11EBEAC")]
	public new void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}

	[Token(Token = "0x600DDC4")]
	[Address(RVA = "0x11EBEB4", Offset = "0x11EBEB4", VA = "0x11EBEB4")]
	public List<RoomGameSettingData> _003C_003EiFixBaseProxy_PrepareGameSettingData()
	{
		return null;
	}

	[Token(Token = "0x600DDC5")]
	[Address(RVA = "0x11EBEBC", Offset = "0x11EBEBC", VA = "0x11EBEBC")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}
}
