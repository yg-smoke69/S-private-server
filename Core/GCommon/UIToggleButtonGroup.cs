using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200416F")]
public class UIToggleButtonGroup : MonoBehaviour
{
	[Token(Token = "0x2004170")]
	public delegate void OnItemSelect(UIToggleButton selectButton);

	[Token(Token = "0x2004171")]
	public delegate void OnItemUnSelect(UIToggleButton selectButton);

	[Token(Token = "0x2004172")]
	public delegate void OnItemAwakeFinished();

	[Token(Token = "0x401B731")]
	[FieldOffset(Offset = "0xC")]
	public UIToggleButton[] toggleButtons;

	[Token(Token = "0x401B732")]
	[FieldOffset(Offset = "0x10")]
	public UIToggleButton DefaultClickBtn;

	[Token(Token = "0x401B733")]
	[FieldOffset(Offset = "0x14")]
	public OnItemSelect OnItemSelectCallback;

	[Token(Token = "0x401B734")]
	[FieldOffset(Offset = "0x18")]
	public OnItemSelect OnItemUnSelectCallback;

	[Token(Token = "0x401B735")]
	[FieldOffset(Offset = "0x1C")]
	public OnItemAwakeFinished OnAwakeCallback;

	[Token(Token = "0x601ABD0")]
	[Address(RVA = "0x2BBF284", Offset = "0x2BBF284", VA = "0x2BBF284")]
	public UIToggleButtonGroup()
	{
	}

	[Token(Token = "0x601ABD1")]
	[Address(RVA = "0x2BBF28C", Offset = "0x2BBF28C", VA = "0x2BBF28C")]
	private void Awake()
	{
	}

	[Token(Token = "0x601ABD2")]
	[Address(RVA = "0x2BBF29C", Offset = "0x2BBF29C", VA = "0x2BBF29C", Slot = "4")]
	protected virtual void OnAwake()
	{
	}

	[Token(Token = "0x601ABD3")]
	[Address(RVA = "0x2BBF6B0", Offset = "0x2BBF6B0", VA = "0x2BBF6B0")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x601ABD4")]
	[Address(RVA = "0x2BBF6BC", Offset = "0x2BBF6BC", VA = "0x2BBF6BC")]
	public void ResetAllToggleButton()
	{
	}

	[Token(Token = "0x601ABD5")]
	[Address(RVA = "0x2BBF864", Offset = "0x2BBF864", VA = "0x2BBF864", Slot = "5")]
	public virtual void OnSelectButton(UIToggleButton selectedButton)
	{
	}

	[Token(Token = "0x601ABD6")]
	[Address(RVA = "0x2BBFEBC", Offset = "0x2BBFEBC", VA = "0x2BBFEBC")]
	public void OnSelectItemByIndex(int index)
	{
	}

	[Token(Token = "0x601ABD7")]
	[Address(RVA = "0x2BBFE10", Offset = "0x2BBFE10", VA = "0x2BBFE10")]
	public void RefreshButtonStates()
	{
	}

	[Token(Token = "0x601ABD8")]
	[Address(RVA = "0x2BBF750", Offset = "0x2BBF750", VA = "0x2BBF750")]
	public void RebindButtons()
	{
	}

	[Token(Token = "0x601ABD9")]
	[Address(RVA = "0x2BC006C", Offset = "0x2BC006C", VA = "0x2BC006C")]
	public void SetToggleButtonSelectEnable(bool enable)
	{
	}
}
