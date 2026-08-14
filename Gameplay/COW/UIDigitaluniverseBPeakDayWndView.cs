using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034DA")]
public class UIDigitaluniverseBPeakDayWndView : UIBaseView
{
	[Token(Token = "0x4014C00")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Desc;

	[Token(Token = "0x4014C01")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid RewardGrid;

	[Token(Token = "0x4014C02")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject ClaimStatus;

	[Token(Token = "0x4014C03")]
	[FieldOffset(Offset = "0x20")]
	public UIButton BtnClaim;

	[Token(Token = "0x4014C04")]
	[FieldOffset(Offset = "0x24")]
	public GameObject ExpiredDesc;

	[Token(Token = "0x6016240")]
	[Address(RVA = "0x2EFFD84", Offset = "0x2EFFD84", VA = "0x2EFFD84")]
	public UIDigitaluniverseBPeakDayWndView()
	{
	}

	[Token(Token = "0x6016241")]
	[Address(RVA = "0x2EFFD8C", Offset = "0x2EFFD8C", VA = "0x2EFFD8C", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016242")]
	[Address(RVA = "0x2F0009C", Offset = "0x2F0009C", VA = "0x2F0009C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
