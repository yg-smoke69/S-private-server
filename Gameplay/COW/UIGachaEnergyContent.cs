using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002639")]
internal class UIGachaEnergyContent : UIGachaContentBase
{
	[Token(Token = "0x400EC03")]
	[FieldOffset(Offset = "0x0")]
	private static readonly string GACHA_ENERGY_BUFF_STATE;

	[Token(Token = "0x400EC04")]
	[FieldOffset(Offset = "0x44")]
	private UIGachaEnergyContentView m_View;

	[Token(Token = "0x400EC05")]
	[FieldOffset(Offset = "0x48")]
	private UIModelGacha m_ModelGacha;

	[Token(Token = "0x600E39F")]
	[Address(RVA = "0x24738AC", Offset = "0x24738AC", VA = "0x24738AC")]
	public UIGachaEnergyContent()
	{
	}

	[Token(Token = "0x600E3A0")]
	[Address(RVA = "0x24738B4", Offset = "0x24738B4", VA = "0x24738B4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E3A1")]
	[Address(RVA = "0x2473958", Offset = "0x2473958", VA = "0x2473958", Slot = "62")]
	public override string GetTutorialWndTitleKey()
	{
		return null;
	}

	[Token(Token = "0x600E3A2")]
	[Address(RVA = "0x2473A30", Offset = "0x2473A30", VA = "0x2473A30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E3A3")]
	[Address(RVA = "0x2473D20", Offset = "0x2473D20", VA = "0x2473D20", Slot = "33")]
	protected override void InitGachaContentBuyBtn()
	{
	}

	[Token(Token = "0x600E3A4")]
	[Address(RVA = "0x2473E4C", Offset = "0x2473E4C", VA = "0x2473E4C", Slot = "34")]
	protected override void OnRefreshUIView()
	{
	}

	[Token(Token = "0x600E3A5")]
	[Address(RVA = "0x2474058", Offset = "0x2474058", VA = "0x2474058", Slot = "61")]
	public override UIGachaPreviewController OpenPreviewPanel(Transform parent)
	{
		return null;
	}

	[Token(Token = "0x600E3A6")]
	[Address(RVA = "0x2474150", Offset = "0x2474150", VA = "0x2474150")]
	private void OnClickShowRewardsBtn()
	{
	}

	[Token(Token = "0x600E3A7")]
	[Address(RVA = "0x2474528", Offset = "0x2474528", VA = "0x2474528")]
	private void OnClickChooseCheckbtn()
	{
	}

	[Token(Token = "0x600E3A8")]
	[Address(RVA = "0x24746C8", Offset = "0x24746C8", VA = "0x24746C8")]
	private void OnClickRefreshBuffBtn()
	{
	}

	[Token(Token = "0x600E3A9")]
	[Address(RVA = "0x2473EAC", Offset = "0x2473EAC", VA = "0x2473EAC")]
	private void RefreshChooseBuffState()
	{
	}

	[Token(Token = "0x600E3AB")]
	[Address(RVA = "0x24748FC", Offset = "0x24748FC", VA = "0x24748FC")]
	public new void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E3AC")]
	[Address(RVA = "0x2474904", Offset = "0x2474904", VA = "0x2474904")]
	public UIGachaPreviewController _003C_003EiFixBaseProxy_OpenPreviewPanel(Transform P0)
	{
		return null;
	}
}
