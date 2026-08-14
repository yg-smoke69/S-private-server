using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20020E2")]
public class UIEPWeeklyRewardItemController : MonoBehaviour
{
	[Token(Token = "0x20020E3")]
	private enum EOperateStatus
	{
		[Token(Token = "0x400CDC9")]
		None,
		[Token(Token = "0x400CDCA")]
		UnFinished,
		[Token(Token = "0x400CDCB")]
		CanReceive,
		[Token(Token = "0x400CDCC")]
		Received
	}

	[Token(Token = "0x400CDBC")]
	[FieldOffset(Offset = "0xC")]
	public GameObject CanOpenEffect;

	[Token(Token = "0x400CDBD")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Icon;

	[Token(Token = "0x400CDBE")]
	[FieldOffset(Offset = "0x14")]
	public UIButton OperateButton;

	[Token(Token = "0x400CDBF")]
	[FieldOffset(Offset = "0x18")]
	public UILabel NeedCnt;

	[Token(Token = "0x400CDC0")]
	[FieldOffset(Offset = "0x1C")]
	public UISprite TipsIcon;

	[Token(Token = "0x400CDC1")]
	[FieldOffset(Offset = "0x20")]
	public GameObject OnGoingIcon;

	[Token(Token = "0x400CDC2")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ClaimIcon;

	[Token(Token = "0x400CDC3")]
	[FieldOffset(Offset = "0x28")]
	public GameObject ReachIcon;

	[Token(Token = "0x400CDC4")]
	[FieldOffset(Offset = "0x2C")]
	private UIModelElitePass m_ModelEp;

	[Token(Token = "0x400CDC5")]
	[FieldOffset(Offset = "0x30")]
	private EPWeeklyRewardInfo m_Data;

	[Token(Token = "0x400CDC6")]
	[FieldOffset(Offset = "0x34")]
	private string RewardDesc;

	[Token(Token = "0x400CDC7")]
	[FieldOffset(Offset = "0x38")]
	private EOperateStatus m_OperateStatus;

	[Token(Token = "0x600AA42")]
	[Address(RVA = "0x2BB5674", Offset = "0x2BB5674", VA = "0x2BB5674")]
	public UIEPWeeklyRewardItemController()
	{
	}

	[Token(Token = "0x600AA43")]
	[Address(RVA = "0x2BB5714", Offset = "0x2BB5714", VA = "0x2BB5714")]
	private void Start()
	{
	}

	[Token(Token = "0x600AA44")]
	[Address(RVA = "0x2BB5834", Offset = "0x2BB5834", VA = "0x2BB5834")]
	public void SetData(EPWeeklyRewardInfo data)
	{
	}

	[Token(Token = "0x600AA45")]
	[Address(RVA = "0x2BB594C", Offset = "0x2BB594C", VA = "0x2BB594C")]
	private void SetView()
	{
	}

	[Token(Token = "0x600AA46")]
	[Address(RVA = "0x2BB66F4", Offset = "0x2BB66F4", VA = "0x2BB66F4")]
	private void OnOperate()
	{
	}
}
