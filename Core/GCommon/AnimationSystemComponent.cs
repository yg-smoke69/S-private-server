using Il2CppDummyDll;
using UnityEngine;

namespace GCommon;

[Token(Token = "0x2003ED4")]
public class AnimationSystemComponent : MonoBehaviour
{
	[Token(Token = "0x2003ED5")]
	public delegate void AnimationComponentPlay(AnimationID animID);

	[Token(Token = "0x401A876")]
	private const uint MAX_ANIM_LAYER_NB = 8u;

	[Token(Token = "0x401A877")]
	[FieldOffset(Offset = "0xC")]
	protected Animator m_defaultAnimator;

	[Token(Token = "0x401A878")]
	[FieldOffset(Offset = "0x10")]
	protected Animator m_Animator;

	[Token(Token = "0x401A879")]
	[FieldOffset(Offset = "0x14")]
	protected AnimationRuntimeHandle[] m_CurrentHandles;

	[Token(Token = "0x401A87A")]
	[FieldOffset(Offset = "0x18")]
	protected AnimationID[] m_DefaultAnims;

	[Token(Token = "0x401A87B")]
	[FieldOffset(Offset = "0x1C")]
	protected AnimatorCullingMode m_defaultCullingMode;

	[Token(Token = "0x401A87C")]
	[FieldOffset(Offset = "0x20")]
	private int m_SwitchAnimationControllTickCount;

	[Token(Token = "0x401A87D")]
	[FieldOffset(Offset = "0x0")]
	private static uint uniqueIndex;

	[Token(Token = "0x401A87E")]
	[FieldOffset(Offset = "0x24")]
	public AnimationComponentPlay OnAnimationComponentPlayCall;

	[Token(Token = "0x6019931")]
	[Address(RVA = "0x26B6244", Offset = "0x26B6244", VA = "0x26B6244")]
	public AnimationSystemComponent()
	{
	}

	[Token(Token = "0x6019932")]
	[Address(RVA = "0x26B624C", Offset = "0x26B624C", VA = "0x26B624C", Slot = "4")]
	protected virtual uint GetMaxLayerUsed()
	{
		return default(uint);
	}

	[Token(Token = "0x6019933")]
	[Address(RVA = "0x26B6254", Offset = "0x26B6254", VA = "0x26B6254", Slot = "5")]
	public virtual AnimationRuntimeHandle PlayAnim(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false)
	{
		return null;
	}

	[Token(Token = "0x6019934")]
	public AnimationRuntimeHandle PlayAnim<T>(AnimationID animID, bool canTransitionToSelf = false, float noramlized_time = 0f, bool useInstantSwitch = false, bool loop = false) where T : AnimationRuntimeHandle, new()
	{
		return null;
	}

	[Token(Token = "0x6019935")]
	[Address(RVA = "0x26B62EC", Offset = "0x26B62EC", VA = "0x26B62EC")]
	public void AddDefaultState(AnimationID animID)
	{
	}

	[Token(Token = "0x6019936")]
	[Address(RVA = "0x26B6368", Offset = "0x26B6368", VA = "0x26B6368")]
	public bool IsPlaying(AnimationID animID)
	{
		return default(bool);
	}

	[Token(Token = "0x6019937")]
	[Address(RVA = "0x26B64D8", Offset = "0x26B64D8", VA = "0x26B64D8")]
	public AnimationRuntimeHandle GetCurrentRunningHandlerByAnimId(AnimationID animID)
	{
		return null;
	}

	[Token(Token = "0x6019938")]
	[Address(RVA = "0x26B64EC", Offset = "0x26B64EC", VA = "0x26B64EC")]
	public AnimationID GetCurrentAnimID(int layerIndex)
	{
		return default(AnimationID);
	}

	[Token(Token = "0x6019939")]
	[Address(RVA = "0x26B65D0", Offset = "0x26B65D0", VA = "0x26B65D0")]
	public bool CanInterrupted()
	{
		return default(bool);
	}

	[Token(Token = "0x601993A")]
	[Address(RVA = "0x26B6688", Offset = "0x26B6688", VA = "0x26B6688")]
	public bool CanInterrupted(int layerIndex)
	{
		return default(bool);
	}

	[Token(Token = "0x601993B")]
	[Address(RVA = "0x26B66B4", Offset = "0x26B66B4", VA = "0x26B66B4")]
	public void TransitionAllLayerToDefaultState()
	{
	}

	[Token(Token = "0x601993C")]
	[Address(RVA = "0x26B6724", Offset = "0x26B6724", VA = "0x26B6724")]
	public void TransitionToDefaultState(int layerIndex)
	{
	}

	[Token(Token = "0x601993D")]
	[Address(RVA = "0x26B6734", Offset = "0x26B6734", VA = "0x26B6734")]
	public void PauseAnimation()
	{
	}

	[Token(Token = "0x601993E")]
	[Address(RVA = "0x26B6800", Offset = "0x26B6800", VA = "0x26B6800")]
	private void SwitchAnimControllerImpl(RuntimeAnimatorController runCtrl)
	{
	}

	[Token(Token = "0x601993F")]
	[Address(RVA = "0x26B6A64", Offset = "0x26B6A64", VA = "0x26B6A64", Slot = "6")]
	public virtual void SwitchAnimController(RuntimeAnimatorController runCtrl)
	{
	}

	[Token(Token = "0x6019940")]
	[Address(RVA = "0x26B6A80", Offset = "0x26B6A80", VA = "0x26B6A80")]
	public void SwitchDynamicAnimController(RuntimeAnimatorController runCtrl)
	{
	}

	[Token(Token = "0x6019941")]
	[Address(RVA = "0x26B5C74", Offset = "0x26B5C74", VA = "0x26B5C74")]
	internal void SetAnimationFinished(AnimationID animID, bool autoTransitionToDefaultState)
	{
	}

	[Token(Token = "0x6019942")]
	[Address(RVA = "0x26B6A84", Offset = "0x26B6A84", VA = "0x26B6A84", Slot = "7")]
	protected virtual void BeforeTransitionToDefaultStateAfterFinish()
	{
	}

	[Token(Token = "0x6019943")]
	[Address(RVA = "0x26B6A88", Offset = "0x26B6A88", VA = "0x26B6A88", Slot = "8")]
	protected virtual void OnTransitionToDefaultState(int layerIndex)
	{
	}

	[Token(Token = "0x6019944")]
	[Address(RVA = "0x26B641C", Offset = "0x26B641C", VA = "0x26B641C")]
	public AnimationRuntimeHandle GetCurrentRunningHandler(int layerIndex)
	{
		return null;
	}

	[Token(Token = "0x6019945")]
	[Address(RVA = "0x26B6774", Offset = "0x26B6774", VA = "0x26B6774")]
	public bool HasAnimator()
	{
		return default(bool);
	}

	[Token(Token = "0x6019946")]
	protected virtual T PlayAnimInternal<T>(AnimationConfigData data, bool useInstantSwitch, float normalized_time = 0f, bool loop = false) where T : AnimationRuntimeHandle, new()
	{
		return null;
	}

	[Token(Token = "0x6019947")]
	[Address(RVA = "0x26B6B30", Offset = "0x26B6B30", VA = "0x26B6B30", Slot = "10")]
	protected virtual void Awake()
	{
	}

	[Token(Token = "0x6019948")]
	[Address(RVA = "0x26B5BFC", Offset = "0x26B5BFC", VA = "0x26B5BFC")]
	public AnimatorStateInfo GetCurrentAnimatorStateInfo(int layer)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(AnimatorStateInfo);
	}

	[Token(Token = "0x6019949")]
	[Address(RVA = "0x26B6D78", Offset = "0x26B6D78", VA = "0x26B6D78")]
	protected void UpdateCheckEnding()
	{
	}

	[Token(Token = "0x601994A")]
	[Address(RVA = "0x26B6E80", Offset = "0x26B6E80", VA = "0x26B6E80", Slot = "11")]
	public virtual void EnableAnimator(bool enabled)
	{
	}
}
