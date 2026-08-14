using System;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Serializable]
[Token(Token = "0x2000987")]
public class ActSkillPhaseConfig
{
	[Token(Token = "0x4005887")]
	[FieldOffset(Offset = "0x8")]
	public APEFHKOKAIJ PhaseType;

	[Token(Token = "0x4005888")]
	[FieldOffset(Offset = "0xC")]
	public bool m_IsFinishingPhase;

	[Token(Token = "0x4005889")]
	[FieldOffset(Offset = "0x10")]
	public float m_MoveSpeedScale;

	[Token(Token = "0x400588A")]
	[FieldOffset(Offset = "0x14")]
	public float m_PhaseDuration;

	[Token(Token = "0x400588B")]
	[FieldOffset(Offset = "0x18")]
	public string m_AnimName;

	[Token(Token = "0x400588C")]
	[FieldOffset(Offset = "0x1C")]
	public string m_CustomParams;

	[Token(Token = "0x400588D")]
	[FieldOffset(Offset = "0x20")]
	public bool m_IsSetAutoNextPhaseManually;

	[Token(Token = "0x400588E")]
	[FieldOffset(Offset = "0x24")]
	public int m_AutoNextPhaseIndex;

	[Token(Token = "0x400588F")]
	[FieldOffset(Offset = "0x28")]
	public bool m_IsSupportCombo;

	[Token(Token = "0x4005890")]
	[FieldOffset(Offset = "0x2C")]
	public int m_ComboNextPhaseIndex;

	[Token(Token = "0x4005891")]
	[FieldOffset(Offset = "0x30")]
	public float m_ComboTriggerStartTime;

	[Token(Token = "0x4005892")]
	[FieldOffset(Offset = "0x34")]
	public float m_comboTriggerEndTime;

	[Token(Token = "0x4005893")]
	[FieldOffset(Offset = "0x38")]
	public bool IsUseSkillAutoMove;

	[Token(Token = "0x4005894")]
	[FieldOffset(Offset = "0x3C")]
	public float AutoMoveMAXSpeed;

	[Token(Token = "0x4005895")]
	[FieldOffset(Offset = "0x40")]
	public AnimationCurve AutoMoveSpeedCurve;

	[Token(Token = "0x4005896")]
	[FieldOffset(Offset = "0x44")]
	public float AutoMoveMAXSpeedY;

	[Token(Token = "0x4005897")]
	[FieldOffset(Offset = "0x48")]
	public AnimationCurve AutoMoveSpeedYCurve;

	[Token(Token = "0x60048C8")]
	[Address(RVA = "0x11341B8", Offset = "0x11341B8", VA = "0x11341B8")]
	public ActSkillPhaseConfig()
	{
	}
}
