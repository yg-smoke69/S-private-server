using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x200211B")]
public class UIHDDisplayInputHandler : MonoBehaviour
{
	[Token(Token = "0x200211C")]
	private enum MouseButton
	{
		[Token(Token = "0x400CF6D")]
		Left,
		[Token(Token = "0x400CF6E")]
		Right,
		[Token(Token = "0x400CF6F")]
		Middle,
		[Token(Token = "0x400CF70")]
		None
	}

	[Token(Token = "0x200211D")]
	public enum ERotateAxis
	{
		[Token(Token = "0x400CF72")]
		X,
		[Token(Token = "0x400CF73")]
		Y,
		[Token(Token = "0x400CF74")]
		Z
	}

	[Token(Token = "0x400CF62")]
	[FieldOffset(Offset = "0xC")]
	public float PanMovementSensitivity;

	[Token(Token = "0x400CF63")]
	[FieldOffset(Offset = "0x10")]
	public float RotateSensitivity;

	[Token(Token = "0x400CF64")]
	[FieldOffset(Offset = "0x14")]
	public float CurrentPanAngle;

	[Token(Token = "0x400CF65")]
	[FieldOffset(Offset = "0x18")]
	private Vector2 lastTouchPos;

	[Token(Token = "0x400CF66")]
	[FieldOffset(Offset = "0x20")]
	private UIHDStandLobbyManager.HDLobbyState m_LobbyState;

	[Token(Token = "0x400CF67")]
	[FieldOffset(Offset = "0x24")]
	private bool m_AutoRotateSwitchOn;

	[Token(Token = "0x400CF68")]
	[FieldOffset(Offset = "0x28")]
	private float m_AutoRotateSpeed;

	[Token(Token = "0x400CF69")]
	[FieldOffset(Offset = "0x2C")]
	private ERotateAxis m_RotateAxis;

	[Token(Token = "0x400CF6A")]
	[FieldOffset(Offset = "0x30")]
	private bool m_AutoRotateOn;

	[Token(Token = "0x400CF6B")]
	[FieldOffset(Offset = "0x31")]
	private bool m_IsFingerDown;

	[Token(Token = "0x600AD51")]
	[Address(RVA = "0x202ACA4", Offset = "0x202ACA4", VA = "0x202ACA4")]
	public UIHDDisplayInputHandler()
	{
	}

	[Token(Token = "0x600AD52")]
	[Address(RVA = "0x202AD68", Offset = "0x202AD68", VA = "0x202AD68")]
	public void SetData(UIHDStandLobbyManager.HDLobbyState lobbyState, bool autoRotateSwitchOn, bool autoRotateOn, float autoRotateSpeed, ERotateAxis axis)
	{
	}

	[Token(Token = "0x600AD53")]
	[Address(RVA = "0x202AE28", Offset = "0x202AE28", VA = "0x202AE28")]
	private void OnDisplayObjectAutoRotateChanged(object[] data)
	{
	}

	[Token(Token = "0x600AD54")]
	[Address(RVA = "0x202AF44", Offset = "0x202AF44", VA = "0x202AF44")]
	private void Start()
	{
	}

	[Token(Token = "0x600AD55")]
	[Address(RVA = "0x202B39C", Offset = "0x202B39C", VA = "0x202B39C")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x600AD56")]
	[Address(RVA = "0x202B874", Offset = "0x202B874", VA = "0x202B874")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x600AD57")]
	[Address(RVA = "0x202BE9C", Offset = "0x202BE9C", VA = "0x202BE9C")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x600AD58")]
	[Address(RVA = "0x202C004", Offset = "0x202C004", VA = "0x202C004")]
	private void FingerUp(LeanFinger finger)
	{
	}

	[Token(Token = "0x600AD59")]
	[Address(RVA = "0x202C144", Offset = "0x202C144", VA = "0x202C144")]
	private void Update()
	{
	}

	[Token(Token = "0x600AD5A")]
	[Address(RVA = "0x202C254", Offset = "0x202C254", VA = "0x202C254")]
	private void AutoRotateOneFrame()
	{
	}

	[Token(Token = "0x600AD5B")]
	[Address(RVA = "0x202C33C", Offset = "0x202C33C", VA = "0x202C33C")]
	public void SaveCurrentPanAngle(float angle)
	{
	}

	[Token(Token = "0x600AD5C")]
	[Address(RVA = "0x202BC88", Offset = "0x202BC88", VA = "0x202BC88")]
	private void RotateItem()
	{
	}

	[Token(Token = "0x600AD5D")]
	[Address(RVA = "0x202BB10", Offset = "0x202BB10", VA = "0x202BB10")]
	public bool CheckOnUIClick()
	{
		return default(bool);
	}
}
