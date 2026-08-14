using COW.GamePlay;
using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002B4F")]
internal class UISPHudSinglePlayerItemController : UIEasyListItemController
{
	[Token(Token = "0x401098D")]
	[FieldOffset(Offset = "0x38")]
	private UISPHudSinglePlayerItemView m_View;

	[Token(Token = "0x401098E")]
	[FieldOffset(Offset = "0x40")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x6011D5A")]
	[Address(RVA = "0x1D2FB50", Offset = "0x1D2FB50", VA = "0x1D2FB50")]
	public UISPHudSinglePlayerItemController()
	{
	}

	[Token(Token = "0x6011D5B")]
	[Address(RVA = "0x1D2FB58", Offset = "0x1D2FB58", VA = "0x1D2FB58")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011D5C")]
	[Address(RVA = "0x1D2FC00", Offset = "0x1D2FC00", VA = "0x1D2FC00", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011D5D")]
	[Address(RVA = "0x1D2FE40", Offset = "0x1D2FE40", VA = "0x1D2FE40")]
	private void SelectedPlayer(object[] data)
	{
	}

	[Token(Token = "0x6011D5E")]
	[Address(RVA = "0x1D2FFE4", Offset = "0x1D2FFE4", VA = "0x1D2FFE4", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x6011D5F")]
	[Address(RVA = "0x1D22C98", Offset = "0x1D22C98", VA = "0x1D22C98")]
	public void SetPlayerInfo(PlayerData data, int index)
	{
	}

	[Token(Token = "0x6011D60")]
	[Address(RVA = "0x1D301C8", Offset = "0x1D301C8", VA = "0x1D301C8")]
	public void UpdateKillCount(uint killcount)
	{
	}

	[Token(Token = "0x6011D61")]
	[Address(RVA = "0x1D30294", Offset = "0x1D30294", VA = "0x1D30294", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x6011D62")]
	[Address(RVA = "0x1D30174", Offset = "0x1D30174", VA = "0x1D30174")]
	public void RefreshKingOfKill()
	{
	}

	[Token(Token = "0x6011D63")]
	[Address(RVA = "0x1D3056C", Offset = "0x1D3056C", VA = "0x1D3056C")]
	private void OnKoKPlayerChange(object[] data)
	{
	}

	[Token(Token = "0x6011D64")]
	[Address(RVA = "0x1D305D4", Offset = "0x1D305D4", VA = "0x1D305D4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011D65")]
	[Address(RVA = "0x1D305DC", Offset = "0x1D305DC", VA = "0x1D305DC")]
	public void _003C_003EiFixBaseProxy_OnUIDestory()
	{
	}
}
