using COW.GamePlay;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000474")]
internal class TrainingMaxKillerController : MonoBehaviour
{
	[Token(Token = "0x4003D1F")]
	[FieldOffset(Offset = "0x10")]
	private IHAAMHPPLMG m_BindPlayer;

	[Token(Token = "0x4003D20")]
	[FieldOffset(Offset = "0x28")]
	private Camera m_mainCamera;

	[Token(Token = "0x4003D21")]
	[FieldOffset(Offset = "0x2C")]
	private Vector3 m_invisiblePos;

	[Token(Token = "0x4003D22")]
	[FieldOffset(Offset = "0x38")]
	public Vector3 scaleOrg;

	[Token(Token = "0x4003D23")]
	[FieldOffset(Offset = "0x44")]
	public float FixedSize;

	[Token(Token = "0x4003D24")]
	[FieldOffset(Offset = "0x48")]
	public float MinScale;

	[Token(Token = "0x4003D25")]
	[FieldOffset(Offset = "0x4C")]
	public float MaxScale;

	[Token(Token = "0x6001662")]
	[Address(RVA = "0x232BD4C", Offset = "0x232BD4C", VA = "0x232BD4C")]
	public TrainingMaxKillerController()
	{
	}

	[Token(Token = "0x6001663")]
	[Address(RVA = "0x232BDF8", Offset = "0x232BDF8", VA = "0x232BDF8")]
	private void Awake()
	{
	}

	[Token(Token = "0x6001664")]
	[Address(RVA = "0x232C010", Offset = "0x232C010", VA = "0x232C010")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6001665")]
	[Address(RVA = "0x232C1A8", Offset = "0x232C1A8", VA = "0x232C1A8")]
	public void SetScaleOrg(float x, float y, float z)
	{
	}

	[Token(Token = "0x6001666")]
	[Address(RVA = "0x232C268", Offset = "0x232C268", VA = "0x232C268", Slot = "4")]
	protected virtual void OnTrainingZoneChanged(object[] param)
	{
	}

	[Token(Token = "0x6001667")]
	[Address(RVA = "0x232C384", Offset = "0x232C384", VA = "0x232C384")]
	private void OnTrainingMaxKillChange(object[] data)
	{
	}

	[Token(Token = "0x6001668")]
	[Address(RVA = "0x232C494", Offset = "0x232C494", VA = "0x232C494")]
	protected Vector3 TargetPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6001669")]
	[Address(RVA = "0x232C77C", Offset = "0x232C77C", VA = "0x232C77C")]
	private void LateUpdate()
	{
	}
}
