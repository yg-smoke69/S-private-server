using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

namespace COW;

[Token(Token = "0x2002BF0")]
internal class UIVeteranRewardsItemController : UIBaseController
{
	[Token(Token = "0x4010C6F")]
	[FieldOffset(Offset = "0x28")]
	private UIVeteranRewardsItemView m_View;

	[Token(Token = "0x4010C70")]
	[FieldOffset(Offset = "0x2C")]
	private UIWidget m_ItemWidget;

	[Token(Token = "0x4010C71")]
	[FieldOffset(Offset = "0x30")]
	private int m_IndexInList;

	[Token(Token = "0x4010C72")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsLastOne;

	[Token(Token = "0x4010C73")]
	[FieldOffset(Offset = "0x38")]
	private VeteranRewardItem m_ItemData;

	[Token(Token = "0x17001312")]
	public Vector2 ItemSize
	{
		[Token(Token = "0x6012362")]
		[Address(RVA = "0x2CBF09C", Offset = "0x2CBF09C", VA = "0x2CBF09C")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector2);
		}
		[Token(Token = "0x6012363")]
		[Address(RVA = "0x2CBF29C", Offset = "0x2CBF29C", VA = "0x2CBF29C")]
		set
		{
		}
	}

	[Token(Token = "0x6012360")]
	[Address(RVA = "0x2CBEF74", Offset = "0x2CBEF74", VA = "0x2CBEF74")]
	public UIVeteranRewardsItemController()
	{
	}

	[Token(Token = "0x6012361")]
	[Address(RVA = "0x2CBEFF8", Offset = "0x2CBEFF8", VA = "0x2CBEFF8")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6012364")]
	[Address(RVA = "0x2CBF46C", Offset = "0x2CBF46C", VA = "0x2CBF46C", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6012365")]
	[Address(RVA = "0x2CBF600", Offset = "0x2CBF600", VA = "0x2CBF600")]
	private void OnItemClick()
	{
	}

	[Token(Token = "0x6012366")]
	[Address(RVA = "0x2CBD99C", Offset = "0x2CBD99C", VA = "0x2CBD99C")]
	public void SetRewardData(VeteranRewardItem item, int listIndex, bool isLastOne = false)
	{
	}

	[Token(Token = "0x6012367")]
	[Address(RVA = "0x2CC0590", Offset = "0x2CC0590", VA = "0x2CC0590")]
	private void ShowItemPreview()
	{
	}

	[Token(Token = "0x6012368")]
	[Address(RVA = "0x2CBF868", Offset = "0x2CBF868", VA = "0x2CBF868")]
	private void SetBtnClickEvent(uint rewardsStatus)
	{
	}

	[Token(Token = "0x6012369")]
	[Address(RVA = "0x2CBF9DC", Offset = "0x2CBF9DC", VA = "0x2CBF9DC")]
	private void SetDayCountLabel(uint dayID)
	{
	}

	[Token(Token = "0x601236A")]
	[Address(RVA = "0x2CBFBE8", Offset = "0x2CBFBE8", VA = "0x2CBFBE8")]
	private void AdjustView(AwardItemInfo awardInfo, bool isLastOne = false)
	{
	}

	[Token(Token = "0x601236B")]
	[Address(RVA = "0x2CC09F4", Offset = "0x2CC09F4", VA = "0x2CC09F4")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
