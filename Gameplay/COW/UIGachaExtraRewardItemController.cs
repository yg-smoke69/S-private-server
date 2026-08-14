using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x200268D")]
public class UIGachaExtraRewardItemController : UIBaseController
{
	[Token(Token = "0x400EDE7")]
	[FieldOffset(Offset = "0x28")]
	public UIGachaExtraRewardItemView m_View;

	[Token(Token = "0x400EDE8")]
	[FieldOffset(Offset = "0x2C")]
	public StatndardItemMiniData m_Data;

	[Token(Token = "0x600E774")]
	[Address(RVA = "0x247A064", Offset = "0x247A064", VA = "0x247A064")]
	public UIGachaExtraRewardItemController()
	{
	}

	[Token(Token = "0x600E775")]
	[Address(RVA = "0x247A0E8", Offset = "0x247A0E8", VA = "0x247A0E8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E776")]
	[Address(RVA = "0x247A18C", Offset = "0x247A18C", VA = "0x247A18C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E777")]
	[Address(RVA = "0x247A23C", Offset = "0x247A23C", VA = "0x247A23C")]
	public void Init()
	{
	}

	[Token(Token = "0x600E778")]
	[Address(RVA = "0x2477144", Offset = "0x2477144", VA = "0x2477144")]
	public void SetStandItemMiniData(StatndardItemMiniData data, bool hasTween = true)
	{
	}

	[Token(Token = "0x600E779")]
	[Address(RVA = "0x247A2A8", Offset = "0x247A2A8", VA = "0x247A2A8")]
	public void RefreshView()
	{
	}

	[Token(Token = "0x600E77A")]
	[Address(RVA = "0x247ADE4", Offset = "0x247ADE4", VA = "0x247ADE4")]
	public UIDragScrollView GetItemDragView()
	{
		return null;
	}

	[Token(Token = "0x600E77B")]
	[Address(RVA = "0x247AE54", Offset = "0x247AE54", VA = "0x247AE54")]
	public void UpdateQuantityLabel(string newCount)
	{
	}

	[Token(Token = "0x600E77C")]
	[Address(RVA = "0x247AF00", Offset = "0x247AF00", VA = "0x247AF00")]
	public void SetFlowLightEnable(bool b)
	{
	}

	[Token(Token = "0x600E77D")]
	[Address(RVA = "0x247A748", Offset = "0x247A748", VA = "0x247A748")]
	public void SetQualityBG()
	{
	}

	[Token(Token = "0x600E77E")]
	[Address(RVA = "0x247A440", Offset = "0x247A440", VA = "0x247A440")]
	public void RefreshBaseItemView(BaseItemInfo info)
	{
	}

	[Token(Token = "0x600E77F")]
	[Address(RVA = "0x247AF98", Offset = "0x247AF98", VA = "0x247AF98")]
	public void SetBtnClickEvent(bool useFullScreen = true)
	{
	}

	[Token(Token = "0x600E780")]
	[Address(RVA = "0x247B144", Offset = "0x247B144", VA = "0x247B144")]
	public void SetCustomBtnClickEvent(Callback action)
	{
	}

	[Token(Token = "0x600E781")]
	[Address(RVA = "0x247B280", Offset = "0x247B280", VA = "0x247B280")]
	public void EnableItemBtn()
	{
	}

	[Token(Token = "0x600E782")]
	[Address(RVA = "0x247B310", Offset = "0x247B310", VA = "0x247B310")]
	public void DisableItemBtn()
	{
	}

	[Token(Token = "0x600E783")]
	[Address(RVA = "0x247B3A0", Offset = "0x247B3A0", VA = "0x247B3A0")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x600E784")]
	[Address(RVA = "0x247B4FC", Offset = "0x247B4FC", VA = "0x247B4FC")]
	private void ShowFullScreenPreview()
	{
	}

	[Token(Token = "0x600E785")]
	[Address(RVA = "0x247A4E8", Offset = "0x247A4E8", VA = "0x247A4E8")]
	public void SetLimitTitleState(bool show)
	{
	}

	[Token(Token = "0x600E786")]
	[Address(RVA = "0x2477298", Offset = "0x2477298", VA = "0x2477298")]
	public void SetClaimedState(bool show)
	{
	}

	[Token(Token = "0x600E787")]
	[Address(RVA = "0x247A580", Offset = "0x247A580", VA = "0x247A580")]
	public void SetLadderGotState(bool show)
	{
	}

	[Token(Token = "0x600E788")]
	[Address(RVA = "0x2477330", Offset = "0x2477330", VA = "0x2477330")]
	public void SetHighLightState(bool show)
	{
	}

	[Token(Token = "0x600E789")]
	[Address(RVA = "0x2477200", Offset = "0x2477200", VA = "0x2477200")]
	public void SetGreyBGState(bool show)
	{
	}

	[Token(Token = "0x600E78A")]
	[Address(RVA = "0x247A618", Offset = "0x247A618", VA = "0x247A618")]
	public void SetOwnedState(bool show)
	{
	}

	[Token(Token = "0x600E78B")]
	[Address(RVA = "0x247A6B0", Offset = "0x247A6B0", VA = "0x247A6B0")]
	public void SetDownloadInfoState(bool show)
	{
	}

	[Token(Token = "0x600E78C")]
	[Address(RVA = "0x247B72C", Offset = "0x247B72C", VA = "0x247B72C")]
	public void SetQuantityIgnoreOne(bool ignore)
	{
	}

	[Token(Token = "0x600E78D")]
	[Address(RVA = "0x247B7B8", Offset = "0x247B7B8", VA = "0x247B7B8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
