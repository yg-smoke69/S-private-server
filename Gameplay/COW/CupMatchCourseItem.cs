using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200205D")]
public class CupMatchCourseItem : MonoBehaviour
{
	[Token(Token = "0x400CAE0")]
	[FieldOffset(Offset = "0xC")]
	public GameObject Win;

	[Token(Token = "0x400CAE1")]
	[FieldOffset(Offset = "0x10")]
	public GameObject Lose;

	[Token(Token = "0x400CAE2")]
	[FieldOffset(Offset = "0x14")]
	public UISprite TeamIcon;

	[Token(Token = "0x400CAE3")]
	[FieldOffset(Offset = "0x18")]
	public UILabel OtherWinTeamName;

	[Token(Token = "0x400CAE4")]
	[FieldOffset(Offset = "0x1C")]
	public UILabel OtherLoseTeamName;

	[Token(Token = "0x400CAE5")]
	[FieldOffset(Offset = "0x20")]
	public UILabel SelfTeamName;

	[Token(Token = "0x400CAE6")]
	[FieldOffset(Offset = "0x24")]
	public GameObject OtherWin;

	[Token(Token = "0x400CAE7")]
	[FieldOffset(Offset = "0x28")]
	public GameObject OtherLose;

	[Token(Token = "0x400CAE8")]
	[FieldOffset(Offset = "0x2C")]
	public GameObject Mine;

	[Token(Token = "0x400CAE9")]
	[FieldOffset(Offset = "0x30")]
	public GameObject Waiting;

	[Token(Token = "0x400CAEA")]
	[FieldOffset(Offset = "0x34")]
	public GameObject Empty;

	[Token(Token = "0x600A580")]
	[Address(RVA = "0x1C86C34", Offset = "0x1C86C34", VA = "0x1C86C34")]
	public CupMatchCourseItem()
	{
	}
}
