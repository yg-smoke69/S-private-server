using System;
using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20007F4")]
internal class SafeZone : Entity
{
	[Token(Token = "0x20007F5")]
	public enum PDAKFLCADHD
	{
		[Token(Token = "0x400505D")]
		Stable,
		[Token(Token = "0x400505E")]
		PreShrink,
		[Token(Token = "0x400505F")]
		Shrink,
		[Token(Token = "0x4005060")]
		RandomPreShrink,
		[Token(Token = "0x4005061")]
		RandomShrink,
		[Token(Token = "0x4005062")]
		Count
	}

	[Serializable]
	[Token(Token = "0x20007F6")]
	public class ZoneDefinition
	{
		[Token(Token = "0x4005063")]
		[FieldOffset(Offset = "0x8")]
		public int stageID;

		[Token(Token = "0x4005064")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 OuterCenter;

		[Token(Token = "0x4005065")]
		[FieldOffset(Offset = "0x18")]
		public float OuterRadius;

		[Token(Token = "0x4005066")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 InnerCenter;

		[Token(Token = "0x4005067")]
		[FieldOffset(Offset = "0x28")]
		public float InnerRadius;

		[Token(Token = "0x4005068")]
		[FieldOffset(Offset = "0x2C")]
		public PDAKFLCADHD TimeSpanType;

		[Token(Token = "0x4005069")]
		[FieldOffset(Offset = "0x30")]
		public uint StartTime;

		[Token(Token = "0x400506A")]
		[FieldOffset(Offset = "0x34")]
		public uint EndTime;

		[Token(Token = "0x400506B")]
		[FieldOffset(Offset = "0x38")]
		public bool QuickPreShrink;

		[Token(Token = "0x400506C")]
		[FieldOffset(Offset = "0x39")]
		public bool IsPhaseRandomCenter;

		[Token(Token = "0x400506D")]
		[FieldOffset(Offset = "0x3A")]
		public bool UsingZone;

		[Token(Token = "0x400506E")]
		[FieldOffset(Offset = "0x3C")]
		public KPEBBKMBGPH OuterZone;

		[Token(Token = "0x400506F")]
		[FieldOffset(Offset = "0x40")]
		public KPEBBKMBGPH InnerZone;

		[Token(Token = "0x60032FD")]
		[Address(RVA = "0x29ADC80", Offset = "0x29ADC80", VA = "0x29ADC80")]
		public ZoneDefinition()
		{
		}

		[Token(Token = "0x60032FE")]
		[Address(RVA = "0x29ADC88", Offset = "0x29ADC88", VA = "0x29ADC88")]
		public bool OOJMNGDMJAL(Vector3 ACCOJJMKKPM)
		{
			return default(bool);
		}

		[Token(Token = "0x60032FF")]
		[Address(RVA = "0x29ADE34", Offset = "0x29ADE34", VA = "0x29ADE34")]
		public Vector3 PEGMHFCLEGD()
		{
			//IL_0002: Unknown result type (might be due to invalid IL or missing references)
			//IL_0008: Unknown result type (might be due to invalid IL or missing references)
			return default(Vector3);
		}

		[Token(Token = "0x6003300")]
		[Address(RVA = "0x29ADED0", Offset = "0x29ADED0", VA = "0x29ADED0")]
		public float DMPFGOPGNAA()
		{
			return default(float);
		}

		[Token(Token = "0x6003301")]
		[Address(RVA = "0x29ADFE4", Offset = "0x29ADFE4", VA = "0x29ADFE4")]
		public float PFIHKKBJMLI()
		{
			return default(float);
		}
	}

	[Token(Token = "0x20007F7")]
	private class HLIPEOMOPCA
	{
		[Token(Token = "0x4005070")]
		[FieldOffset(Offset = "0x8")]
		private CommonParticleEffect NPCECHCKFMC;

		[Token(Token = "0x4005071")]
		[FieldOffset(Offset = "0xC")]
		private CommonParticleEffect PGABCJONCHN;

		[Token(Token = "0x4005072")]
		[FieldOffset(Offset = "0x10")]
		private uint AMGBLMJIBCP;

		[Token(Token = "0x4005073")]
		[FieldOffset(Offset = "0x14")]
		private bool OOJDLEPCOLI;

		[Token(Token = "0x6003302")]
		[Address(RVA = "0x29ACCE8", Offset = "0x29ACCE8", VA = "0x29ACCE8")]
		public HLIPEOMOPCA(ResourceID OLOEBCMCLFK, ResourceID BDDAIFIMIOG)
		{
		}

		[Token(Token = "0x6003303")]
		[Address(RVA = "0x29AD230", Offset = "0x29AD230", VA = "0x29AD230")]
		public void AALCMHKNNKL()
		{
		}

		[Token(Token = "0x6003304")]
		[Address(RVA = "0x29AD490", Offset = "0x29AD490", VA = "0x29AD490")]
		public void IENPMLHCMPG()
		{
		}

		[Token(Token = "0x6003305")]
		[Address(RVA = "0x29AD794", Offset = "0x29AD794", VA = "0x29AD794")]
		public void HDCJALOFKLJ()
		{
		}

		[Token(Token = "0x6003306")]
		[Address(RVA = "0x29AD5A8", Offset = "0x29AD5A8", VA = "0x29AD5A8")]
		private void IOOAABLNIDD()
		{
		}

		[Token(Token = "0x6003307")]
		[Address(RVA = "0x29ADA28", Offset = "0x29ADA28", VA = "0x29ADA28")]
		public void IDONDFICAFN()
		{
		}
	}

	[Token(Token = "0x20007F8")]
	public class DOJILNNMFOL
	{
		[Token(Token = "0x4005074")]
		[FieldOffset(Offset = "0x8")]
		public uint MALAFENAOHF;

		[Token(Token = "0x4005075")]
		[FieldOffset(Offset = "0xC")]
		public Vector3 CBOJBGBJLOD;

		[Token(Token = "0x4005076")]
		[FieldOffset(Offset = "0x18")]
		public uint DPOHOBCILOO;

		[Token(Token = "0x4005077")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 EADMFFJONEG;

		[Token(Token = "0x6003308")]
		[Address(RVA = "0x29ACCE0", Offset = "0x29ACCE0", VA = "0x29ACCE0")]
		public DOJILNNMFOL()
		{
		}
	}

	[Token(Token = "0x400503E")]
	[FieldOffset(Offset = "0x34")]
	public byte SafeZoneMaxIndex;

	[Token(Token = "0x400503F")]
	[FieldOffset(Offset = "0x38")]
	private GameObject JCDKIKIAEJH;

	[Token(Token = "0x4005040")]
	[FieldOffset(Offset = "0x3C")]
	private Renderer NNBLGLHCDJM;

	[Token(Token = "0x4005041")]
	[FieldOffset(Offset = "0x40")]
	private float HCAJFJFDMHH;

	[Token(Token = "0x4005042")]
	[FieldOffset(Offset = "0x44")]
	private bool LOACDNBPAFA;

	[Token(Token = "0x4005043")]
	[FieldOffset(Offset = "0x48")]
	public float TexMaxEffectLimitRadius;

	[Token(Token = "0x4005044")]
	[FieldOffset(Offset = "0x4C")]
	public float TexMaxEffectRatio;

	[Token(Token = "0x4005045")]
	[FieldOffset(Offset = "0x50")]
	public float TexMinEffectLimitRadius;

	[Token(Token = "0x4005046")]
	[FieldOffset(Offset = "0x54")]
	public float TexMinEffectRatio;

	[Token(Token = "0x4005047")]
	[FieldOffset(Offset = "0x58")]
	private int KCDADIEGAIL;

	[Token(Token = "0x4005048")]
	[FieldOffset(Offset = "0x5C")]
	private int HEMDLEJDKHC;

	[Token(Token = "0x4005049")]
	[FieldOffset(Offset = "0x60")]
	private float BKCDBLHFIFN;

	[Token(Token = "0x400504A")]
	[FieldOffset(Offset = "0x64")]
	private ZoneDefinition MGEMKBFLHGN;

	[Token(Token = "0x400504B")]
	[FieldOffset(Offset = "0x68")]
	public bool ShowingRectZone;

	[Token(Token = "0x400504C")]
	[FieldOffset(Offset = "0x6C")]
	public float CurrentRadius;

	[Token(Token = "0x400504D")]
	[FieldOffset(Offset = "0x70")]
	public float CurrentLength;

	[Token(Token = "0x400504E")]
	[FieldOffset(Offset = "0x74")]
	public float CurrentWidth;

	[Token(Token = "0x400504F")]
	[FieldOffset(Offset = "0x78")]
	public Vector3 CurrentForward;

	[Token(Token = "0x4005050")]
	[FieldOffset(Offset = "0x84")]
	private bool EJDFNKDMFML;

	[Token(Token = "0x4005051")]
	[FieldOffset(Offset = "0x88")]
	public int DamagePerHit;

	[Token(Token = "0x4005052")]
	[FieldOffset(Offset = "0x8C")]
	public int DamageInterval;

	[Token(Token = "0x4005053")]
	[FieldOffset(Offset = "0x90")]
	private float DEKNIDADMOK;

	[Token(Token = "0x4005054")]
	[FieldOffset(Offset = "0x94")]
	public bool EnableSafeZoneDamage;

	[Token(Token = "0x4005055")]
	[FieldOffset(Offset = "0x98")]
	public float SafeZoneHeight;

	[Token(Token = "0x4005056")]
	[FieldOffset(Offset = "0x9C")]
	public float HeightScaleForRect;

	[Token(Token = "0x4005057")]
	[FieldOffset(Offset = "0xA0")]
	private HLIPEOMOPCA LFMKBIDNJJN;

	[Token(Token = "0x4005058")]
	[FieldOffset(Offset = "0xA4")]
	private BloodType DPBLCIOEFLC;

	[Token(Token = "0x4005059")]
	[FieldOffset(Offset = "0xA8")]
	private Dictionary<uint, DOJILNNMFOL> LPMHKFMGJEB;

	[Token(Token = "0x400505A")]
	[FieldOffset(Offset = "0xAC")]
	private List<DOJILNNMFOL> ELMDCOBPFPE;

	[Token(Token = "0x400505B")]
	[FieldOffset(Offset = "0xB0")]
	private Dictionary<uint, GameObject> HONIKIGDINN;

	[Token(Token = "0x60032D9")]
	[Address(RVA = "0x1A128E0", Offset = "0x1A128E0", VA = "0x1A128E0")]
	public SafeZone()
	{
	}

	[Token(Token = "0x60032DA")]
	[Address(RVA = "0x1A12A6C", Offset = "0x1A12A6C", VA = "0x1A12A6C", Slot = "14")]
	protected override void OnAwake()
	{
	}

	[Token(Token = "0x60032DB")]
	[Address(RVA = "0x1A12D5C", Offset = "0x1A12D5C", VA = "0x1A12D5C", Slot = "15")]
	protected override void OnStart()
	{
	}

	[Token(Token = "0x60032DC")]
	[Address(RVA = "0x1A131A0", Offset = "0x1A131A0", VA = "0x1A131A0", Slot = "17")]
	public override void OnFixedUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x60032DD")]
	[Address(RVA = "0x1A14D04", Offset = "0x1A14D04", VA = "0x1A14D04")]
	public ZoneDefinition GetSafeZoneStatus()
	{
		return null;
	}

	[Token(Token = "0x60032DE")]
	[Address(RVA = "0x1A133D4", Offset = "0x1A133D4", VA = "0x1A133D4")]
	private void CGJBNCHGIKI()
	{
	}

	[Token(Token = "0x60032DF")]
	[Address(RVA = "0x1A14DB8", Offset = "0x1A14DB8", VA = "0x1A14DB8")]
	protected void MAAEJHANEFO()
	{
	}

	[Token(Token = "0x60032E0")]
	[Address(RVA = "0x1A141A0", Offset = "0x1A141A0", VA = "0x1A141A0")]
	protected void HBDBDOCKLJJ(bool JNHHLCDKAAJ)
	{
	}

	[Token(Token = "0x60032E1")]
	[Address(RVA = "0x1A156E4", Offset = "0x1A156E4", VA = "0x1A156E4", Slot = "24")]
	protected virtual void DGAFBDMFEDM()
	{
	}

	[Token(Token = "0x60032E2")]
	[Address(RVA = "0x1A152D8", Offset = "0x1A152D8", VA = "0x1A152D8")]
	private void HPLKLJJKPGB()
	{
	}

	[Token(Token = "0x60032E3")]
	[Address(RVA = "0x1A1585C", Offset = "0x1A1585C", VA = "0x1A1585C")]
	public bool IsZoneActive()
	{
		return default(bool);
	}

	[Token(Token = "0x60032E4")]
	[Address(RVA = "0x1A15480", Offset = "0x1A15480", VA = "0x1A15480")]
	public bool IsSafePosition(Vector3 ACCOJJMKKPM)
	{
		return default(bool);
	}

	[Token(Token = "0x60032E5")]
	[Address(RVA = "0x1A158D4", Offset = "0x1A158D4", VA = "0x1A158D4")]
	public bool ShowWarning(Vector3 ACCOJJMKKPM)
	{
		return default(bool);
	}

	[Token(Token = "0x60032E6")]
	[Address(RVA = "0x1A15A30", Offset = "0x1A15A30", VA = "0x1A15A30")]
	public bool IsInInnerPosition(Vector3 ACCOJJMKKPM)
	{
		return default(bool);
	}

	[Token(Token = "0x60032E7")]
	[Address(RVA = "0x1A15ADC", Offset = "0x1A15ADC", VA = "0x1A15ADC")]
	public bool IsLocalPlayerInInnerSafePosition()
	{
		return default(bool);
	}

	[Token(Token = "0x60032E8")]
	[Address(RVA = "0x1A15D64", Offset = "0x1A15D64", VA = "0x1A15D64")]
	public void InitByMessage(KGOHADAMBLI LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60032E9")]
	[Address(RVA = "0x1A16964", Offset = "0x1A16964", VA = "0x1A16964")]
	public void InitByMessage(EPCCGBHFKHM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60032EA")]
	[Address(RVA = "0x1A16714", Offset = "0x1A16714", VA = "0x1A16714")]
	private void LHDBOCOCGOO(bool COJAMHMHMDG)
	{
	}

	[Token(Token = "0x60032EB")]
	[Address(RVA = "0x1A16B70", Offset = "0x1A16B70", VA = "0x1A16B70")]
	public void InitAllGamezoneMessage(MCDIGEEGOLM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60032EC")]
	[Address(RVA = "0x1A171E4", Offset = "0x1A171E4", VA = "0x1A171E4")]
	public void InitBombZoneMessage(HMMEOGMGJKL LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x60032ED")]
	[Address(RVA = "0x1A17940", Offset = "0x1A17940", VA = "0x1A17940")]
	public List<DOJILNNMFOL> GetBombZoneInfos()
	{
		return null;
	}

	[Token(Token = "0x60032EE")]
	[Address(RVA = "0x1A17998", Offset = "0x1A17998", VA = "0x1A17998")]
	public int BombZoneIndexAtPosition(Vector3 MLCIHBOHEHE)
	{
		return default(int);
	}

	[Token(Token = "0x60032EF")]
	[Address(RVA = "0x1A17C3C", Offset = "0x1A17C3C", VA = "0x1A17C3C")]
	public void UpdateBombZoneEffect(uint LNMKFKJCBLB, bool KMJCIHFDHNP)
	{
	}

	[Token(Token = "0x60032F0")]
	[Address(RVA = "0x1A17E40", Offset = "0x1A17E40", VA = "0x1A17E40")]
	public Dictionary<uint, DOJILNNMFOL> GetGameZoneInfoMap()
	{
		return null;
	}

	[Token(Token = "0x60032F1")]
	[Address(RVA = "0x1A17E98", Offset = "0x1A17E98", VA = "0x1A17E98")]
	public DOJILNNMFOL GetCurrentGameZoneInfo()
	{
		return null;
	}

	[Token(Token = "0x60032F2")]
	[Address(RVA = "0x1A17F10", Offset = "0x1A17F10", VA = "0x1A17F10")]
	public DOJILNNMFOL GetGameZoneInfoByIndex(uint HHLONFLCJBL)
	{
		return null;
	}

	[Token(Token = "0x60032F3")]
	[Address(RVA = "0x1A159D8", Offset = "0x1A159D8", VA = "0x1A159D8")]
	public ZoneDefinition getZoneStatus()
	{
		return null;
	}

	[Token(Token = "0x60032F4")]
	[Address(RVA = "0x1A17FF8", Offset = "0x1A17FF8", VA = "0x1A17FF8")]
	public bool IsInRebornFinal()
	{
		return default(bool);
	}

	[Token(Token = "0x60032F5")]
	[Address(RVA = "0x1A180FC", Offset = "0x1A180FC", VA = "0x1A180FC")]
	public bool IsRebornFinalStart()
	{
		return default(bool);
	}

	[Token(Token = "0x60032F6")]
	[Address(RVA = "0x1A18220", Offset = "0x1A18220", VA = "0x1A18220")]
	public void Destory()
	{
	}

	[Token(Token = "0x60032F7")]
	[Address(RVA = "0x1A18310", Offset = "0x1A18310", VA = "0x1A18310")]
	public bool CheckPlayerInSafeZone()
	{
		return default(bool);
	}

	[Token(Token = "0x60032F8")]
	[Address(RVA = "0x1A12BE0", Offset = "0x1A12BE0", VA = "0x1A12BE0")]
	public void InitVFX()
	{
	}

	[Token(Token = "0x60032F9")]
	[Address(RVA = "0x1A14D5C", Offset = "0x1A14D5C", VA = "0x1A14D5C")]
	public void SetVFXEnable(bool ELOELMEPFCN)
	{
	}

	[Token(Token = "0x60032FA")]
	[Address(RVA = "0x1A18484", Offset = "0x1A18484", VA = "0x1A18484")]
	public void _003C_003EiFixBaseProxy_OnAwake()
	{
	}

	[Token(Token = "0x60032FB")]
	[Address(RVA = "0x1A1848C", Offset = "0x1A1848C", VA = "0x1A1848C")]
	public void _003C_003EiFixBaseProxy_OnStart()
	{
	}

	[Token(Token = "0x60032FC")]
	[Address(RVA = "0x1A18494", Offset = "0x1A18494", VA = "0x1A18494")]
	public void _003C_003EiFixBaseProxy_OnFixedUpdate(float P0, float P1)
	{
	}
}
