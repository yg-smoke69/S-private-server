using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D48")]
public class UIMultiTipsButton : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40115E6")]
	[FieldOffset(Offset = "0xC")]
	public UIButton m_Button;

	[Token(Token = "0x40115E7")]
	[FieldOffset(Offset = "0x10")]
	public GameObject m_TipsObject;

	[Token(Token = "0x40115E8")]
	[FieldOffset(Offset = "0x14")]
	public UILabel m_TipsNumLabel;

	[Token(Token = "0x40115E9")]
	[FieldOffset(Offset = "0x18")]
	public string[] m_TipsTypes;

	[Token(Token = "0x40115EA")]
	[FieldOffset(Offset = "0x1C")]
	private List<int> m_Types;

	[Token(Token = "0x40115EB")]
	[FieldOffset(Offset = "0x20")]
	private Dictionary<int, int> m_TipNums;

	[Token(Token = "0x40115EC")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsClearing;

	[Token(Token = "0x6012F44")]
	[Address(RVA = "0x19530DC", Offset = "0x19530DC", VA = "0x19530DC")]
	public UIMultiTipsButton()
	{
	}

	[Token(Token = "0x6012F45")]
	[Address(RVA = "0x19530E4", Offset = "0x19530E4", VA = "0x19530E4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012F46")]
	[Address(RVA = "0x19538B0", Offset = "0x19538B0", VA = "0x19538B0", Slot = "4")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6012F47")]
	[Address(RVA = "0x1953588", Offset = "0x1953588", VA = "0x1953588")]
	private void SetTipNumber(int num)
	{
	}

	[Token(Token = "0x6012F48")]
	[Address(RVA = "0x1953B24", Offset = "0x1953B24", VA = "0x1953B24")]
	private void ClearTipsWhenClick()
	{
	}

	[Token(Token = "0x6012F49")]
	[Address(RVA = "0x1953EF4", Offset = "0x1953EF4", VA = "0x1953EF4")]
	private void OnDestroy()
	{
	}
}
