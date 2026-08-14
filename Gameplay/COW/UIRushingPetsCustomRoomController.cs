using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using message;
using proto;

namespace COW;

[Token(Token = "0x20022ED")]
public class UIRushingPetsCustomRoomController : UIRoomBaseController
{
	[Token(Token = "0x20022EE")]
	private sealed class _003COverwriteBackButtonLogic_003Ec__AnonStorey0
	{
		[Token(Token = "0x400DA15")]
		[FieldOffset(Offset = "0x8")]
		internal UIPopupMessageBoxController quitDialog;

		[Token(Token = "0x400DA16")]
		[FieldOffset(Offset = "0xC")]
		internal UIRushingPetsCustomRoomController _0024this;

		[Token(Token = "0x600C0A9")]
		[Address(RVA = "0x143196C", Offset = "0x143196C", VA = "0x143196C")]
		public _003COverwriteBackButtonLogic_003Ec__AnonStorey0()
		{
		}

		[Token(Token = "0x600C0AA")]
		[Address(RVA = "0x14322C4", Offset = "0x14322C4", VA = "0x14322C4")]
		internal void _003C_003Em__0()
		{
		}

		[Token(Token = "0x600C0AB")]
		[Address(RVA = "0x14323BC", Offset = "0x14323BC", VA = "0x14323BC")]
		internal void _003C_003Em__1()
		{
		}
	}

	[Token(Token = "0x400DA13")]
	[FieldOffset(Offset = "0xB4")]
	private Dictionary<uint, uint> m_CurRoomParamMap;

	[Token(Token = "0x400DA14")]
	[FieldOffset(Offset = "0xB8")]
	protected Dictionary<string, CSVBaseData> m_CsvDataMap;

	[Token(Token = "0x600C095")]
	[Address(RVA = "0x143093C", Offset = "0x143093C", VA = "0x143093C")]
	public UIRushingPetsCustomRoomController()
	{
	}

	[Token(Token = "0x600C096")]
	[Address(RVA = "0x1430944", Offset = "0x1430944", VA = "0x1430944")]
	public new static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600C097")]
	[Address(RVA = "0x14309E8", Offset = "0x14309E8", VA = "0x14309E8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600C098")]
	[Address(RVA = "0x1430D9C", Offset = "0x1430D9C", VA = "0x1430D9C", Slot = "56")]
	protected override string GetCurrentGameStartInfo()
	{
		return null;
	}

	[Token(Token = "0x600C099")]
	[Address(RVA = "0x14311BC", Offset = "0x14311BC", VA = "0x14311BC", Slot = "53")]
	protected override bool IsShowInfoPanelOpenBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600C09A")]
	[Address(RVA = "0x1431214", Offset = "0x1431214", VA = "0x1431214", Slot = "50")]
	protected override bool IsShowInviteBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600C09B")]
	[Address(RVA = "0x143126C", Offset = "0x143126C", VA = "0x143126C", Slot = "54")]
	protected override bool IsShowLoadOut()
	{
		return default(bool);
	}

	[Token(Token = "0x600C09C")]
	[Address(RVA = "0x14312C4", Offset = "0x14312C4", VA = "0x14312C4", Slot = "51")]
	protected override bool IsShowOB()
	{
		return default(bool);
	}

	[Token(Token = "0x600C09D")]
	[Address(RVA = "0x143131C", Offset = "0x143131C", VA = "0x143131C", Slot = "52")]
	protected override bool IsShowToggleDisplayTypeBtn()
	{
		return default(bool);
	}

	[Token(Token = "0x600C09E")]
	[Address(RVA = "0x1431374", Offset = "0x1431374", VA = "0x1431374", Slot = "58")]
	protected override void OnBtnCustomize()
	{
	}

	[Token(Token = "0x600C09F")]
	[Address(RVA = "0x1431484", Offset = "0x1431484", VA = "0x1431484", Slot = "57")]
	protected override void OnBtnGameStartCallBack()
	{
	}

	[Token(Token = "0x600C0A0")]
	[Address(RVA = "0x1431558", Offset = "0x1431558", VA = "0x1431558", Slot = "55")]
	protected override EInventory.ItemSubType RoomCardType()
	{
		return default(EInventory.ItemSubType);
	}

	[Token(Token = "0x600C0A1")]
	[Address(RVA = "0x14315B0", Offset = "0x14315B0", VA = "0x14315B0", Slot = "40")]
	public override bool OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600C0A2")]
	[Address(RVA = "0x1431974", Offset = "0x1431974", VA = "0x1431974", Slot = "46")]
	protected override void RefreshUIData(bool mapModeChanged)
	{
	}

	[Token(Token = "0x600C0A3")]
	[Address(RVA = "0x1431A8C", Offset = "0x1431A8C", VA = "0x1431A8C", Slot = "47")]
	protected override List<RoomGameSettingData> PrepareGameSettingData()
	{
		return null;
	}

	[Token(Token = "0x600C0A4")]
	[Address(RVA = "0x1432158", Offset = "0x1432158", VA = "0x1432158")]
	protected RushingPetsRoomSettingData GetSettingDataByType(DCNOOCAGCKC settingType)
	{
		return null;
	}

	[Token(Token = "0x600C0A5")]
	[Address(RVA = "0x14322A4", Offset = "0x14322A4", VA = "0x14322A4")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600C0A6")]
	[Address(RVA = "0x14322AC", Offset = "0x14322AC", VA = "0x14322AC")]
	public bool _003C_003EiFixBaseProxy_OverwriteBackButtonLogic()
	{
		return default(bool);
	}

	[Token(Token = "0x600C0A7")]
	[Address(RVA = "0x14322B4", Offset = "0x14322B4", VA = "0x14322B4")]
	public void _003C_003EiFixBaseProxy_RefreshUIData(bool P0)
	{
	}

	[Token(Token = "0x600C0A8")]
	[Address(RVA = "0x14322BC", Offset = "0x14322BC", VA = "0x14322BC")]
	public List<RoomGameSettingData> _003C_003EiFixBaseProxy_PrepareGameSettingData()
	{
		return null;
	}
}
