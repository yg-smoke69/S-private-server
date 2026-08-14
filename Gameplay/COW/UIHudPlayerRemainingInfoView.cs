using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20036E4")]
public class UIHudPlayerRemainingInfoView : UIBaseView
{
	[Token(Token = "0x40162B0")]
	[FieldOffset(Offset = "0x14")]
	public UIWidget WidgetTutorial;

	[Token(Token = "0x40162B1")]
	[FieldOffset(Offset = "0x18")]
	public GameObject Remaining;

	[Token(Token = "0x40162B2")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel RemainLabel;

	[Token(Token = "0x40162B3")]
	[FieldOffset(Offset = "0x20")]
	public UILabel RemainingCountText;

	[Token(Token = "0x40162B4")]
	[FieldOffset(Offset = "0x24")]
	public GameObject Kill;

	[Token(Token = "0x40162B5")]
	[FieldOffset(Offset = "0x28")]
	public UILabel KillCountText;

	[Token(Token = "0x40162B6")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Enemy;

	[Token(Token = "0x40162B7")]
	[FieldOffset(Offset = "0x30")]
	public UILabel RemainingEnemyCountText;

	[Token(Token = "0x40162B8")]
	[FieldOffset(Offset = "0x34")]
	public GameObject KDA;

	[Token(Token = "0x40162B9")]
	[FieldOffset(Offset = "0x38")]
	public UILabel KdaCountText;

	[Token(Token = "0x40162BA")]
	[FieldOffset(Offset = "0x3C")]
	public GameObject OnlyAlive;

	[Token(Token = "0x40162BB")]
	[FieldOffset(Offset = "0x40")]
	public UILabel AliveLabel;

	[Token(Token = "0x40162BC")]
	[FieldOffset(Offset = "0x44")]
	public UILabel AliveCount;

	[Token(Token = "0x40162BD")]
	[FieldOffset(Offset = "0x48")]
	public GameObject OnlyKill;

	[Token(Token = "0x40162BE")]
	[FieldOffset(Offset = "0x4C")]
	public UILabel killCount;

	[Token(Token = "0x40162BF")]
	[FieldOffset(Offset = "0x50")]
	public GameObject Property;

	[Token(Token = "0x40162C0")]
	[FieldOffset(Offset = "0x54")]
	public UILabel PropertyCount;

	[Token(Token = "0x40162C1")]
	[FieldOffset(Offset = "0x58")]
	public UISprite PropertyIcon;

	[Token(Token = "0x40162C2")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject Score;

	[Token(Token = "0x40162C3")]
	[FieldOffset(Offset = "0x60")]
	public UILabel ScoreText;

	[Token(Token = "0x40162C4")]
	[FieldOffset(Offset = "0x64")]
	public UILabel ScoreNum;

	[Token(Token = "0x6016857")]
	[Address(RVA = "0x1869CC8", Offset = "0x1869CC8", VA = "0x1869CC8")]
	public UIHudPlayerRemainingInfoView()
	{
	}

	[Token(Token = "0x6016858")]
	[Address(RVA = "0x1869CD0", Offset = "0x1869CD0", VA = "0x1869CD0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016859")]
	[Address(RVA = "0x186A598", Offset = "0x186A598", VA = "0x186A598")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
