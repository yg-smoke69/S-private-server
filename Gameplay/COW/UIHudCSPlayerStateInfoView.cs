using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003AA2")]
public class UIHudCSPlayerStateInfoView : MonoBehaviour
{
	[Token(Token = "0x4018EF7")]
	[FieldOffset(Offset = "0xC")]
	public UISprite StateAlive;

	[Token(Token = "0x4018EF8")]
	[FieldOffset(Offset = "0x10")]
	public UISprite StateKnockDown;

	[Token(Token = "0x4018EF9")]
	[FieldOffset(Offset = "0x14")]
	public UISprite StateDead;

	[Token(Token = "0x60173A6")]
	[Address(RVA = "0x1F19AE8", Offset = "0x1F19AE8", VA = "0x1F19AE8")]
	public UIHudCSPlayerStateInfoView()
	{
	}

	[Token(Token = "0x60173A7")]
	[Address(RVA = "0x1F16184", Offset = "0x1F16184", VA = "0x1F16184")]
	public void SetTeammateState(ETeammateState nextState)
	{
	}

	[Token(Token = "0x60173A8")]
	[Address(RVA = "0x1F19AF0", Offset = "0x1F19AF0", VA = "0x1F19AF0")]
	public void HideTeammateStates()
	{
	}
}
