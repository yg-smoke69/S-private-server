using COW.GamePlay;
using COW.HUD;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2003345")]
public class DebugPlayerTargetInfo
{
	[Token(Token = "0x4013884")]
	[FieldOffset(Offset = "0x8")]
	public UIHudAimTargetScoreInfoController AimtargetScoreInfoPanel;

	[Token(Token = "0x4013885")]
	[FieldOffset(Offset = "0xC")]
	public UIHudDebugPlayerTagController TagContoller;

	[Token(Token = "0x4013886")]
	[FieldOffset(Offset = "0x10")]
	public Color Player_Color;

	[Token(Token = "0x4013887")]
	[FieldOffset(Offset = "0x20")]
	public IHAAMHPPLMG Player_ID;

	[Token(Token = "0x4013888")]
	[FieldOffset(Offset = "0x38")]
	public bool IsUsing;

	[Token(Token = "0x6015C79")]
	[Address(RVA = "0x1C8B644", Offset = "0x1C8B644", VA = "0x1C8B644")]
	public DebugPlayerTargetInfo(IHAAMHPPLMG playerID, Color playerColor)
	{
	}

	[Token(Token = "0x6015C7A")]
	[Address(RVA = "0x1C8B6A4", Offset = "0x1C8B6A4", VA = "0x1C8B6A4")]
	public void Destroy()
	{
	}
}
