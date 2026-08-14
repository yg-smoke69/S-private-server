using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002801")]
public class UIHUDPlayerAttributeUpItem : MonoBehaviour
{
	[Token(Token = "0x400F6E6")]
	[FieldOffset(Offset = "0xC")]
	public float ItemDeltaY;

	[Token(Token = "0x400F6E7")]
	[FieldOffset(Offset = "0x10")]
	public UILabel ShowLabel;

	[Token(Token = "0x400F6E8")]
	[FieldOffset(Offset = "0x14")]
	public float m_TweenDuration;

	[Token(Token = "0x600F8B6")]
	[Address(RVA = "0x1686264", Offset = "0x1686264", VA = "0x1686264")]
	public UIHUDPlayerAttributeUpItem()
	{
	}

	[Token(Token = "0x600F8B7")]
	[Address(RVA = "0x1685E90", Offset = "0x1685E90", VA = "0x1685E90")]
	public void ShowMsg(string msg)
	{
	}
}
