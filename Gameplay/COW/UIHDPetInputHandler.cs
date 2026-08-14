using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2002128")]
public class UIHDPetInputHandler : MonoBehaviour
{
	[Token(Token = "0x2002129")]
	private enum MouseButton
	{
		[Token(Token = "0x400CFAD")]
		Left,
		[Token(Token = "0x400CFAE")]
		Right,
		[Token(Token = "0x400CFAF")]
		Middle,
		[Token(Token = "0x400CFB0")]
		None
	}

	[Token(Token = "0x400CFA4")]
	[FieldOffset(Offset = "0xC")]
	public float PanMovementSensitivity;

	[Token(Token = "0x400CFA5")]
	[FieldOffset(Offset = "0x10")]
	public float RotateSensitivity;

	[Token(Token = "0x400CFA6")]
	[FieldOffset(Offset = "0x14")]
	private float CurrentPanAngle;

	[Token(Token = "0x400CFA7")]
	[FieldOffset(Offset = "0x18")]
	private bool m_isTouched;

	[Token(Token = "0x400CFA8")]
	[FieldOffset(Offset = "0x1C")]
	private Vector2 lastTouchPos;

	[Token(Token = "0x400CFA9")]
	[FieldOffset(Offset = "0x24")]
	private Vector2 tempLastTouchPos;

	[Token(Token = "0x400CFAA")]
	[FieldOffset(Offset = "0x2C")]
	public bool InputEnable;

	[Token(Token = "0x400CFAB")]
	private const string TargetAreaName = "ItemRotateTouchArea";

	[Token(Token = "0x600ADAD")]
	[Address(RVA = "0x2034828", Offset = "0x2034828", VA = "0x2034828")]
	public UIHDPetInputHandler()
	{
	}

	[Token(Token = "0x600ADAE")]
	[Address(RVA = "0x2034904", Offset = "0x2034904", VA = "0x2034904")]
	private void Start()
	{
	}

	[Token(Token = "0x600ADAF")]
	[Address(RVA = "0x2034D48", Offset = "0x2034D48", VA = "0x2034D48")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600ADB0")]
	[Address(RVA = "0x203518C", Offset = "0x203518C", VA = "0x203518C")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADB1")]
	[Address(RVA = "0x2035AA4", Offset = "0x2035AA4", VA = "0x2035AA4")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADB2")]
	[Address(RVA = "0x2035EF8", Offset = "0x2035EF8", VA = "0x2035EF8")]
	private void FingerUp(LeanFinger finger)
	{
	}

	[Token(Token = "0x600ADB3")]
	[Address(RVA = "0x2035F78", Offset = "0x2035F78", VA = "0x2035F78")]
	private void Update()
	{
	}

	[Token(Token = "0x600ADB4")]
	[Address(RVA = "0x2035B70", Offset = "0x2035B70", VA = "0x2035B70")]
	public bool IsTargetArea(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x600ADB5")]
	[Address(RVA = "0x20357A8", Offset = "0x20357A8", VA = "0x20357A8")]
	private void RotateItem()
	{
	}

	[Token(Token = "0x600ADB6")]
	[Address(RVA = "0x2035FCC", Offset = "0x2035FCC", VA = "0x2035FCC")]
	public float GetCurrentPanAngle()
	{
		return default(float);
	}

	[Token(Token = "0x600ADB7")]
	[Address(RVA = "0x2036024", Offset = "0x2036024", VA = "0x2036024")]
	public void ResetPetRatation(float angle)
	{
	}

	[Token(Token = "0x600ADB8")]
	[Address(RVA = "0x2036094", Offset = "0x2036094", VA = "0x2036094")]
	public void EnableInput(bool v)
	{
	}

	[Token(Token = "0x600ADB9")]
	[Address(RVA = "0x20360F4", Offset = "0x20360F4", VA = "0x20360F4")]
	public void ResetPetInput()
	{
	}

	[Token(Token = "0x600ADBA")]
	[Address(RVA = "0x2035304", Offset = "0x2035304", VA = "0x2035304")]
	public bool CheckOnUIClick()
	{
		return default(bool);
	}
}
