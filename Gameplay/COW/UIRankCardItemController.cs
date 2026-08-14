using GCommon;
using Il2CppDummyDll;

namespace COW;

[Token(Token = "0x2002AAD")]
public class UIRankCardItemController : UIEasyListItemController
{
	[Token(Token = "0x401066D")]
	private const string DOUBLE_CARD_DESC_KEY = "T_14_Q_RANKCARD_DOUBLERP_DESC";

	[Token(Token = "0x401066E")]
	private const string NO_DEDUCT_CARD_DESC_KEY = "T_16_Q_RANKCARD_DEDUCT_DESC";

	[Token(Token = "0x401066F")]
	private const string RANK_CARD_TIPS_KEY = "T_35_XC_RANKCARD_TIP";

	[Token(Token = "0x4010670")]
	private const string OWN_CNT_KEY = "T_35_XC_OWNED";

	[Token(Token = "0x4010671")]
	[FieldOffset(Offset = "0x38")]
	private UIRankCardItemView m_View;

	[Token(Token = "0x4010672")]
	[FieldOffset(Offset = "0x3C")]
	private BaseItemInfo m_data;

	[Token(Token = "0x4010673")]
	[FieldOffset(Offset = "0x40")]
	private RankCardData m_RankCardData;

	[Token(Token = "0x4010674")]
	[FieldOffset(Offset = "0x44")]
	private UIModelInventory m_ModelInventory;

	[Token(Token = "0x4010675")]
	[FieldOffset(Offset = "0x48")]
	private int m_CardCnt;

	[Token(Token = "0x4010676")]
	[FieldOffset(Offset = "0x4C")]
	private int m_SelectCardId;

	[Token(Token = "0x6011766")]
	[Address(RVA = "0x1AC2E9C", Offset = "0x1AC2E9C", VA = "0x1AC2E9C")]
	public UIRankCardItemController()
	{
	}

	[Token(Token = "0x6011767")]
	[Address(RVA = "0x1AC2EA4", Offset = "0x1AC2EA4", VA = "0x1AC2EA4")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6011768")]
	[Address(RVA = "0x1AC2F48", Offset = "0x1AC2F48", VA = "0x1AC2F48", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6011769")]
	[Address(RVA = "0x1AC3248", Offset = "0x1AC3248", VA = "0x1AC3248", Slot = "31")]
	public override void SetViewData(object data, int data_index)
	{
	}

	[Token(Token = "0x601176A")]
	[Address(RVA = "0x1AC3ADC", Offset = "0x1AC3ADC", VA = "0x1AC3ADC")]
	private void OnClickRankCardItem()
	{
	}

	[Token(Token = "0x601176B")]
	[Address(RVA = "0x1AC3C78", Offset = "0x1AC3C78", VA = "0x1AC3C78")]
	private void OnItemSelect(object[] data)
	{
	}

	[Token(Token = "0x601176C")]
	[Address(RVA = "0x1AC3DC8", Offset = "0x1AC3DC8", VA = "0x1AC3DC8")]
	private void OnInfoBtnClick()
	{
	}

	[Token(Token = "0x601176D")]
	[Address(RVA = "0x1AC4388", Offset = "0x1AC4388", VA = "0x1AC4388")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
