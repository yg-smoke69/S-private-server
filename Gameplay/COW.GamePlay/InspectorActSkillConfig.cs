using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x2000988")]
public class InspectorActSkillConfig : ScriptableObject
{
	[Token(Token = "0x4005898")]
	[FieldOffset(Offset = "0xC")]
	public KBJIDDDPPOO m_SkillType;

	[Token(Token = "0x4005899")]
	[FieldOffset(Offset = "0x10")]
	public bool m_IsComboInputSkill;

	[Token(Token = "0x400589A")]
	[FieldOffset(Offset = "0x11")]
	public bool m_IsForceCastSkill;

	[Token(Token = "0x400589B")]
	[FieldOffset(Offset = "0x14")]
	public float m_CoolDown;

	[Token(Token = "0x400589C")]
	[FieldOffset(Offset = "0x18")]
	public bool m_IsLockPlayerMove;

	[Token(Token = "0x400589D")]
	[FieldOffset(Offset = "0x19")]
	public bool m_IsLockPlayerJump;

	[Token(Token = "0x400589E")]
	[FieldOffset(Offset = "0x1A")]
	public bool IsLockAimRotationUpdate;

	[Token(Token = "0x400589F")]
	[FieldOffset(Offset = "0x1B")]
	public bool IsForwardFollowAimRot;

	[Token(Token = "0x40058A0")]
	[FieldOffset(Offset = "0x1C")]
	public bool IsFowardFollowMoveDirection;

	[Token(Token = "0x40058A1")]
	[FieldOffset(Offset = "0x20")]
	public List<ActSkillPhaseConfig> m_PhaseConfig;

	[Token(Token = "0x60048C9")]
	[Address(RVA = "0x198F66C", Offset = "0x198F66C", VA = "0x198F66C")]
	public InspectorActSkillConfig()
	{
	}
}
