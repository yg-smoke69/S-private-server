using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003776")]
public class UIHudTokenLeaderboardItemView : UIBaseView
{
	[Token(Token = "0x4016775")]
	[FieldOffset(Offset = "0x14")]
	public GameObject BGDefault;

	[Token(Token = "0x4016776")]
	[FieldOffset(Offset = "0x18")]
	public GameObject BGLocal;

	[Token(Token = "0x4016777")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel LabelName;

	[Token(Token = "0x4016778")]
	[FieldOffset(Offset = "0x20")]
	public UILabel LabelClan;

	[Token(Token = "0x4016779")]
	[FieldOffset(Offset = "0x24")]
	public UILabel LabelKill;

	[Token(Token = "0x401677A")]
	[FieldOffset(Offset = "0x28")]
	public UILabel LabelPick;

	[Token(Token = "0x401677B")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel LabelScore;

	[Token(Token = "0x6016A0D")]
	[Address(RVA = "0x1582FD8", Offset = "0x1582FD8", VA = "0x1582FD8")]
	public UIHudTokenLeaderboardItemView()
	{
	}

	[Token(Token = "0x6016A0E")]
	[Address(RVA = "0x1582FE0", Offset = "0x1582FE0", VA = "0x1582FE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016A0F")]
	[Address(RVA = "0x15833B0", Offset = "0x15833B0", VA = "0x15833B0")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
