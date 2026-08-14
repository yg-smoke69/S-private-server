using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW;

[Token(Token = "0x2002287")]
public class ReplayEventBtnView : MonoBehaviour
{
	[Token(Token = "0x400D82B")]
	[FieldOffset(Offset = "0xC")]
	public UIButton Button;

	[Token(Token = "0x400D82C")]
	[FieldOffset(Offset = "0x10")]
	public UILabel Tips;

	[Token(Token = "0x400D82D")]
	[FieldOffset(Offset = "0x14")]
	private OLDFDLECCBG m_ReplayEvent;

	[Token(Token = "0x400D82E")]
	[FieldOffset(Offset = "0x18")]
	private IHAAMHPPLMG m_PlayerID;

	[Token(Token = "0x400D82F")]
	[FieldOffset(Offset = "0x30")]
	private float m_Time;

	[Token(Token = "0x600BD58")]
	[Address(RVA = "0x2400350", Offset = "0x2400350", VA = "0x2400350")]
	public ReplayEventBtnView()
	{
	}

	[Token(Token = "0x600BD59")]
	[Address(RVA = "0x2400358", Offset = "0x2400358", VA = "0x2400358")]
	public void Init(OLDFDLECCBG evt, uint id, float time, string info = "", uint color = uint.MaxValue)
	{
	}

	[Token(Token = "0x600BD5A")]
	[Address(RVA = "0x24005F0", Offset = "0x24005F0", VA = "0x24005F0")]
	private void OnBtnClick()
	{
	}

	[Token(Token = "0x600BD5B")]
	[Address(RVA = "0x2400958", Offset = "0x2400958", VA = "0x2400958")]
	private void OnHover(bool isOver)
	{
	}

	[Token(Token = "0x600BD5C")]
	[Address(RVA = "0x24009FC", Offset = "0x24009FC", VA = "0x24009FC")]
	public OLDFDLECCBG GetReplayEvent()
	{
		return default(OLDFDLECCBG);
	}

	[Token(Token = "0x600BD5D")]
	[Address(RVA = "0x2400A54", Offset = "0x2400A54", VA = "0x2400A54")]
	public void SetActive(bool free, IHAAMHPPLMG id)
	{
	}

	[Token(Token = "0x600BD5E")]
	[Address(RVA = "0x2400C68", Offset = "0x2400C68", VA = "0x2400C68")]
	private void _003COnBtnClick_003Em__0()
	{
	}
}
