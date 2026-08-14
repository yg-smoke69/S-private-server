using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2003373")]
public class AutoChangeComp : MonoBehaviour
{
	[Token(Token = "0x401397F")]
	[FieldOffset(Offset = "0xC")]
	private GameObject[] m_Items;

	[Token(Token = "0x4013980")]
	[FieldOffset(Offset = "0x10")]
	private float m_Interval;

	[Token(Token = "0x4013981")]
	[FieldOffset(Offset = "0x14")]
	private int m_CurIndex;

	[Token(Token = "0x4013982")]
	[FieldOffset(Offset = "0x18")]
	private uint m_CallID;

	[Token(Token = "0x6015E0A")]
	[Address(RVA = "0x2ECF174", Offset = "0x2ECF174", VA = "0x2ECF174")]
	public AutoChangeComp()
	{
	}

	[Token(Token = "0x6015E0B")]
	[Address(RVA = "0x2ECF188", Offset = "0x2ECF188", VA = "0x2ECF188")]
	public void SetData(bool start = true)
	{
	}

	[Token(Token = "0x6015E0C")]
	[Address(RVA = "0x2ECF3C8", Offset = "0x2ECF3C8", VA = "0x2ECF3C8")]
	public void Clear()
	{
	}

	[Token(Token = "0x6015E0D")]
	[Address(RVA = "0x2ECF604", Offset = "0x2ECF604", VA = "0x2ECF604")]
	private void OnDisable()
	{
	}

	[Token(Token = "0x6015E0E")]
	[Address(RVA = "0x2ECF608", Offset = "0x2ECF608", VA = "0x2ECF608")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6015E0F")]
	[Address(RVA = "0x2ECF4E0", Offset = "0x2ECF4E0", VA = "0x2ECF4E0")]
	private void DoAction()
	{
	}
}
