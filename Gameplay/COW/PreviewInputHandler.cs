using System.Collections.Generic;
using Il2CppDummyDll;
using Lean.Touch;
using UnityEngine;

namespace COW;

[Token(Token = "0x2000A32")]
public class PreviewInputHandler : MonoBehaviour
{
	[Token(Token = "0x2000A33")]
	private enum MouseButton
	{
		[Token(Token = "0x4005B40")]
		Left,
		[Token(Token = "0x4005B41")]
		Right,
		[Token(Token = "0x4005B42")]
		Middle,
		[Token(Token = "0x4005B43")]
		None
	}

	[Token(Token = "0x4005B3A")]
	[FieldOffset(Offset = "0xC")]
	private float RotateSensitivity;

	[Token(Token = "0x4005B3B")]
	[FieldOffset(Offset = "0x10")]
	private float CurrentPanAngle;

	[Token(Token = "0x4005B3C")]
	[FieldOffset(Offset = "0x14")]
	private Vector2 lastTouchPos;

	[Token(Token = "0x4005B3D")]
	[FieldOffset(Offset = "0x1C")]
	private bool InputEnable;

	[Token(Token = "0x4005B3E")]
	[FieldOffset(Offset = "0x20")]
	public List<GameObject> m_PreviewTransList;

	[Token(Token = "0x6004F75")]
	[Address(RVA = "0x195AFC4", Offset = "0x195AFC4", VA = "0x195AFC4")]
	public PreviewInputHandler()
	{
	}

	[Token(Token = "0x6004F76")]
	[Address(RVA = "0x195B070", Offset = "0x195B070", VA = "0x195B070")]
	public void SetPreviewInputEnable(bool flag)
	{
	}

	[Token(Token = "0x6004F77")]
	[Address(RVA = "0x195B0D0", Offset = "0x195B0D0", VA = "0x195B0D0")]
	private void Start()
	{
	}

	[Token(Token = "0x6004F78")]
	[Address(RVA = "0x195B394", Offset = "0x195B394", VA = "0x195B394")]
	private void OnDestroy()
	{
	}

	[Token(Token = "0x6004F79")]
	[Address(RVA = "0x195B6D8", Offset = "0x195B6D8", VA = "0x195B6D8")]
	private void FingerSet(LeanFinger finger)
	{
	}

	[Token(Token = "0x6004F7A")]
	[Address(RVA = "0x195BCB4", Offset = "0x195BCB4", VA = "0x195BCB4")]
	private void FingerDown(LeanFinger finger)
	{
	}

	[Token(Token = "0x6004F7B")]
	[Address(RVA = "0x195B840", Offset = "0x195B840", VA = "0x195B840")]
	public static bool IsOverGUIElements(Vector2 screenPosition)
	{
		return default(bool);
	}

	[Token(Token = "0x6004F7C")]
	[Address(RVA = "0x195B9A8", Offset = "0x195B9A8", VA = "0x195B9A8")]
	private void RotateList(float angle, float angledelta = 0f)
	{
	}

	[Token(Token = "0x6004F7D")]
	[Address(RVA = "0x195BD40", Offset = "0x195BD40", VA = "0x195BD40")]
	private void Update()
	{
	}
}
