using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B37")]
internal class UISPHudKillLeaderBoardControler : UIBaseController, _Attribute
{
	[Token(Token = "0x401093F")]
	[FieldOffset(Offset = "0x28")]
	private UISPHudKillLeaderBoardView m_View;

	[Token(Token = "0x4010940")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelSpectator m_model;

	[Token(Token = "0x4010941")]
	[FieldOffset(Offset = "0x30")]
	private bool HasKillLeader;

	[Token(Token = "0x6011C9E")]
	[Address(RVA = "0x1D1F6A0", Offset = "0x1D1F6A0", VA = "0x1D1F6A0")]
	public UISPHudKillLeaderBoardControler()
	{
	}

	[Token(Token = "0x6011C9F")]
	[Address(RVA = "0x1D1F724", Offset = "0x1D1F724", VA = "0x1D1F724")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011CA0")]
	[Address(RVA = "0x1D1F7CC", Offset = "0x1D1F7CC", VA = "0x1D1F7CC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011CA1")]
	[Address(RVA = "0x1D1F9E8", Offset = "0x1D1F9E8", VA = "0x1D1F9E8", Slot = "17")]
	protected override void OnUIDestroy()
	{
	}

	[Token(Token = "0x6011CA2")]
	[Address(RVA = "0x1D1FA70", Offset = "0x1D1FA70", VA = "0x1D1FA70", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011CA3")]
	[Address(RVA = "0x1D1FB98", Offset = "0x1D1FB98", VA = "0x1D1FB98")]
	public void SetKillLeaderBoardInfo(SPGameAchievement achievement)
	{
	}

	[Token(Token = "0x6011CA4")]
	[Address(RVA = "0x1D1FF90", Offset = "0x1D1FF90", VA = "0x1D1FF90")]
	private void OnUIToggle(object[] data)
	{
	}

	[Token(Token = "0x6011CA5")]
	[Address(RVA = "0x1D20074", Offset = "0x1D20074", VA = "0x1D20074", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011CA6")]
	[Address(RVA = "0x1D203EC", Offset = "0x1D203EC", VA = "0x1D203EC", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011CA7")]
	[Address(RVA = "0x1D20480", Offset = "0x1D20480", VA = "0x1D20480")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011CA8")]
	[Address(RVA = "0x1D20488", Offset = "0x1D20488", VA = "0x1D20488")]
	public void _003C_003EiFixBaseProxy_OnUIDestroy()
	{
	}

	[Token(Token = "0x6011CA9")]
	[Address(RVA = "0x1D20490", Offset = "0x1D20490", VA = "0x1D20490")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
