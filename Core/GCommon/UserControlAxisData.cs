using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

namespace GCommon;

[Token(Token = "0x2003EE8")]
public class UserControlAxisData
{
	[Token(Token = "0x2003EE9")]
	public enum EAxisDataType
	{
		[Token(Token = "0x401A937")]
		Left,
		[Token(Token = "0x401A938")]
		Right,
		[Token(Token = "0x401A939")]
		WeaponSlider,
		[Token(Token = "0x401A93A")]
		RouletteSlider,
		[Token(Token = "0x401A93B")]
		MedkitSlider,
		[Token(Token = "0x401A93C")]
		GrenadeSlider
	}

	[Token(Token = "0x401A924")]
	[FieldOffset(Offset = "0x8")]
	public Vector3 Direction;

	[Token(Token = "0x401A925")]
	[FieldOffset(Offset = "0x14")]
	public Vector3 DeltaPos;

	[Token(Token = "0x401A926")]
	[FieldOffset(Offset = "0x20")]
	public Vector3 LastDirection;

	[Token(Token = "0x401A927")]
	[FieldOffset(Offset = "0x2C")]
	public UserControlTouchInfo TouchInfo;

	[Token(Token = "0x401A928")]
	[FieldOffset(Offset = "0x30")]
	public UserControlTouchInfo LastTouchInfo;

	[Token(Token = "0x401A929")]
	[FieldOffset(Offset = "0x34")]
	private bool m_IsTouched;

	[Token(Token = "0x401A92A")]
	[FieldOffset(Offset = "0x35")]
	private bool m_IsActuallyMoved;

	[Token(Token = "0x401A92B")]
	[FieldOffset(Offset = "0x36")]
	private bool m_IsCheckUpperPanel;

	[Token(Token = "0x401A92C")]
	[FieldOffset(Offset = "0x37")]
	private bool m_IsInBegin;

	[Token(Token = "0x401A92D")]
	[FieldOffset(Offset = "0x38")]
	private Vector3 m_CurrentDeltaValue;

	[Token(Token = "0x401A92E")]
	[FieldOffset(Offset = "0x44")]
	private Vector3 m_StartScreenPos;

	[Token(Token = "0x401A92F")]
	[FieldOffset(Offset = "0x50")]
	private Vector3 m_CurrentScreenPos;

	[Token(Token = "0x401A930")]
	[FieldOffset(Offset = "0x5C")]
	private float m_ActuallyMovedDistance;

	[Token(Token = "0x401A931")]
	[FieldOffset(Offset = "0x60")]
	public Vector3 SwipeDirection;

	[Token(Token = "0x401A932")]
	[FieldOffset(Offset = "0x6C")]
	private EAxisDataType m_AxisDataType;

	[Token(Token = "0x401A933")]
	[FieldOffset(Offset = "0x70")]
	private Dictionary<int, UserButtonArea> m_TouchingThroughArea;

	[Token(Token = "0x401A934")]
	[FieldOffset(Offset = "0x74")]
	private CrossPlatformInputManager.VirtualAxis m_HVirtualAxis;

	[Token(Token = "0x401A935")]
	[FieldOffset(Offset = "0x78")]
	private CrossPlatformInputManager.VirtualAxis m_VVirtualAxis;

	[Token(Token = "0x60199FE")]
	[Address(RVA = "0x2BCED1C", Offset = "0x2BCED1C", VA = "0x2BCED1C")]
	public UserControlAxisData(string hName, string vName, float acturallyMovedDist, EAxisDataType t)
	{
	}

	[Token(Token = "0x60199FF")]
	[Address(RVA = "0x2BCF054", Offset = "0x2BCF054", VA = "0x2BCF054")]
	public EAxisDataType GetAxisDataType()
	{
		return default(EAxisDataType);
	}

	[Token(Token = "0x6019A00")]
	[Address(RVA = "0x2BCF05C", Offset = "0x2BCF05C", VA = "0x2BCF05C")]
	public int GetTouchFinger()
	{
		return default(int);
	}

	[Token(Token = "0x6019A01")]
	[Address(RVA = "0x2BCF080", Offset = "0x2BCF080", VA = "0x2BCF080")]
	public bool IsInRange(Vector3 v)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A02")]
	[Address(RVA = "0x2BCF13C", Offset = "0x2BCF13C", VA = "0x2BCF13C")]
	private bool IsButtonArea(Vector3 v)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A03")]
	[Address(RVA = "0x2BCF324", Offset = "0x2BCF324", VA = "0x2BCF324")]
	public bool IsStationary()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A04")]
	[Address(RVA = "0x2BCF364", Offset = "0x2BCF364", VA = "0x2BCF364")]
	public bool CanTouchingThrough(Vector2 pos)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A05")]
	[Address(RVA = "0x2BCF62C", Offset = "0x2BCF62C", VA = "0x2BCF62C")]
	public bool IsSpeedupButtonArea(Vector3 v)
	{
		return default(bool);
	}

	[Token(Token = "0x6019A06")]
	[Address(RVA = "0x2BCF744", Offset = "0x2BCF744", VA = "0x2BCF744")]
	public void UpdateValue(Vector3 pos, Vector3 deltaValue)
	{
	}

	[Token(Token = "0x6019A07")]
	[Address(RVA = "0x2BCF770", Offset = "0x2BCF770", VA = "0x2BCF770")]
	public Vector3 GetCurrentScreenPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019A08")]
	[Address(RVA = "0x2BCF784", Offset = "0x2BCF784", VA = "0x2BCF784")]
	public bool CheckIsInBegin()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A09")]
	[Address(RVA = "0x2BCF78C", Offset = "0x2BCF78C", VA = "0x2BCF78C")]
	public void OnBegin(Vector3 startPos, Vector3 deltaPos)
	{
	}

	[Token(Token = "0x6019A0A")]
	[Address(RVA = "0x2BCF86C", Offset = "0x2BCF86C", VA = "0x2BCF86C")]
	public void OnEnd()
	{
	}

	[Token(Token = "0x6019A0B")]
	[Address(RVA = "0x2BCF98C", Offset = "0x2BCF98C", VA = "0x2BCF98C")]
	public void OnMove(Vector3 lastPos, Vector3 curPos)
	{
	}

	[Token(Token = "0x6019A0C")]
	[Address(RVA = "0x2BCFBE4", Offset = "0x2BCFBE4", VA = "0x2BCFBE4")]
	public void OnStationary(Vector3 lastPos, Vector3 curPos, bool doFix, float threshold)
	{
	}

	[Token(Token = "0x6019A0D")]
	[Address(RVA = "0x2BCFDD4", Offset = "0x2BCFDD4", VA = "0x2BCFDD4")]
	public void UpdateDirection()
	{
	}

	[Token(Token = "0x6019A0E")]
	[Address(RVA = "0x2BCFDF8", Offset = "0x2BCFDF8", VA = "0x2BCFDF8")]
	public Vector3 GetDelta()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019A0F")]
	[Address(RVA = "0x2BCFE0C", Offset = "0x2BCFE0C", VA = "0x2BCFE0C")]
	public bool IsTouched()
	{
		return default(bool);
	}

	[Token(Token = "0x6019A10")]
	[Address(RVA = "0x2BCFE14", Offset = "0x2BCFE14", VA = "0x2BCFE14")]
	public Vector3 GetStartScreenPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6019A11")]
	[Address(RVA = "0x2BCFE28", Offset = "0x2BCFE28", VA = "0x2BCFE28")]
	public void SetVirtualAxes()
	{
	}

	[Token(Token = "0x6019A12")]
	[Address(RVA = "0x2BCFE90", Offset = "0x2BCFE90", VA = "0x2BCFE90")]
	public void AddTouchingThroughArea(int key, UserButtonArea area)
	{
	}

	[Token(Token = "0x6019A13")]
	[Address(RVA = "0x2BCFF60", Offset = "0x2BCFF60", VA = "0x2BCFF60")]
	public void EnableTouchingThroughArea(int key, bool v)
	{
	}

	[Token(Token = "0x6019A14")]
	[Address(RVA = "0x2BD0018", Offset = "0x2BD0018", VA = "0x2BD0018")]
	public void EnableCheckUpperPanel(bool enable)
	{
	}
}
