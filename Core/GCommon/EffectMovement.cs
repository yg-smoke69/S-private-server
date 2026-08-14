using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003EA2")]
public class EffectMovement : MonoBehaviour
{
	[Token(Token = "0x401A749")]
	[FieldOffset(Offset = "0xC")]
	private Vector3 m_StartPoint;

	[Token(Token = "0x401A74A")]
	[FieldOffset(Offset = "0x18")]
	private Vector3 m_ControlPoint;

	[Token(Token = "0x401A74B")]
	[FieldOffset(Offset = "0x24")]
	private Vector3 m_EndPoint;

	[Token(Token = "0x401A74C")]
	[FieldOffset(Offset = "0x30")]
	private float m_StartTime;

	[Token(Token = "0x401A74D")]
	[FieldOffset(Offset = "0x34")]
	private float m_DurationTime;

	[Token(Token = "0x401A74E")]
	[FieldOffset(Offset = "0x38")]
	private bool m_NeedAutoDestroy;

	[Token(Token = "0x401A74F")]
	[FieldOffset(Offset = "0x39")]
	private bool m_EndOfMove;

	[Token(Token = "0x401A750")]
	[FieldOffset(Offset = "0x3C")]
	private ReusableObject m_OwnedResuable;

	[Token(Token = "0x60197AD")]
	[Address(RVA = "0x329DC48", Offset = "0x329DC48", VA = "0x329DC48")]
	public EffectMovement()
	{
	}

	[Token(Token = "0x60197AE")]
	[Address(RVA = "0x329DC50", Offset = "0x329DC50", VA = "0x329DC50")]
	private void Start()
	{
	}

	[Token(Token = "0x60197AF")]
	[Address(RVA = "0x329DCB8", Offset = "0x329DCB8", VA = "0x329DCB8")]
	public void Init(Vector3 start_point, Vector3 end_point, Vector3 control_point, float time, bool need_auto_recycle)
	{
	}

	[Token(Token = "0x60197B0")]
	[Address(RVA = "0x329DD98", Offset = "0x329DD98", VA = "0x329DD98")]
	private Vector3 GetPosByBezierCurve(float rate)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x60197B1")]
	[Address(RVA = "0x329DF30", Offset = "0x329DF30", VA = "0x329DF30")]
	private void Update()
	{
	}
}
