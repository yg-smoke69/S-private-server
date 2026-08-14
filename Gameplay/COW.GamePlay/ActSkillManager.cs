using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x200097A")]
internal class ActSkillManager : MonoBehaviour
{
	[Token(Token = "0x4005866")]
	[FieldOffset(Offset = "0xC")]
	private bool _003CHFOKBJMILBN_003Ek__BackingField;

	[Token(Token = "0x4005867")]
	[FieldOffset(Offset = "0x10")]
	public List<BaseActSkillConfig> m_SkillConfig;

	[Token(Token = "0x4005868")]
	[FieldOffset(Offset = "0x14")]
	protected FDMPBIEMHAF NPEFBHLPGJG;

	[Token(Token = "0x4005869")]
	[FieldOffset(Offset = "0x18")]
	protected List<LMCDCKCIEJK> DPNPDAMCHDD;

	[Token(Token = "0x400586A")]
	[FieldOffset(Offset = "0x1C")]
	private bool EIJMOEOOPGJ;

	[Token(Token = "0x400586B")]
	[FieldOffset(Offset = "0x20")]
	private int FFOHGOFFJDB;

	[Token(Token = "0x170005A4")]
	public bool KLPACHKFNBD
	{
		[Token(Token = "0x600485D")]
		[Address(RVA = "0x11331C8", Offset = "0x11331C8", VA = "0x11331C8")]
		get
		{
			return default(bool);
		}
		[Token(Token = "0x600485E")]
		[Address(RVA = "0x11331D0", Offset = "0x11331D0", VA = "0x11331D0")]
		set
		{
		}
	}

	[Token(Token = "0x170005A5")]
	public FDMPBIEMHAF BOEJECEGHJI
	{
		[Token(Token = "0x600485F")]
		[Address(RVA = "0x11331D8", Offset = "0x11331D8", VA = "0x11331D8")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A6")]
	protected LMCDCKCIEJK IKCAJGCDIDC
	{
		[Token(Token = "0x6004860")]
		[Address(RVA = "0x1133230", Offset = "0x1133230", VA = "0x1133230")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005A7")]
	public bool MPGCANLMKED
	{
		[Token(Token = "0x6004861")]
		[Address(RVA = "0x11332F8", Offset = "0x11332F8", VA = "0x11332F8")]
		get
		{
			return default(bool);
		}
	}

	[Token(Token = "0x600485C")]
	[Address(RVA = "0x1133134", Offset = "0x1133134", VA = "0x1133134")]
	public ActSkillManager()
	{
	}

	[Token(Token = "0x6004862")]
	[Address(RVA = "0x1133364", Offset = "0x1133364", VA = "0x1133364")]
	public void InitSkill(FDMPBIEMHAF ADHJBCCFHKM)
	{
	}

	[Token(Token = "0x6004863")]
	[Address(RVA = "0x1133574", Offset = "0x1133574", VA = "0x1133574")]
	public void SetActive(bool EBMEPDAJPEM)
	{
	}

	[Token(Token = "0x6004864")]
	[Address(RVA = "0x11336A0", Offset = "0x11336A0", VA = "0x11336A0")]
	public void TryToCastSkillByIndex(int IJGMIEJFKBC, bool CBCGFJIADND = false)
	{
	}

	[Token(Token = "0x6004865")]
	[Address(RVA = "0x11338A8", Offset = "0x11338A8", VA = "0x11338A8")]
	protected bool ELGDICLCJIE(int IJGMIEJFKBC)
	{
		return default(bool);
	}

	[Token(Token = "0x6004866")]
	[Address(RVA = "0x11339E8", Offset = "0x11339E8", VA = "0x11339E8")]
	protected void EBJODMMNMFC()
	{
	}

	[Token(Token = "0x6004867")]
	[Address(RVA = "0x1133830", Offset = "0x1133830", VA = "0x1133830")]
	protected bool NELLNAOPNKK(int IJGMIEJFKBC)
	{
		return default(bool);
	}

	[Token(Token = "0x6004868")]
	[Address(RVA = "0x1133C28", Offset = "0x1133C28", VA = "0x1133C28")]
	protected void CPDGOIOCEBB(int IJGMIEJFKBC)
	{
	}

	[Token(Token = "0x6004869")]
	[Address(RVA = "0x1133600", Offset = "0x1133600", VA = "0x1133600")]
	public void ForceStopSkill()
	{
	}

	[Token(Token = "0x600486A")]
	[Address(RVA = "0x1133E14", Offset = "0x1133E14", VA = "0x1133E14")]
	public void FinishSkill()
	{
	}

	[Token(Token = "0x600486B")]
	[Address(RVA = "0x1133E74", Offset = "0x1133E74", VA = "0x1133E74")]
	public void UpdateSkill(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x600486C")]
	[Address(RVA = "0x1133CBC", Offset = "0x1133CBC", VA = "0x1133CBC")]
	public void OnSkillFinished()
	{
	}

	[Token(Token = "0x600486D")]
	[Address(RVA = "0x1133F4C", Offset = "0x1133F4C", VA = "0x1133F4C")]
	public bool OverriderUpdateOwnerKinematics(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
		return default(bool);
	}

	[Token(Token = "0x600486E")]
	[Address(RVA = "0x1134010", Offset = "0x1134010", VA = "0x1134010")]
	public bool CheckSkillCanCast(int IJGMIEJFKBC)
	{
		return default(bool);
	}
}
