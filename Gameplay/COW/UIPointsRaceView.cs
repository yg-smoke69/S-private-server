using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200390C")]
public class UIPointsRaceView : UIBaseView
{
	[Token(Token = "0x4017BB7")]
	[FieldOffset(Offset = "0x14")]
	public UILabel IndividualStarsCount;

	[Token(Token = "0x4017BB8")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid ClanPivot;

	[Token(Token = "0x4017BB9")]
	[FieldOffset(Offset = "0x1C")]
	public UIProgressBar ProgressBar;

	[Token(Token = "0x4017BBA")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Content;

	[Token(Token = "0x4017BBB")]
	[FieldOffset(Offset = "0x24")]
	public GameObject CurrentClanStarsText;

	[Token(Token = "0x4017BBC")]
	[FieldOffset(Offset = "0x28")]
	public GameObject LastClanStarsText;

	[Token(Token = "0x4017BBD")]
	[FieldOffset(Offset = "0x2C")]
	public UIButton RaceTips;

	[Token(Token = "0x4017BBE")]
	[FieldOffset(Offset = "0x30")]
	public UILabel CurrentStarsNumber;

	[Token(Token = "0x4017BBF")]
	[FieldOffset(Offset = "0x34")]
	public UIGrid IndividualPivot;

	[Token(Token = "0x4017BC0")]
	[FieldOffset(Offset = "0x38")]
	public UIButton RankListButton;

	[Token(Token = "0x4017BC1")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton ClaimClanAwardBtn;

	[Token(Token = "0x4017BC2")]
	[FieldOffset(Offset = "0x40")]
	public GameObject ReceivedButton;

	[Token(Token = "0x6016ECD")]
	[Address(RVA = "0x2C54290", Offset = "0x2C54290", VA = "0x2C54290")]
	public UIPointsRaceView()
	{
	}

	[Token(Token = "0x6016ECE")]
	[Address(RVA = "0x2C54298", Offset = "0x2C54298", VA = "0x2C54298", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016ECF")]
	[Address(RVA = "0x2C54830", Offset = "0x2C54830", VA = "0x2C54830")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
