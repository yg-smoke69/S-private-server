using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW;

[Token(Token = "0x200299F")]
internal class UIMaskController : UIBaseController
{
	[Token(Token = "0x20029A0")]
	private enum EAnimStep
	{
		[Token(Token = "0x401002C")]
		AnimStep_Finished,
		[Token(Token = "0x401002D")]
		AnimStep_FirstChange,
		[Token(Token = "0x401002E")]
		AnimStep_Stable,
		[Token(Token = "0x401002F")]
		AnimStep_SecondChange
	}

	[Token(Token = "0x401001F")]
	[FieldOffset(Offset = "0x28")]
	private UIMaskView m_View;

	[Token(Token = "0x4010020")]
	[FieldOffset(Offset = "0x2C")]
	private float m_CurAnimStepChangeDuration;

	[Token(Token = "0x4010021")]
	[FieldOffset(Offset = "0x30")]
	private float m_FadeDuration;

	[Token(Token = "0x4010022")]
	[FieldOffset(Offset = "0x34")]
	private float m_LightDuration;

	[Token(Token = "0x4010023")]
	[FieldOffset(Offset = "0x38")]
	private float m_AnimStableDuration;

	[Token(Token = "0x4010024")]
	[FieldOffset(Offset = "0x3C")]
	private EMaskAnimType m_AnimType;

	[Token(Token = "0x4010025")]
	[FieldOffset(Offset = "0x40")]
	private bool m_isAnimFinsihDisableMask;

	[Token(Token = "0x4010026")]
	[FieldOffset(Offset = "0x44")]
	private float m_AnimChangeTimePass;

	[Token(Token = "0x4010027")]
	[FieldOffset(Offset = "0x48")]
	private float m_AnimStableTimePass;

	[Token(Token = "0x4010028")]
	[FieldOffset(Offset = "0x4C")]
	private EAnimStep m_AnimStep;

	[Token(Token = "0x4010029")]
	[FieldOffset(Offset = "0x50")]
	private Color m_LerpBeginAnimColor;

	[Token(Token = "0x401002A")]
	[FieldOffset(Offset = "0x60")]
	private Color m_LerpEndAnimColor;

	[Token(Token = "0x6010B83")]
	[Address(RVA = "0x2814278", Offset = "0x2814278", VA = "0x2814278")]
	public UIMaskController()
	{
	}

	[Token(Token = "0x6010B84")]
	[Address(RVA = "0x2814348", Offset = "0x2814348", VA = "0x2814348")]
	public static ResourceID GetResourceID()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6010B85")]
	[Address(RVA = "0x28143EC", Offset = "0x28143EC", VA = "0x28143EC", Slot = "13")]
	protected override void OnUIInit()
	{
	}

	[Token(Token = "0x6010B86")]
	[Address(RVA = "0x28144A8", Offset = "0x28144A8", VA = "0x28144A8")]
	public void SetMask(bool enabled)
	{
	}

	[Token(Token = "0x6010B87")]
	[Address(RVA = "0x2814560", Offset = "0x2814560", VA = "0x2814560")]
	public void SetMaskColor(Color color)
	{
	}

	[Token(Token = "0x6010B88")]
	[Address(RVA = "0x2814628", Offset = "0x2814628", VA = "0x2814628")]
	public void BeginMaskAnim(EMaskAnimType maskAnimType, bool isAnimFinsihDisableMask, float fadeDuration, float lightDuration, float stableDuration = 0f)
	{
	}

	[Token(Token = "0x6010B89")]
	[Address(RVA = "0x2814928", Offset = "0x2814928", VA = "0x2814928")]
	private bool IsTwiceChangeAnim()
	{
		return default(bool);
	}

	[Token(Token = "0x6010B8A")]
	[Address(RVA = "0x2814998", Offset = "0x2814998", VA = "0x2814998")]
	private bool IsCurFadeChange()
	{
		return default(bool);
	}

	[Token(Token = "0x6010B8B")]
	[Address(RVA = "0x2814A4C", Offset = "0x2814A4C", VA = "0x2814A4C")]
	private bool IsCurLightChange()
	{
		return default(bool);
	}

	[Token(Token = "0x6010B8C")]
	[Address(RVA = "0x28147E8", Offset = "0x28147E8", VA = "0x28147E8")]
	private void InitCurChangeAnimStep()
	{
	}

	[Token(Token = "0x6010B8D")]
	[Address(RVA = "0x2814B00", Offset = "0x2814B00", VA = "0x2814B00")]
	private void Update()
	{
	}

	[Token(Token = "0x6010B8E")]
	[Address(RVA = "0x2814B60", Offset = "0x2814B60", VA = "0x2814B60")]
	private void UpdateAnim()
	{
	}

	[Token(Token = "0x6010B8F")]
	[Address(RVA = "0x2814C90", Offset = "0x2814C90", VA = "0x2814C90")]
	private void UpdateChangeAnim()
	{
	}

	[Token(Token = "0x6010B90")]
	[Address(RVA = "0x2814E80", Offset = "0x2814E80", VA = "0x2814E80")]
	private void OnChangeAnimEnd()
	{
	}

	[Token(Token = "0x6010B91")]
	[Address(RVA = "0x2814BF4", Offset = "0x2814BF4", VA = "0x2814BF4")]
	private void UpdateStableAnim()
	{
	}

	[Token(Token = "0x6010B92")]
	[Address(RVA = "0x2814FD4", Offset = "0x2814FD4", VA = "0x2814FD4")]
	private void OnStableAnimEnd()
	{
	}

	[Token(Token = "0x6010B93")]
	[Address(RVA = "0x2814F0C", Offset = "0x2814F0C", VA = "0x2814F0C")]
	private void OnAnimFinished()
	{
	}

	[Token(Token = "0x6010B94")]
	[Address(RVA = "0x281503C", Offset = "0x281503C", VA = "0x281503C")]
	public void _003C_003EiFixBaseProxy_OnUIInit()
	{
	}
}
