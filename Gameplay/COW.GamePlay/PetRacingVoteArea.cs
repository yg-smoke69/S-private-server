using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000704")]
internal class PetRacingVoteArea : BaseLevelObject
{
	[Token(Token = "0x4004BDA")]
	[FieldOffset(Offset = "0x74")]
	public int petIndex;

	[Token(Token = "0x4004BDB")]
	[FieldOffset(Offset = "0x78")]
	public GameObject ActiveEffect;

	[Token(Token = "0x4004BDC")]
	[FieldOffset(Offset = "0x7C")]
	private GameObject JIKEPKJBBFD;

	[Token(Token = "0x4004BDD")]
	[FieldOffset(Offset = "0x80")]
	private PetRacerConfigData DHAHMDCHKFN;

	[Token(Token = "0x6002CB7")]
	[Address(RVA = "0xBCF7E0", Offset = "0xBCF7E0", VA = "0xBCF7E0")]
	public PetRacingVoteArea()
	{
	}

	[Token(Token = "0x6002CB8")]
	[Address(RVA = "0xBCF7E8", Offset = "0xBCF7E8", VA = "0xBCF7E8", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002CB9")]
	[Address(RVA = "0xBCF88C", Offset = "0xBCF88C", VA = "0xBCF88C", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x6002CBA")]
	[Address(RVA = "0xBCFAB4", Offset = "0xBCFAB4", VA = "0xBCFAB4", Slot = "16")]
	protected override void OnOnDestroy()
	{
	}

	[Token(Token = "0x6002CBB")]
	[Address(RVA = "0xBCFCB8", Offset = "0xBCFCB8", VA = "0xBCFCB8")]
	public void OnPhaseChange(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002CBC")]
	[Address(RVA = "0xBD008C", Offset = "0xBD008C", VA = "0xBD008C")]
	public void OnVoted(object[] AJKBOONEOAB)
	{
	}

	[Token(Token = "0x6002CBD")]
	[Address(RVA = "0xBD0444", Offset = "0xBD0444", VA = "0xBD0444", Slot = "30")]
	public override void DoAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002CBE")]
	[Address(RVA = "0xBD074C", Offset = "0xBD074C", VA = "0xBD074C")]
	public void OnPetCreated(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002CBF")]
	[Address(RVA = "0xBD0C70", Offset = "0xBD0C70", VA = "0xBD0C70")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x6002CC0")]
	[Address(RVA = "0xBD0C78", Offset = "0xBD0C78", VA = "0xBD0C78")]
	public new void _003C_003EiFixBaseProxy_OnOnDestroy()
	{
	}

	[Token(Token = "0x6002CC1")]
	[Address(RVA = "0xBD0C80", Offset = "0xBD0C80", VA = "0xBD0C80")]
	public void _003C_003EiFixBaseProxy_DoAction(object[] P0)
	{
	}
}
