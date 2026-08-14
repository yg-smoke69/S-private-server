using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EE7")]
public class UserControlTouchData
{
	[Token(Token = "0x401A91C")]
	[FieldOffset(Offset = "0x8")]
	public UserControlTouchInfo TouchInfo;

	[Token(Token = "0x401A91D")]
	[FieldOffset(Offset = "0xC")]
	public UserControlTouchInfo LastTouchInfo;

	[Token(Token = "0x401A91E")]
	[FieldOffset(Offset = "0x10")]
	private bool m_IsTouched;

	[Token(Token = "0x401A91F")]
	[FieldOffset(Offset = "0x11")]
	private bool m_IsActuallyMoved;

	[Token(Token = "0x401A920")]
	[FieldOffset(Offset = "0x14")]
	private Vector3 m_StartScreenPos;

	[Token(Token = "0x401A921")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_CurrentScreenPos;

	[Token(Token = "0x401A922")]
	[FieldOffset(Offset = "0x2C")]
	private float m_ActuallyMovedDistance;

	[Token(Token = "0x401A923")]
	[FieldOffset(Offset = "0x30")]
	private Vector3 m_CachedScreenPos;

	[Token(Token = "0x60199F5")]
	[Address(RVA = "0x2BD1F00", Offset = "0x2BD1F00", VA = "0x2BD1F00")]
	public UserControlTouchData(float actually_move_dist)
	{
	}

	[Token(Token = "0x60199F6")]
	[Address(RVA = "0x2BD3E20", Offset = "0x2BD3E20", VA = "0x2BD3E20")]
	public void OnBegin(Vector3 startPos)
	{
	}

	[Token(Token = "0x60199F7")]
	[Address(RVA = "0x2BD3F78", Offset = "0x2BD3F78", VA = "0x2BD3F78")]
	public void OnEnd()
	{
	}

	[Token(Token = "0x60199F8")]
	[Address(RVA = "0x2BD41A8", Offset = "0x2BD41A8", VA = "0x2BD41A8")]
	public void OnStationary(Vector3 curPos)
	{
	}

	[Token(Token = "0x60199F9")]
	[Address(RVA = "0x2BD4094", Offset = "0x2BD4094", VA = "0x2BD4094")]
	public void OnMove(Vector3 lastPos, Vector3 curPos)
	{
	}

	[Token(Token = "0x60199FA")]
	[Address(RVA = "0x2BD4650", Offset = "0x2BD4650", VA = "0x2BD4650")]
	public bool HaveCachedTouchPos()
	{
		return default(bool);
	}

	[Token(Token = "0x60199FB")]
	[Address(RVA = "0x2BD5564", Offset = "0x2BD5564", VA = "0x2BD5564")]
	public bool IsTouched()
	{
		return default(bool);
	}

	[Token(Token = "0x60199FC")]
	[Address(RVA = "0x2BD47D8", Offset = "0x2BD47D8", VA = "0x2BD47D8")]
	public Vector3 GetCachedTouchPos()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60199FD")]
	[Address(RVA = "0x2BD41B4", Offset = "0x2BD41B4", VA = "0x2BD41B4")]
	public void ClearTouchInfo()
	{
	}
}
