using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200046C")]
public class SingerBScenePointManager : MonoBehaviour
{
	[Token(Token = "0x4003CE4")]
	[FieldOffset(Offset = "0xC")]
	public Transform SkateBoardBeginPoint;

	[Token(Token = "0x4003CE5")]
	[FieldOffset(Offset = "0x10")]
	public float SkateBoardBeginPointRange;

	[Token(Token = "0x4003CE6")]
	[FieldOffset(Offset = "0x14")]
	public Transform DanceFlyBeginPoint;

	[Token(Token = "0x4003CE7")]
	[FieldOffset(Offset = "0x18")]
	public float DanceFlyBeginRange;

	[Token(Token = "0x4003CE8")]
	[FieldOffset(Offset = "0x1C")]
	public Transform DanceFlyGravityDirRoot;

	[Token(Token = "0x4003CE9")]
	[FieldOffset(Offset = "0x20")]
	public Transform DancePlaneTeleportCenter;

	[Token(Token = "0x4003CEA")]
	[FieldOffset(Offset = "0x24")]
	public float DancePlaneTeleportRange;

	[Token(Token = "0x4003CEB")]
	[FieldOffset(Offset = "0x28")]
	public Transform XJStarLightCenterPoint;

	[Token(Token = "0x4003CEC")]
	[FieldOffset(Offset = "0x2C")]
	public List<Transform> CallDancePoints;

	[Token(Token = "0x4003CED")]
	[FieldOffset(Offset = "0x30")]
	private float m_Theta;

	[Token(Token = "0x6001638")]
	[Address(RVA = "0x21CF56C", Offset = "0x21CF56C", VA = "0x21CF56C")]
	public SingerBScenePointManager()
	{
	}

	[Token(Token = "0x6001639")]
	[Address(RVA = "0x21CF604", Offset = "0x21CF604", VA = "0x21CF604")]
	public Vector3 GetRadomSkateBoardBeginPoint(out Vector3 forward)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600163A")]
	[Address(RVA = "0x21CF7B8", Offset = "0x21CF7B8", VA = "0x21CF7B8")]
	public Vector3 GetRadomDanceFlyBeginPoint(out Vector3 forward)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600163B")]
	[Address(RVA = "0x21CF850", Offset = "0x21CF850", VA = "0x21CF850")]
	public Vector3 GetRadomDancePlaneTeleportPoint(out Vector3 forward)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600163C")]
	[Address(RVA = "0x21CF69C", Offset = "0x21CF69C", VA = "0x21CF69C")]
	private Vector3 GetRandomPointInCircle(Vector3 center, float radius)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x600163D")]
	[Address(RVA = "0x21CF8E8", Offset = "0x21CF8E8", VA = "0x21CF8E8")]
	private void OnDrawGizmosSelected()
	{
	}

	[Token(Token = "0x600163E")]
	[Address(RVA = "0x21CF99C", Offset = "0x21CF99C", VA = "0x21CF99C")]
	private void drawTransformRange(Transform transform, float radius, Color color)
	{
	}

	[Token(Token = "0x600163F")]
	[Address(RVA = "0x21CFC58", Offset = "0x21CFC58", VA = "0x21CFC58")]
	private void drawCircle(float radius)
	{
	}
}
