using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EEB")]
public class UserButtonArea
{
	[Token(Token = "0x401A940")]
	[FieldOffset(Offset = "0x8")]
	private Vector2 m_Position;

	[Token(Token = "0x401A941")]
	[FieldOffset(Offset = "0x10")]
	private Vector2 m_Size;

	[Token(Token = "0x401A942")]
	[FieldOffset(Offset = "0x18")]
	private EInputButtonType m_ButtonType;

	[Token(Token = "0x401A943")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_Enable;

	[Token(Token = "0x6019A15")]
	[Address(RVA = "0x2BCEAEC", Offset = "0x2BCEAEC", VA = "0x2BCEAEC")]
	public UserButtonArea(int key, Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable = true)
	{
	}

	[Token(Token = "0x6019A16")]
	[Address(RVA = "0x2BCEB40", Offset = "0x2BCEB40", VA = "0x2BCEB40")]
	public void Update(Vector2 pos, Vector2 size, EInputButtonType buttonType, bool isEnable)
	{
	}

	[Token(Token = "0x6019A17")]
	[Address(RVA = "0x2BCEB64", Offset = "0x2BCEB64", VA = "0x2BCEB64")]
	public bool InButtonRange(Vector2 point)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A18")]
	[Address(RVA = "0x2BCED0C", Offset = "0x2BCED0C", VA = "0x2BCED0C")]
	public void Enable(bool v)
	{
	}

	[Token(Token = "0x6019A19")]
	[Address(RVA = "0x2BCED14", Offset = "0x2BCED14", VA = "0x2BCED14")]
	public bool IsEnable()
	{
		return default(bool);
	}
}
