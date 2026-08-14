using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace UnityStandardAssets.CrossPlatformInput;

[Token(Token = "0x2003B24")]
public abstract class VirtualInput
{
	[Token(Token = "0x40192AE")]
	[FieldOffset(Offset = "0x8")]
	private Vector3 _003CvirtualMousePosition_003Ek__BackingField;

	[Token(Token = "0x40192AF")]
	[FieldOffset(Offset = "0x14")]
	protected Dictionary<string, CrossPlatformInputManager.VirtualAxis> m_VirtualAxes;

	[Token(Token = "0x40192B0")]
	[FieldOffset(Offset = "0x18")]
	protected Dictionary<string, CrossPlatformInputManager.VirtualButton> m_VirtualButtons;

	[Token(Token = "0x40192B1")]
	[FieldOffset(Offset = "0x1C")]
	protected List<string> m_AlwaysUseVirtual;

	[Token(Token = "0x170017D2")]
	public Vector3 virtualMousePosition
	{
		[Token(Token = "0x6017795")]
		[Address(RVA = "0x2A668C8", Offset = "0x2A668C8", VA = "0x2A668C8")]
		get
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}
		[Token(Token = "0x6017796")]
		[Address(RVA = "0x2A6713C", Offset = "0x2A6713C", VA = "0x2A6713C")]
		private set
		{
		}
	}

	[Token(Token = "0x6017794")]
	[Address(RVA = "0x2A65D14", Offset = "0x2A65D14", VA = "0x2A65D14")]
	protected VirtualInput()
	{
	}

	[Token(Token = "0x6017797")]
	[Address(RVA = "0x2A64150", Offset = "0x2A64150", VA = "0x2A64150")]
	public bool AxisExists(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017798")]
	[Address(RVA = "0x2A6427C", Offset = "0x2A6427C", VA = "0x2A6427C")]
	public bool ButtonExists(string name)
	{
		return default(bool);
	}

	[Token(Token = "0x6017799")]
	[Address(RVA = "0x2A643A8", Offset = "0x2A643A8", VA = "0x2A643A8")]
	public void RegisterVirtualAxis(CrossPlatformInputManager.VirtualAxis axis)
	{
	}

	[Token(Token = "0x601779A")]
	[Address(RVA = "0x2A64604", Offset = "0x2A64604", VA = "0x2A64604")]
	public void RegisterVirtualButton(CrossPlatformInputManager.VirtualButton button)
	{
	}

	[Token(Token = "0x601779B")]
	[Address(RVA = "0x2A648C0", Offset = "0x2A648C0", VA = "0x2A648C0")]
	public void UnRegisterVirtualAxis(string name)
	{
	}

	[Token(Token = "0x601779C")]
	[Address(RVA = "0x2A64A24", Offset = "0x2A64A24", VA = "0x2A64A24")]
	public void UnRegisterVirtualButton(string name)
	{
	}

	[Token(Token = "0x601779D")]
	[Address(RVA = "0x2A64B88", Offset = "0x2A64B88", VA = "0x2A64B88")]
	public CrossPlatformInputManager.VirtualAxis VirtualAxisReference(string name)
	{
		return null;
	}

	[Token(Token = "0x601779E")]
	[Address(RVA = "0x2A65348", Offset = "0x2A65348", VA = "0x2A65348")]
	public void SetVirtualMousePositionX(float f)
	{
	}

	[Token(Token = "0x601779F")]
	[Address(RVA = "0x2A65474", Offset = "0x2A65474", VA = "0x2A65474")]
	public void SetVirtualMousePositionY(float f)
	{
	}

	[Token(Token = "0x60177A0")]
	[Address(RVA = "0x2A655A4", Offset = "0x2A655A4", VA = "0x2A655A4")]
	public void SetVirtualMousePositionZ(float f)
	{
	}

	[Token(Token = "0x60177A1")]
	public abstract float GetAxis(string name, bool raw);

	[Token(Token = "0x60177A2")]
	public abstract bool GetButton(string name);

	[Token(Token = "0x60177A3")]
	public abstract bool GetButtonDown(string name);

	[Token(Token = "0x60177A4")]
	public abstract bool GetButtonUp(string name);

	[Token(Token = "0x60177A5")]
	public abstract void SetButtonDown(string name);

	[Token(Token = "0x60177A6")]
	public abstract void SetButtonUp(string name);

	[Token(Token = "0x60177A7")]
	public abstract void SetAxisPositive(string name);

	[Token(Token = "0x60177A8")]
	public abstract void SetAxisNegative(string name);

	[Token(Token = "0x60177A9")]
	public abstract void SetAxisZero(string name);

	[Token(Token = "0x60177AA")]
	public abstract void SetAxis(string name, float value);

	[Token(Token = "0x60177AB")]
	public abstract Vector3 MousePosition();

	[Token(Token = "0x60177AC")]
	public abstract bool GetKeyCodeButton(KeyCode kc);
}
