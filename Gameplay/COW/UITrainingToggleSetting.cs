using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x20023E6")]
public class UITrainingToggleSetting : MonoBehaviour
{
	[Token(Token = "0x400DF12")]
	[FieldOffset(Offset = "0xC")]
	public ETrainingToggleType ToggleType;

	[Token(Token = "0x400DF13")]
	[FieldOffset(Offset = "0x10")]
	public UIToggle NoneToggle;

	[Token(Token = "0x400DF14")]
	[FieldOffset(Offset = "0x14")]
	public UIToggle Lv1Toggle;

	[Token(Token = "0x400DF15")]
	[FieldOffset(Offset = "0x18")]
	public UIToggle Lv2Toggle;

	[Token(Token = "0x400DF16")]
	[FieldOffset(Offset = "0x1C")]
	public UIToggle Lv3Toggle;

	[Token(Token = "0x400DF17")]
	[FieldOffset(Offset = "0x20")]
	public UIToggle Lv4Toggle;

	[Token(Token = "0x600CAA5")]
	[Address(RVA = "0x1C2C798", Offset = "0x1C2C798", VA = "0x1C2C798")]
	public UITrainingToggleSetting()
	{
	}

	[Token(Token = "0x600CAA6")]
	[Address(RVA = "0x1C2C7A0", Offset = "0x1C2C7A0", VA = "0x1C2C7A0")]
	private void Start()
	{
	}

	[Token(Token = "0x600CAA7")]
	[Address(RVA = "0x1C2CAF4", Offset = "0x1C2CAF4", VA = "0x1C2CAF4")]
	private void OnValueChange()
	{
	}
}
