using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

[Token(Token = "0x2003B1E")]
public class MobileInput : VirtualInput
{
	[Token(Token = "0x6017773")]
	[Address(RVA = "0x2A63FAC", Offset = "0x2A63FAC", VA = "0x2A63FAC")]
	public MobileInput()
	{
	}

	[Token(Token = "0x6017774")]
	[Address(RVA = "0x2A65E08", Offset = "0x2A65E08", VA = "0x2A65E08")]
	private void AddButton(string name)
	{
	}

	[Token(Token = "0x6017775")]
	[Address(RVA = "0x2A65EC4", Offset = "0x2A65EC4", VA = "0x2A65EC4")]
	private void AddAxes(string name)
	{
	}

	[Token(Token = "0x6017776")]
	[Address(RVA = "0x2A65F70", Offset = "0x2A65F70", VA = "0x2A65F70", Slot = "4")]
	public override float GetAxis(string name, bool raw)
	{
		return default(float);
	}

	[Token(Token = "0x6017777")]
	[Address(RVA = "0x2A66044", Offset = "0x2A66044", VA = "0x2A66044", Slot = "8")]
	public override void SetButtonDown(string name)
	{
	}

	[Token(Token = "0x6017778")]
	[Address(RVA = "0x2A66134", Offset = "0x2A66134", VA = "0x2A66134", Slot = "9")]
	public override void SetButtonUp(string name)
	{
	}

	[Token(Token = "0x6017779")]
	[Address(RVA = "0x2A66218", Offset = "0x2A66218", VA = "0x2A66218", Slot = "10")]
	public override void SetAxisPositive(string name)
	{
	}

	[Token(Token = "0x601777A")]
	[Address(RVA = "0x2A662F0", Offset = "0x2A662F0", VA = "0x2A662F0", Slot = "11")]
	public override void SetAxisNegative(string name)
	{
	}

	[Token(Token = "0x601777B")]
	[Address(RVA = "0x2A663CC", Offset = "0x2A663CC", VA = "0x2A663CC", Slot = "12")]
	public override void SetAxisZero(string name)
	{
	}

	[Token(Token = "0x601777C")]
	[Address(RVA = "0x2A664A4", Offset = "0x2A664A4", VA = "0x2A664A4", Slot = "13")]
	public override void SetAxis(string name, float value)
	{
	}

	[Token(Token = "0x601777D")]
	[Address(RVA = "0x2A66588", Offset = "0x2A66588", VA = "0x2A66588", Slot = "6")]
	public override bool GetButtonDown(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601777E")]
	[Address(RVA = "0x2A666A0", Offset = "0x2A666A0", VA = "0x2A666A0", Slot = "7")]
	public override bool GetButtonUp(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x601777F")]
	[Address(RVA = "0x2A667B8", Offset = "0x2A667B8", VA = "0x2A667B8", Slot = "5")]
	public override bool GetButton(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017780")]
	[Address(RVA = "0x2A668B4", Offset = "0x2A668B4", VA = "0x2A668B4", Slot = "14")]
	public override Vector3 MousePosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6017781")]
	[Address(RVA = "0x2A668DC", Offset = "0x2A668DC", VA = "0x2A668DC", Slot = "15")]
	public override bool GetKeyCodeButton(KeyCode kc)
	{
		return default(bool);
	}
}
