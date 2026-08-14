using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000BFB")]
public class UIHudBlockTypeBtnItemController : MonoBehaviour
{
	[Token(Token = "0x400634B")]
	[FieldOffset(Offset = "0xC")]
	public UISprite BG;

	[Token(Token = "0x400634C")]
	[FieldOffset(Offset = "0x10")]
	public UISprite Icon;

	[Token(Token = "0x400634D")]
	[FieldOffset(Offset = "0x14")]
	public UISprite HL;

	[Token(Token = "0x400634E")]
	[FieldOffset(Offset = "0x18")]
	public UIButton Btn;

	[Token(Token = "0x6005A7D")]
	[Address(RVA = "0x1E0667C", Offset = "0x1E0667C", VA = "0x1E0667C")]
	public UIHudBlockTypeBtnItemController()
	{
	}
}
