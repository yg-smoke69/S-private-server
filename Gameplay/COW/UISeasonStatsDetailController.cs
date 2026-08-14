using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002B0D")]
internal class UISeasonStatsDetailController : UINavigationController
{
	[Token(Token = "0x4010829")]
	[FieldOffset(Offset = "0x68")]
	private UISeasonStatsDetailView m_View;

	[Token(Token = "0x401082A")]
	[FieldOffset(Offset = "0x6C")]
	private GameObject[] m_CSStarArray;

	[Token(Token = "0x401082B")]
	[FieldOffset(Offset = "0x70")]
	private GameObject[] m_CSBlackStarArray;

	[Token(Token = "0x401082C")]
	[FieldOffset(Offset = "0x74")]
	private UIModelPeriodicLadderMatch m_ModelLadderMatchPeriodic;

	[Token(Token = "0x6011AEF")]
	[Address(RVA = "0x1A456C4", Offset = "0x1A456C4", VA = "0x1A456C4")]
	public UISeasonStatsDetailController()
	{
	}

	[Token(Token = "0x6011AF0")]
	[Address(RVA = "0x1A45748", Offset = "0x1A45748", VA = "0x1A45748")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011AF1")]
	[Address(RVA = "0x1A457EC", Offset = "0x1A457EC", VA = "0x1A457EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011AF2")]
	[Address(RVA = "0x1A461E4", Offset = "0x1A461E4", VA = "0x1A461E4", Slot = "31")]
	public override void OnNavigationShowed(UINavigationData navigationData, bool isRoot = false)
	{
	}

	[Token(Token = "0x6011AF3")]
	[Address(RVA = "0x1A46574", Offset = "0x1A46574", VA = "0x1A46574")]
	private void OnCloseBtnClick()
	{
	}

	[Token(Token = "0x6011AF4")]
	[Address(RVA = "0x1A46680", Offset = "0x1A46680", VA = "0x1A46680")]
	private void OnShareBtnClick()
	{
	}

	[Token(Token = "0x6011AF5")]
	[Address(RVA = "0x1A46390", Offset = "0x1A46390", VA = "0x1A46390")]
	public void SetViewData(DGNDKMLMLPM ladderMatchType)
	{
	}

	[Token(Token = "0x6011AF6")]
	[Address(RVA = "0x1A47BD8", Offset = "0x1A47BD8", VA = "0x1A47BD8")]
	private void RefreshCSData()
	{
	}

	[Token(Token = "0x6011AF7")]
	[Address(RVA = "0x1A49318", Offset = "0x1A49318", VA = "0x1A49318")]
	private void RefreshPeriodicData()
	{
	}

	[Token(Token = "0x6011AF8")]
	[Address(RVA = "0x1A46918", Offset = "0x1A46918", VA = "0x1A46918")]
	private void RefreshBRData()
	{
	}

	[Token(Token = "0x6011AF9")]
	[Address(RVA = "0x1A4AA74", Offset = "0x1A4AA74", VA = "0x1A4AA74")]
	private string SecFormat(uint _sec)
	{
		return null;
	}

	[Token(Token = "0x6011AFA")]
	[Address(RVA = "0x1A4ABB0", Offset = "0x1A4ABB0", VA = "0x1A4ABB0")]
	private string uniFormat(uint n)
	{
		return null;
	}

	[Token(Token = "0x6011AFB")]
	[Address(RVA = "0x1A4AD44", Offset = "0x1A4AD44", VA = "0x1A4AD44", Slot = "25")]
	public override void BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011AFC")]
	[Address(RVA = "0x1A4AEA0", Offset = "0x1A4AEA0", VA = "0x1A4AEA0", Slot = "26")]
	public override void AfterScreenshot()
	{
	}

	[Token(Token = "0x6011AFD")]
	[Address(RVA = "0x1A4AFFC", Offset = "0x1A4AFFC", VA = "0x1A4AFFC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x6011AFE")]
	[Address(RVA = "0x1A4B004", Offset = "0x1A4B004", VA = "0x1A4B004")]
	public void _003C_003EiFixBaseProxy_OnNavigationShowed(UINavigationData P0, bool P1)
	{
	}

	[Token(Token = "0x6011AFF")]
	[Address(RVA = "0x1A4B00C", Offset = "0x1A4B00C", VA = "0x1A4B00C")]
	public new void _003C_003EiFixBaseProxy_BeforeScreenshot()
	{
	}

	[Token(Token = "0x6011B00")]
	[Address(RVA = "0x1A4B014", Offset = "0x1A4B014", VA = "0x1A4B014")]
	public new void _003C_003EiFixBaseProxy_AfterScreenshot()
	{
	}
}
