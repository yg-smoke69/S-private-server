using COW;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

[Token(Token = "0x2001FC8")]
public class UIAvatarInputHandler : MonoBehaviour
{
	[Token(Token = "0x2001FC9")]
	private enum MouseButton
	{
		[Token(Token = "0x400C766")]
		Left,
		[Token(Token = "0x400C767")]
		Right,
		[Token(Token = "0x400C768")]
		Middle,
		[Token(Token = "0x400C769")]
		None
	}

	[Token(Token = "0x400C756")]
	[FieldOffset(Offset = "0xC")]
	public float PanMovementSensitivity;

	[Token(Token = "0x400C757")]
	[FieldOffset(Offset = "0x10")]
	public float RotateSensitivity;

	[Token(Token = "0x400C758")]
	[FieldOffset(Offset = "0x14")]
	public bool UseReference;

	[Token(Token = "0x400C759")]
	[FieldOffset(Offset = "0x18")]
	public Vector3 ReferencePoint;

	[Token(Token = "0x400C75A")]
	[FieldOffset(Offset = "0x24")]
	private float CurrentPanAngle;

	[Token(Token = "0x400C75B")]
	[FieldOffset(Offset = "0x28")]
	private Vector2 lastTouchPos;

	[Token(Token = "0x400C75C")]
	[FieldOffset(Offset = "0x30")]
	private Vector2 tempLastTouchPos;

	[Token(Token = "0x400C75D")]
	[FieldOffset(Offset = "0x38")]
	public bool InputEnable;

	[Token(Token = "0x400C75E")]
	[FieldOffset(Offset = "0x39")]
	public bool IngoreUICheck;

	[Token(Token = "0x400C75F")]
	private const string TargetAreaName = "AvatarRotateTouchArea";

	[Token(Token = "0x400C760")]
	[FieldOffset(Offset = "0x3C")]
	private UIMaleAvatar m_avatar;

	[Token(Token = "0x400C761")]
	[FieldOffset(Offset = "0x40")]
	public HangManager hang;

	[Token(Token = "0x400C762")]
	[FieldOffset(Offset = "0x44")]
	private Camera m_InputDetectCamera;

	[Token(Token = "0x400C763")]
	[FieldOffset(Offset = "0x48")]
	public float hangWindPower;

	[Token(Token = "0x400C764")]
	[FieldOffset(Offset = "0x4C")]
	private bool EnableInHDStandLobby;

	[Token(Token = "0x17000FAA")]
	public Camera InputDetectCamera
	{
		[Token(Token = "0x6009EE2")]
		[Address(RVA = "0x264AA40", Offset = "0x264AA40", VA = "0x264AA40")]
		private get
		{
			return null;
		}
		[Token(Token = "0x6009EE3")]
		[Address(RVA = "0x264AB7C", Offset = "0x264AB7C", VA = "0x264AB7C")]
		set
		{
		}
	}

	[Token(Token = "0x6009EE1")]
	[Address(RVA = "0x264A94C", Offset = "0x264A94C", VA = "0x264A94C")]
	public UIAvatarInputHandler()
	{
	}

	[Token(Token = "0x6009EE4")]
	[Address(RVA = "0x264AB84", Offset = "0x264AB84", VA = "0x264AB84")]
	public void SetAvatar(UIMaleAvatar ava)
	{
	}

	[Token(Token = "0x6009EE5")]
	[Address(RVA = "0x264AB8C", Offset = "0x264AB8C", VA = "0x264AB8C")]
	private bool CheckCanMove()
	{
		return default(bool);
	}

	[Token(Token = "0x6009EE6")]
	[Address(RVA = "0x264AC4C", Offset = "0x264AC4C", VA = "0x264AC4C")]
	private void Start()
	{
	}

	[Token(Token = "0x6009EE7")]
	[Address(RVA = "0x264AF94", Offset = "0x264AF94", VA = "0x264AF94")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6009EE8")]
	[Address(RVA = "0x264B35C", Offset = "0x264B35C", VA = "0x264B35C")]
	public void SetLastTouchPos(object[] data)
	{
	}

	[Token(Token = "0x6009EE9")]
	[Address(RVA = "0x264B378", Offset = "0x264B378", VA = "0x264B378")]
	public void SetUseReference(bool reference, Vector3 point)
	{
	}

	[Token(Token = "0x6009EEA")]
	[Address(RVA = "0x264B38C", Offset = "0x264B38C", VA = "0x264B38C")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x6009EEB")]
	[Address(RVA = "0x264BA90", Offset = "0x264BA90", VA = "0x264BA90")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x6009EEC")]
	[Address(RVA = "0x264BF9C", Offset = "0x264BF9C", VA = "0x264BF9C")]
	private void Update()
	{
	}

	[Token(Token = "0x6009EED")]
	[Address(RVA = "0x264B660", Offset = "0x264B660", VA = "0x264B660")]
	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6009EEE")]
	[Address(RVA = "0x264B7D0", Offset = "0x264B7D0", VA = "0x264B7D0")]
	private void RotateAvatar(float angle, float angledelta = 0f)
	{
	}

	[Token(Token = "0x6009EEF")]
	[Address(RVA = "0x264C158", Offset = "0x264C158", VA = "0x264C158")]
	public void ResetPreviewAvatar()
	{
	}

	[Token(Token = "0x6009EF0")]
	[Address(RVA = "0x264C18C", Offset = "0x264C18C", VA = "0x264C18C")]
	public void SetAvatarRotation(float rotateY)
	{
	}

	[Token(Token = "0x6009EF1")]
	[Address(RVA = "0x264C29C", Offset = "0x264C29C", VA = "0x264C29C")]
	public void ResetAvatarRatation(float angle)
	{
	}

	[Token(Token = "0x6009EF2")]
	[Address(RVA = "0x264C408", Offset = "0x264C408", VA = "0x264C408")]
	public void ResetAvatarRotation()
	{
	}

	[Token(Token = "0x6009EF3")]
	[Address(RVA = "0x264C50C", Offset = "0x264C50C", VA = "0x264C50C")]
	public void ResetAvatarInput()
	{
	}

	[Token(Token = "0x6009EF4")]
	[Address(RVA = "0x264C688", Offset = "0x264C688", VA = "0x264C688")]
	public float GetCurrentPanAngle()
	{
		return default(float);
	}

	[Token(Token = "0x6009EF5")]
	[Address(RVA = "0x264BC10", Offset = "0x264BC10", VA = "0x264BC10")]
	private bool CheckIsTouchAvatar(Vector2 touchPos)
	{
		return default(bool);
	}

	[Token(Token = "0x6009EF6")]
	[Address(RVA = "0x264BEDC", Offset = "0x264BEDC", VA = "0x264BEDC")]
	private void OnTouchAvatar()
	{
	}

	[Token(Token = "0x6009EF7")]
	[Address(RVA = "0x264BFA0", Offset = "0x264BFA0", VA = "0x264BFA0")]
	public void FluxWindSet()
	{
	}
}
