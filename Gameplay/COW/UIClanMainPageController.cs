using System;
using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200254D")]
public class UIClanMainPageController : UIBaseController, _Attribute, IConvertible
{
	[Token(Token = "0x400E711")]
	[FieldOffset(Offset = "0x28")]
	private UIClanMainPageView m_View;

	[Token(Token = "0x400E712")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelClan m_ModelClan;

	[Token(Token = "0x400E713")]
	[FieldOffset(Offset = "0x30")]
	private UIBaseProfileInfoController m_BaseProfileUI;

	[Token(Token = "0x400E714")]
	[FieldOffset(Offset = "0x34")]
	private UILobbyChatController m_ChatBtn;

	[Token(Token = "0x600D932")]
	[Address(RVA = "0x2B353D4", Offset = "0x2B353D4", VA = "0x2B353D4")]
	public UIClanMainPageController()
	{
	}

	[Token(Token = "0x600D933")]
	[Address(RVA = "0x2B35458", Offset = "0x2B35458", VA = "0x2B35458")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600D934")]
	[Address(RVA = "0x2B354FC", Offset = "0x2B354FC", VA = "0x2B354FC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600D935")]
	[Address(RVA = "0x2B35594", Offset = "0x2B35594", VA = "0x2B35594", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600D936")]
	[Address(RVA = "0x2B36CF8", Offset = "0x2B36CF8", VA = "0x2B36CF8", Slot = "33")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x600D937")]
	[Address(RVA = "0x2B36D68", Offset = "0x2B36D68", VA = "0x2B36D68", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600D938")]
	[Address(RVA = "0x2B37558", Offset = "0x2B37558", VA = "0x2B37558", Slot = "20")]
	protected override void OnDestroy()
	{
	}

	[Token(Token = "0x600D939")]
	[Address(RVA = "0x2B3747C", Offset = "0x2B3747C", VA = "0x2B3747C")]
	private void InitView()
	{
	}

	[Token(Token = "0x600D93A")]
	[Address(RVA = "0x2B37684", Offset = "0x2B37684", VA = "0x2B37684")]
	private void RefreshChat()
	{
	}

	[Token(Token = "0x600D93B")]
	[Address(RVA = "0x2B36460", Offset = "0x2B36460", VA = "0x2B36460")]
	private void RefreshCaptain()
	{
	}

	[Token(Token = "0x600D93C")]
	[Address(RVA = "0x2B3667C", Offset = "0x2B3667C", VA = "0x2B3667C")]
	private void RefreshClanLogo()
	{
	}

	[Token(Token = "0x600D93D")]
	[Address(RVA = "0x2B358B8", Offset = "0x2B358B8", VA = "0x2B358B8")]
	private void RefreshClanInfo()
	{
	}

	[Token(Token = "0x600D93E")]
	[Address(RVA = "0x2B3603C", Offset = "0x2B3603C", VA = "0x2B3603C")]
	private void RefreshDetails()
	{
	}

	[Token(Token = "0x600D93F")]
	[Address(RVA = "0x2B3687C", Offset = "0x2B3687C", VA = "0x2B3687C")]
	private void RefreshClanWarInfo()
	{
	}

	[Token(Token = "0x600D940")]
	[Address(RVA = "0x2B36C24", Offset = "0x2B36C24", VA = "0x2B36C24")]
	private void UpdateDeputyCaptainButtonState()
	{
	}

	[Token(Token = "0x600D941")]
	[Address(RVA = "0x2B37838", Offset = "0x2B37838", VA = "0x2B37838")]
	private string GetLevelDetailString(ClanLevelData data)
	{
		return null;
	}

	[Token(Token = "0x600D942")]
	[Address(RVA = "0x2B385BC", Offset = "0x2B385BC", VA = "0x2B385BC")]
	private void OnSettingClicked()
	{
	}

	[Token(Token = "0x600D943")]
	[Address(RVA = "0x2B38810", Offset = "0x2B38810", VA = "0x2B38810")]
	private void OnBuffClicked()
	{
	}

	[Token(Token = "0x600D944")]
	[Address(RVA = "0x2B39184", Offset = "0x2B39184", VA = "0x2B39184")]
	private void OnOpenRankList()
	{
	}

	[Token(Token = "0x600D945")]
	[Address(RVA = "0x2B393E0", Offset = "0x2B393E0", VA = "0x2B393E0")]
	private void OnClanLogClicked()
	{
	}

	[Token(Token = "0x600D946")]
	[Address(RVA = "0x2B394F0", Offset = "0x2B394F0", VA = "0x2B394F0")]
	private void OnClanWarBtnClicked()
	{
	}

	[Token(Token = "0x600D947")]
	[Address(RVA = "0x2B39624", Offset = "0x2B39624", VA = "0x2B39624")]
	private void OnDeputyCaptainApplyClicked()
	{
	}

	[Token(Token = "0x600D948")]
	[Address(RVA = "0x2B39758", Offset = "0x2B39758", VA = "0x2B39758")]
	private void OnRedPacketClicked()
	{
	}

	[Token(Token = "0x600D949")]
	[Address(RVA = "0x2B3993C", Offset = "0x2B3993C", VA = "0x2B3993C")]
	private void OnSignInClicked()
	{
	}

	[Token(Token = "0x600D94A")]
	[Address(RVA = "0x2B39B20", Offset = "0x2B39B20", VA = "0x2B39B20")]
	private void OnInviteClick()
	{
	}

	[Token(Token = "0x600D94B")]
	[Address(RVA = "0x2B39F7C", Offset = "0x2B39F7C", VA = "0x2B39F7C")]
	private void OnCaptainClicked()
	{
	}

	[Token(Token = "0x600D94C")]
	[Address(RVA = "0x2B3A180", Offset = "0x2B3A180", VA = "0x2B3A180")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600D94D")]
	[Address(RVA = "0x2B3A188", Offset = "0x2B3A188", VA = "0x2B3A188")]
	public void _003C_003EiFixBaseProxy_OnDestroy()
	{
	}
}
