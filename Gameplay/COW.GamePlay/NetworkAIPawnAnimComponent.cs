using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20003DE")]
internal class NetworkAIPawnAnimComponent : NetworkAIPawnAnimBaseComponent
{
	[Token(Token = "0x4003950")]
	[FieldOffset(Offset = "0x1C")]
	public List<AnimationClipInfo> AnimationClipInfos;

	[Token(Token = "0x4003951")]
	[FieldOffset(Offset = "0x20")]
	public List<SkillAnim> m_SkillAnimList;

	[Token(Token = "0x4003952")]
	[FieldOffset(Offset = "0x24")]
	private Dictionary<int, Dictionary<int, List<AnimationClip>>> KPOFGMNHGEG;

	[Token(Token = "0x4003953")]
	[FieldOffset(Offset = "0x28")]
	private Animation MBLMLLIJAIK;

	[Token(Token = "0x170001A0")]
	public override Animation GMLJAEMAFNO
	{
		[Token(Token = "0x600114B")]
		[Address(RVA = "0x17E8FB0", Offset = "0x17E8FB0", VA = "0x17E8FB0", Slot = "5")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x600114A")]
	[Address(RVA = "0x17E8EAC", Offset = "0x17E8EAC", VA = "0x17E8EAC")]
	public NetworkAIPawnAnimComponent()
	{
	}

	[Token(Token = "0x600114C")]
	[Address(RVA = "0x17E9008", Offset = "0x17E9008", VA = "0x17E9008", Slot = "4")]
	public override void Init(NetworkAIPawn FIMNKGABILM, [Optional] Animation CFGGELHHJLD, [Optional] Animator HLIOOJLOAGA)
	{
	}

	[Token(Token = "0x600114D")]
	[Address(RVA = "0x17EA2A4", Offset = "0x17EA2A4", VA = "0x17EA2A4")]
	private void HJFBMAJADIK()
	{
	}

	[Token(Token = "0x600114E")]
	[Address(RVA = "0x17EA4CC", Offset = "0x17EA4CC", VA = "0x17EA4CC")]
	private string HHDOOMBGMFO(BJDDKOAMBAP FKBFOJFNHOM)
	{
		return null;
	}

	[Token(Token = "0x600114F")]
	[Address(RVA = "0x17EA350", Offset = "0x17EA350", VA = "0x17EA350")]
	private AnimationClip MIBCABPHLJM(BJDDKOAMBAP FKBFOJFNHOM)
	{
		return null;
	}

	[Token(Token = "0x6001150")]
	[Address(RVA = "0x17E9364", Offset = "0x17E9364", VA = "0x17E9364")]
	private void FCJCGEKINIA()
	{
	}

	[Token(Token = "0x6001151")]
	[Address(RVA = "0x17EA688", Offset = "0x17EA688", VA = "0x17EA688", Slot = "14")]
	public override void UpdateAnimSpeed(float PHEJDNJONIL)
	{
	}

	[Token(Token = "0x6001152")]
	[Address(RVA = "0x17EA7C4", Offset = "0x17EA7C4", VA = "0x17EA7C4", Slot = "7")]
	public override void PlayAttack()
	{
	}

	[Token(Token = "0x6001153")]
	[Address(RVA = "0x17EA884", Offset = "0x17EA884", VA = "0x17EA884", Slot = "8")]
	public override void PlayHitfly()
	{
	}

	[Token(Token = "0x6001154")]
	[Address(RVA = "0x17EA944", Offset = "0x17EA944", VA = "0x17EA944", Slot = "9")]
	public override void StopHitfly(bool BAJJBNNNGIH)
	{
	}

	[Token(Token = "0x6001155")]
	[Address(RVA = "0x17EAA48", Offset = "0x17EAA48", VA = "0x17EAA48", Slot = "10")]
	public override void Dead(bool KCHNLMEEHOP, bool FDICOIFLBAD)
	{
	}

	[Token(Token = "0x6001156")]
	[Address(RVA = "0x17EABB0", Offset = "0x17EABB0", VA = "0x17EABB0", Slot = "11")]
	public override void SetSpeed(float OJGNBJELDEM)
	{
	}

	[Token(Token = "0x6001157")]
	[Address(RVA = "0x17EAD68", Offset = "0x17EAD68", VA = "0x17EAD68")]
	private string DCAFIFPACHJ(float OJGNBJELDEM)
	{
		return null;
	}

	[Token(Token = "0x6001158")]
	[Address(RVA = "0x17E9844", Offset = "0x17E9844", VA = "0x17E9844")]
	private void KEMMGKFAKNK()
	{
	}

	[Token(Token = "0x6001159")]
	[Address(RVA = "0x17EAF98", Offset = "0x17EAF98", VA = "0x17EAF98", Slot = "12")]
	public override bool PlaySkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE LGIMFPCBALH, float GGMFDABGEKN, float NCGNOHEHDML, bool ICLFBLKGENK)
	{
		return default(bool);
	}

	[Token(Token = "0x600115A")]
	[Address(RVA = "0x17EB4B8", Offset = "0x17EB4B8", VA = "0x17EB4B8")]
	private void LCLFGPILCAL(List<AnimationClip> NHIPLADDAMN, float GGMFDABGEKN, float NCGNOHEHDML)
	{
	}

	[Token(Token = "0x600115B")]
	[Address(RVA = "0x17EB1B0", Offset = "0x17EB1B0", VA = "0x17EB1B0")]
	private void HHJLDPCHNGF(List<AnimationClip> NHIPLADDAMN, float GGMFDABGEKN, float NCGNOHEHDML)
	{
	}

	[Token(Token = "0x600115C")]
	[Address(RVA = "0x17EB8A4", Offset = "0x17EB8A4", VA = "0x17EB8A4", Slot = "13")]
	public override bool UpdateSkillAnim(OPKPPFDNCMC GEPIPPKAIBK, GDEHAFJBPGE LGIMFPCBALH, int HBGPBPOMLDG, float MIEOJFFIIHH)
	{
		return default(bool);
	}

	[Token(Token = "0x600115D")]
	[Address(RVA = "0x17EBC40", Offset = "0x17EBC40", VA = "0x17EBC40")]
	public Animation _003C_003EiFixBaseProxy_get_Animation()
	{
		return null;
	}

	[Token(Token = "0x600115E")]
	[Address(RVA = "0x17EBC44", Offset = "0x17EBC44", VA = "0x17EBC44")]
	public void _003C_003EiFixBaseProxy_UpdateAnimSpeed(float P0)
	{
	}

	[Token(Token = "0x600115F")]
	[Address(RVA = "0x17EBC48", Offset = "0x17EBC48", VA = "0x17EBC48")]
	public void _003C_003EiFixBaseProxy_PlayAttack()
	{
	}

	[Token(Token = "0x6001160")]
	[Address(RVA = "0x17EBC4C", Offset = "0x17EBC4C", VA = "0x17EBC4C")]
	public void _003C_003EiFixBaseProxy_PlayHitfly()
	{
	}

	[Token(Token = "0x6001161")]
	[Address(RVA = "0x17EBC50", Offset = "0x17EBC50", VA = "0x17EBC50")]
	public void _003C_003EiFixBaseProxy_StopHitfly(bool P0)
	{
	}

	[Token(Token = "0x6001162")]
	[Address(RVA = "0x17EBC54", Offset = "0x17EBC54", VA = "0x17EBC54")]
	public bool _003C_003EiFixBaseProxy_UpdateSkillAnim(OPKPPFDNCMC P0, GDEHAFJBPGE P1, int P2, float P3)
	{
		return default(bool);
	}
}
