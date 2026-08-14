using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200412D")]
public class UICheckBoxButtonGroup : MonoBehaviour
{
	[Token(Token = "0x200412E")]
	public delegate void OnItemCheck(UICheckboxButton checkbox);

	[Token(Token = "0x401B5E6")]
	[FieldOffset(Offset = "0xC")]
	public UICheckboxButton[] checkBoxButtons;

	[Token(Token = "0x401B5E7")]
	[FieldOffset(Offset = "0x10")]
	public OnItemCheck OnItemCheckCallback;

	[Token(Token = "0x401B5E8")]
	[FieldOffset(Offset = "0x14")]
	private int m_MaxCheckBoxOnCount;

	[Token(Token = "0x401B5E9")]
	[FieldOffset(Offset = "0x18")]
	private int checkBoxOnCount;

	[Token(Token = "0x17001D5A")]
	public int MaxCheckBoxOnCount
	{
		[Token(Token = "0x601AA2C")]
		[Address(RVA = "0x2C9B764", Offset = "0x2C9B764", VA = "0x2C9B764")]
		get
		{
			return default(int);
		}
		[Token(Token = "0x601AA2D")]
		[Address(RVA = "0x2C9B76C", Offset = "0x2C9B76C", VA = "0x2C9B76C")]
		set
		{
		}
	}

	[Token(Token = "0x601AA2B")]
	[Address(RVA = "0x2C9B75C", Offset = "0x2C9B75C", VA = "0x2C9B75C")]
	public UICheckBoxButtonGroup()
	{
	}

	[Token(Token = "0x601AA2E")]
	[Address(RVA = "0x2C9B8BC", Offset = "0x2C9B8BC", VA = "0x2C9B8BC")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AA2F")]
	[Address(RVA = "0x2C9B8CC", Offset = "0x2C9B8CC", VA = "0x2C9B8CC", Slot = "4")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x601AA30")]
	[Address(RVA = "0x2C9BA58", Offset = "0x2C9BA58", VA = "0x2C9BA58")]
	public void ResetAllCheckBoxButton()
	{
	}

	[Token(Token = "0x601AA31")]
	[Address(RVA = "0x2C9BE90", Offset = "0x2C9BE90", VA = "0x2C9BE90", Slot = "5")]
	public virtual void OnCheckBoxButton(UICheckboxButton selectedButton)
	{
	}

	[Token(Token = "0x601AA32")]
	[Address(RVA = "0x2C9C578", Offset = "0x2C9C578", VA = "0x2C9C578")]
	public void OnCheckBoxOnByIndex(int index)
	{
	}

	[Token(Token = "0x601AA33")]
	[Address(RVA = "0x2C9BD7C", Offset = "0x2C9BD7C", VA = "0x2C9BD7C")]
	public void RebindButtons()
	{
	}

	[Token(Token = "0x601AA34")]
	[Address(RVA = "0x2C9B79C", Offset = "0x2C9B79C", VA = "0x2C9B79C")]
	public void SetcheckBoxButtonEnable(bool enable)
	{
	}
}
