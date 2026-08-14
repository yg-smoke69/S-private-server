using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002C4C")]
internal class UIWereWolvesCustomRoomController : UIRoomBaseController
{
	[Token(Token = "0x2002C4D")]
	private sealed class _003COverwriteBackButtonLogic_003Ec__AnonStorey0
	{
		[Token(Token = "0x4010E46")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupMessageBoxController quitDialog;

		[Token(Token = "0x4010E47")]
		[FieldOffset(Offset = "0xC")]
		internal UIWereWolvesCustomRoomController _0024this;

		[Token(Token = "0x60127D9")]
		[Address(RVA = "0x1B8207C", Offset = "0x1B8207C", VA = "0x1B8207C")]
		public _003COverwriteBackButtonLogic_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x60127DA")]
		[Address(RVA = "0x1B83784", Offset = "0x1B83784", VA = "0x1B83784")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x60127DB")]
		[Address(RVA = "0x1B8387C", Offset = "0x1B8387C", VA = "0x1B8387C")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x4010E45")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<uint, uint> m_CurRoomParamMap;

	[Token(Token = "0x60127C6")]
	[Address(RVA = "0x1B81860", Offset = "0x1B81860", VA = "0x1B81860")]
	public UIWereWolvesCustomRoomController()
	{
	}

	[Token(Token = "0x60127C7")]
	[Address(RVA = "0x1B81868", Offset = "0x1B81868", VA = "0x1B81868")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60127C8")]
	[Address(RVA = "0x1B8190C", Offset = "0x1B8190C", VA = "0x1B8190C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60127C9")]
	[Address(RVA = "0x1B81AB0", Offset = "0x1B81AB0", VA = "0x1B81AB0", Slot = "50")]
	protected override bool IsShowInviteBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60127CA")]
	[Address(RVA = "0x1B81B08", Offset = "0x1B81B08", VA = "0x1B81B08", Slot = "51")]
	protected override bool IsShowOB()
	{
		return default(bool);
	}

	[Token(Token = "0x60127CB")]
	[Address(RVA = "0x1B81B60", Offset = "0x1B81B60", VA = "0x1B81B60", Slot = "52")]
	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60127CC")]
	[Address(RVA = "0x1B81BB8", Offset = "0x1B81BB8", VA = "0x1B81BB8", Slot = "53")]
	protected override bool IsShowInfoPanelOpenBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x60127CD")]
	[Address(RVA = "0x1B81C10", Offset = "0x1B81C10", VA = "0x1B81C10", Slot = "54")]
	protected override bool IsShowLoadOut()
	{
		return default(bool);
	}

	[Token(Token = "0x60127CE")]
	[Address(RVA = "0x1B81C68", Offset = "0x1B81C68", VA = "0x1B81C68", Slot = "55")]
	protected override EInventory.ItemSubType RoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x60127CF")]
	[Address(RVA = "0x1B81CC0", Offset = "0x1B81CC0", VA = "0x1B81CC0", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x60127D0")]
	[Address(RVA = "0x1B82084", Offset = "0x1B82084", VA = "0x1B82084", Slot = "46")]
	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	[Token(Token = "0x60127D1")]
	[Address(RVA = "0x1B82610", Offset = "0x1B82610", VA = "0x1B82610", Slot = "47")]
	protected override List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	[Token(Token = "0x60127D2")]
	[Address(RVA = "0x1B83160", Offset = "0x1B83160", VA = "0x1B83160", Slot = "57")]
	protected override void OnBtnGameStartCallBack()
	{
	}

	[Token(Token = "0x60127D3")]
	[Address(RVA = "0x1B83234", Offset = "0x1B83234", VA = "0x1B83234", Slot = "56")]
	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	[Token(Token = "0x60127D4")]
	[Address(RVA = "0x1B83654", Offset = "0x1B83654", VA = "0x1B83654", Slot = "58")]
	protected override void OnBtnCustomize()
	{
	}

	[Token(Token = "0x60127D5")]
	[Address(RVA = "0x1B83764", Offset = "0x1B83764", VA = "0x1B83764")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60127D6")]
	[Address(RVA = "0x1B8376C", Offset = "0x1B8376C", VA = "0x1B8376C")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x60127D7")]
	[Address(RVA = "0x1B83774", Offset = "0x1B83774", VA = "0x1B83774")]
	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	[Token(Token = "0x60127D8")]
	[Address(RVA = "0x1B8377C", Offset = "0x1B8377C", VA = "0x1B8377C")]
	public List<RoomGameSettingData> _003C_003EiFixBaseProxy_PrepareGameSettingData()
	{
		return null;
	}
}
