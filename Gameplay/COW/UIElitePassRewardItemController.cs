using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x20025F5")]
internal class UIElitePassRewardItemController : UIEasyListItemController
{
	[Token(Token = "0x400EA9C")]
	[FieldOffset(Offset = "0x38")]
	private UIElitePassRewardItemView m_View;

	[Token(Token = "0x400EA9D")]
	[FieldOffset(Offset = "0x3C")]
	private EPAwardInfo m_AwardInfo;

	[Token(Token = "0x400EA9E")]
	[FieldOffset(Offset = "0x40")]
	private UIModelElitePass m_EPModel;

	[Token(Token = "0x400EA9F")]
	[FieldOffset(Offset = "0x44")]
	private bool m_IsClickEp;

	[Token(Token = "0x600E02E")]
	[Address(RVA = "0x3060B18", Offset = "0x3060B18", VA = "0x3060B18")]
	public UIElitePassRewardItemController()
	{
	}

	[Token(Token = "0x600E02F")]
	[Address(RVA = "0x3060B20", Offset = "0x3060B20", VA = "0x3060B20")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E030")]
	[Address(RVA = "0x3060BC8", Offset = "0x3060BC8", VA = "0x3060BC8", Slot = "30")]
	protected override ResourceID GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E031")]
	[Address(RVA = "0x3060C24", Offset = "0x3060C24", VA = "0x3060C24", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x600E032")]
	[Address(RVA = "0x3061278", Offset = "0x3061278", VA = "0x3061278", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x600E033")]
	[Address(RVA = "0x30613AC", Offset = "0x30613AC", VA = "0x30613AC")]
	private void UpdateMaxRewardUI()
	{
	}

	[Token(Token = "0x600E034")]
	[Address(RVA = "0x3062154", Offset = "0x3062154", VA = "0x3062154")]
	private void UpdateNormalRewardUI()
	{
	}

	[Token(Token = "0x600E035")]
	[Address(RVA = "0x3064634", Offset = "0x3064634", VA = "0x3064634")]
	private void OnFPReviewClick()
	{
	}

	[Token(Token = "0x600E036")]
	[Address(RVA = "0x30649A4", Offset = "0x30649A4", VA = "0x30649A4")]
	private void OnEPReviewClick()
	{
	}

	[Token(Token = "0x600E037")]
	[Address(RVA = "0x3064A08", Offset = "0x3064A08", VA = "0x3064A08")]
	private void OnEPMaxRewardReviewClick()
	{
	}

	[Token(Token = "0x600E038")]
	[Address(RVA = "0x3064B34", Offset = "0x3064B34", VA = "0x3064B34")]
	private void OnFPGetButton()
	{
	}

	[Token(Token = "0x600E039")]
	[Address(RVA = "0x3064D6C", Offset = "0x3064D6C", VA = "0x3064D6C")]
	private void OnEPGetButton()
	{
	}

	[Token(Token = "0x600E03A")]
	[Address(RVA = "0x3064FA4", Offset = "0x3064FA4", VA = "0x3064FA4")]
	private void OnBadgeButtonClick()
	{
	}

	[Token(Token = "0x600E03B")]
	[Address(RVA = "0x3065284", Offset = "0x3065284", VA = "0x3065284")]
	private void OnMaxRewardHelpBtnClick()
	{
	}

	[Token(Token = "0x600E03C")]
	[Address(RVA = "0x30655B0", Offset = "0x30655B0", VA = "0x30655B0")]
	private void OnClaimMaxRewardBtnClick()
	{
	}

	[Token(Token = "0x600E03D")]
	[Address(RVA = "0x3064698", Offset = "0x3064698", VA = "0x3064698")]
	private void OnRewardClick(bool isEp)
	{
	}

	[Token(Token = "0x600E03E")]
	[Address(RVA = "0x3065644", Offset = "0x3065644", VA = "0x3065644", Slot = "34")]
	public override void OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E03F")]
	[Address(RVA = "0x3065770", Offset = "0x3065770", VA = "0x3065770", Slot = "35")]
	public override void OnItemBtnUnSelect()
	{
	}

	[Token(Token = "0x600E040")]
	[Address(RVA = "0x3065884", Offset = "0x3065884", VA = "0x3065884")]
	private void OnEnable()
	{
	}

	[Token(Token = "0x600E041")]
	[Address(RVA = "0x306598C", Offset = "0x306598C", VA = "0x306598C")]
	public ResourceID _003C_003EiFixBaseProxy_GetResID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x600E042")]
	[Address(RVA = "0x3065994", Offset = "0x3065994", VA = "0x3065994")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x600E043")]
	[Address(RVA = "0x306599C", Offset = "0x306599C", VA = "0x306599C")]
	public void _003C_003EiFixBaseProxy_OnItemBtnSelect()
	{
	}

	[Token(Token = "0x600E044")]
	[Address(RVA = "0x30659A4", Offset = "0x30659A4", VA = "0x30659A4")]
	public void _003C_003EiFixBaseProxy_OnItemBtnUnSelect()
	{
	}
}
