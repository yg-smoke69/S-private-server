using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20009A6")]
internal class PlayerNetwork : Player, _Attribute
{
	[Token(Token = "0x20009A7")]
	protected class HHCBNAPCKHF : ShadowStateBase
	{
		[Token(Token = "0x4005987")]
		[FieldOffset(Offset = "0x10")]
		public Vector3 JHJLNLCEGOG;

		[Token(Token = "0x4005988")]
		[FieldOffset(Offset = "0x1C")]
		public Vector3 PGDEDHFOMCN;

		[Token(Token = "0x4005989")]
		[FieldOffset(Offset = "0x28")]
		public Quaternion FBMPKHMBHAM;

		[Token(Token = "0x400598A")]
		[FieldOffset(Offset = "0x38")]
		public Quaternion BPLOAFBIHJL;

		[Token(Token = "0x400598B")]
		[FieldOffset(Offset = "0x48")]
		public Quaternion PJIHDKAKGOH;

		[Token(Token = "0x400598C")]
		[FieldOffset(Offset = "0x58")]
		public Quaternion KNMAOPMBPBO;

		[Token(Token = "0x400598D")]
		[FieldOffset(Offset = "0x68")]
		public DFKKGHCFGNM LANMPIGGDAG;

		[Token(Token = "0x400598E")]
		[FieldOffset(Offset = "0x6C")]
		public FBCAHNCLMDC ADFIDIPODGK;

		[Token(Token = "0x400598F")]
		[FieldOffset(Offset = "0x70")]
		public float INCJIBNNCPI;

		[Token(Token = "0x4005990")]
		[FieldOffset(Offset = "0x74")]
		public float GNCPKAHPNCJ;

		[Token(Token = "0x4005991")]
		[FieldOffset(Offset = "0x78")]
		public Vector3 OFDAMCCLNGO;

		[Token(Token = "0x4005992")]
		[FieldOffset(Offset = "0x84")]
		public uint FBEJLLEOICJ;

		[Token(Token = "0x4005993")]
		[FieldOffset(Offset = "0x88")]
		public Vector3 JKGELJKMLCM;

		[Token(Token = "0x4005994")]
		[FieldOffset(Offset = "0x94")]
		public Vector3 FLPHCCOENMI;

		[Token(Token = "0x6004AA8")]
		[Address(RVA = "0x20FC9D0", Offset = "0x20FC9D0", VA = "0x20FC9D0")]
		public HHCBNAPCKHF()
		{
		}
	}

	[Token(Token = "0x4005979")]
	[FieldOffset(Offset = "0x998")]
	protected float BCLJOJABBFG;

	[Token(Token = "0x400597A")]
	[FieldOffset(Offset = "0x99C")]
	protected float GBDINMOKEOJ;

	[Token(Token = "0x400597B")]
	[FieldOffset(Offset = "0x9A0")]
	protected uint KINJCKMOGIM;

	[Token(Token = "0x400597C")]
	[FieldOffset(Offset = "0x9A4")]
	protected HHCBNAPCKHF PLGAAJABBHA;

	[Token(Token = "0x400597D")]
	[FieldOffset(Offset = "0x9A8")]
	protected uint KCANGJBFMJH;

	[Token(Token = "0x400597E")]
	[FieldOffset(Offset = "0x9AC")]
	protected BaseProfileInfo OJAFLKJINPJ;

	[Token(Token = "0x400597F")]
	[FieldOffset(Offset = "0x9B0")]
	protected bool HEJHAOLDOLF;

	[Token(Token = "0x4005980")]
	[FieldOffset(Offset = "0x9B4")]
	private Dictionary<uint, uint> AOEEJNAONNM;

	[Token(Token = "0x4005981")]
	private const float KEBBFJFLBDE = 10000f;

	[Token(Token = "0x4005982")]
	[FieldOffset(Offset = "0x9B8")]
	protected float BAIPKFCEJAM;

	[Token(Token = "0x4005983")]
	[FieldOffset(Offset = "0x9BC")]
	protected EPreparationTimerType EOHOCKKMGEI;

	[Token(Token = "0x4005984")]
	[FieldOffset(Offset = "0x9C0")]
	private List<uint> ADCNALCPPDF;

	[Token(Token = "0x4005985")]
	[FieldOffset(Offset = "0x9C4")]
	private float AAKJOCPGMGC;

	[Token(Token = "0x4005986")]
	private const float KLBJGLEHKPP = 1f / 30f;

	[Token(Token = "0x170005ED")]
	public override BaseProfileInfo GFNIFLOJIAF
	{
		[Token(Token = "0x6004A04")]
		[Address(RVA = "0x14E8534", Offset = "0x14E8534", VA = "0x14E8534", Slot = "215")]
		get
		{
			return null;
		}
	}

	[Token(Token = "0x170005EE")]
	protected ushort GOABMLJIIMJ
	{
		[Token(Token = "0x6004A6C")]
		[Address(RVA = "0x14E1AB4", Offset = "0x14E1AB4", VA = "0x14E1AB4")]
		get
		{
			return default(ushort);
		}
	}

	[Token(Token = "0x6004A03")]
	[Address(RVA = "0x14E0D70", Offset = "0x14E0D70", VA = "0x14E0D70")]
	public PlayerNetwork()
	{
	}

	[Token(Token = "0x6004A05")]
	[Address(RVA = "0x14E858C", Offset = "0x14E858C", VA = "0x14E858C", Slot = "102")]
	public override bool HaveFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A06")]
	[Address(RVA = "0x14E8604", Offset = "0x14E8604", VA = "0x14E8604")]
	public Dictionary<uint, uint> GetPlayerWeaponSkinMap()
	{
		return null;
	}

	[Token(Token = "0x6004A07")]
	[Address(RVA = "0x14E865C", Offset = "0x14E865C", VA = "0x14E865C")]
	public void SetIsInWaitingRoom(bool EBOJJLIHHCM)
	{
	}

	[Token(Token = "0x6004A08")]
	[Address(RVA = "0x14E86BC", Offset = "0x14E86BC", VA = "0x14E86BC", Slot = "97")]
	public override BaseProfileInfo PlayerBaseProfile()
	{
		return null;
	}

	[Token(Token = "0x6004A09")]
	[Address(RVA = "0x14E8714", Offset = "0x14E8714", VA = "0x14E8714")]
	public bool CanUseTreasureMap()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A0A")]
	[Address(RVA = "0x14E31A0", Offset = "0x14E31A0", VA = "0x14E31A0", Slot = "103")]
	public override void InitProperties(object KGCOINAOBOH, bool HMLKNAHACCI = true)
	{
	}

	[Token(Token = "0x6004A0B")]
	[Address(RVA = "0x14EA9A4", Offset = "0x14EA9A4", VA = "0x14EA9A4")]
	private void LMFNBFAHHOL(uint PGPGNOPCIIJ)
	{
	}

	[Token(Token = "0x6004A0C")]
	[Address(RVA = "0x14EA894", Offset = "0x14EA894", VA = "0x14EA894")]
	private void LEOCOHBODCC(PKCEFACBDMP KABNPBMPAIP)
	{
	}

	[Token(Token = "0x6004A0D")]
	[Address(RVA = "0x14EAC78", Offset = "0x14EAC78", VA = "0x14EAC78")]
	private void MHPMICAPECG(uint KKFJDIELKPJ)
	{
	}

	[Token(Token = "0x6004A0E")]
	[Address(RVA = "0x14EAF18", Offset = "0x14EAF18", VA = "0x14EAF18")]
	private void JFPGKPEHPIG(uint LOLDMOOMJBI)
	{
	}

	[Token(Token = "0x6004A0F")]
	[Address(RVA = "0x14E8DA8", Offset = "0x14E8DA8", VA = "0x14E8DA8")]
	private void PELEGEAEILN(GKBDLJFGGMI DAAKKAOCBAA)
	{
	}

	[Token(Token = "0x6004A10")]
	[Address(RVA = "0x14EB1B8", Offset = "0x14EB1B8", VA = "0x14EB1B8", Slot = "320")]
	protected virtual bool MNMKNHEDAPH()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A11")]
	[Address(RVA = "0x14EB210", Offset = "0x14EB210", VA = "0x14EB210", Slot = "321")]
	protected virtual void NPAHMINLFJA()
	{
	}

	[Token(Token = "0x6004A12")]
	[Address(RVA = "0x14EB59C", Offset = "0x14EB59C", VA = "0x14EB59C")]
	private static void ANPKKCKJBGK(BMMNIPHPNKI MNIJJHLDOMJ, CIBBLFMOMLK GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6004A13")]
	[Address(RVA = "0x14EB9A8", Offset = "0x14EB9A8", VA = "0x14EB9A8", Slot = "322")]
	public virtual void PushPlayerSyncedOptimizedStateData(object ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6004A14")]
	[Address(RVA = "0x14EC128", Offset = "0x14EC128", VA = "0x14EC128")]
	private void LBCGDBDLEKI(CIBBLFMOMLK HKAABMDNNAG, ref Quaternion JGOGIAFGCFC, ref Quaternion OFGMAFLCLEH, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6004A15")]
	[Address(RVA = "0x14ECABC", Offset = "0x14ECABC", VA = "0x14ECABC", Slot = "293")]
	public void PushPlayerSyncedPosition(object CLLBLAJEMNA, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6004A16")]
	[Address(RVA = "0x14EC890", Offset = "0x14EC890", VA = "0x14EC890")]
	private void PKGCIELHMLO(uint LPJONPCPBED, uint BLOANDINMIH)
	{
	}

	[Token(Token = "0x6004A17")]
	[Address(RVA = "0x14EBD8C", Offset = "0x14EBD8C", VA = "0x14EBD8C")]
	private void ADPEKKPGDAI()
	{
	}

	[Token(Token = "0x6004A18")]
	[Address(RVA = "0x14ECD18", Offset = "0x14ECD18", VA = "0x14ECD18", Slot = "323")]
	public virtual void PushPlayerSyncedStateData(object ANBEGGDFLBM, uint LPJONPCPBED)
	{
	}

	[Token(Token = "0x6004A19")]
	[Address(RVA = "0x14ED128", Offset = "0x14ED128", VA = "0x14ED128", Slot = "324")]
	public virtual void SyncStartFire(byte GLDLCOBLGNF)
	{
	}

	[Token(Token = "0x6004A1A")]
	[Address(RVA = "0x14ED748", Offset = "0x14ED748", VA = "0x14ED748", Slot = "325")]
	public virtual void SyncStopFire()
	{
	}

	[Token(Token = "0x6004A1B")]
	[Address(RVA = "0x14ED970", Offset = "0x14ED970", VA = "0x14ED970", Slot = "326")]
	public virtual void SyncStartReload(float MLPAAKNGDLA)
	{
	}

	[Token(Token = "0x6004A1C")]
	[Address(RVA = "0x14ED9F8", Offset = "0x14ED9F8", VA = "0x14ED9F8", Slot = "327")]
	public virtual void SyncStopReload(OFICGIIFGMF LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A1D")]
	[Address(RVA = "0x14EDAA8", Offset = "0x14EDAA8", VA = "0x14EDAA8", Slot = "328")]
	public virtual void SyncPlayEmotionAnimation(NIBOCOJJCCJ LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A1E")]
	[Address(RVA = "0x14EDB78", Offset = "0x14EDB78", VA = "0x14EDB78", Slot = "329")]
	public virtual void SyncPickupInventory(LHODJLEHDND LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A1F")]
	[Address(RVA = "0x14EDD10", Offset = "0x14EDD10", VA = "0x14EDD10", Slot = "330")]
	public virtual void SyncLoadoutRuntimeValue(HHNFFMHCPFO LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A20")]
	[Address(RVA = "0x14EDDA8", Offset = "0x14EDDA8", VA = "0x14EDDA8", Slot = "331")]
	public virtual void SyncDropInventory(KJBONEENCAL LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A21")]
	[Address(RVA = "0x14EDE40", Offset = "0x14EDE40", VA = "0x14EDE40", Slot = "332")]
	public virtual void SyncRemoveInventoryList(ABJFDIFIILN LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A22")]
	[Address(RVA = "0x14EDED8", Offset = "0x14EDED8", VA = "0x14EDED8", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004A23")]
	[Address(RVA = "0x14EE0FC", Offset = "0x14EE0FC", VA = "0x14EE0FC", Slot = "305")]
	public void SyncDoAction(FPCOHGNMLBG LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A24")]
	[Address(RVA = "0x14EF0E8", Offset = "0x14EF0E8", VA = "0x14EF0E8", Slot = "306")]
	public void SyncTryUseInventory(bool FJNDHBCJPEJ, uint KFBALILGIIG)
	{
	}

	[Token(Token = "0x6004A25")]
	[Address(RVA = "0x14EF5C8", Offset = "0x14EF5C8", VA = "0x14EF5C8", Slot = "176")]
	public override void RequestStopEmote4Plant()
	{
	}

	[Token(Token = "0x6004A26")]
	[Address(RVA = "0x14EF758", Offset = "0x14EF758", VA = "0x14EF758", Slot = "170")]
	public override void RequestPlayEmote4Plant(OFJHNKMJNGA CLJGFIOLMAK, uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6004A27")]
	[Address(RVA = "0x14EFC94", Offset = "0x14EFC94", VA = "0x14EFC94", Slot = "171")]
	public override void RequestStoreInWareHouse(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6004A28")]
	[Address(RVA = "0x14EFD34", Offset = "0x14EFD34", VA = "0x14EFD34", Slot = "172")]
	public override void RequestStopStoringInWarehouse()
	{
	}

	[Token(Token = "0x6004A29")]
	[Address(RVA = "0x14F025C", Offset = "0x14F025C", VA = "0x14F025C", Slot = "173")]
	public override void RequestOpenTreasury()
	{
	}

	[Token(Token = "0x6004A2A")]
	[Address(RVA = "0x14F052C", Offset = "0x14F052C", VA = "0x14F052C", Slot = "174")]
	public override void RequestOpenTimingTreasureBox()
	{
	}

	[Token(Token = "0x6004A2B")]
	[Address(RVA = "0x14F0784", Offset = "0x14F0784", VA = "0x14F0784", Slot = "175")]
	public override void RequestHayrickJump()
	{
	}

	[Token(Token = "0x6004A2C")]
	[Address(RVA = "0x14F09E4", Offset = "0x14F09E4", VA = "0x14F09E4", Slot = "181")]
	public override void RequestPray4EscortBoss(uint IEPFELEIMFE)
	{
	}

	[Token(Token = "0x6004A2D")]
	[Address(RVA = "0x14F0A84", Offset = "0x14F0A84", VA = "0x14F0A84", Slot = "182")]
	public override void RequestStopPraying4EscortBoss()
	{
	}

	[Token(Token = "0x6004A2E")]
	[Address(RVA = "0x14F0B18", Offset = "0x14F0B18", VA = "0x14F0B18", Slot = "186")]
	public override void DoUpdateActionState(EAcationState FNECNAAOMEG, EPreparationTimerType JCLPFENICLD, float LEBOAIEJCPJ)
	{
	}

	[Token(Token = "0x6004A2F")]
	[Address(RVA = "0x14F0D34", Offset = "0x14F0D34", VA = "0x14F0D34", Slot = "333")]
	public virtual void SyncEquipmentChanged(LJGFNPIMGMA LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A30")]
	[Address(RVA = "0x14F0FB4", Offset = "0x14F0FB4", VA = "0x14F0FB4", Slot = "334")]
	public virtual void SyncAttachmentChanged(KBDODAHANGB LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A31")]
	[Address(RVA = "0x14F1058", Offset = "0x14F1058", VA = "0x14F1058", Slot = "335")]
	public virtual void SyncPlayersVisibility(ulong DNHNPDIJHCE)
	{
	}

	[Token(Token = "0x6004A32")]
	[Address(RVA = "0x14F176C", Offset = "0x14F176C", VA = "0x14F176C")]
	public void NotifyServerGotForceSyncState(uint IAKABEJPKAE)
	{
	}

	[Token(Token = "0x6004A33")]
	[Address(RVA = "0x14F1984", Offset = "0x14F1984", VA = "0x14F1984", Slot = "304")]
	public void SyncStateWithServer(JIIKBLKJCKM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A34")]
	[Address(RVA = "0x14F23E8", Offset = "0x14F23E8", VA = "0x14F23E8", Slot = "149")]
	public override void OnWeaponReloadStarted(float LDBLIBDEDMH, bool GJFOOHPJCOG = false)
	{
	}

	[Token(Token = "0x6004A35")]
	[Address(RVA = "0x14F2658", Offset = "0x14F2658", VA = "0x14F2658", Slot = "150")]
	public override void OnWeaponReloadFinished(bool KIHNJGKPMPP)
	{
	}

	[Token(Token = "0x6004A36")]
	[Address(RVA = "0x14F285C", Offset = "0x14F285C", VA = "0x14F285C", Slot = "147")]
	public override void OnWeaponLift(bool FNHIJNENHHM = false)
	{
	}

	[Token(Token = "0x6004A37")]
	[Address(RVA = "0x14F2D64", Offset = "0x14F2D64", VA = "0x14F2D64", Slot = "113")]
	public override void UpdateAI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004A38")]
	[Address(RVA = "0x14F2E4C", Offset = "0x14F2E4C", VA = "0x14F2E4C")]
	private void PBMMHNBMIMI(float OMAFEKBHOAA, out bool DCCFMIHLEKA, out float CGPEFIBAFAB)
	{
	}

	[Token(Token = "0x6004A39")]
	[Address(RVA = "0x14E5BF4", Offset = "0x14E5BF4", VA = "0x14E5BF4", Slot = "114")]
	public override void UpdateBehavior(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004A3A")]
	[Address(RVA = "0x14E876C", Offset = "0x14E876C", VA = "0x14E876C")]
	protected Vector3 HLONBIENFFI(Vector3 NLPMJMOOMIH, DFKKGHCFGNM OOKGBDLEHHD, float IHDMOOHOJKO = 0f)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004A3B")]
	[Address(RVA = "0x14F3158", Offset = "0x14F3158", VA = "0x14F3158", Slot = "101")]
	protected override void ENOKKOIOGGN()
	{
	}

	[Token(Token = "0x6004A3C")]
	[Address(RVA = "0x14F32B4", Offset = "0x14F32B4", VA = "0x14F32B4")]
	private void ABDLHNPGCMG(float OMAFEKBHOAA, out bool DCCFMIHLEKA, out float CGPEFIBAFAB)
	{
	}

	[Token(Token = "0x6004A3D")]
	[Address(RVA = "0x14F35C0", Offset = "0x14F35C0", VA = "0x14F35C0", Slot = "116")]
	public override void UpdateKinematics(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004A3E")]
	[Address(RVA = "0x14F6628", Offset = "0x14F6628", VA = "0x14F6628", Slot = "205")]
	public override void OnGetOffChair(LevelChair COFMFDFDICP)
	{
	}

	[Token(Token = "0x6004A3F")]
	[Address(RVA = "0x14F6918", Offset = "0x14F6918", VA = "0x14F6918", Slot = "190")]
	public override void OnGetOffVehicle()
	{
	}

	[Token(Token = "0x6004A40")]
	[Address(RVA = "0x14F6C10", Offset = "0x14F6C10", VA = "0x14F6C10", Slot = "189")]
	public override void OnGetOnVehicle(Vehicle JOGHOHLEJFL)
	{
	}

	[Token(Token = "0x6004A41")]
	[Address(RVA = "0x14F6C94", Offset = "0x14F6C94", VA = "0x14F6C94", Slot = "187")]
	public override void OnGetOnFerrisWheel(LevelFerrisWheel NLDLLCIMJGH, byte NCLKIGNAEMK, byte FNJFBBAGJGF)
	{
	}

	[Token(Token = "0x6004A42")]
	[Address(RVA = "0x14F6EA8", Offset = "0x14F6EA8", VA = "0x14F6EA8", Slot = "188")]
	public override void OnGetOffFerrisWheel(byte NCLKIGNAEMK, byte FNJFBBAGJGF)
	{
	}

	[Token(Token = "0x6004A43")]
	[Address(RVA = "0x14F6F34", Offset = "0x14F6F34", VA = "0x14F6F34", Slot = "124")]
	public override int TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, [Optional] ELMGJKHIIAA JIIJIFKKCCB, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, [Optional] MKFEKBKJCKE OPINPCANMDE, uint EMFANFHKAMM = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x6004A44")]
	[Address(RVA = "0x14F7858", Offset = "0x14F7858", VA = "0x14F7858", Slot = "55")]
	public override void TakeHealing(int EDEOPLNOGPP, IHAAMHPPLMG ONPMGNIIMJD, int BOEIBGAABDL, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE)
	{
	}

	[Token(Token = "0x6004A45")]
	[Address(RVA = "0x14F8028", Offset = "0x14F8028", VA = "0x14F8028", Slot = "131")]
	public override void StartFiring(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004A46")]
	[Address(RVA = "0x14F839C", Offset = "0x14F839C", VA = "0x14F839C", Slot = "132")]
	public override void StartWarmUp(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004A47")]
	[Address(RVA = "0x14F8574", Offset = "0x14F8574", VA = "0x14F8574", Slot = "134")]
	public override void StopCharge(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004A48")]
	[Address(RVA = "0x14F874C", Offset = "0x14F874C", VA = "0x14F874C", Slot = "133")]
	public override void StopFire(GPBDEDFKJNA LPGPKFMGCBG)
	{
	}

	[Token(Token = "0x6004A49")]
	[Address(RVA = "0x14F89AC", Offset = "0x14F89AC", VA = "0x14F89AC", Slot = "137")]
	public override void SwapWeapon(int POFFNNMOOBM, bool GDKLMFLNNGM = false, [Optional] List<int> HACDOKBPCHJ)
	{
	}

	[Token(Token = "0x6004A4A")]
	[Address(RVA = "0x14F8BE4", Offset = "0x14F8BE4", VA = "0x14F8BE4", Slot = "138")]
	public override void SwapWeapon(BMGBKEENCJH FANMJANBFIL, bool GDKLMFLNNGM = false)
	{
	}

	[Token(Token = "0x6004A4B")]
	[Address(RVA = "0x14F8DFC", Offset = "0x14F8DFC", VA = "0x14F8DFC", Slot = "119")]
	public override void OnLandFinsish()
	{
	}

	[Token(Token = "0x6004A4C")]
	[Address(RVA = "0x14F8E74", Offset = "0x14F8E74", VA = "0x14F8E74", Slot = "336")]
	public virtual void SyncStartGrenade()
	{
	}

	[Token(Token = "0x6004A4D")]
	[Address(RVA = "0x14F9004", Offset = "0x14F9004", VA = "0x14F9004", Slot = "337")]
	public virtual void SyncStopGrenade()
	{
	}

	[Token(Token = "0x6004A4E")]
	[Address(RVA = "0x14F98D4", Offset = "0x14F98D4", VA = "0x14F98D4", Slot = "338")]
	public virtual void SyncTriggerGrenade()
	{
	}

	[Token(Token = "0x6004A4F")]
	[Address(RVA = "0x14F9A18", Offset = "0x14F9A18", VA = "0x14F9A18", Slot = "339")]
	public virtual void SyncStopSighting()
	{
	}

	[Token(Token = "0x6004A50")]
	[Address(RVA = "0x14F9A7C", Offset = "0x14F9A7C", VA = "0x14F9A7C", Slot = "135")]
	public override bool GetSightingState()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A51")]
	[Address(RVA = "0x14F9B04", Offset = "0x14F9B04", VA = "0x14F9B04", Slot = "168")]
	public override bool RequestRescureTarget(IHAAMHPPLMG FFDHFKIMFDG)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A52")]
	[Address(RVA = "0x14F9D1C", Offset = "0x14F9D1C", VA = "0x14F9D1C", Slot = "311")]
	public void OnRequestResureTargetRes(DCBAMPDIHIG KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6004A53")]
	[Address(RVA = "0x14FA214", Offset = "0x14FA214", VA = "0x14FA214", Slot = "169")]
	public override bool RequestStopResure()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A54")]
	[Address(RVA = "0x14FA3CC", Offset = "0x14FA3CC", VA = "0x14FA3CC", Slot = "312")]
	public void OnRequestStopResureTargetRes(CKFGLAAAOFC KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6004A55")]
	[Address(RVA = "0x14FA574", Offset = "0x14FA574", VA = "0x14FA574")]
	public void SyncBeRescured(DCBAMPDIHIG LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A56")]
	[Address(RVA = "0x14FA6C4", Offset = "0x14FA6C4", VA = "0x14FA6C4", Slot = "108")]
	public override void Dead(int HEONOMOEOLN, IHAAMHPPLMG HLJDHPGGODB, bool KCHNLMEEHOP = false, bool EPIDFMHNHFG = false)
	{
	}

	[Token(Token = "0x6004A57")]
	[Address(RVA = "0x14FAA00", Offset = "0x14FAA00", VA = "0x14FAA00", Slot = "309")]
	public void SyncKnockDown(NKDBFGLPCCF LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A58")]
	[Address(RVA = "0x14FB0CC", Offset = "0x14FB0CC", VA = "0x14FB0CC", Slot = "310")]
	public void SyncRevive(GBJAEPHNFMD DMOMICALGHM)
	{
	}

	[Token(Token = "0x6004A59")]
	[Address(RVA = "0x14FB2CC", Offset = "0x14FB2CC", VA = "0x14FB2CC")]
	public void SyncRevive3P()
	{
	}

	[Token(Token = "0x6004A5A")]
	[Address(RVA = "0x14FB4B4", Offset = "0x14FB4B4", VA = "0x14FB4B4")]
	public void SyncBeginFootball(MGFCOIELOIA LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A5B")]
	[Address(RVA = "0x14FB964", Offset = "0x14FB964", VA = "0x14FB964")]
	public void SyncReviveFromFootball()
	{
	}

	[Token(Token = "0x6004A5C")]
	[Address(RVA = "0x14FB9DC", Offset = "0x14FB9DC", VA = "0x14FB9DC", Slot = "340")]
	public virtual void SyncLocalPlayerSimpleChangeFootballState(bool JOOCDAGOABC)
	{
	}

	[Token(Token = "0x6004A5D")]
	[Address(RVA = "0x14FBA84", Offset = "0x14FBA84", VA = "0x14FBA84", Slot = "107")]
	public override void SetAI(bool KENDCFNPDCE)
	{
	}

	[Token(Token = "0x6004A5E")]
	[Address(RVA = "0x14FBB50", Offset = "0x14FBB50", VA = "0x14FBB50", Slot = "341")]
	public virtual void RequestFoceSyncPosition()
	{
	}

	[Token(Token = "0x6004A5F")]
	[Address(RVA = "0x14FBD4C", Offset = "0x14FBD4C", VA = "0x14FBD4C", Slot = "197")]
	public override bool RequestPlayCustomAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A60")]
	[Address(RVA = "0x14FBE88", Offset = "0x14FBE88", VA = "0x14FBE88", Slot = "198")]
	public override bool RequestUseBattleFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A61")]
	[Address(RVA = "0x14FC06C", Offset = "0x14FC06C", VA = "0x14FC06C", Slot = "199")]
	public override bool RequestPlayEmotionAnimation(uint IMBFPICKFHM = 1u, float HLPLKMJMJMB = 0f)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A62")]
	[Address(RVA = "0x14FC4B0", Offset = "0x14FC4B0", VA = "0x14FC4B0")]
	public void SyncDeadPosition(Vector3 ACCOJJMKKPM)
	{
	}

	[Token(Token = "0x6004A63")]
	[Address(RVA = "0x14FC7A4", Offset = "0x14FC7A4", VA = "0x14FC7A4", Slot = "317")]
	public void SyncInventoryInfo(BGKCMKNDAGA KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6004A64")]
	[Address(RVA = "0x14FCC24", Offset = "0x14FCC24", VA = "0x14FCC24", Slot = "318")]
	public void SyncAttachmentInfo(List<JPALKHEHFIM> CNLFNIHHCHH)
	{
	}

	[Token(Token = "0x6004A65")]
	[Address(RVA = "0x14FCDD0", Offset = "0x14FCDD0", VA = "0x14FCDD0")]
	public void SyncSecondWeaponDataStatus(HGKBCALNBJK KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6004A66")]
	[Address(RVA = "0x14FCF14", Offset = "0x14FCF14", VA = "0x14FCF14")]
	public void SyncWeaponAmmoInClip(FHNKIFBANMH KMIPBIGPDPI)
	{
	}

	[Token(Token = "0x6004A67")]
	[Address(RVA = "0x14FCFE4", Offset = "0x14FCFE4", VA = "0x14FCFE4", Slot = "203")]
	public override void ReviveInitMotionState(Vector3 ACCOJJMKKPM, Quaternion JGOGIAFGCFC, uint DDFGMFGPDEK)
	{
	}

	[Token(Token = "0x6004A68")]
	[Address(RVA = "0x14FD370", Offset = "0x14FD370", VA = "0x14FD370", Slot = "342")]
	public virtual void SyncTeleportInfo(JIIKBLKJCKM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A69")]
	[Address(RVA = "0x14F5F08", Offset = "0x14F5F08", VA = "0x14F5F08")]
	private bool DGGMFEPOIEJ()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A6A")]
	[Address(RVA = "0x14F6204", Offset = "0x14F6204", VA = "0x14F6204")]
	private void DOIHPCMJEHE(float HHDJIFKMMAJ, Vector3 BNDPJDJAFOM, Vector3 NFCLOPBEKGN, Vector3 DAFFCNMJLHL)
	{
	}

	[Token(Token = "0x6004A6B")]
	[Address(RVA = "0x14F6144", Offset = "0x14F6144", VA = "0x14F6144")]
	private bool LKPBJOFIBLC()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A6D")]
	[Address(RVA = "0x14FE288", Offset = "0x14FE288", VA = "0x14FE288")]
	private float EFEDFMNEFNC(ushort JLFOIHNNAJK)
	{
		return default(float);
	}

	[Token(Token = "0x6004A6E")]
	[Address(RVA = "0x14FE300", Offset = "0x14FE300", VA = "0x14FE300")]
	protected void ELPJMACFGEL(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A6F")]
	[Address(RVA = "0x14FE470", Offset = "0x14FE470", VA = "0x14FE470")]
	protected void OJFGCGHAMFN(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A70")]
	[Address(RVA = "0x14FE55C", Offset = "0x14FE55C", VA = "0x14FE55C")]
	protected void KNADOHCIKMC(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A71")]
	[Address(RVA = "0x14FE7AC", Offset = "0x14FE7AC", VA = "0x14FE7AC")]
	protected void JIEAOAGPOIM(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A72")]
	[Address(RVA = "0x14FE938", Offset = "0x14FE938", VA = "0x14FE938")]
	protected void CFENAMAAEHI(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A73")]
	[Address(RVA = "0x14FEBCC", Offset = "0x14FEBCC", VA = "0x14FEBCC")]
	protected void HBHEEHKKGAJ(ushort IIJMFDCBGAJ, ushort NPLOJLCFCKO)
	{
	}

	[Token(Token = "0x6004A74")]
	[Address(RVA = "0x14FED58", Offset = "0x14FED58", VA = "0x14FED58", Slot = "343")]
	public virtual void ShowAttMsg(string LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004A75")]
	[Address(RVA = "0x14FEF10", Offset = "0x14FEF10", VA = "0x14FEF10")]
	public void OnSyncPlayerCollectionSkin(uint LAIIJPFGAPF)
	{
	}

	[Token(Token = "0x6004A76")]
	[Address(RVA = "0x14FF078", Offset = "0x14FF078", VA = "0x14FF078")]
	public bool OnDebugSetSkinID(uint KBBMIAOMMOH, uint LAIIJPFGAPF)
	{
		return default(bool);
	}

	[Token(Token = "0x6004A77")]
	[Address(RVA = "0x14E139C", Offset = "0x14E139C", VA = "0x14E139C", Slot = "24")]
	protected override void OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004A78")]
	[Address(RVA = "0x14FFBD8", Offset = "0x14FFBD8", VA = "0x14FFBD8")]
	public void OnSkillsChanged(List<NANIPKCMIIE> APGCIMHHGAD, DEHNALLDFNB OMNGGLFFMGM)
	{
	}

	[Token(Token = "0x6004A79")]
	[Address(RVA = "0x1500848", Offset = "0x1500848", VA = "0x1500848")]
	private void FFLAGGLLILD()
	{
	}

	[Token(Token = "0x6004A7A")]
	[Address(RVA = "0x1500854", Offset = "0x1500854", VA = "0x1500854")]
	public new void _003C_003EiFixBaseProxy_OnUserDefineReplicationInfo()
	{
	}

	[Token(Token = "0x6004A7B")]
	[Address(RVA = "0x150085C", Offset = "0x150085C", VA = "0x150085C")]
	public void _003C_003EiFixBaseProxy_InitProperties(object P0, bool P1)
	{
	}

	[Token(Token = "0x6004A7C")]
	[Address(RVA = "0x1500864", Offset = "0x1500864", VA = "0x1500864")]
	public void _003C_003EiFixBaseProxy_UpdateBehavior(float P0, float P1)
	{
	}

	[Token(Token = "0x6004A7D")]
	[Address(RVA = "0x150086C", Offset = "0x150086C", VA = "0x150086C")]
	public BaseProfileInfo _003C_003EiFixBaseProxy_get_Profile()
	{
		return null;
	}

	[Token(Token = "0x6004A7E")]
	[Address(RVA = "0x1500874", Offset = "0x1500874", VA = "0x1500874")]
	public bool _003C_003EiFixBaseProxy_HaveFlight()
	{
		return default(bool);
	}

	[Token(Token = "0x6004A7F")]
	[Address(RVA = "0x150087C", Offset = "0x150087C", VA = "0x150087C")]
	public BaseProfileInfo _003C_003EiFixBaseProxy_PlayerBaseProfile()
	{
		return null;
	}

	[Token(Token = "0x6004A80")]
	[Address(RVA = "0x1500884", Offset = "0x1500884", VA = "0x1500884")]
	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6004A81")]
	[Address(RVA = "0x150088C", Offset = "0x150088C", VA = "0x150088C")]
	public void _003C_003EiFixBaseProxy_RequestStopEmote4Plant()
	{
	}

	[Token(Token = "0x6004A82")]
	[Address(RVA = "0x1500894", Offset = "0x1500894", VA = "0x1500894")]
	public void _003C_003EiFixBaseProxy_RequestPlayEmote4Plant(OFJHNKMJNGA P0, uint P1)
	{
	}

	[Token(Token = "0x6004A83")]
	[Address(RVA = "0x150089C", Offset = "0x150089C", VA = "0x150089C")]
	public void _003C_003EiFixBaseProxy_RequestStoreInWareHouse(uint P0)
	{
	}

	[Token(Token = "0x6004A84")]
	[Address(RVA = "0x15008A4", Offset = "0x15008A4", VA = "0x15008A4")]
	public void _003C_003EiFixBaseProxy_RequestStopStoringInWarehouse()
	{
	}

	[Token(Token = "0x6004A85")]
	[Address(RVA = "0x15008AC", Offset = "0x15008AC", VA = "0x15008AC")]
	public void _003C_003EiFixBaseProxy_RequestOpenTreasury()
	{
	}

	[Token(Token = "0x6004A86")]
	[Address(RVA = "0x15008B4", Offset = "0x15008B4", VA = "0x15008B4")]
	public void _003C_003EiFixBaseProxy_RequestOpenTimingTreasureBox()
	{
	}

	[Token(Token = "0x6004A87")]
	[Address(RVA = "0x15008BC", Offset = "0x15008BC", VA = "0x15008BC")]
	public void _003C_003EiFixBaseProxy_RequestHayrickJump()
	{
	}

	[Token(Token = "0x6004A88")]
	[Address(RVA = "0x15008C4", Offset = "0x15008C4", VA = "0x15008C4")]
	public void _003C_003EiFixBaseProxy_RequestPray4EscortBoss(uint P0)
	{
	}

	[Token(Token = "0x6004A89")]
	[Address(RVA = "0x15008CC", Offset = "0x15008CC", VA = "0x15008CC")]
	public void _003C_003EiFixBaseProxy_RequestStopPraying4EscortBoss()
	{
	}

	[Token(Token = "0x6004A8A")]
	[Address(RVA = "0x15008D4", Offset = "0x15008D4", VA = "0x15008D4")]
	public void _003C_003EiFixBaseProxy_DoUpdateActionState(EAcationState P0, EPreparationTimerType P1, float P2)
	{
	}

	[Token(Token = "0x6004A8B")]
	[Address(RVA = "0x15008F4", Offset = "0x15008F4", VA = "0x15008F4")]
	public void _003C_003EiFixBaseProxy_OnWeaponReloadStarted(float P0, bool P1)
	{
	}

	[Token(Token = "0x6004A8C")]
	[Address(RVA = "0x15008FC", Offset = "0x15008FC", VA = "0x15008FC")]
	public void _003C_003EiFixBaseProxy_OnWeaponReloadFinished(bool P0)
	{
	}

	[Token(Token = "0x6004A8D")]
	[Address(RVA = "0x1500904", Offset = "0x1500904", VA = "0x1500904")]
	public void _003C_003EiFixBaseProxy_OnWeaponLift(bool P0)
	{
	}

	[Token(Token = "0x6004A8E")]
	[Address(RVA = "0x150090C", Offset = "0x150090C", VA = "0x150090C")]
	public void _003C_003EiFixBaseProxy_UpdateAI(float P0, float P1)
	{
	}

	[Token(Token = "0x6004A8F")]
	[Address(RVA = "0x1500914", Offset = "0x1500914", VA = "0x1500914")]
	public void _003C_003EiFixBaseProxy_ENOKKOIOGGN()
	{
	}

	[Token(Token = "0x6004A90")]
	[Address(RVA = "0x150091C", Offset = "0x150091C", VA = "0x150091C")]
	public void _003C_003EiFixBaseProxy_UpdateKinematics(float P0, float P1)
	{
	}

	[Token(Token = "0x6004A91")]
	[Address(RVA = "0x1500924", Offset = "0x1500924", VA = "0x1500924")]
	public void _003C_003EiFixBaseProxy_OnGetOffChair(LevelChair P0)
	{
	}

	[Token(Token = "0x6004A92")]
	[Address(RVA = "0x150092C", Offset = "0x150092C", VA = "0x150092C")]
	public void _003C_003EiFixBaseProxy_OnGetOffVehicle()
	{
	}

	[Token(Token = "0x6004A93")]
	[Address(RVA = "0x1500934", Offset = "0x1500934", VA = "0x1500934")]
	public void _003C_003EiFixBaseProxy_OnGetOnVehicle(Vehicle P0)
	{
	}

	[Token(Token = "0x6004A94")]
	[Address(RVA = "0x150093C", Offset = "0x150093C", VA = "0x150093C")]
	public void _003C_003EiFixBaseProxy_OnGetOnFerrisWheel(LevelFerrisWheel P0, byte P1, byte P2)
	{
	}

	[Token(Token = "0x6004A95")]
	[Address(RVA = "0x150095C", Offset = "0x150095C", VA = "0x150095C")]
	public void _003C_003EiFixBaseProxy_OnGetOffFerrisWheel(byte P0, byte P1)
	{
	}

	[Token(Token = "0x6004A96")]
	[Address(RVA = "0x1500964", Offset = "0x1500964", VA = "0x1500964")]
	public int _003C_003EiFixBaseProxy_TakeDamage(int P0, IHAAMHPPLMG P1, ELMGJKHIIAA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, MKFEKBKJCKE P7, uint P8)
	{
		return default(int);
	}

	[Token(Token = "0x6004A97")]
	[Address(RVA = "0x15009EC", Offset = "0x15009EC", VA = "0x15009EC")]
	public new void _003C_003EiFixBaseProxy_TakeHealing(int P0, IHAAMHPPLMG P1, int P2, Vector3 P3, Vector3 P4, List<float> P5)
	{
	}

	[Token(Token = "0x6004A98")]
	[Address(RVA = "0x1500A5C", Offset = "0x1500A5C", VA = "0x1500A5C")]
	public void _003C_003EiFixBaseProxy_StartFiring(GPBDEDFKJNA P0)
	{
	}

	[Token(Token = "0x6004A99")]
	[Address(RVA = "0x1500A64", Offset = "0x1500A64", VA = "0x1500A64")]
	public void _003C_003EiFixBaseProxy_StartWarmUp(GPBDEDFKJNA P0)
	{
	}

	[Token(Token = "0x6004A9A")]
	[Address(RVA = "0x1500A6C", Offset = "0x1500A6C", VA = "0x1500A6C")]
	public void _003C_003EiFixBaseProxy_StopCharge(GPBDEDFKJNA P0)
	{
	}

	[Token(Token = "0x6004A9B")]
	[Address(RVA = "0x1500A74", Offset = "0x1500A74", VA = "0x1500A74")]
	public void _003C_003EiFixBaseProxy_StopFire(GPBDEDFKJNA P0)
	{
	}

	[Token(Token = "0x6004A9C")]
	[Address(RVA = "0x1500A7C", Offset = "0x1500A7C", VA = "0x1500A7C")]
	public void _003C_003EiFixBaseProxy_SwapWeapon(int P0, bool P1, List<int> P2)
	{
	}

	[Token(Token = "0x6004A9D")]
	[Address(RVA = "0x1500A9C", Offset = "0x1500A9C", VA = "0x1500A9C")]
	public void _003C_003EiFixBaseProxy_SwapWeapon(BMGBKEENCJH P0, bool P1)
	{
	}

	[Token(Token = "0x6004A9E")]
	[Address(RVA = "0x1500AA4", Offset = "0x1500AA4", VA = "0x1500AA4")]
	public void _003C_003EiFixBaseProxy_OnLandFinsish()
	{
	}

	[Token(Token = "0x6004A9F")]
	[Address(RVA = "0x1500AAC", Offset = "0x1500AAC", VA = "0x1500AAC")]
	public bool _003C_003EiFixBaseProxy_GetSightingState()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA0")]
	[Address(RVA = "0x1500AB4", Offset = "0x1500AB4", VA = "0x1500AB4")]
	public bool _003C_003EiFixBaseProxy_RequestRescureTarget(IHAAMHPPLMG P0)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA1")]
	[Address(RVA = "0x1500AE8", Offset = "0x1500AE8", VA = "0x1500AE8")]
	public bool _003C_003EiFixBaseProxy_RequestStopResure()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA2")]
	[Address(RVA = "0x1500AF0", Offset = "0x1500AF0", VA = "0x1500AF0")]
	public void _003C_003EiFixBaseProxy_Dead(int P0, IHAAMHPPLMG P1, bool P2, bool P3)
	{
	}

	[Token(Token = "0x6004AA3")]
	[Address(RVA = "0x1500B3C", Offset = "0x1500B3C", VA = "0x1500B3C")]
	public void _003C_003EiFixBaseProxy_SetAI(bool P0)
	{
	}

	[Token(Token = "0x6004AA4")]
	[Address(RVA = "0x1500B44", Offset = "0x1500B44", VA = "0x1500B44")]
	public bool _003C_003EiFixBaseProxy_RequestPlayCustomAnimation()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA5")]
	[Address(RVA = "0x1500B4C", Offset = "0x1500B4C", VA = "0x1500B4C")]
	public bool _003C_003EiFixBaseProxy_RequestUseBattleFlag()
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA6")]
	[Address(RVA = "0x1500B54", Offset = "0x1500B54", VA = "0x1500B54")]
	public bool _003C_003EiFixBaseProxy_RequestPlayEmotionAnimation(uint P0, float P1)
	{
		return default(bool);
	}

	[Token(Token = "0x6004AA7")]
	[Address(RVA = "0x1500B5C", Offset = "0x1500B5C", VA = "0x1500B5C")]
	public void _003C_003EiFixBaseProxy_ReviveInitMotionState(Vector3 P0, Quaternion P1, uint P2)
	{
	}
}
