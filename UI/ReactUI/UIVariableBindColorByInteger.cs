using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.UI;

namespace ReactUI;

[Token(Token = "0x2000CC5")]
public sealed class UIVariableBindColorByInteger : UIVariableBind
{
	[Serializable]
	[Token(Token = "0x2000CC6")]
	private struct ColorPair
	{
		[Token(Token = "0x40067C1")]
		[FieldOffset(Offset = "0x0")]
		public int index;

		[Token(Token = "0x40067C2")]
		[FieldOffset(Offset = "0x4")]
		public Color color;
	}

	[Token(Token = "0x40067BD")]
	[FieldOffset(Offset = "0x1C")]
	private string integerBind;

	[Token(Token = "0x40067BE")]
	[FieldOffset(Offset = "0x20")]
	private ColorPair[] colors;

	[Token(Token = "0x40067BF")]
	[FieldOffset(Offset = "0x24")]
	private Graphic m_graphic;

	[Token(Token = "0x40067C0")]
	[FieldOffset(Offset = "0x28")]
	private UIVariable bindVariable;

	[Token(Token = "0x6006132")]
	[Address(RVA = "0x315F350", Offset = "0x315F350", VA = "0x315F350")]
	public UIVariableBindColorByInteger()
	{
	}

	[Token(Token = "0x6006133")]
	[Address(RVA = "0x315F3D4", Offset = "0x315F3D4", VA = "0x315F3D4", Slot = "6")]
	protected override void BindVariables()
	{
	}

	[Token(Token = "0x6006134")]
	[Address(RVA = "0x315F790", Offset = "0x315F790", VA = "0x315F790", Slot = "7")]
	protected override void UnbindVariables()
	{
	}

	[Token(Token = "0x6006135")]
	[Address(RVA = "0x315F5C8", Offset = "0x315F5C8", VA = "0x315F5C8")]
	private void OnValueChanged()
	{
	}
}
