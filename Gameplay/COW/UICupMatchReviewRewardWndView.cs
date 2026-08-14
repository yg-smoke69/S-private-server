using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200349E")]
public class UICupMatchReviewRewardWndView : UIBaseView
{
	[Token(Token = "0x4014878")]
	[FieldOffset(Offset = "0x14")]
	public Transform Left;

	[Token(Token = "0x4014879")]
	[FieldOffset(Offset = "0x18")]
	public GameObject LeftReward1;

	[Token(Token = "0x401487A")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject LeftReward2;

	[Token(Token = "0x401487B")]
	[FieldOffset(Offset = "0x20")]
	public GameObject LeftReward3;

	[Token(Token = "0x401487C")]
	[FieldOffset(Offset = "0x24")]
	public GameObject LeftReward4;

	[Token(Token = "0x401487D")]
	[FieldOffset(Offset = "0x28")]
	public Transform Right;

	[Token(Token = "0x401487E")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject RightReward1;

	[Token(Token = "0x401487F")]
	[FieldOffset(Offset = "0x30")]
	public GameObject RightReward2;

	[Token(Token = "0x4014880")]
	[FieldOffset(Offset = "0x34")]
	public GameObject RightReward3;

	[Token(Token = "0x4014881")]
	[FieldOffset(Offset = "0x38")]
	public GameObject RightReward4;

	[Token(Token = "0x4014882")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject Ticket;

	[Token(Token = "0x4014883")]
	[FieldOffset(Offset = "0x40")]
	public UILabel UseLabel;

	[Token(Token = "0x4014884")]
	[FieldOffset(Offset = "0x44")]
	public UIToggle Toggle;

	[Token(Token = "0x4014885")]
	[FieldOffset(Offset = "0x48")]
	public GameObject UseTicket;

	[Token(Token = "0x4014886")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject UnUseTicket;

	[Token(Token = "0x4014887")]
	[FieldOffset(Offset = "0x50")]
	public Transform Center;

	[Token(Token = "0x4014888")]
	[FieldOffset(Offset = "0x54")]
	public GameObject CenterReward1;

	[Token(Token = "0x4014889")]
	[FieldOffset(Offset = "0x58")]
	public GameObject CenterReward2;

	[Token(Token = "0x401488A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject CenterReward3;

	[Token(Token = "0x401488B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject CenterReward4;

	[Token(Token = "0x401488C")]
	[FieldOffset(Offset = "0x64")]
	public UINetworkTexture NetworkTexture;

	[Token(Token = "0x401488D")]
	[FieldOffset(Offset = "0x68")]
	public UIButton BtnClose;

	[Token(Token = "0x401488E")]
	[FieldOffset(Offset = "0x6C")]
	public GameObject LeftSelectEffect;

	[Token(Token = "0x401488F")]
	[FieldOffset(Offset = "0x70")]
	public GameObject RightSelectEffect;

	[Token(Token = "0x4014890")]
	[FieldOffset(Offset = "0x74")]
	public GameObject RightMask;

	[Token(Token = "0x4014891")]
	[FieldOffset(Offset = "0x78")]
	public GameObject LeftMask;

	[Token(Token = "0x601618E")]
	[Address(RVA = "0x2AB07E8", Offset = "0x2AB07E8", VA = "0x2AB07E8")]
	public UICupMatchReviewRewardWndView()
	{
	}

	[Token(Token = "0x601618F")]
	[Address(RVA = "0x2AB07F0", Offset = "0x2AB07F0", VA = "0x2AB07F0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016190")]
	[Address(RVA = "0x2AB119C", Offset = "0x2AB119C", VA = "0x2AB119C")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
