using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20034CD")]
public class UIDigitalUniverseBDailyMissionView : UIBaseView
{
	[Token(Token = "0x4014B1D")]
	[FieldOffset(Offset = "0x14")]
	public UILabel LuckyBagInfoMessage;

	[Token(Token = "0x4014B1E")]
	[FieldOffset(Offset = "0x18")]
	public UIGrid Grid;

	[Token(Token = "0x4014B1F")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject AlreadyCliamedContainer;

	[Token(Token = "0x4014B20")]
	[FieldOffset(Offset = "0x20")]
	public GameObject Grey;

	[Token(Token = "0x4014B21")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelTips;

	[Token(Token = "0x4014B22")]
	[FieldOffset(Offset = "0x28")]
	public UIButton BtnClaim;

	[Token(Token = "0x4014B23")]
	[FieldOffset(Offset = "0x2C")]
	public UISprite BtnSprite;

	[Token(Token = "0x4014B24")]
	[FieldOffset(Offset = "0x30")]
	public UIWidget UIDigitalUniverseBDailyMission;

	[Token(Token = "0x4014B25")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Mask;

	[Token(Token = "0x4014B26")]
	[FieldOffset(Offset = "0x38")]
	public UILabel LabelNum;

	[Token(Token = "0x601621B")]
	[Address(RVA = "0x2D85A2C", Offset = "0x2D85A2C", VA = "0x2D85A2C")]
	public UIDigitalUniverseBDailyMissionView()
	{
	}

	[Token(Token = "0x601621C")]
	[Address(RVA = "0x2D85A34", Offset = "0x2D85A34", VA = "0x2D85A34", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x601621D")]
	[Address(RVA = "0x2D85F18", Offset = "0x2D85F18", VA = "0x2D85F18")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
