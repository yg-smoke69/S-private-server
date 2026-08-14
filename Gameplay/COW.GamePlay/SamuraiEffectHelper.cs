using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x200092E")]
public class SamuraiEffectHelper : MonoBehaviour
{
	[Token(Token = "0x4005540")]
	[FieldOffset(Offset = "0xC")]
	public List<PhaseEffectInfo> phaseEffectInfos;

	[Token(Token = "0x4005541")]
	[FieldOffset(Offset = "0x10")]
	public List<SkillEffectInfo> skillEffectsInfos;

	[Token(Token = "0x4005542")]
	[FieldOffset(Offset = "0x14")]
	public AIAttachEffects initDefaultActiveEffects;

	[Token(Token = "0x6004073")]
	[Address(RVA = "0x29B08D8", Offset = "0x29B08D8", VA = "0x29B08D8")]
	public SamuraiEffectHelper()
	{
	}

	[Token(Token = "0x6004074")]
	[Address(RVA = "0x29B08E0", Offset = "0x29B08E0", VA = "0x29B08E0")]
	public void SetDefault()
	{
	}

	[Token(Token = "0x6004075")]
	[Address(RVA = "0x29B0C1C", Offset = "0x29B0C1C", VA = "0x29B0C1C")]
	public void OnPhaseChange(int KPIAGKHAPOP)
	{
	}

	[Token(Token = "0x6004076")]
	[Address(RVA = "0x29B0DD8", Offset = "0x29B0DD8", VA = "0x29B0DD8")]
	public void OnSkillPhaseEnter(GDEHAFJBPGE KPIAGKHAPOP, OPKPPFDNCMC GEPIPPKAIBK)
	{
	}

	[Token(Token = "0x6004077")]
	[Address(RVA = "0x29B0944", Offset = "0x29B0944", VA = "0x29B0944")]
	private void BCLFDHBMCPJ(AIAttachEffects DNIGJEAOOFJ)
	{
	}
}
