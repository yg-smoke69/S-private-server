using System.Runtime.InteropServices;
using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200228B")]
internal class UISPHudPlayerAccStatsPanelController : UIBaseController, _Attribute
{
	[Token(Token = "0x400D862")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudPlayerAccStatsPanelView m_View;

	[Token(Token = "0x400D863")]
	[FieldOffset(Offset = "0x2C")]
	private UISPHudPlayerAccStatsItemView m_KillCtrl;

	[Token(Token = "0x400D864")]
	[FieldOffset(Offset = "0x30")]
	private UISPHudPlayerAccStatsItemView m_HeadShotCtrl;

	[Token(Token = "0x400D865")]
	[FieldOffset(Offset = "0x34")]
	private UISPHudPlayerAccStatsItemView m_DamageCtrl;

	[Token(Token = "0x400D866")]
	[FieldOffset(Offset = "0x38")]
	private bool m_IsRequesting;

	[Token(Token = "0x400D867")]
	[FieldOffset(Offset = "0x40")]
	private IHAAMHPPLMG m_RequestPlayerID;

	[Token(Token = "0x400D868")]
	[FieldOffset(Offset = "0x58")]
	private IHAAMHPPLMG m_CurrentTrackingPlayerID;

	[Token(Token = "0x600BD6B")]
	[Address(RVA = "0x1D264E8", Offset = "0x1D264E8", VA = "0x1D264E8")]
	public UISPHudPlayerAccStatsPanelController()
	{
	}

	[Token(Token = "0x600BD6C")]
	[Address(RVA = "0x1D265DC", Offset = "0x1D265DC", VA = "0x1D265DC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600BD6D")]
	[Address(RVA = "0x1D26684", Offset = "0x1D26684", VA = "0x1D26684", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600BD6E")]
	[Address(RVA = "0x1D26974", Offset = "0x1D26974", VA = "0x1D26974", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x600BD6F")]
	[Address(RVA = "0x1D26BA0", Offset = "0x1D26BA0", VA = "0x1D26BA0")]
	private void RequestPlayerRank(object[] data)
	{
	}

	[Token(Token = "0x600BD70")]
	[Address(RVA = "0x1D26E9C", Offset = "0x1D26E9C", VA = "0x1D26E9C")]
	private void OnObserverSwitch(object[] data)
	{
	}

	[Token(Token = "0x600BD71")]
	[Address(RVA = "0x1D270F8", Offset = "0x1D270F8", VA = "0x1D270F8")]
	private void ShowRank(object[] param)
	{
	}

	[Token(Token = "0x600BD72")]
	[Address(RVA = "0x1D27570", Offset = "0x1D27570", VA = "0x1D27570", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x600BD73")]
	[Address(RVA = "0x1D2762C", Offset = "0x1D2762C", VA = "0x1D2762C", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x600BD74")]
	[Address(RVA = "0x1D276C0", Offset = "0x1D276C0", VA = "0x1D276C0")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600BD75")]
	[Address(RVA = "0x1D276C8", Offset = "0x1D276C8", VA = "0x1D276C8")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
