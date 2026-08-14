using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200337F")]
public class HackerStorePropertyNodeView : UIBaseView
{
	[Token(Token = "0x40139DA")]
	[FieldOffset(Offset = "0x14")]
	public GameObject VehicleSkinScoreTable;

	[Token(Token = "0x40139DB")]
	[FieldOffset(Offset = "0x18")]
	public UIScrollView VehicleSkinScoreScrollView;

	[Token(Token = "0x40139DC")]
	[FieldOffset(Offset = "0x1C")]
	public UIGrid VehicleScoreGrid;

	[Token(Token = "0x40139DD")]
	[FieldOffset(Offset = "0x20")]
	public GameObject PvpPropertyContainer;

	[Token(Token = "0x40139DE")]
	[FieldOffset(Offset = "0x24")]
	public GameObject PropertyScore;

	[Token(Token = "0x40139DF")]
	[FieldOffset(Offset = "0x28")]
	public UIGrid ScoreGrid;

	[Token(Token = "0x40139E0")]
	[FieldOffset(Offset = "0x2C")]
	public UITable PropertyTable;

	[Token(Token = "0x40139E1")]
	[FieldOffset(Offset = "0x30")]
	public UIButton Weaponskillbtn;

	[Token(Token = "0x40139E2")]
	[FieldOffset(Offset = "0x34")]
	public UISprite SpriteWeaponskillIcon;

	[Token(Token = "0x6015E34")]
	[Address(RVA = "0x190BF3C", Offset = "0x190BF3C", VA = "0x190BF3C")]
	public HackerStorePropertyNodeView()
	{
	}

	[Token(Token = "0x6015E35")]
	[Address(RVA = "0x190BF44", Offset = "0x190BF44", VA = "0x190BF44", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6015E36")]
	[Address(RVA = "0x190C3C8", Offset = "0x190C3C8", VA = "0x190C3C8")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
