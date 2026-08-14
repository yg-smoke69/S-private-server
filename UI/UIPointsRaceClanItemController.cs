using COW;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using proto;

[Token(Token = "0x2002A60")]
public class UIPointsRaceClanItemController : UIBaseController
{
	[Token(Token = "0x401045F")]
	[FieldOffset(Offset = "0x28")]
	private UIPointsRaceClanItemView m_View;

	[Token(Token = "0x4010460")]
	[FieldOffset(Offset = "0x2C")]
	private AwardDesc m_Info;

	[Token(Token = "0x4010461")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_TipsOffset;

	[Token(Token = "0x4010462")]
	[FieldOffset(Offset = "0x3C")]
	private uint m_RewardHonorPoints;

	[Token(Token = "0x4010463")]
	[FieldOffset(Offset = "0x40")]
	private Animator m_BoxAnimator;

	[Token(Token = "0x4010464")]
	[FieldOffset(Offset = "0x44")]
	private float m_BoxAnimGapTime;

	[Token(Token = "0x4010465")]
	[FieldOffset(Offset = "0x48")]
	private uint m_BoxCallID;

	[Token(Token = "0x60113CD")]
	[Address(RVA = "0x223B1B4", Offset = "0x223B1B4", VA = "0x223B1B4")]
	public UIPointsRaceClanItemController()
	{
	}

	[Token(Token = "0x60113CE")]
	[Address(RVA = "0x223B244", Offset = "0x223B244", VA = "0x223B244")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60113CF")]
	[Address(RVA = "0x223B2A8", Offset = "0x223B2A8", VA = "0x223B2A8", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x60113D0")]
	[Address(RVA = "0x223B584", Offset = "0x223B584", VA = "0x223B584", Slot = "16")]
	protected override void OnUIDestory()
	{
	}

	[Token(Token = "0x60113D1")]
	[Address(RVA = "0x223B658", Offset = "0x223B658", VA = "0x223B658")]
	private void OnClickClose()
	{
	}

	[Token(Token = "0x60113D2")]
	[Address(RVA = "0x223B660", Offset = "0x223B660", VA = "0x223B660")]
	public void SetData(uint rewardHonorPoints, AwardDesc info, uint minPoints, bool isUnlock, bool isClaimed, bool isShowArrow, uint stageId, bool isOpen)
	{
	}

	[Token(Token = "0x60113D3")]
	[Address(RVA = "0x223B448", Offset = "0x223B448", VA = "0x223B448")]
	public void UpdateView(bool isUnlock, bool isClaimed)
	{
	}

	[Token(Token = "0x60113D4")]
	[Address(RVA = "0x223B878", Offset = "0x223B878", VA = "0x223B878")]
	private void OnClickBox()
	{
	}

	[Token(Token = "0x60113D5")]
	[Address(RVA = "0x223C630", Offset = "0x223C630", VA = "0x223C630")]
	private void _003CSetData_003Em__0()
	{
	}
}
