using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002CE3")]
public class CustomHudItem : MonoBehaviour
{
	[Token(Token = "0x401120A")]
	[FieldOffset(Offset = "0xC")]
	public UIEventListener m_EventListener;

	[Token(Token = "0x401120B")]
	[FieldOffset(Offset = "0x10")]
	public string m_HudName;

	[Token(Token = "0x401120C")]
	[FieldOffset(Offset = "0x14")]
	public UISprite m_LockIcon;

	[Token(Token = "0x401120D")]
	[FieldOffset(Offset = "0x18")]
	public UISprite m_Hidden;

	[Token(Token = "0x401120E")]
	[FieldOffset(Offset = "0x1C")]
	public UIWidget m_BG;

	[Token(Token = "0x401120F")]
	[FieldOffset(Offset = "0x20")]
	public bool m_Circle;

	[Token(Token = "0x4011210")]
	[FieldOffset(Offset = "0x24")]
	public UI2DSprite m_2dSprite;

	[Token(Token = "0x6012C92")]
	[Address(RVA = "0x1C87D90", Offset = "0x1C87D90", VA = "0x1C87D90")]
	public CustomHudItem()
	{
	}

	[Token(Token = "0x6012C93")]
	[Address(RVA = "0x1C87D98", Offset = "0x1C87D98", VA = "0x1C87D98", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6012C94")]
	[Address(RVA = "0x1C87F90", Offset = "0x1C87F90", VA = "0x1C87F90", Slot = "5")]
	protected virtual void OnHudPress(GameObject go, bool state)
	{
	}

	[Token(Token = "0x6012C95")]
	[Address(RVA = "0x1C88174", Offset = "0x1C88174", VA = "0x1C88174", Slot = "6")]
	protected virtual void OnHudDragStart(GameObject go)
	{
	}

	[Token(Token = "0x6012C96")]
	[Address(RVA = "0x1C881D0", Offset = "0x1C881D0", VA = "0x1C881D0", Slot = "7")]
	protected virtual void OnHudDragEnd(GameObject go)
	{
	}
}
