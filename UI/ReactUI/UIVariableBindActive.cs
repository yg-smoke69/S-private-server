using System.Collections;
using Il2CppDummyDll;
using UnityEngine;

namespace ReactUI;

[Token(Token = "0x2000CBD")]
public sealed class UIVariableBindActive : UIVariableBindBool
{
	[Token(Token = "0x2000CBE")]
	public enum TransitionModeEnum
	{
		[Token(Token = "0x4006799")]
		Instant,
		[Token(Token = "0x400679A")]
		Fade
	}

	[Token(Token = "0x4006796")]
	[FieldOffset(Offset = "0x28")]
	private TransitionModeEnum transitionMode;

	[Token(Token = "0x4006797")]
	[FieldOffset(Offset = "0x2C")]
	private float transitionTime;

	[Token(Token = "0x600611C")]
	[Address(RVA = "0x315E194", Offset = "0x315E194", VA = "0x315E194")]
	public UIVariableBindActive()
	{
	}

	[Token(Token = "0x600611D")]
	[Address(RVA = "0x315E228", Offset = "0x315E228", VA = "0x315E228", Slot = "10")]
	protected override void OnValueChanged()
	{
	}

	[Token(Token = "0x600611E")]
	[Address(RVA = "0x315E4C8", Offset = "0x315E4C8", VA = "0x315E4C8")]
	private IEnumerator Tween_FadeCanvas(CanvasGroup P_0, float P_1, bool P_2)
	{
		return null;
	}
}
