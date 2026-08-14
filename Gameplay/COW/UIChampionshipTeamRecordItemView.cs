using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003424")]
public class UIChampionshipTeamRecordItemView : UIBaseView
{
	[Token(Token = "0x4014252")]
	[FieldOffset(Offset = "0x14")]
	public GameObject Invalid;

	[Token(Token = "0x4014253")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Rank01;

	[Token(Token = "0x4014254")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel Score01;

	[Token(Token = "0x4014255")]
	[FieldOffset(Offset = "0x20")]
	public UILabel Kill01;

	[Token(Token = "0x4014256")]
	[FieldOffset(Offset = "0x24")]
	public UILabel Session01;

	[Token(Token = "0x4014257")]
	[FieldOffset(Offset = "0x28")]
	public GameObject Valid;

	[Token(Token = "0x4014258")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel Session;

	[Token(Token = "0x4014259")]
	[FieldOffset(Offset = "0x30")]
	public UILabel Kill;

	[Token(Token = "0x401425A")]
	[FieldOffset(Offset = "0x34")]
	public UILabel Score;

	[Token(Token = "0x401425B")]
	[FieldOffset(Offset = "0x38")]
	public UILabel Rank;

	[Token(Token = "0x6016020")]
	[Address(RVA = "0x2622598", Offset = "0x2622598", VA = "0x2622598")]
	public UIChampionshipTeamRecordItemView()
	{
	}

	[Token(Token = "0x6016021")]
	[Address(RVA = "0x26225A0", Offset = "0x26225A0", VA = "0x26225A0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016022")]
	[Address(RVA = "0x2622A90", Offset = "0x2622A90", VA = "0x2622A90")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
