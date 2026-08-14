using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000BE8")]
public class UIHudBlockEditEnumPopItemController : MonoBehaviour
{
	[Token(Token = "0x40062FE")]
	[FieldOffset(Offset = "0xC")]
	public UIButton mBtn;

	[Token(Token = "0x40062FF")]
	[FieldOffset(Offset = "0x10")]
	public UISprite HL;

	[Token(Token = "0x4006300")]
	[FieldOffset(Offset = "0x14")]
	public UISprite Icon;

	[Token(Token = "0x4006301")]
	[FieldOffset(Offset = "0x18")]
	public UILabel Name;

	[Token(Token = "0x4006302")]
	[FieldOffset(Offset = "0x1C")]
	public BEPopWndItemData mData;

	[Token(Token = "0x6005A24")]
	[Address(RVA = "0x1E03CE4", Offset = "0x1E03CE4", VA = "0x1E03CE4")]
	public UIHudBlockEditEnumPopItemController()
	{
	}

	[Token(Token = "0x6005A25")]
	[Address(RVA = "0x1E03CEC", Offset = "0x1E03CEC", VA = "0x1E03CEC")]
	public void InitView(BEPopWndItemData data)
	{
	}
}
