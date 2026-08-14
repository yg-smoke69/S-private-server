using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A91")]
public class UIProfileCreditRewardItemController : UIBaseController
{
	[Token(Token = "0x40105AD")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileCreditRewardItemView m_View;

	[Token(Token = "0x40105AE")]
	[FieldOffset(Offset = "0x2C")]
	private UIStandardItemMiniController m_UIStandardItemMiniController;

	[Token(Token = "0x60115FB")]
	[Address(RVA = "0x16D1A08", Offset = "0x16D1A08", VA = "0x16D1A08")]
	public UIProfileCreditRewardItemController()
	{
	}

	[Token(Token = "0x60115FC")]
	[Address(RVA = "0x16D1A8C", Offset = "0x16D1A8C", VA = "0x16D1A8C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60115FD")]
	[Address(RVA = "0x16D1B30", Offset = "0x16D1B30", VA = "0x16D1B30", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60115FE")]
	[Address(RVA = "0x16D0B4C", Offset = "0x16D0B4C", VA = "0x16D0B4C")]
	public void SetData(BaseItemInfo item, ECreditScore.RewardState rewardState)
	{
	}

	[Token(Token = "0x60115FF")]
	[Address(RVA = "0x16D1D20", Offset = "0x16D1D20", VA = "0x16D1D20")]
	private void ClaimeReward()
	{
	}

	[Token(Token = "0x6011600")]
	[Address(RVA = "0x16D1870", Offset = "0x16D1870", VA = "0x16D1870")]
	public void ClaimeSuccessfully()
	{
	}

	[Token(Token = "0x6011601")]
	[Address(RVA = "0x16D1E40", Offset = "0x16D1E40", VA = "0x16D1E40")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
