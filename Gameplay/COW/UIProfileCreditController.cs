using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using proto;

namespace COW;

[Token(Token = "0x2002A90")]
internal class UIProfileCreditController : UIBaseController, _Attribute
{
	[Token(Token = "0x40105A9")]
	[FieldOffset(Offset = "0x28")]
	private UIProfileCreditView m_View;

	[Token(Token = "0x40105AA")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelCredit m_Model;

	[Token(Token = "0x40105AB")]
	private const int MAX_REWARD_ITEMS_COUNT = 3;

	[Token(Token = "0x40105AC")]
	[FieldOffset(Offset = "0x30")]
	private UIProfileCreditRewardItemController[] m_AwardItemCtrlArray;

	[Token(Token = "0x60115EE")]
	[Address(RVA = "0x16D0408", Offset = "0x16D0408", VA = "0x16D0408")]
	public UIProfileCreditController()
	{
	}

	[Token(Token = "0x60115EF")]
	[Address(RVA = "0x16D048C", Offset = "0x16D048C", VA = "0x16D048C")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60115F0")]
	[Address(RVA = "0x16D0530", Offset = "0x16D0530", VA = "0x16D0530", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60115F1")]
	[Address(RVA = "0x16D0A18", Offset = "0x16D0A18", VA = "0x16D0A18", Slot = "15")]
	protected override void OnUIClose()
	{
	}

	[Token(Token = "0x60115F2")]
	[Address(RVA = "0x16CFA98", Offset = "0x16CFA98", VA = "0x16CFA98")]
	public void SetUIData(CreditScoreInfoBasic info)
	{
	}

	[Token(Token = "0x60115F3")]
	[Address(RVA = "0x16D0D18", Offset = "0x16D0D18", VA = "0x16D0D18")]
	private void OnClickRewardTip()
	{
	}

	[Token(Token = "0x60115F4")]
	[Address(RVA = "0x16D0F74", Offset = "0x16D0F74", VA = "0x16D0F74")]
	private void OnClickCreditHistory()
	{
	}

	[Token(Token = "0x60115F5")]
	[Address(RVA = "0x16D11B0", Offset = "0x16D11B0", VA = "0x16D11B0")]
	private void OnClickHelp()
	{
	}

	[Token(Token = "0x60115F6")]
	[Address(RVA = "0x16D1328", Offset = "0x16D1328", VA = "0x16D1328")]
	private void OnShowCreditPunishRules(object[] data)
	{
	}

	[Token(Token = "0x60115F7")]
	[Address(RVA = "0x16D1390", Offset = "0x16D1390", VA = "0x16D1390", Slot = "31")]
	private void GCommon_002EIUIModelDataChangeObserver_002EOnDataChanged(UIBaseModel model, uint propID, object[] param)
	{
	}

	[Token(Token = "0x60115F8")]
	[Address(RVA = "0x16D1964", Offset = "0x16D1964", VA = "0x16D1964", Slot = "32")]
	private uint GCommon_002EIUIModelDataChangeObserver_002EGetInterestedPropID(UIBaseModel model)
	{
		return default(uint);
	}

	[Token(Token = "0x60115F9")]
	[Address(RVA = "0x16D19F8", Offset = "0x16D19F8", VA = "0x16D19F8")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}

	[Token(Token = "0x60115FA")]
	[Address(RVA = "0x16D1A00", Offset = "0x16D1A00", VA = "0x16D1A00")]
	public void _003C_003EiFixBaseProxy_OnUIClose()
	{
	}
}
