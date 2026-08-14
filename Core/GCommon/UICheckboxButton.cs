using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x200412C")]
public class UICheckboxButton : UIButton
{
	[Token(Token = "0x401B5DF")]
	[FieldOffset(Offset = "0xBC")]
	public bool IsDefualtChecked;

	[Token(Token = "0x401B5E0")]
	[FieldOffset(Offset = "0xC0")]
	public GameObject CheckedObject;

	[Token(Token = "0x401B5E1")]
	[FieldOffset(Offset = "0xC4")]
	public GameObject UnCheckedObject;

	[Token(Token = "0x401B5E2")]
	[FieldOffset(Offset = "0xC8")]
	public OnCheckboxValueChanged OnValueChanged;

	[Token(Token = "0x401B5E3")]
	[FieldOffset(Offset = "0xCC")]
	public OnCheckboxValueChangedNtf OnValueChangedNotifyGroup;

	[Token(Token = "0x401B5E4")]
	[FieldOffset(Offset = "0xD0")]
	public List<EventDelegate> onValueChange;

	[Token(Token = "0x401B5E5")]
	[FieldOffset(Offset = "0xD4")]
	private bool m_IsChecked;

	[Token(Token = "0x17001D59")]
	public bool IsChecked
	{
		[Token(Token = "0x601AA26")]
		[Address(RVA = "0x2C9C1B4", Offset = "0x2C9C1B4", VA = "0x2C9C1B4")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x601AA27")]
		[Address(RVA = "0x2C9BC38", Offset = "0x2C9BC38", VA = "0x2C9BC38")]
		set
		{
		}
	}

	[Token(Token = "0x601AA25")]
	[Address(RVA = "0x2C9C7A4", Offset = "0x2C9C7A4", VA = "0x2C9C7A4")]
	public UICheckboxButton()
	{
	}

	[Token(Token = "0x601AA28")]
	[Address(RVA = "0x2C9C830", Offset = "0x2C9C830", VA = "0x2C9C830")]
	private void Start()
	{
	}

	[Token(Token = "0x601AA29")]
	[Address(RVA = "0x2C9C8F4", Offset = "0x2C9C8F4", VA = "0x2C9C8F4")]
	private void Awake()
	{
	}

	[Token(Token = "0x601AA2A")]
	[Address(RVA = "0x2C9C8FC", Offset = "0x2C9C8FC", VA = "0x2C9C8FC")]
	private void OnCheckBoxTicked()
	{
	}
}
