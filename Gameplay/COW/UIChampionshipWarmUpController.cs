using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002031")]
public class UIChampionshipWarmUpController : UINavigationController
{
	[Token(Token = "0x400CA0B")]
	[FieldOffset(Offset = "0x68")]
	private UIChampionshipWarmUpView m_View;

	[Token(Token = "0x400CA0C")]
	[FieldOffset(Offset = "0x6C")]
	private UIModelChampionship m_ModelChampionship;

	[Token(Token = "0x400CA0D")]
	[FieldOffset(Offset = "0x70")]
	private ChampionshipSettingDesc m_ChampionshipSettingInfo;

	[Token(Token = "0x400CA0E")]
	[FieldOffset(Offset = "0x74")]
	private MapOpeningInfo m_MapInfo;

	[Token(Token = "0x400CA0F")]
	[FieldOffset(Offset = "0x78")]
	private ChampionshipOpenInfoDesc m_ChampionshipOpenInfo;

	[Token(Token = "0x600A360")]
	[Address(RVA = "0x2624E58", Offset = "0x2624E58", VA = "0x2624E58")]
	public UIChampionshipWarmUpController()
	{
	}

	[Token(Token = "0x600A361")]
	[Address(RVA = "0x2624EDC", Offset = "0x2624EDC", VA = "0x2624EDC")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600A362")]
	[Address(RVA = "0x2624F80", Offset = "0x2624F80", VA = "0x2624F80", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600A363")]
	[Address(RVA = "0x26252A8", Offset = "0x26252A8", VA = "0x26252A8")]
	private void SetView()
	{
	}

	[Token(Token = "0x600A364")]
	[Address(RVA = "0x2625920", Offset = "0x2625920", VA = "0x2625920")]
	protected void RefreshCupIcon()
	{
	}

	[Token(Token = "0x600A365")]
	[Address(RVA = "0x2625BA8", Offset = "0x2625BA8", VA = "0x2625BA8")]
	protected void OnBtnRuleClick()
	{
	}

	[Token(Token = "0x600A366")]
	[Address(RVA = "0x2625D24", Offset = "0x2625D24", VA = "0x2625D24")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
