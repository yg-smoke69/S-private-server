using System.Runtime.InteropServices;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x2004192")]
public class TestPlayerMove : MonoBehaviour, _Attribute
{
	[Token(Token = "0x401B7BE")]
	[FieldOffset(Offset = "0xC")]
	public Transform[] OtherPlayer;

	[Token(Token = "0x401B7BF")]
	[FieldOffset(Offset = "0x10")]
	private Quaternion m_AimingRotation;

	[Token(Token = "0x401B7C0")]
	[FieldOffset(Offset = "0x20")]
	private CharacterController m_CharacterController;

	[Token(Token = "0x401B7C1")]
	[FieldOffset(Offset = "0x24")]
	private bool m_IsFiring;

	[Token(Token = "0x401B7C2")]
	[FieldOffset(Offset = "0x28")]
	private FollowAndAutoRotationCamera m_CamEntity;

	[Token(Token = "0x401B7C3")]
	[FieldOffset(Offset = "0x2C")]
	private GameObject m_FireEffect;

	[Token(Token = "0x401B7C4")]
	[FieldOffset(Offset = "0x30")]
	private UserControlHandler m_UserControlHanlder;

	[Token(Token = "0x401B7C5")]
	private const float IPHONE_DPI = 326f;

	[Token(Token = "0x401B7C6")]
	private const float MAX_ROTATION_DELTA = 300f;

	[Token(Token = "0x401B7C7")]
	private const float ROTATION_EXPONENT = 3f;

	[Token(Token = "0x601AC82")]
	[Address(RVA = "0x2634DD0", Offset = "0x2634DD0", VA = "0x2634DD0")]
	public TestPlayerMove()
	{
	}

	[Token(Token = "0x601AC83")]
	[Address(RVA = "0x2634DD8", Offset = "0x2634DD8", VA = "0x2634DD8")]
	private void Start()
	{
	}

	[Token(Token = "0x601AC84")]
	[Address(RVA = "0x2635118", Offset = "0x2635118", VA = "0x2635118")]
	private void Update()
	{
	}

	[Token(Token = "0x601AC85")]
	[Address(RVA = "0x263605C", Offset = "0x263605C", VA = "0x263605C", Slot = "4")]
	public Vector3 GetCameraTrackableEntityPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AC86")]
	[Address(RVA = "0x263609C", Offset = "0x263609C", VA = "0x263609C", Slot = "6")]
	public Quaternion GetCameraTrackableEntityAimRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Quaternion);
	}

	[Token(Token = "0x601AC87")]
	[Address(RVA = "0x26360AC", Offset = "0x26360AC", VA = "0x26360AC", Slot = "5")]
	public Vector3 GetCameraTrackableEntityTopPosition()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AC88")]
	[Address(RVA = "0x26361B4", Offset = "0x26361B4", VA = "0x26361B4", Slot = "7")]
	public Transform GetCameraTrackableEntityTransfrom()
	{
		return null;
	}

	[Token(Token = "0x601AC89")]
	[Address(RVA = "0x26361BC", Offset = "0x26361BC", VA = "0x26361BC", Slot = "8")]
	public bool IsCameraTrackableEntityAlive()
	{
		return default(bool);
	}

	[Token(Token = "0x601AC8A")]
	[Address(RVA = "0x2635D60", Offset = "0x2635D60", VA = "0x2635D60")]
	private Vector3 UpdateMovingDireciton()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AC8B")]
	[Address(RVA = "0x26361C4", Offset = "0x26361C4", VA = "0x26361C4")]
	private void UpdateRotation(float gameTime, float deltaTime)
	{
	}

	[Token(Token = "0x601AC8C")]
	[Address(RVA = "0x2636374", Offset = "0x2636374", VA = "0x2636374")]
	private Vector3 ProcessRotation()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x601AC8D")]
	[Address(RVA = "0x263677C", Offset = "0x263677C", VA = "0x263677C")]
	private void OnGUI()
	{
	}
}
