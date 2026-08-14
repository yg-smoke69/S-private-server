using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002D49")]
public class UITipsButton : MonoBehaviour, _Attribute
{
	[Token(Token = "0x40115ED")]
	[FieldOffset(Offset = "0xC")]
	public UIButton m_Button;

	[Token(Token = "0x40115EE")]
	[FieldOffset(Offset = "0x10")]
	public string m_TipsType;

	[Token(Token = "0x40115EF")]
	[FieldOffset(Offset = "0x14")]
	public GameObject m_TipsObject;

	[Token(Token = "0x40115F0")]
	[FieldOffset(Offset = "0x18")]
	public UILabel m_TipsNumLabel;

	[Token(Token = "0x40115F1")]
	[FieldOffset(Offset = "0x1C")]
	public ETipsType m_Type;

	[Token(Token = "0x6012F4A")]
	[Address(RVA = "0x201BABC", Offset = "0x201BABC", VA = "0x201BABC")]
	public UITipsButton()
	{
	}

	[Token(Token = "0x6012F4B")]
	[Address(RVA = "0x201BAC4", Offset = "0x201BAC4", VA = "0x201BAC4")]
	private void Awake()
	{
	}

	[Token(Token = "0x6012F4C")]
	[Address(RVA = "0x2000904", Offset = "0x2000904", VA = "0x2000904")]
	public void SetTipsType(ETipsType type)
	{
	}

	[Token(Token = "0x6012F4D")]
	[Address(RVA = "0x201C160", Offset = "0x201C160", VA = "0x201C160", Slot = "4")]
	public void OnTipsDataChange(ETipsType type, int num)
	{
	}

	[Token(Token = "0x6012F4E")]
	[Address(RVA = "0x201BD24", Offset = "0x201BD24", VA = "0x201BD24")]
	private void SetTipNumber(int num)
	{
	}

	[Token(Token = "0x6012F4F")]
	[Address(RVA = "0x201C1F4", Offset = "0x201C1F4", VA = "0x201C1F4")]
	private void ClearTipsWhenClick()
	{
	}

	[Token(Token = "0x6012F50")]
	[Address(RVA = "0x201C3D8", Offset = "0x201C3D8", VA = "0x201C3D8")]
	private void OnDestroy()
	{
	}
}
