using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x20005AC")]
public class BezierFollowingObject : ReusableObject
{
	[Token(Token = "0x4004376")]
	[FieldOffset(Offset = "0x18")]
	public float DefaultFollowTime;

	[Token(Token = "0x4004377")]
	[FieldOffset(Offset = "0x1C")]
	private Transform m_Target;

	[Token(Token = "0x4004378")]
	[FieldOffset(Offset = "0x20")]
	private Vector3 m_StartPoint;

	[Token(Token = "0x4004379")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_TurnPoint;

	[Token(Token = "0x400437A")]
	[FieldOffset(Offset = "0x38")]
	private float m_FollowTime;

	[Token(Token = "0x400437B")]
	[FieldOffset(Offset = "0x3C")]
	private float m_StartTime;

	[Token(Token = "0x6002298")]
	[Address(RVA = "0x2ECFFFC", Offset = "0x2ECFFFC", VA = "0x2ECFFFC")]
	public BezierFollowingObject()
	{
	}

	[Token(Token = "0x6002299")]
	[Address(RVA = "0x2ED0004", Offset = "0x2ED0004", VA = "0x2ED0004")]
	public static void StartFollowing(Transform owner, Transform target, Vector3 startPoint, Vector3 turnPoint, bool isUseDefaultTime = true, float followTime = 0.5f)
	{
	}

	[Token(Token = "0x600229A")]
	[Address(RVA = "0x2ED0230", Offset = "0x2ED0230", VA = "0x2ED0230")]
	public void StartFollow(Transform target, Vector3 startPoint, Vector3 turnPoint, float followTime)
	{
	}

	[Token(Token = "0x600229B")]
	[Address(RVA = "0x2ED0290", Offset = "0x2ED0290", VA = "0x2ED0290")]
	private void Update()
	{
	}

	[Token(Token = "0x600229C")]
	[Address(RVA = "0x2ED0420", Offset = "0x2ED0420", VA = "0x2ED0420")]
	private Vector3 GetCurPoint(float t)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}
}
