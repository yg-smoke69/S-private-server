using Il2CppDummyDll;
using UnityEngine;

[Token(Token = "0x200044B")]
public class UICutsceneBlackMask : MonoBehaviour
{
	[Token(Token = "0x200044C")]
	private enum EAnimStep
	{
		[Token(Token = "0x4003C66")]
		AnimStep_Finished,
		[Token(Token = "0x4003C67")]
		AnimStep_FirstChange,
		[Token(Token = "0x4003C68")]
		AnimStep_Stable,
		[Token(Token = "0x4003C69")]
		AnimStep_SecondChange
	}

	[Token(Token = "0x4003C5B")]
	[FieldOffset(Offset = "0xC")]
	public UISprite MaskSprite;

	[Token(Token = "0x4003C5C")]
	[FieldOffset(Offset = "0x10")]
	private float m_AnimChangeDuration;

	[Token(Token = "0x4003C5D")]
	[FieldOffset(Offset = "0x14")]
	private float m_AnimStableDuration;

	[Token(Token = "0x4003C5E")]
	[FieldOffset(Offset = "0x18")]
	private EMaskAnimType m_AnimType;

	[Token(Token = "0x4003C5F")]
	[FieldOffset(Offset = "0x1C")]
	private bool m_isAnimFinsihDisableMask;

	[Token(Token = "0x4003C60")]
	[FieldOffset(Offset = "0x20")]
	private float m_AnimChangeTimePass;

	[Token(Token = "0x4003C61")]
	[FieldOffset(Offset = "0x24")]
	private float m_AnimStableTimePass;

	[Token(Token = "0x4003C62")]
	[FieldOffset(Offset = "0x28")]
	private EAnimStep m_AnimStep;

	[Token(Token = "0x4003C63")]
	[FieldOffset(Offset = "0x2C")]
	private Color m_LerpBeginAnimColor;

	[Token(Token = "0x4003C64")]
	[FieldOffset(Offset = "0x3C")]
	private Color m_LerpEndAnimColor;

	[Token(Token = "0x6001579")]
	[Address(RVA = "0x146C898", Offset = "0x146C898", VA = "0x146C898")]
	public UICutsceneBlackMask()
	{
	}

	[Token(Token = "0x600157A")]
	[Address(RVA = "0x146C900", Offset = "0x146C900", VA = "0x146C900")]
	public void SetMaskColor(Color color)
	{
	}

	[Token(Token = "0x600157B")]
	[Address(RVA = "0x146C958", Offset = "0x146C958", VA = "0x146C958")]
	public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float changeDuration, float stableDuration = 0f)
	{
	}

	[Token(Token = "0x600157C")]
	[Address(RVA = "0x146CBB4", Offset = "0x146CBB4", VA = "0x146CBB4")]
	private bool IsTwiceChangeAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x600157D")]
	[Address(RVA = "0x146CBCC", Offset = "0x146CBCC", VA = "0x146CBCC")]
	private bool IsCurFadeChange()
	{
		return default(bool);
	}

	[Token(Token = "0x600157E")]
	[Address(RVA = "0x146CC2C", Offset = "0x146CC2C", VA = "0x146CC2C")]
	private bool IsCurLightChange()
	{
		return default(bool);
	}

	[Token(Token = "0x600157F")]
	[Address(RVA = "0x146CA7C", Offset = "0x146CA7C", VA = "0x146CA7C")]
	private void InitCurChangeAnimStep()
	{
	}

	[Token(Token = "0x6001580")]
	[Address(RVA = "0x146CC8C", Offset = "0x146CC8C", VA = "0x146CC8C")]
	private void Update()
	{
	}

	[Token(Token = "0x6001581")]
	[Address(RVA = "0x146CC90", Offset = "0x146CC90", VA = "0x146CC90")]
	private void UpdateAnim()
	{
	}

	[Token(Token = "0x6001582")]
	[Address(RVA = "0x146CD34", Offset = "0x146CD34", VA = "0x146CD34")]
	private void UpdateChangeAnim()
	{
	}

	[Token(Token = "0x6001583")]
	[Address(RVA = "0x146CEE0", Offset = "0x146CEE0", VA = "0x146CEE0")]
	private void OnChangeAnimEnd()
	{
	}

	[Token(Token = "0x6001584")]
	[Address(RVA = "0x146CCDC", Offset = "0x146CCDC", VA = "0x146CCDC")]
	private void UpdateStableAnim()
	{
	}

	[Token(Token = "0x6001585")]
	[Address(RVA = "0x146CF80", Offset = "0x146CF80", VA = "0x146CF80")]
	private void OnStableAnimEnd()
	{
	}

	[Token(Token = "0x6001586")]
	[Address(RVA = "0x146CF14", Offset = "0x146CF14", VA = "0x146CF14")]
	private void OnAnimFinished()
	{
	}
}
