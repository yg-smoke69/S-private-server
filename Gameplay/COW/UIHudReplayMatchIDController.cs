using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200282B")]
public class UIHudReplayMatchIDController : MonoBehaviour
{
	[Token(Token = "0x400F7D9")]
	[FieldOffset(Offset = "0xC")]
	public UILabel MatchIDText;

	[Token(Token = "0x600FA7D")]
	[Address(RVA = "0x13E5EA0", Offset = "0x13E5EA0", VA = "0x13E5EA0")]
	public UIHudReplayMatchIDController()
	{
	}

	[Token(Token = "0x600FA7E")]
	[Address(RVA = "0x13E5EA8", Offset = "0x13E5EA8", VA = "0x13E5EA8")]
	private void Awake()
	{
	}

	[Token(Token = "0x600FA7F")]
	[Address(RVA = "0x13E5FA4", Offset = "0x13E5FA4", VA = "0x13E5FA4")]
	public void SetIDText(string text)
	{
	}
}
