using GCommon;
using Il2CppDummyDll;
using UnityEngine;

namespace COW.GamePlay;

[Token(Token = "0x2000612")]
internal class LevelDummy : LevelObjectSpawnedAttackable
{
	[Token(Token = "0x40045B7")]
	[FieldOffset(Offset = "0xA4")]
	public Transform FireEffectContainer;

	[Token(Token = "0x40045B8")]
	[FieldOffset(Offset = "0xA8")]
	private NJFBLNFPHFK BOPLAOANKBI;

	[Token(Token = "0x40045B9")]
	[FieldOffset(Offset = "0xAC")]
	private OOIPMACFIFL GNKIDIEGEGB;

	[Token(Token = "0x40045BA")]
	private const uint OOKOFLIJBNF = 3u;

	[Token(Token = "0x170002EF")]
	public override int JLCCLJCEDIL
	{
		[Token(Token = "0x600257E")]
		[Address(RVA = "0x271910C", Offset = "0x271910C", VA = "0x271910C", Slot = "64")]
		get
		{
			return default(int);
		}
	}

	[Token(Token = "0x600257C")]
	[Address(RVA = "0x2718B44", Offset = "0x2718B44", VA = "0x2718B44")]
	public LevelDummy()
	{
	}

	[Token(Token = "0x600257D")]
	[Address(RVA = "0x2718B4C", Offset = "0x2718B4C", VA = "0x2718B4C", Slot = "41")]
	protected override void DPLMGOJKKCM(CSVBaseData IHCGHDENPKF)
	{
	}

	[Token(Token = "0x600257F")]
	[Address(RVA = "0x271917C", Offset = "0x271917C", VA = "0x271917C", Slot = "68")]
	public override Vector3 GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002580")]
	[Address(RVA = "0x27192A4", Offset = "0x27192A4", VA = "0x27192A4")]
	public ResourceID GetHitSound()
	{
		return default(ResourceID);
	}

	[Token(Token = "0x6002581")]
	[Address(RVA = "0x2719314", Offset = "0x2719314", VA = "0x2719314", Slot = "70")]
	public override bool NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6002582")]
	[Address(RVA = "0x271938C", Offset = "0x271938C", VA = "0x271938C", Slot = "71")]
	public override bool IsSameTeamWithPlayerID(IHAAMHPPLMG FGFGBHLEONO)
	{
		return default(bool);
	}

	[Token(Token = "0x6002583")]
	[Address(RVA = "0x2719424", Offset = "0x2719424", VA = "0x2719424", Slot = "36")]
	protected override string GetObjectTag()
	{
		return null;
	}

	[Token(Token = "0x6002584")]
	[Address(RVA = "0x27194C8", Offset = "0x27194C8", VA = "0x27194C8", Slot = "31")]
	public override void SyncAction(object[] OECMLDILLJN)
	{
	}

	[Token(Token = "0x6002585")]
	[Address(RVA = "0x2719F38", Offset = "0x2719F38", VA = "0x2719F38")]
	public void _003C_003EiFixBaseProxy_DPLMGOJKKCM(CSVBaseData P0)
	{
	}

	[Token(Token = "0x6002586")]
	[Address(RVA = "0x2719F40", Offset = "0x2719F40", VA = "0x2719F40")]
	public Vector3 _003C_003EiFixBaseProxy_GetAttackableCenterWS()
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6002587")]
	[Address(RVA = "0x2719F54", Offset = "0x2719F54", VA = "0x2719F54")]
	public bool _003C_003EiFixBaseProxy_NeedAssit()
	{
		return default(bool);
	}

	[Token(Token = "0x6002588")]
	[Address(RVA = "0x2719F5C", Offset = "0x2719F5C", VA = "0x2719F5C")]
	public bool _003C_003EiFixBaseProxy_IsSameTeamWithPlayerID(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6002589")]
	[Address(RVA = "0x2719F90", Offset = "0x2719F90", VA = "0x2719F90")]
	public void _003C_003EiFixBaseProxy_SyncAction(object[] P0)
	{
	}
}
