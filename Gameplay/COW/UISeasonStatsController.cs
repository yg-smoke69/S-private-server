using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using message;

namespace COW;

[Token(Token = "0x2002B0C")]
public class UISeasonStatsController : UIBaseController, _Attribute
{
	[Token(Token = "0x4010821")]
	[FieldOffset(Offset = "0x28")]
	private UISeasonStatsView m_View;

	[Token(Token = "0x4010822")]
	[FieldOffset(Offset = "0x2C")]
	private DGNDKMLMLPM m_LadderMatchType;

	[Token(Token = "0x4010823")]
	[FieldOffset(Offset = "0x30")]
	private UIStandardItemMiniController m_ItemCtrl;

	[Token(Token = "0x4010824")]
	[FieldOffset(Offset = "0x34")]
	private UIStandardItemMiniController m_ItemPeakCtrl;

	[Token(Token = "0x4010825")]
	[FieldOffset(Offset = "0x38")]
	private UIModelLadderMatch m_ModelLadderMatchBR;

	[Token(Token = "0x4010826")]
	[FieldOffset(Offset = "0x3C")]
	private UIModelCSLadderMatch m_ModelLadderMatchCS;

	[Token(Token = "0x4010827")]
	[FieldOffset(Offset = "0x40")]
	private UIModelPeriodicLadderMatch m_ModelLadderMatchPeriodic;

	[Token(Token = "0x4010828")]
	[FieldOffset(Offset = "0x44")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x6011AE0")]
	[Address(RVA = "0x1A43BC4", Offset = "0x1A43BC4", VA = "0x1A43BC4")]
	public UISeasonStatsController()
	{
	}

	[Token(Token = "0x6011AE1")]
	[Address(RVA = "0x1A43D84", Offset = "0x1A43D84", VA = "0x1A43D84")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011AE2")]
	[Address(RVA = "0x1A43E28", Offset = "0x1A43E28", VA = "0x1A43E28", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011AE3")]
	[Address(RVA = "0x1A44118", Offset = "0x1A44118", VA = "0x1A44118")]
	public void SetViewData(DGNDKMLMLPM ladderMatchType)
	{
	}

	[Token(Token = "0x6011AE4")]
	[Address(RVA = "0x1A444E4", Offset = "0x1A444E4", VA = "0x1A444E4")]
	private void RefreshItemCtrl(uint awardId, bool needSetGreyBg, bool isPeak)
	{
	}

	[Token(Token = "0x6011AE5")]
	[Address(RVA = "0x1A446C8", Offset = "0x1A446C8", VA = "0x1A446C8")]
	private void RefreshSeasonStateInfo(uint wins, uint kills, string keyKdTitle, string kdLabel)
	{
	}

	[Token(Token = "0x6011AE6")]
	[Address(RVA = "0x1A44918", Offset = "0x1A44918", VA = "0x1A44918")]
	private void RefreshRankSprite(ResourceID resIdSprite, bool isPeak)
	{
	}

	[Token(Token = "0x6011AE7")]
	[Address(RVA = "0x1A44A78", Offset = "0x1A44A78", VA = "0x1A44A78")]
	private void RefreshCSData()
	{
	}

	[Token(Token = "0x6011AE8")]
	[Address(RVA = "0x1A44220", Offset = "0x1A44220", VA = "0x1A44220")]
	private void RefreshPeriodicData()
	{
	}

	[Token(Token = "0x6011AE9")]
	[Address(RVA = "0x1A44CF0", Offset = "0x1A44CF0", VA = "0x1A44CF0")]
	private void RefreshBRData()
	{
	}

	[Token(Token = "0x6011AEA")]
	[Address(RVA = "0x1A44F38", Offset = "0x1A44F38", VA = "0x1A44F38")]
	private void OnDetailsBtnClick()
	{
	}

	[Token(Token = "0x6011AEB")]
	[Address(RVA = "0x1A45104", Offset = "0x1A45104", VA = "0x1A45104")]
	private void OnViewAllBtnClicked()
	{
	}

	[Token(Token = "0x6011AEC")]
	[Address(RVA = "0x1A45474", Offset = "0x1A45474", VA = "0x1A45474", Slot = "31")]
	public void OnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x6011AED")]
	[Address(RVA = "0x1A455E0", Offset = "0x1A455E0", VA = "0x1A455E0", Slot = "32")]
	public uint GetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x6011AEE")]
	[Address(RVA = "0x1A456BC", Offset = "0x1A456BC", VA = "0x1A456BC")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
