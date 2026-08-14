using System.Collections.Generic;
using System.Runtime.InteropServices;
using Il2CppDummyDll;
using UnityEngine;
using message;

namespace COW.GamePlay;

[Token(Token = "0x20009D5")]
internal class PlayerSingersB : PlayerNetwork
{
	[Token(Token = "0x20009D6")]
	public enum EJFHOBDOEAC
	{
		[Token(Token = "0x40059F8")]
		EnumKeyStateOrder_StarFalling,
		[Token(Token = "0x40059F9")]
		EnumKeyStateOrder_BeginFlight,
		[Token(Token = "0x40059FA")]
		EnumKeyStateOrder_FlightToSkate,
		[Token(Token = "0x40059FB")]
		EnumKeyStateOrder_SkateToFlight,
		[Token(Token = "0x40059FC")]
		EnumKeyStateOrder_CallDanceTeleport
	}

	[Token(Token = "0x40059F2")]
	[FieldOffset(Offset = "0x9C8")]
	public EJFHOBDOEAC CurKeyState;

	[Token(Token = "0x40059F3")]
	[FieldOffset(Offset = "0x9CC")]
	private SpeedChange KEDGBHBJHPB;

	[Token(Token = "0x40059F4")]
	[FieldOffset(Offset = "0x9D0")]
	public GameObject m_SpeedUpEffect;

	[Token(Token = "0x40059F5")]
	[FieldOffset(Offset = "0x9D4")]
	private ParticleSystem JCDDCONFBKJ;

	[Token(Token = "0x40059F6")]
	private const float ENFDOCCEFPH = 0.95f;

	[Token(Token = "0x6004B93")]
	[Address(RVA = "0x2108D1C", Offset = "0x2108D1C", VA = "0x2108D1C")]
	public PlayerSingersB()
	{
	}

	[Token(Token = "0x6004B94")]
	[Address(RVA = "0x2108D98", Offset = "0x2108D98", VA = "0x2108D98", Slot = "103")]
	public override void InitProperties(object KGCOINAOBOH, bool HMLKNAHACCI = true)
	{
	}

	[Token(Token = "0x6004B95")]
	[Address(RVA = "0x2108E44", Offset = "0x2108E44", VA = "0x2108E44")]
	private void GEFLNPGNOBN()
	{
	}

	[Token(Token = "0x6004B96")]
	[Address(RVA = "0x2109120", Offset = "0x2109120", VA = "0x2109120")]
	public void ChangeSpeed(float CFDKBMGONMP, float NAHOKHJEBIL, float IJJPNHHMHPJ, float COHMPBJCIPI)
	{
	}

	[Token(Token = "0x6004B97")]
	[Address(RVA = "0x21091E4", Offset = "0x21091E4", VA = "0x21091E4", Slot = "154")]
	public override float GetExtraSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6004B98")]
	[Address(RVA = "0x2109258", Offset = "0x2109258", VA = "0x2109258", Slot = "18")]
	public override void OnUpdate(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004B99")]
	[Address(RVA = "0x2108EAC", Offset = "0x2108EAC", VA = "0x2108EAC")]
	protected void LKLJCHDKJAC()
	{
	}

	[Token(Token = "0x6004B9A")]
	[Address(RVA = "0x21092FC", Offset = "0x21092FC", VA = "0x21092FC", Slot = "321")]
	protected override void NPAHMINLFJA()
	{
	}

	[Token(Token = "0x6004B9B")]
	[Address(RVA = "0x21093FC", Offset = "0x21093FC", VA = "0x21093FC", Slot = "242")]
	public override bool CanFlightRoam()
	{
		return default(bool);
	}

	[Token(Token = "0x6004B9C")]
	[Address(RVA = "0x2109454", Offset = "0x2109454", VA = "0x2109454", Slot = "240")]
	public override void RequestChangeFlightRoamState(bool OFEBJECKEBE)
	{
	}

	[Token(Token = "0x6004B9D")]
	[Address(RVA = "0x2109578", Offset = "0x2109578", VA = "0x2109578", Slot = "272")]
	protected override void GOPCHBGONHM()
	{
	}

	[Token(Token = "0x6004B9E")]
	[Address(RVA = "0x2109778", Offset = "0x2109778", VA = "0x2109778", Slot = "273")]
	protected override void CHHIDDHMGHA()
	{
	}

	[Token(Token = "0x6004B9F")]
	[Address(RVA = "0x21098DC", Offset = "0x21098DC", VA = "0x21098DC", Slot = "274")]
	protected override void OCIILCDCKPB(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004BA0")]
	[Address(RVA = "0x2109CA0", Offset = "0x2109CA0", VA = "0x2109CA0", Slot = "275")]
	protected override void PMEIEBKGCEF()
	{
	}

	[Token(Token = "0x6004BA1")]
	[Address(RVA = "0x2109FAC", Offset = "0x2109FAC", VA = "0x2109FAC", Slot = "259")]
	protected override void MFNJELADALH(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004BA2")]
	[Address(RVA = "0x210A844", Offset = "0x210A844", VA = "0x210A844")]
	protected void EMHJGOMJGFI(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
	}

	[Token(Token = "0x6004BA3")]
	[Address(RVA = "0x210A234", Offset = "0x210A234", VA = "0x210A234")]
	protected Vector3 DNBMMNDDGDA(float OPKNJGBDOBB, float OMAFEKBHOAA)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		return default(Vector3);
	}

	[Token(Token = "0x6004BA4")]
	[Address(RVA = "0x210ADA8", Offset = "0x210ADA8", VA = "0x210ADA8", Slot = "225")]
	public override void SwitchToFlight(bool OFEBJECKEBE)
	{
	}

	[Token(Token = "0x6004BA5")]
	[Address(RVA = "0x210AE20", Offset = "0x210AE20", VA = "0x210AE20", Slot = "221")]
	public override void OnEnterFlightChangeCamera()
	{
	}

	[Token(Token = "0x6004BA6")]
	[Address(RVA = "0x210AE74", Offset = "0x210AE74", VA = "0x210AE74", Slot = "222")]
	public override void OnExitFlightChangeCamera()
	{
	}

	[Token(Token = "0x6004BA7")]
	[Address(RVA = "0x210AEC8", Offset = "0x210AEC8", VA = "0x210AEC8")]
	private void Update()
	{
	}

	[Token(Token = "0x6004BA8")]
	[Address(RVA = "0x210AF28", Offset = "0x210AF28", VA = "0x210AF28")]
	private void FEOPMCKLOEA()
	{
	}

	[Token(Token = "0x6004BA9")]
	[Address(RVA = "0x210B198", Offset = "0x210B198", VA = "0x210B198", Slot = "228")]
	public override void SpawnStarLightToXJ()
	{
	}

	[Token(Token = "0x6004BAA")]
	[Address(RVA = "0x210B6B0", Offset = "0x210B6B0", VA = "0x210B6B0")]
	public void RequestDropMusicStick()
	{
	}

	[Token(Token = "0x6004BAB")]
	[Address(RVA = "0x210B7B8", Offset = "0x210B7B8", VA = "0x210B7B8", Slot = "153")]
	protected override void NHBCHNEHPDJ()
	{
	}

	[Token(Token = "0x6004BAC")]
	[Address(RVA = "0x210BAD4", Offset = "0x210BAD4", VA = "0x210BAD4", Slot = "342")]
	public override void SyncTeleportInfo(JIIKBLKJCKM LHCHNFGKLHD)
	{
	}

	[Token(Token = "0x6004BAD")]
	[Address(RVA = "0x210BC3C", Offset = "0x210BC3C", VA = "0x210BC3C", Slot = "124")]
	public override int TakeDamage(int KOCMLPLOILD, IHAAMHPPLMG HLJDHPGGODB, [Optional] ELMGJKHIIAA JIIJIFKKCCB, int BOEIBGAABDL = -1, [Optional] Vector3 NJMFBKNHMBP, [Optional] Vector3 DOBOBMFMKBJ, [Optional] List<float> NBKBEBFNDBE, [Optional] MKFEKBKJCKE OPINPCANMDE, uint GGIDKOBOJBB = 0u)
	{
		return default(int);
	}

	[Token(Token = "0x6004BAE")]
	[Address(RVA = "0x210BD34", Offset = "0x210BD34", VA = "0x210BD34", Slot = "212")]
	public override bool IsIgnorePlayerAudioComponent()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BAF")]
	[Address(RVA = "0x210BD8C", Offset = "0x210BD8C", VA = "0x210BD8C", Slot = "218")]
	public override bool IsCameraUseTargetBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BB0")]
	[Address(RVA = "0x210BDE4", Offset = "0x210BDE4", VA = "0x210BDE4", Slot = "320")]
	protected override bool MNMKNHEDAPH()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BB1")]
	[Address(RVA = "0x210BE3C", Offset = "0x210BE3C", VA = "0x210BE3C", Slot = "115")]
	protected override void LNMJFMKPKEO()
	{
	}

	[Token(Token = "0x6004BB2")]
	[Address(RVA = "0x210BEC8", Offset = "0x210BEC8", VA = "0x210BEC8", Slot = "341")]
	public override void RequestFoceSyncPosition()
	{
	}

	[Token(Token = "0x6004BB3")]
	[Address(RVA = "0x210BF1C", Offset = "0x210BF1C", VA = "0x210BF1C", Slot = "223")]
	public override void FlightFollowToSkateBoard()
	{
	}

	[Token(Token = "0x6004BB4")]
	[Address(RVA = "0x210C51C", Offset = "0x210C51C", VA = "0x210C51C", Slot = "224")]
	protected override void EKDCDADDHFM()
	{
	}

	[Token(Token = "0x6004BB5")]
	[Address(RVA = "0x210C58C", Offset = "0x210C58C", VA = "0x210C58C", Slot = "226")]
	public override void SkateBoardToFlightFollow()
	{
	}

	[Token(Token = "0x6004BB6")]
	[Address(RVA = "0x210C9D8", Offset = "0x210C9D8", VA = "0x210C9D8", Slot = "227")]
	protected override void ADIINCGOMBB()
	{
	}

	[Token(Token = "0x6004BB7")]
	[Address(RVA = "0x210CA48", Offset = "0x210CA48", VA = "0x210CA48", Slot = "229")]
	public override void OnPreTeleportCallDance()
	{
	}

	[Token(Token = "0x6004BB8")]
	[Address(RVA = "0x210CAC4", Offset = "0x210CAC4", VA = "0x210CAC4", Slot = "117")]
	protected override bool ANHDPJADLOH()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BB9")]
	[Address(RVA = "0x210CB1C", Offset = "0x210CB1C", VA = "0x210CB1C")]
	public new void _003C_003EiFixBaseProxy_InitProperties(object P0, bool P1)
	{
	}

	[Token(Token = "0x6004BBA")]
	[Address(RVA = "0x210CB24", Offset = "0x210CB24", VA = "0x210CB24")]
	public float _003C_003EiFixBaseProxy_GetExtraSpeed()
	{
		return default(float);
	}

	[Token(Token = "0x6004BBB")]
	[Address(RVA = "0x210CB2C", Offset = "0x210CB2C", VA = "0x210CB2C")]
	public new void _003C_003EiFixBaseProxy_OnUpdate(float P0, float P1)
	{
	}

	[Token(Token = "0x6004BBC")]
	[Address(RVA = "0x210CB34", Offset = "0x210CB34", VA = "0x210CB34")]
	public void _003C_003EiFixBaseProxy_NPAHMINLFJA()
	{
	}

	[Token(Token = "0x6004BBD")]
	[Address(RVA = "0x210CB3C", Offset = "0x210CB3C", VA = "0x210CB3C")]
	public bool _003C_003EiFixBaseProxy_CanFlightRoam()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BBE")]
	[Address(RVA = "0x210CB44", Offset = "0x210CB44", VA = "0x210CB44")]
	public void _003C_003EiFixBaseProxy_RequestChangeFlightRoamState(bool P0)
	{
	}

	[Token(Token = "0x6004BBF")]
	[Address(RVA = "0x210CB4C", Offset = "0x210CB4C", VA = "0x210CB4C")]
	public void _003C_003EiFixBaseProxy_GOPCHBGONHM()
	{
	}

	[Token(Token = "0x6004BC0")]
	[Address(RVA = "0x210CB54", Offset = "0x210CB54", VA = "0x210CB54")]
	public void _003C_003EiFixBaseProxy_CHHIDDHMGHA()
	{
	}

	[Token(Token = "0x6004BC1")]
	[Address(RVA = "0x210CB5C", Offset = "0x210CB5C", VA = "0x210CB5C")]
	public void _003C_003EiFixBaseProxy_OCIILCDCKPB(float P0, float P1)
	{
	}

	[Token(Token = "0x6004BC2")]
	[Address(RVA = "0x210CB64", Offset = "0x210CB64", VA = "0x210CB64")]
	public void _003C_003EiFixBaseProxy_PMEIEBKGCEF()
	{
	}

	[Token(Token = "0x6004BC3")]
	[Address(RVA = "0x210CB6C", Offset = "0x210CB6C", VA = "0x210CB6C")]
	public void _003C_003EiFixBaseProxy_MFNJELADALH(float P0, float P1)
	{
	}

	[Token(Token = "0x6004BC4")]
	[Address(RVA = "0x210CB74", Offset = "0x210CB74", VA = "0x210CB74")]
	public void _003C_003EiFixBaseProxy_SwitchToFlight(bool P0)
	{
	}

	[Token(Token = "0x6004BC5")]
	[Address(RVA = "0x210CB7C", Offset = "0x210CB7C", VA = "0x210CB7C")]
	public void _003C_003EiFixBaseProxy_OnEnterFlightChangeCamera()
	{
	}

	[Token(Token = "0x6004BC6")]
	[Address(RVA = "0x210CB84", Offset = "0x210CB84", VA = "0x210CB84")]
	public void _003C_003EiFixBaseProxy_OnExitFlightChangeCamera()
	{
	}

	[Token(Token = "0x6004BC7")]
	[Address(RVA = "0x210CB8C", Offset = "0x210CB8C", VA = "0x210CB8C")]
	public void _003C_003EiFixBaseProxy_SpawnStarLightToXJ()
	{
	}

	[Token(Token = "0x6004BC8")]
	[Address(RVA = "0x210CB94", Offset = "0x210CB94", VA = "0x210CB94")]
	public void _003C_003EiFixBaseProxy_NHBCHNEHPDJ()
	{
	}

	[Token(Token = "0x6004BC9")]
	[Address(RVA = "0x210CB9C", Offset = "0x210CB9C", VA = "0x210CB9C")]
	public void _003C_003EiFixBaseProxy_SyncTeleportInfo(JIIKBLKJCKM P0)
	{
	}

	[Token(Token = "0x6004BCA")]
	[Address(RVA = "0x210CBA4", Offset = "0x210CBA4", VA = "0x210CBA4")]
	public new int _003C_003EiFixBaseProxy_TakeDamage(int P0, IHAAMHPPLMG P1, ELMGJKHIIAA P2, int P3, Vector3 P4, Vector3 P5, List<float> P6, MKFEKBKJCKE P7, uint P8)
	{
		return default(int);
	}

	[Token(Token = "0x6004BCB")]
	[Address(RVA = "0x210CC2C", Offset = "0x210CC2C", VA = "0x210CC2C")]
	public bool _003C_003EiFixBaseProxy_IsIgnorePlayerAudioComponent()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BCC")]
	[Address(RVA = "0x210CC34", Offset = "0x210CC34", VA = "0x210CC34")]
	public bool _003C_003EiFixBaseProxy_IsCameraUseTargetBackOffset()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BCD")]
	[Address(RVA = "0x210CC3C", Offset = "0x210CC3C", VA = "0x210CC3C")]
	public bool _003C_003EiFixBaseProxy_MNMKNHEDAPH()
	{
		return default(bool);
	}

	[Token(Token = "0x6004BCE")]
	[Address(RVA = "0x210CC44", Offset = "0x210CC44", VA = "0x210CC44")]
	public void _003C_003EiFixBaseProxy_LNMJFMKPKEO()
	{
	}

	[Token(Token = "0x6004BCF")]
	[Address(RVA = "0x210CC4C", Offset = "0x210CC4C", VA = "0x210CC4C")]
	public void _003C_003EiFixBaseProxy_RequestFoceSyncPosition()
	{
	}

	[Token(Token = "0x6004BD0")]
	[Address(RVA = "0x210CC54", Offset = "0x210CC54", VA = "0x210CC54")]
	public void _003C_003EiFixBaseProxy_FlightFollowToSkateBoard()
	{
	}

	[Token(Token = "0x6004BD1")]
	[Address(RVA = "0x210CC5C", Offset = "0x210CC5C", VA = "0x210CC5C")]
	public void _003C_003EiFixBaseProxy_EKDCDADDHFM()
	{
	}

	[Token(Token = "0x6004BD2")]
	[Address(RVA = "0x210CC64", Offset = "0x210CC64", VA = "0x210CC64")]
	public void _003C_003EiFixBaseProxy_SkateBoardToFlightFollow()
	{
	}

	[Token(Token = "0x6004BD3")]
	[Address(RVA = "0x210CC6C", Offset = "0x210CC6C", VA = "0x210CC6C")]
	public void _003C_003EiFixBaseProxy_ADIINCGOMBB()
	{
	}

	[Token(Token = "0x6004BD4")]
	[Address(RVA = "0x210CC74", Offset = "0x210CC74", VA = "0x210CC74")]
	public void _003C_003EiFixBaseProxy_OnPreTeleportCallDance()
	{
	}

	[Token(Token = "0x6004BD5")]
	[Address(RVA = "0x210CC7C", Offset = "0x210CC7C", VA = "0x210CC7C")]
	public bool _003C_003EiFixBaseProxy_ANHDPJADLOH()
	{
		return default(bool);
	}
}
