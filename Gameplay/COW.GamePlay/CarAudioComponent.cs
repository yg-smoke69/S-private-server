using System.Collections.Generic;
using GCommon;
using Il2CppDummyDll;
using UnityEngine;
using WwiseGameSyncs;

namespace COW.GamePlay;

[Token(Token = "0x20003F6")]
internal class CarAudioComponent : MonoBehaviour
{
	[Token(Token = "0x20003F7")]
	public enum ALFAFAAPAGE
	{
		[Token(Token = "0x4003A02")]
		Simple,
		[Token(Token = "0x4003A03")]
		FourChannel
	}

	[Token(Token = "0x40039DF")]
	[FieldOffset(Offset = "0xC")]
	public ALFAFAAPAGE engineSoundStyle;

	[Token(Token = "0x40039E0")]
	[FieldOffset(Offset = "0x10")]
	public float pitchMultiplier;

	[Token(Token = "0x40039E1")]
	[FieldOffset(Offset = "0x14")]
	public float lowPitchMin;

	[Token(Token = "0x40039E2")]
	[FieldOffset(Offset = "0x18")]
	public float lowPitchMax;

	[Token(Token = "0x40039E3")]
	[FieldOffset(Offset = "0x1C")]
	public float highPitchMultiplier;

	[Token(Token = "0x40039E4")]
	[FieldOffset(Offset = "0x20")]
	public float maxRolloffDistance;

	[Token(Token = "0x40039E5")]
	[FieldOffset(Offset = "0x24")]
	public float dopplerLevel;

	[Token(Token = "0x40039E6")]
	[FieldOffset(Offset = "0x28")]
	public bool useDoppler;

	[Token(Token = "0x40039E7")]
	[FieldOffset(Offset = "0x2C")]
	public string HighAccelerationResourceName;

	[Token(Token = "0x40039E8")]
	[FieldOffset(Offset = "0x30")]
	public string StartUpResourceName;

	[Token(Token = "0x40039E9")]
	[FieldOffset(Offset = "0x34")]
	public string StopResourceName;

	[Token(Token = "0x40039EA")]
	[FieldOffset(Offset = "0x38")]
	public string SkidResourceName;

	[Token(Token = "0x40039EB")]
	[FieldOffset(Offset = "0x3C")]
	private AudioSource DJBIAAPBGKA;

	[Token(Token = "0x40039EC")]
	[FieldOffset(Offset = "0x40")]
	private AudioSource FHMEIGIOPBJ;

	[Token(Token = "0x40039ED")]
	[FieldOffset(Offset = "0x44")]
	private AudioSource ACLPJDHFLKC;

	[Token(Token = "0x40039EE")]
	[FieldOffset(Offset = "0x48")]
	private AudioSource MKDGNMOJNAM;

	[Token(Token = "0x40039EF")]
	[FieldOffset(Offset = "0x4C")]
	private AudioSource GMFHKJJLNFK;

	[Token(Token = "0x40039F0")]
	[FieldOffset(Offset = "0x50")]
	private ResourceID HPGIKCGJECC;

	[Token(Token = "0x40039F1")]
	[FieldOffset(Offset = "0x54")]
	private ResourceID PDPMMLCBEBP;

	[Token(Token = "0x40039F2")]
	[FieldOffset(Offset = "0x58")]
	private ResourceID LIECHDCEHDK;

	[Token(Token = "0x40039F3")]
	[FieldOffset(Offset = "0x5C")]
	private bool KBKGBGDNDHO;

	[Token(Token = "0x40039F4")]
	[FieldOffset(Offset = "0x60")]
	private VehicleControllerInterface IGECMFCOLPJ;

	[Token(Token = "0x40039F5")]
	[FieldOffset(Offset = "0x64")]
	private Vehicle NDNNIIKIDBO;

	[Token(Token = "0x40039F6")]
	[FieldOffset(Offset = "0x68")]
	private bool HFNIJPAAGCK;

	[Token(Token = "0x40039F7")]
	[FieldOffset(Offset = "0x69")]
	private bool GFNDBCFBAPF;

	[Token(Token = "0x40039F8")]
	[FieldOffset(Offset = "0x6C")]
	private float ALLBGJACOEH;

	[Token(Token = "0x40039F9")]
	[FieldOffset(Offset = "0x70")]
	private GameObject FMDMBDFPAPD;

	[Token(Token = "0x40039FA")]
	[FieldOffset(Offset = "0x74")]
	private GameObject JFDPPODJKIH;

	[Token(Token = "0x40039FB")]
	[FieldOffset(Offset = "0x78")]
	private Dictionary<uint, ResourceID> CJPDAKCNJBO;

	[Token(Token = "0x40039FC")]
	[FieldOffset(Offset = "0x7C")]
	private CDPEGEHFLFO EEBENGOJJOK;

	[Token(Token = "0x40039FD")]
	[FieldOffset(Offset = "0x80")]
	private Dictionary<uint, ResourceID> IENIBGJMAGP;

	[Token(Token = "0x40039FE")]
	[FieldOffset(Offset = "0x84")]
	private Dictionary<AudioClip, AudioSource> JHKICGJNPCJ;

	[Token(Token = "0x40039FF")]
	[FieldOffset(Offset = "0x88")]
	private bool GAPDNODLCJN;

	[Token(Token = "0x4003A00")]
	[FieldOffset(Offset = "0x89")]
	private bool DNAGNJJNPCF;

	[Token(Token = "0x60012A1")]
	[Address(RVA = "0x1E95C48", Offset = "0x1E95C48", VA = "0x1E95C48")]
	public CarAudioComponent()
	{
	}

	[Token(Token = "0x60012A2")]
	[Address(RVA = "0x1E95E18", Offset = "0x1E95E18", VA = "0x1E95E18")]
	public WwiseGameSyncID GetVehicleRPMSyncID(int MBNPJDBGHBP)
	{
		return default(WwiseGameSyncID);
	}

	[Token(Token = "0x60012A3")]
	[Address(RVA = "0x1E96184", Offset = "0x1E96184", VA = "0x1E96184")]
	public void StartSound(bool DHBOOENNIOP)
	{
	}

	[Token(Token = "0x60012A4")]
	[Address(RVA = "0x1E97BD0", Offset = "0x1E97BD0", VA = "0x1E97BD0")]
	public void StopSound()
	{
	}

	[Token(Token = "0x60012A5")]
	[Address(RVA = "0x1E9888C", Offset = "0x1E9888C", VA = "0x1E9888C")]
	public void ChangeSkinAudioEventResMap(GHIEHBEMIPF PGLGNHLKCHE, ResourceID IDNEFEOPGIF)
	{
	}

	[Token(Token = "0x60012A6")]
	[Address(RVA = "0x1E98974", Offset = "0x1E98974", VA = "0x1E98974")]
	public void ClearAudioEventResMap()
	{
	}

	[Token(Token = "0x60012A7")]
	[Address(RVA = "0x1E98A34", Offset = "0x1E98A34", VA = "0x1E98A34")]
	private ResourceID HEGAEMCLIHB(GHIEHBEMIPF PGLGNHLKCHE)
	{
		return default(ResourceID);
	}

	[Token(Token = "0x60012A8")]
	[Address(RVA = "0x1E971CC", Offset = "0x1E971CC", VA = "0x1E971CC")]
	public void PostEventWithVehicleEventType(GHIEHBEMIPF PGLGNHLKCHE, SwitchBase[] AOHIDOIFLCK)
	{
	}

	[Token(Token = "0x60012A9")]
	[Address(RVA = "0x1E9934C", Offset = "0x1E9934C", VA = "0x1E9934C")]
	private float KHCMBOCOIIE()
	{
		return default(float);
	}

	[Token(Token = "0x60012AA")]
	[Address(RVA = "0x1E996D0", Offset = "0x1E996D0", VA = "0x1E996D0")]
	public void OnVisibleChanged(bool FICNJIMKAEF)
	{
	}

	[Token(Token = "0x60012AB")]
	[Address(RVA = "0x1E99A10", Offset = "0x1E99A10", VA = "0x1E99A10")]
	private void LKINKCNNOJF()
	{
	}

	[Token(Token = "0x60012AC")]
	[Address(RVA = "0x1E99CA8", Offset = "0x1E99CA8", VA = "0x1E99CA8")]
	private void Update()
	{
	}

	[Token(Token = "0x60012AD")]
	[Address(RVA = "0x1E97434", Offset = "0x1E97434", VA = "0x1E97434")]
	private AudioSource NMMBCFHKALJ(ResourceID GIGNCKFBEOE)
	{
		return null;
	}

	[Token(Token = "0x60012AE")]
	[Address(RVA = "0x1E984A0", Offset = "0x1E984A0", VA = "0x1E984A0")]
	private void PAIPHNBOFHB(ref AudioSource JEMBDPGAPFD, ref AudioSource LMKMNAFNNJJ)
	{
	}

	[Token(Token = "0x60012AF")]
	[Address(RVA = "0x1E9D020", Offset = "0x1E9D020", VA = "0x1E9D020")]
	private void NEHHBOEDFPK()
	{
	}
}
