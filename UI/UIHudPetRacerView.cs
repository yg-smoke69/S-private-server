using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2002280")]
public class UIHudPetRacerView : MonoBehaviour
{
	[Token(Token = "0x400D7EF")]
	[FieldOffset(Offset = "0xC")]
	public UISprite IdleSprite;

	[Token(Token = "0x400D7F0")]
	[FieldOffset(Offset = "0x10")]
	public UISprite RunSprite;

	[Token(Token = "0x400D7F1")]
	[FieldOffset(Offset = "0x14")]
	public UISprite RunSprite01;

	[Token(Token = "0x400D7F2")]
	[FieldOffset(Offset = "0x18")]
	public UISprite RunSprite02;

	[Token(Token = "0x400D7F3")]
	[FieldOffset(Offset = "0x1C")]
	public GameObject HighlightObj;

	[Token(Token = "0x400D7F4")]
	[FieldOffset(Offset = "0x20")]
	public GameObject UnHighlightObj;

	[Token(Token = "0x400D7F5")]
	[FieldOffset(Offset = "0x24")]
	public GameObject VotedObj;

	[Token(Token = "0x600BD2D")]
	[Address(RVA = "0x1486200", Offset = "0x1486200", VA = "0x1486200")]
	public UIHudPetRacerView()
	{
	}
}
