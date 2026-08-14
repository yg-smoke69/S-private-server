using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003956")]
public class UIReplayListItemView : UIBaseView
{
	[Token(Token = "0x4017FF8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel Kill;

	[Token(Token = "0x4017FF9")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Rank;

	[Token(Token = "0x4017FFA")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject CSShow;

	[Token(Token = "0x4017FFB")]
	[FieldOffset(Offset = "0x20")]
	public GameObject CS_V;

	[Token(Token = "0x4017FFC")]
	[FieldOffset(Offset = "0x24")]
	public UILabel V;

	[Token(Token = "0x4017FFD")]
	[FieldOffset(Offset = "0x28")]
	public GameObject CS_F;

	[Token(Token = "0x4017FFE")]
	[FieldOffset(Offset = "0x2C")]
	public UILabel F;

	[Token(Token = "0x4017FFF")]
	[FieldOffset(Offset = "0x30")]
	public UIButton ItemBtn;

	[Token(Token = "0x4018000")]
	[FieldOffset(Offset = "0x34")]
	public UIButton DelBtn;

	[Token(Token = "0x4018001")]
	[FieldOffset(Offset = "0x38")]
	public UIButton PlayBtn;

	[Token(Token = "0x4018002")]
	[FieldOffset(Offset = "0x3C")]
	public UIButton SaveBtn;

	[Token(Token = "0x4018003")]
	[FieldOffset(Offset = "0x40")]
	public UILabel Day;

	[Token(Token = "0x4018004")]
	[FieldOffset(Offset = "0x44")]
	public UILabel Time;

	[Token(Token = "0x4018005")]
	[FieldOffset(Offset = "0x48")]
	public UILabel GameModeLabel;

	[Token(Token = "0x4018006")]
	[FieldOffset(Offset = "0x4C")]
	public GameObject GroupHCN;

	[Token(Token = "0x4018007")]
	[FieldOffset(Offset = "0x50")]
	public UILabel GroupNum;

	[Token(Token = "0x4018008")]
	[FieldOffset(Offset = "0x54")]
	public UILabel DeltaRating;

	[Token(Token = "0x4018009")]
	[FieldOffset(Offset = "0x58")]
	public UILabel Rating;

	[Token(Token = "0x401800A")]
	[FieldOffset(Offset = "0x5C")]
	public GameObject WinSprite;

	[Token(Token = "0x401800B")]
	[FieldOffset(Offset = "0x60")]
	public GameObject BGLight;

	[Token(Token = "0x401800C")]
	[FieldOffset(Offset = "0x64")]
	public GameObject BGDark;

	[Token(Token = "0x401800D")]
	[FieldOffset(Offset = "0x68")]
	public GameObject Highlight;

	[Token(Token = "0x6016FA9")]
	[Address(RVA = "0x1E53FD8", Offset = "0x1E53FD8", VA = "0x1E53FD8")]
	public UIReplayListItemView()
	{
	}

	[Token(Token = "0x6016FAA")]
	[Address(RVA = "0x1E53FE0", Offset = "0x1E53FE0", VA = "0x1E53FE0", Slot = "4")]
	protected override void OnInit(Transform holder)
	{
	}

	[Token(Token = "0x6016FAB")]
	[Address(RVA = "0x1E54908", Offset = "0x1E54908", VA = "0x1E54908")]
	public void _003C_003EiFixBaseProxy_OnInit(Transform P0)
	{
	}
}
