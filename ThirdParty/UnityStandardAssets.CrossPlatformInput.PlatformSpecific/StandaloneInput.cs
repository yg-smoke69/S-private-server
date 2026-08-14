using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput.PlatformSpecific;

[Token(Token = "0x2003B1F")]
public class StandaloneInput : VirtualInput
{
	[Token(Token = "0x6017782")]
	[Address(RVA = "0x2A63FB0", Offset = "0x2A63FB0", VA = "0x2A63FB0")]
	public StandaloneInput()
	{
	}

	[Token(Token = "0x6017783")]
	[Address(RVA = "0x2A668E4", Offset = "0x2A668E4", VA = "0x2A668E4", Slot = "4")]
	public override float GetAxis(string name, bool raw)
	{
		return default(float);
	}

	[Token(Token = "0x6017784")]
	[Address(RVA = "0x2A668FC", Offset = "0x2A668FC", VA = "0x2A668FC", Slot = "5")]
	public override bool GetButton(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017785")]
	[Address(RVA = "0x2A66908", Offset = "0x2A66908", VA = "0x2A66908", Slot = "6")]
	public override bool GetButtonDown(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017786")]
	[Address(RVA = "0x2A66914", Offset = "0x2A66914", VA = "0x2A66914", Slot = "7")]
	public override bool GetButtonUp(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017787")]
	[Address(RVA = "0x2A66920", Offset = "0x2A66920", VA = "0x2A66920", Slot = "8")]
	public override void SetButtonDown(string name)
	{
	}

	[Token(Token = "0x6017788")]
	[Address(RVA = "0x2A669BC", Offset = "0x2A669BC", VA = "0x2A669BC", Slot = "9")]
	public override void SetButtonUp(string name)
	{
	}

	[Token(Token = "0x6017789")]
	[Address(RVA = "0x2A66A58", Offset = "0x2A66A58", VA = "0x2A66A58", Slot = "10")]
	public override void SetAxisPositive(string name)
	{
	}

	[Token(Token = "0x601778A")]
	[Address(RVA = "0x2A66AF4", Offset = "0x2A66AF4", VA = "0x2A66AF4", Slot = "11")]
	public override void SetAxisNegative(string name)
	{
	}

	[Token(Token = "0x601778B")]
	[Address(RVA = "0x2A66B90", Offset = "0x2A66B90", VA = "0x2A66B90", Slot = "12")]
	public override void SetAxisZero(string name)
	{
	}

	[Token(Token = "0x601778C")]
	[Address(RVA = "0x2A66C2C", Offset = "0x2A66C2C", VA = "0x2A66C2C", Slot = "13")]
	public override void SetAxis(string name, float value)
	{
	}

	[Token(Token = "0x601778D")]
	[Address(RVA = "0x2A66CC8", Offset = "0x2A66CC8", VA = "0x2A66CC8", Slot = "14")]
	public override Vector3 MousePosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601778E")]
	[Address(RVA = "0x2A66CDC", Offset = "0x2A66CDC", VA = "0x2A66CDC", Slot = "15")]
	public override bool GetKeyCodeButton(KeyCode kc)
	{
		return default(bool);
	}
}
