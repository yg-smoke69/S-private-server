using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CD9")]
public class UIVariableBindRectTransByBool : UIVariableBindBool
{
	[Token(Token = "0x2000CDA")]
	public enum RectTransModeEnum
	{
		[Token(Token = "0x4006835")]
		AnchorPos,
		[Token(Token = "0x4006836")]
		SizeDelta,
		[Token(Token = "0x4006837")]
		Rotate,
		[Token(Token = "0x4006838")]
		Scale,
		[Token(Token = "0x4006839")]
		Pivot,
		[Token(Token = "0x400683A")]
		OffsetMin,
		[Token(Token = "0x400683B")]
		OffsetMax
	}

	[Token(Token = "0x400682F")]
	[FieldOffset(Offset = "0x28")]
	private RectTransform rectTrans;

	[Token(Token = "0x4006830")]
	[FieldOffset(Offset = "0x2C")]
	private RectTransModeEnum transMode;

	[Token(Token = "0x4006831")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 trueValue;

	[Token(Token = "0x4006832")]
	[FieldOffset(Offset = "0x3C")]
	private Vector3 falseValue;

	[Token(Token = "0x4006833")]
	[FieldOffset(Offset = "0x48")]
	private float duration;

	[Token(Token = "0x6006198")]
	[Address(RVA = "0x3166EF0", Offset = "0x3166EF0", VA = "0x3166EF0")]
	public UIVariableBindRectTransByBool()
	{
	}

	[Token(Token = "0x6006199")]
	[Address(RVA = "0x3166EF4", Offset = "0x3166EF4", VA = "0x3166EF4", Slot = "10")]
	protected override void OnValueChanged()
	{
	}
}
